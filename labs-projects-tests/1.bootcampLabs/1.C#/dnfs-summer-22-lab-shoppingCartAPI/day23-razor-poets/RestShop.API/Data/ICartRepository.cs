using System.Collections.Generic;
using RestShop.API.Model;

namespace RestShop.API.Data
{
  public interface ICartRepository
  {
    bool SaveChanges();
    Cart GetOne(string id);
    IEnumerable<Cart> GetAll();
    Cart Create();
    void Delete(string id);
    Cart Update(string id, AddProductCartProductRequest cartProduct);
  }
}