using System;
using System.Text.Json.Serialization;

namespace Salt.Stars.Web.Models
{
  public class Hero
  {
    [JsonPropertyName("id")] public int Id { get; set; }

    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("heightInCm")] public short Height { get; set; }

    [JsonPropertyName("weight")] public short Weight { get; set; }

    [JsonPropertyName("birth_year")] public string BirthYear { get; set; }

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

    [JsonPropertyName("StarRating")] public int StarRating { get; set; }
  }
}