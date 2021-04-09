using System.Threading.Tasks;
using Front_GroceryToDo.Models;

namespace Front_GroceryToDo.Data
{
    public interface IRecordsService
    {
        Task<Record> GetRecordByIdAsync(int id);
        Task<bool> AddItemToRecordAsync(Item item);
        Task<bool> UpdateItemInRecordAsync(Item item);
        Task<bool> UpdateRecordDescriptionAsync(string description);
        Task<bool> RemoveItemFromRecordAsync(int itemId);
        Task<bool> WipeRecordAsync();
    }
}