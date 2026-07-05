using System;
using System.Text.Json.Serialization;

namespace Salt.Stars.API.Models
{
    public class Planet
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        public int Id { get; set; }
    }
}