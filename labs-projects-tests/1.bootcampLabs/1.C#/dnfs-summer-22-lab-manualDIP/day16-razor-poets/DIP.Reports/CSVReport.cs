using System;
using System.Threading;

namespace DIP.Reports
{
  public class CSVReport : IReport
  {
    public string GenerateReport(string[] data)
    {
      Thread.Sleep(new Random().Next(1000, 3000));

      var reportString = String.Join("\n", data);
      return $"Comma separated report\n########################\n{reportString}";
    }
  }
}
