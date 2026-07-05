using System.Text.Json.Serialization;

namespace Salt.Stars.Web.Models
{
    public class Planet
    {
        [JsonPropertyName("url")] public string Url { get; set; }

        [JsonPropertyName("name")] public string Name { get; set; }
        

        
        
    }
}