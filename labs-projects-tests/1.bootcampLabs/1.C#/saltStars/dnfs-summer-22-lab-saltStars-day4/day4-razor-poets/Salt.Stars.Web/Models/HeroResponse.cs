using System;
using System.Text.Json.Serialization;

namespace Salt.Stars.Web.Models
{
  public class HeroResponse 
  {
    [JsonPropertyName("hero")]
    public Hero Hero {get; set;}

    [JsonPropertyName("requestedAt")]
    public DateTime RequestedAt {get; set;}


  //   [JsonPropertyName("name")]
  //   public string Name { get; set; }

  //   [JsonPropertyName("mass")]
  //   public string Weight { get; set; }

	// [JsonPropertyName("birth_year")]
	// public string BirthYear {get; set;}

	// [JsonPropertyName("height")]
	// public string Height{get; set;}
  }
}