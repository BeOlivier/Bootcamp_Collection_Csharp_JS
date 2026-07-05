using System.Collections.Generic;
using MvCShop.Web.Models;

namespace MvCShop.Web.Data
{
  public interface IProductRepository
  {
    bool SaveChanges();
    Product GetOne(string id);
    IEnumerable<Product> GetAll();
    void Create(Product item);
  }
}
