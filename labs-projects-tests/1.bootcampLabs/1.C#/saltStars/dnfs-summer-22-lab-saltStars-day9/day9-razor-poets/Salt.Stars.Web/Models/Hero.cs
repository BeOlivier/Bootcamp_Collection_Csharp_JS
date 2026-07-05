using System.Text.Json.Serialization;

namespace Salt.Stars.Web.Models
{
  public class Hero
  {
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("heightInCm")]
    public short Height { get; set; }

    [JsonPropertyName("weight")]
    public short Weight { get; set; }

    [JsonPropertyName("birth_year")]
    public string BirthYear { get; set; }

    [JsonPropertyName("StarRating")]
    public int StarRating { get; set; }

    [JsonPropertyName("EarthBirthYear")]
    public string EarthBirthYear { get; set; }

    [JsonPropertyName("homeWorldUrl")]
    public string HomeWorldUrl { get; set; }

    [JsonPropertyName("homeWorldId")]
    public int HomeWorldId { get; set; }

    [JsonPropertyName("homeWorldName")]
    public string HomeWorldName { get; set; }
  }
}