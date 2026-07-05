using System;
using System.Text.Json.Serialization;
using System.Data.SqlTypes;

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

    public string EarthBirthYear
    {
      // takes in string parameter BirthYear
      // check if string.Contains(A or B)
      // if A then + (after battle of Yavin) 
      // if B then - (Before battle of Yavin)
      // after we determine whether its plus or minus we add
      // 1850 or subtract from 1850 the number before the
      // BBY. We return the result string + AC / BC
      // 200BBY / 199ABY
      get
      {
        var numnum = 0;
        var dubdub = 0.0;
        var double_flag = 0;
        if (BirthYear == null || !int.TryParse(BirthYear.Substring(0, BirthYear.Length - 3), out numnum) ||
            !BirthYear.Contains("BBY") || !BirthYear.Contains("ABY"))
        {
          if (double.TryParse(BirthYear.Substring(0, BirthYear.Length - 3), out dubdub))
          {
            double_flag = 1;
          }
          else
          {
            return "";
          }
          
        }

        
        if (BirthYear.Contains("A"))
        {
          var numOnly = BirthYear.Substring(0, BirthYear.Length - 3);
          return (int.Parse(numOnly) + 1850) + " A.C.";
        }
        
        if (!BirthYear.Contains("A"))
        {
          if (double_flag == 1)
          {
            if (dubdub < 1850 * 1.0)
              return (1850.0 - dubdub) + " A.C.";
            else
            {
              var year = 1850.0 - dubdub;
              var position = year.ToString().IndexOf(".");
              return year.ToString().Substring(1, position + 1) + " B.C.";
            }
          }
          var numOnly = BirthYear.Substring(0, BirthYear.Length - 3);
          if (int.Parse(numOnly) < 1850)
            return (1850 - int.Parse(numOnly) + " A.C.");
          else
            return Math.Abs(1850 - int.Parse(numOnly)) + " B.C.";
        }
        return null;

      }
      
      
      
    }
  }
}