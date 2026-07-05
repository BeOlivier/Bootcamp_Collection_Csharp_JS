namespace SESModels
{
	public class Person
	{
		public string Name { get; set; }
		public string PersonNumber {get; set;}
		public string PhoneNumber {get; set;}
		public List<Email> Emails {get; set;}
		//constructor
		public Person(string name, string personNumber, string phoneNumber, List<Email> emails)
		{
			Name = name;
			PersonNumber = personNumber;
			PhoneNumber = phoneNumber;
			Emails = emails;
		}
	}
}
