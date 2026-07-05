using MvCShop.Web.Models;

namespace MvCShop.Web.Data
{
  public interface ICartRepository
  {
    bool SaveChanges();
    Cart GetOne(string id);
    Cart GetCartForSession(string sessionId);
    Cart Create(string sessionId);
    Cart Update(string id, AddProductCartProductRequest cartProduct);
  }
}