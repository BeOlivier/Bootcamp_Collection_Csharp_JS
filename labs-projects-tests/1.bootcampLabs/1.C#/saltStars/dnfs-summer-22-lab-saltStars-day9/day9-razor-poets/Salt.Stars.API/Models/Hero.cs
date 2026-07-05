using System.Text.Json.Serialization;

namespace Salt.Stars.API.Models
{
  public class Hero
  {

    [JsonPropertyName("url")]
    public string Url { get; set; }

    public int Id
    {
      get
      {
        return ModelUtils.GetIdFromSwAPIUrl(this.Url);
      }
    }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("height")]
    public string Height { get; set; }

    public short HeightInCm
    {
      get
      {
        short result;
        if (short.TryParse(Height, out result))
          return result;
        return 0;
      }
    }

    [JsonPropertyName("mass")]
    public string Mass { get; set; }

    public short Weight
    {
      get
      {
        short result;
        if (short.TryParse(Mass, out result))
          return result;
        return 0;
      }
    }

    [JsonPropertyName("birth_year")]
    public string BirthYear { get; set; }

    [JsonPropertyName("StarRating")]
    public int StarRating { get; set; }

    [JsonPropertyName("EarthBirthYear")]
    public string EarthBirthYear
    {
      get
      {
        return ModelUtils.GetEarthBirthYear(BirthYear);
      }
    }


    [JsonPropertyName("homeworld")]
    public string HomeWorldUrl { get; set; }

    [JsonPropertyName("homeWorldId")]
    public int HomeWorldId
    {
      get
      {
        return ModelUtils.GetIdFromSwAPIUrl(this.HomeWorldUrl);
      }
    }

    [JsonPropertyName("homeWorldName")]
    public string HomeWorldName { get; set; }
  }
}