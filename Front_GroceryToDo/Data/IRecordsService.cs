﻿using System.Threading.Tasks;
using Front_GroceryToDo.Models;

namespace Front_GroceryToDo.Data
{
    public interface IRecordsService
    {
        Task<Record> GetRecordByIdAsync(int id);
        Task<bool> AddItemToRecordAsync(Item item);
        Task<bool> RemoveItemFromRecordAsync(int itemId);
        Task<bool> WipeRecordAsync();
    }
}