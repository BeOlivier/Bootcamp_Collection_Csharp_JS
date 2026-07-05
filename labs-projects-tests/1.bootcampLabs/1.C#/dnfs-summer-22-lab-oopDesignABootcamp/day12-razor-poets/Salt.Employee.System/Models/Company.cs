using System;

namespace SESModels
{
    public class Company : Organisation
    {
        //props
        public IEnumerable<Person> People {get; set;}
        //constructor

        public Company(IEnumerable<Person> list, string name, int num) : base(num, name)
        {
            People = list;
        }
        //methods
		public IEnumerable<Person> GetNonEmployee()
		{
			var result = new List<Person>();

			foreach (var p in People)
			{
				if(GetType(p).ToString() != "Employee")
				{
					result.Add(p);
				}
			}
			return result;
		}
    }
}