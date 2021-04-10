using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Front_GroceryToDo.Models;

namespace Front_GroceryToDo.Data.impl
{
    public class RecordsService : IRecordsService
    {
        private string uri = "https://localhost:5003";
        private readonly HttpClient client;
        private IUserService userService;

        public RecordsService(IUserService userService)
        {
            this.userService = userService;
            client = new HttpClient();
        }

        public async Task<Record> GetRecordByIdAsync(int id)
        {
            string message = await client.GetStringAsync(uri + "/Record/" + id);
            Record result = JsonSerializer.Deserialize<Record>(message);
            userService.SetCachedId(result.Id);
            return result;
        }

        public async Task CreateRecordAsync()
        {
            string message = await client.GetStringAsync($"{uri}/Record");
            int generatedId = JsonSerializer.Deserialize<int>(message);
            userService.SetCachedId(generatedId);
        }

        public async Task<bool> AddItemToRecordAsync(Item item)
        {
            string itemAsJson = JsonSerializer.Serialize(item);
            HttpContent content = new StringContent(itemAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync(uri + "/Record/" + userService.GetCachedId(), content);
            return message.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateItemInRecordAsync(Item item)
        {
            string itemAsJson = JsonSerializer.Serialize(item);
            HttpContent content = new StringContent(itemAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PatchAsync(uri + "/Record/" + userService.GetCachedId(), content);
            return message.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateRecordDescriptionAsync(string description)
        {
            HttpContent content = new StringContent("", Encoding.UTF8, "application/json");
            HttpResponseMessage message =
                await client.PatchAsync($"{uri}/Record?recordId={userService.GetCachedId()}&description={description}", content);
            return message.IsSuccessStatusCode;
        }

        public async Task<bool> RemoveItemFromRecordAsync(int itemId)
        {
            HttpResponseMessage message = await client.DeleteAsync($"{uri}/Record?itemId={itemId}&recordId={userService.GetCachedId()}");
            return message.IsSuccessStatusCode;
        }

        public async Task<bool> WipeRecordAsync()
        {
            HttpResponseMessage message = await client.DeleteAsync($"{uri}/Record/{userService.GetCachedId()}");
            return message.IsSuccessStatusCode;
        }
    }
}