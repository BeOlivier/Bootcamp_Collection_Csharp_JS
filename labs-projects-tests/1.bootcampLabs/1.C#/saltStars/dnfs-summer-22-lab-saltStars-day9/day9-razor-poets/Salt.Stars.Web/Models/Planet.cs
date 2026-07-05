using System.Text.Json.Serialization;

namespace Salt.Stars.Web.Models
{
  public class Planet
  {
    [JsonPropertyName("url")]
    public string Url { get; set; }
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("diameter")]
    public string Diameter { get; set; }
    [JsonPropertyName("gravity")]
    public string Gravity { get; set; }
    [JsonPropertyName("population")]
    public string Population { get; set; }

  }
}