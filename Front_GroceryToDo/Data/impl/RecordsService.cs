using System.Net.Http;
using System.Security.Claims;
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

        public Task<bool> AddItemToRecordAsync(Item item)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> RemoveItemFromRecordAsync(int itemId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> WipeRecordAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}