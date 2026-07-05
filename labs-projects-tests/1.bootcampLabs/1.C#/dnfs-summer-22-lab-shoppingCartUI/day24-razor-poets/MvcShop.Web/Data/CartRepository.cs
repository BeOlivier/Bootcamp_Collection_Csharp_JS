using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MvCShop.Web.Models;

namespace MvCShop.Web.Data
{
  public class CartRepository : ICartRepository
  {
    private readonly AppDbContext _context;

    public CartRepository(AppDbContext context) => _context = context;
    public Cart Create(string sessionId)
    {
      var cart = new Cart
      {
        Id = Guid.NewGuid().ToString(),
        SessionId = sessionId
      };

      _context.Carts.Add(cart);
      SaveChanges();
      return cart;
    }


    public void Delete(string id)
    {
      var cart = GetOne(id);
      if (cart == null)
        return;

      _context.CartProducts.RemoveRange(cart.Products);
      _context.Carts.Remove(cart);
      SaveChanges();
    }

    public Cart GetCartForSession(string sessionId) =>
      _context.Carts.Where(c => c.SessionId == sessionId)
        .Include(c => c.Products)
        .SingleOrDefault();

    public Cart GetOne(string id) =>
      _context.Carts.Where(c => c.Id == id)
        .Include(c => c.Products)
        .SingleOrDefault();


    public bool SaveChanges() => (_context.SaveChanges() >= 0);

    public Cart Update(string id, AddProductCartProductRequest request)
    {
      var cart = GetOne(id);

      var cartProductToAdd = new CartProduct
      {
        CartProductId = Guid.NewGuid().ToString(),
        ProductId = request.ProductId,
        Quantity = request.Quantity,
        Price = request.Price,
      };

      _context.CartProducts.Add(cartProductToAdd);

      cart.Products.Add(cartProductToAdd);
      _context.Carts.Update(cart);

      _context.SaveChanges();

      return cart;
    }
  }
}
