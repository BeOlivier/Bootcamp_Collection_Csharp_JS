using System;
using DIP.Reports;

namespace DIP.ReportGenerator
{
  public class Generator
  {


    public void PrintReport(IReport reportType)
    {
      
      var dataFetcher = new DataFetcher();
      var data = dataFetcher.GetData();

      Console.WriteLine(reportType.GenerateReport(data));

      Console.WriteLine("Report Generation done");

    }

  }
}
