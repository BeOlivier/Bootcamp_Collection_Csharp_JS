using System;
using System.Linq;
using static System.Environment;
using GROAN.Business;

namespace GROAN.App
{
	class Program
	{
		// static bool IsCorrectArg(string[] args)
		// {
			
		// }
		static void Main(string[] args)
		{
			// var search_args = new string[2];
			var addressHandler = new AddressHandler();
			if (!args.Any())
			{
				Console.WriteLine("Please give our app an input ;) !");
				Exit(-1);
			}
			// Console.WriteLine()
			
			if (!args[1].Contains("-name"))
			{
				Console.WriteLine("Please use the correct format for your inquiry ;) example: dotnet run -p GROAN.APP ./data -name:ande");
				Exit(-1);
			}
			var printed = addressHandler.PrintAddresses(args[0], args[1].Split(":")[1]);
			foreach (var person in printed)
			{
				Console.Write(person.Title + " ");
				Console.Write(person.FirstName + " ");
				Console.WriteLine(person.LastName);
			}

		}
	}
}
