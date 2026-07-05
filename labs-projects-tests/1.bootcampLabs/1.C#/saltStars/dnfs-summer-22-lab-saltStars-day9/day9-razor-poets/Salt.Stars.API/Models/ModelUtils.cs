
using System;
using System.Linq;

namespace Salt.Stars.API.Models
{
  public static class ModelUtils
  {
    public static int GetIdFromSwAPIUrl(string url)
    {
      var urlString = url.EndsWith('/') ? url.Remove(url.Length - 1, 1) : url;
      var idString = urlString.Remove(0, urlString.LastIndexOf('/') + 1);

      int id;
      bool success = int.TryParse(idString, out id);
      if (!success)
      {
        throw new Exception($"No numeric id found in url '{url}'");
      }
      return id;
    }

    public static string GetEarthBirthYear(string birthYear)
    {
      if (birthYear == string.Empty)
      {
        return string.Empty;
      }

      var separators = new string[] { "ABY", "BBY" };
      if (!separators.Any(s => birthYear.Contains(s)))
      {
        return string.Empty;
      }

      var birthYearSplitted = birthYear.Split(separators, StringSplitOptions.RemoveEmptyEntries);
      var birthYearAsString = birthYearSplitted[0];

      int birthYearAsInt;
      if (!int.TryParse(birthYearAsString, out birthYearAsInt))
      {
        return string.Empty;
      }

      var isABY = birthYear.Contains("ABY");
      var earthYear = isABY ? birthYearAsInt + 1850 : 1850 - birthYearAsInt;

      var suffix = earthYear >= 0 ? "A.C." : "B.C.";

      return $"{Math.Abs(earthYear)} {suffix}";
    }
  }
}