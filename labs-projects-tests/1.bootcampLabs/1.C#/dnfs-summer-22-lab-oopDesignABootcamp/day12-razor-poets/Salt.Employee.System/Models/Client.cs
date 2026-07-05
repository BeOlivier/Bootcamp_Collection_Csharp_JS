using System;

namespace SESModels
{
    public class Client : Organisation
    {
        public string ContactAdress {get; set;}
        public IEnumerable<Contract> Contracts {get; set;}

        public Client(string contactAdress, int num, string name) : base(num, name)
        {
            ContactAdress = contactAdress;
        }

    }
    
}