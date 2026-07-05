using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace GROAN.Business
{
  public class AddressHandler
  {
	  public PersonInfo PICreator(string[] countriesinfo, string[] peoplesinfo, string[] streetinfo, string[] postcodeinfo)
	  {

			  return new PersonInfo(){ 
				  PersonId = countriesinfo[0],
				  FirstName = peoplesinfo[2],
				  LastName = peoplesinfo[3],
				  Title = peoplesinfo[1],
				  Location = countriesinfo[1],
				  PostCode = postcodeinfo[1],
				  StreetName = streetinfo[2],
				  StreetNum = streetinfo[1],
				  City = streetinfo[3]
				  };
	  }
	  public List<PersonInfo> ParseRow(string lastNameFilter)
        {
			var countriespath =  Path.GetFullPath("./data") + "/countries.csv";
			var countries = File.ReadAllLines(countriespath);
            var countriesInfo  = countries.Select(row => row.Split(",")).ToList();

			var peepopath = Path.GetFullPath("./data") + "/people.csv";
			var people = File.ReadAllLines(peepopath);
			var peepoInfo = people.Select(row => row.Split(",")).ToList();
			
			var postpath = Path.GetFullPath("./data") + "/postalcodes.csv";
			var post = File.ReadAllLines(postpath);
			var postInfo = post.Select(row => row.Split(",")).ToList();
			
			var streetspath = Path.GetFullPath("./data") + "/streets.csv";
			var streets = File.ReadAllLines(streetspath);
			var streetInfo = streets.Select(row => row.Split(",")).ToList();
			
			var result = new List<PersonInfo>();

			for(int i = 1; i < peepoInfo.Count; i++)
			{
				if(peepoInfo[i][3].ToLower().Contains(lastNameFilter.ToLower()))
				{
					result.Add(PICreator(countriesInfo[i], peepoInfo[i],streetInfo[i], postInfo[i]));

				}
			}
			

			return result;

			
		}
	//   public Dictionary<string, string[]> ReadAddresses(string path)
	//   {
	// 	var result = new Dictionary<string, string[]>();
	// 	var content = System.IO.File.ReadAllLines(path);
	// 	foreach (var line in content[1..^0])
	// 	{
	// 		var spliter = line.Split(",");
	// 		result.Add(spliter[0], spliter[1..^0]);
	// 	}
	// 	return result;
	//   }
		public List<PersonInfo> PrintAddresses(string directory, string lastNameFilter)
		{
			var personList = new List<Person>();
			var persons = ParseRow(lastNameFilter);
			// var persons = ReadAddresses("/Users/saltdev/Desktop/SALT/salt-labs/day13/dnfs-summer-22-lab-textualDb/data/people.csv");
			// foreach(KeyValuePair<string, string[]> kvp in persons)
			// {
			// 	var id = kvp.Key;
			// 	var title = kvp.Value[0];
			// 	var firstName = kvp.Value[1];
			// 	var lastName = kvp.Value[2];
			// 	if (lastName.ToLower().Contains(lastNameFilter.ToLower()))
			// 	{
			// 		var p = new Person(id, title, firstName, lastName);
			// 		personList.Add(p);
			// 	}
			// }
			
			return persons;
		}
  }
}
