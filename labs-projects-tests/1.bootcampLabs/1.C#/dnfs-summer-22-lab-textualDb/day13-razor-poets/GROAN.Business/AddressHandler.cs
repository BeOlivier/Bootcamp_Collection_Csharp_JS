using System;
using System.Collections.Generic;
using System.IO;
using GROAN.Business;

namespace GROAN.Business
{
  public class AddressHandler
  {
	  public Dictionary<string, string[]> ReadAddresses(string path)
	  {
		var result = new Dictionary<string, string[]>();
		var csvFileContent = File.ReadAllLines(path);
		foreach (var line in csvFileContent[1..^0])
		{
			var lineSplitter = line.Split(",");
			var personId = lineSplitter[0];
			var personInfo = lineSplitter[1..^0];
			result.Add(personId, personInfo);
		}
		return result;
	  }
		public List<Person> PrintAddresses(string directory, string lastNameFilter)
		{
			var personList = new List<Person>();
			var persons = ReadAddresses("/Users/saltdev/Desktop/salt/salt-labs/labs/day13/dnfs-summer-22-lab-textualDb/data/people.csv");
			// var person = new Person();
			// Console.WriteLine("testing1");
			// Console.WriteLine(lastNameFilter);
			foreach(KeyValuePair<string, string[]> kvp in persons)
			{
				// Console.WriteLine("testing2");
				var id = kvp.Key;
				var title = kvp.Value[0];
				var firstName = kvp.Value[1];
				var lastName = kvp.Value[2];
				if (lastName.ToLower().Contains(lastNameFilter.ToLower()))
				{
					// Console.WriteLine("adding shit to list");
					var p = new Person(id, title, firstName, lastName);
					personList.Add(p);
				}
				// Console.WriteLine("Key: " + kvp.Key + " Value: " + kvp.Value[1]);
			}
			
			return personList;
		}
  }
}
