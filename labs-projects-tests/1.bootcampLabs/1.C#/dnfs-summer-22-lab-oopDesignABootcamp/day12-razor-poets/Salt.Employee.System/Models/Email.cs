namespace SESModels
{
	public class Email
	{
		public string Address { get; set; }
		public bool IsCurrent { get; set; }
		public Email(string address, bool isCurrent)
		{
			Address = address;
			IsCurrent = isCurrent;
		}
			
		public Email(string address)
		{
			Address = address;
			IsCurrent = false;
		}
	}
}