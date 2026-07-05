using System;
using System.Text.Json.Serialization;

namespace GROAN.Business
{
	public class DataResponse
	{
		[JsonPropertyName("name")]
		public Name DRName { get; set; }

		[JsonPropertyName("location")]
		public Location DRLocation { get; set; }


		public class Name
		{	
			[JsonPropertyName("title")]
			public string Title { get; set; }

			[JsonPropertyName("first")]
			public string FirstName { get; set; }
			
			[JsonPropertyName("last")]
			public string LastName { get; set; }
		}
		public class Location
		{
			[JsonPropertyName("street")]
			public Street DRStreet { get; set; }
			[JsonPropertyName("city")]
			public string City {get; set;}
			[JsonPropertyName("state")]
			public string State {get; set;}
			[JsonPropertyName("country")]
			public string Country {get; set;}
			[JsonPropertyName("postcode")]
			public int Postcode {get; set;}

			public class Street
			{
				[JsonPropertyName("number")]
				public int Number {get; set;}
				[JsonPropertyName("name")]
				public string Name {get; set;}
			}



		}
	}
}