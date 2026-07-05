using System;
using System.Threading;

namespace DIP.Reports
{
  public class ExcelReport : IReport
  {
    public string GenerateReport(string[] data)
    {
      Thread.Sleep(new Random().Next(1000, 3000));

      var reportString = String.Join("\n", data);
      return $"Excel Report\n########################\n{reportString}";
    }
  }
}
