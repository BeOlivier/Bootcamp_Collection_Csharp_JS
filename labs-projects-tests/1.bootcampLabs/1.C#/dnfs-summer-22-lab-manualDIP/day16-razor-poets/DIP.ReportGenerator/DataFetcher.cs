using System;
using System.Collections.Generic;
using System.Threading;

namespace DIP.ReportGenerator
{
  public class DataFetcher
  {
    public string[] GetData()
    {
      var result = new List<string>();
      for (int i = 0; i < 100; i++)
      {
        Thread.Sleep(new Random().Next(10, 100));
        result.Add($"The {i + 1} row of the report");
      }

      return result.ToArray();
    }
  }
}