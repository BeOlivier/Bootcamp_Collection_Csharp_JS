namespace SESModels
{
	public class Employee : Person
	{
		public string BankAccount {get; set; }
		public int Salary {get; set; }
		public string Currency {get; set; }
		//constructor
		public Employee(string name, string personNumber, string phoneNumber, List<Email> emails, 
				string BankAccount, int Salary, string Currency) : base(name, personNumber, phoneNumber, emails)
				{
					
				}
	}
}