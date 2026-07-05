using System;

namespace GROAN.Business
{
    public class Person
    {
		public string PersonId { get; set;}
		public string Title { get; set;}
		public string FirstName { get; set;}
		public string LastName { get; set;}
		public Person(string id, string title, string firstName, string lastName)
		{
			PersonId = id;
			Title = title;
			FirstName = firstName;
			LastName = lastName;
		}
    }
}
