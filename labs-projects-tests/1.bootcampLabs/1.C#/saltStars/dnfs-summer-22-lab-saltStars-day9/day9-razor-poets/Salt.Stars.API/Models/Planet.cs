using System.Text.Json.Serialization;

namespace Salt.Stars.API.Models
{
  public class Planet
  {
    [JsonPropertyName("url")]
    public string Url { get; set; }
    [JsonPropertyName("id")]
    public int Id { get { return ModelUtils.GetIdFromSwAPIUrl(this.Url); } }
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
