using System;
using System.Linq;
using GROAN.Business;
// using DataResponse;
using System.Threading.Tasks;

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

	public async static void Garcon() 
	{
		Console.WriteLine("test2");

		var usrClient = new RandomUserClient();
		
		var resultList = await usrClient.GetResponses();
		Console.WriteLine("test3");

		Console.WriteLine(resultList.DataResponses.Count());
		foreach (var item in resultList.DataResponses)
		{
			Console.WriteLine(item.DRName.FirstName);
		}

	}
    static void Main(string[] args)
    {
    	if (!ArgChecker(args)) return;
		Console.WriteLine("test1");
		Program.Garcon();
		// var usrClient = new RandomUserClient();
		// var resultList =  usrClient.GetResponses();
		// Task.WaitAll(resultList);
		// foreach (var member in resultList)
		// for(int i = 0; i < resultList.DataResponses.Count; i++)
		// {
		// }



	}
  }
}
