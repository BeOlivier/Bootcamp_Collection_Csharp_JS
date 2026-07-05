using System;
using DIP.ReportGenerator;
using DIP.Reports;

namespace DIP.App
{
  class Program
  {

    static void Main(string[] args)
    {
      if (!int.TryParse(args[0], out var num))
      {
        Console.WriteLine("error error");
        return;
      }

      if (num <= 0 || num > 3)
      {
        Console.WriteLine("invalid input");
        return;
      }
      
      var generator = new Generator();
      Console.WriteLine("REPORT GENERATOR");
      Console.WriteLine("#################");
      Console.WriteLine($"Printing a report for parameter {args[0]}");
      if (num == 1)
      {
        // var report = new PDFReport();
        generator.PrintReport(new PDFReport());
      }
      if (num == 2)
      {
        // var report = new ExcelReport();
        generator.PrintReport(new ExcelReport());
      }
      if (num == 3)
      {
        // var report = new CSVReport();
        generator.PrintReport(new CSVReport());
      }
      Console.WriteLine("#################");
    }
  }
}
