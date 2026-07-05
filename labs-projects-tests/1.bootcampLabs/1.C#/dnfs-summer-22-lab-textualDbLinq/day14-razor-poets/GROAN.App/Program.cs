using System;
using System.Collections.Generic;
using System.Linq;
using GROAN.Business;

namespace GROAN.App
{
  class Program
  {
	  static bool ArgChecker(string[] args)
	  {
			if (!args.Any())
			{
				Console.WriteLine("Please give our app an input ;) !");
				return false;
			}
			// Console.WriteLine()
			
			if (!args[1].Contains("-name"))
			{
				Console.WriteLine("Please use the correct format for your inquiry ;) example: dotnet run -p GROAN.APP ./data -name:ande");
				return false;
			}
			return true;
	  }
    static void Main(string[] args)
    {
    	if (!ArgChecker(args)) return;

		var handler = new AddressHandler();
		var result = handler.PrintAddresses(args[0], args[1].Split(":")[1]);
		Console.WriteLine("We found " + result.Count + " results" + "\n" + "================================");
		foreach (var value in result)
		{
			Console.WriteLine(value.Title + " " + value.FirstName + " " + value.LastName + 
				"\n" + value.Location + " " + value.City + " " + value.StreetName + " " + value.StreetNum +
				"\n" + value.PostCode + "\n" + "==========================");
		}
    }
  }
}
