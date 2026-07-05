using System;
using System.Text.Json.Serialization;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

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
        int minusInt;
        int a;
        if(!Url.EndsWith("/"))
          {
            minusInt = 1;
          }
        else 
        {
          minusInt = 2;
        }

            var split = Url.Split("/");
            if (int.TryParse(split[split.Length - minusInt], out a) == true)
                return a;
        // if (int.TryParse(split[split.Length - 2])
        // return int.Parse(split[split.Length - 2]);
        throw new Exception($"No numeric id found in url '{Url}'");
        // throw new NotImplementedException("Get id from URL");
      }
      // act.Should().Throw<Exception>().WithMessage($"No numeric id found in url '{URL_TO_TEST}'");
      

    }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    // TODO: Get properties (Weight, Height and Year of birth) donedonedone
    [JsonPropertyName("mass")]
    public int Weight { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("birth_year")]
    public string YearOfBirth { get; set; }


  }
}