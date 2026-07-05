using System;
using System.Threading;

namespace DIP.Reports
{
  public class PDFReport : IReport
  {
    public string GenerateReport(string[] data)
    {
      Thread.Sleep(new Random().Next(1000, 3000));

      var reportString = String.Join("\n", data);
      return $"PDF Report\n########################\n{reportString}";
    }
  }
}
