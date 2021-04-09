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

        public RecordsService()
        {
            client = new HttpClient();
        }

        public async Task<Record> GetRecordByIdAsync(int id)
        {
            string message = await client.GetStringAsync(uri + "/Record/" + id);
            Record result = JsonSerializer.Deserialize<Record>(message);
            return result;
        }

        public async Task<bool> AddItemToRecordAsync(Item item)
        {
            string itemAsJson = JsonSerializer.Serialize(item);
            HttpContent content = new StringContent(itemAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync(uri + "/Record/" + "1002", content);
            return message.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateItemInRecordAsync(Item item)
        {
            string itemAsJson = JsonSerializer.Serialize(item);
            HttpContent content = new StringContent(itemAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PatchAsync(uri + "/Record/" + "1002", content);
            return message.IsSuccessStatusCode;
        }

        public async Task<bool> RemoveItemFromRecordAsync(int itemId)
        {
            int recordId = 1002;
            HttpResponseMessage message = await client.DeleteAsync($"{uri}/Record?itemId={itemId}&recordId={recordId}");
            return message.IsSuccessStatusCode;
        }

        public async Task<bool> WipeRecordAsync()
        {
            int recordId = 1002;
            HttpResponseMessage message = await client.DeleteAsync($"{uri}/Record/{recordId}");
            return message.IsSuccessStatusCode;
        }
    }
}