using System.Collections.Generic;

namespace Patterns.Business.SaltBusiness
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        List<Customer> FindCustomerByCity(string city);
        List<Customer> FindCustomerByShoeSize(int shoeSize);
    }
}