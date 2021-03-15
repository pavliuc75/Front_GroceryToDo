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
            string message = await client.GetStringAsync(uri + "/Record?id=" + id);
            Record result = JsonSerializer.Deserialize<Record>(message);
            return result;
        }

        public async Task<bool> AddItemToRecordAsync(Item item)
        {
            string itemAsJson = JsonSerializer.Serialize(item);
            HttpContent content = new StringContent(itemAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync(uri + "/Record/" + "9999", content);
            return message.IsSuccessStatusCode;
        }

        public async Task<bool> RemoveItemFromRecordAsync(int itemId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> WipeRecordAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}