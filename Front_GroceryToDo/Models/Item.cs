﻿using System.Text.Json.Serialization;

namespace Front_GroceryToDo.Models
{
    public class Item
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("details")] public string Details { get; set; }
        [JsonPropertyName("isCompleted")] public bool IsCompleted { get; set; }
        [JsonPropertyName("quantity")] public int Quantity { get; set; }
        [JsonPropertyName("weight")] public double Weight { get; set; }
        [JsonPropertyName("unit")] public string Unit { get; set; }
    }
}