using System;
using System.Linq;
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
        var urlString = Url.EndsWith('/') ? Url.Remove(Url.Length - 1, 1) : Url;
        var idString = urlString.Remove(0, urlString.LastIndexOf('/') + 1);

        int id;
        bool success = int.TryParse(idString, out id);
        if (!success)
        {
          throw new Exception($"No numeric id found in url '{Url}'");
        }
        return id;
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

    [JsonPropertyName("homeworld")] 
    public string PlanetUrl { get; set; }

    [JsonPropertyName("EarthBirthYear")]
    public object EarthBirthYear
    {
      get
      {
        if (this.BirthYear == string.Empty)
        {
          return string.Empty;
        }

        var separators = new string[] { "ABY", "BBY" };
        if (!separators.Any(s => this.BirthYear.Contains(s)))
        {
          return string.Empty;
        }

        var birthYearSplitted = this.BirthYear.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        var birthYearAsString = birthYearSplitted[0];

        Console.WriteLine(this.BirthYear);
        Console.WriteLine(birthYearSplitted.Length);

        int birthYearAsInt;
        if (!int.TryParse(birthYearAsString, out birthYearAsInt)) {
          return string.Empty;
        }

        var isABY = this.BirthYear.Contains("ABY");
        var earthYear = isABY ? birthYearAsInt + 1850 : 1850 - birthYearAsInt;

        var suffix = earthYear >= 0 ? "A.C." : "B.C.";

        return $"{Math.Abs(earthYear)} {suffix}";
      }
    }
  }
}