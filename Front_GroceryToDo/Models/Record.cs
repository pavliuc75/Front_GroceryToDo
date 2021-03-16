using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Front_GroceryToDo.Models
{
    public class Record
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("description")] public string Description { get; set; }
        [JsonPropertyName("items")] public List<Item> Items { get; set; }
    }
}