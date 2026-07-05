using System.Collections.Generic;
using System.Linq;

namespace Patterns.Business.SaltBusiness
{
    public class InMemoryRepository : ICustomerRepository
    {
        private IList<Customer> _customerList;

        public InMemoryRepository(IList<Customer> customerList)
        {
            _customerList = customerList;
        }

        public void Create(Customer cust)
        {
            _customerList.Add(cust);
        }

        public IList<Customer> Read()
        {
            return _customerList;
        }

        public void Update(Customer updatedCustomer)
        {
            var city = updatedCustomer.GetCity();
            var shoeSize = updatedCustomer.GetShoeSize();
            var id = updatedCustomer.GetId();
            foreach (var customer in _customerList)
            {
                if (customer.GetId() != id) continue;
                customer.UpdateCity(city);
                customer.UpdateShoeSize(shoeSize);
            }
        }

        public void Delete(Customer customer)
        {
            var id = customer.GetId();
            var toRemove = _customerList.Single(c => c.GetId() == id);
            _customerList.Remove(toRemove);
        }

        public List<Customer> FindCustomerByCity(string city)
        {
            var result = _customerList.Where(c => c.GetCity() == city)
                                                    .ToList();
            return result;
        }

        public List<Customer> FindCustomerByShoeSize(int shoeSize)
        {
            var result = _customerList.Where(c => c.GetShoeSize() == shoeSize)
                                                    .ToList();
            return result;
        }
    }
}
