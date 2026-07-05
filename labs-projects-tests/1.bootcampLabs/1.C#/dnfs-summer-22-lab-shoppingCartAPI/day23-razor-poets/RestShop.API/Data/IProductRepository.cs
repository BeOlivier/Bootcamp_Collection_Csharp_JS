using System.Collections.Generic;
using RestShop.API.Model;

namespace RestShop.API.Data
{
  public interface IProductRepository
  {
    bool SaveChanges();
    Product GetOne(string id);
    IEnumerable<Product> GetAll();
    void Create(Product item);
  }
}
