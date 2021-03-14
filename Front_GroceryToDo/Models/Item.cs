using System.Text.Json.Serialization;

namespace Front_GroceryToDo.Models
{
    public class Item
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("quantity")] public int Quantity { get; set; }
        [JsonPropertyName("weight")] public double Weight { get; set; }
    }
    //TODO: add liters, kg etc.
}