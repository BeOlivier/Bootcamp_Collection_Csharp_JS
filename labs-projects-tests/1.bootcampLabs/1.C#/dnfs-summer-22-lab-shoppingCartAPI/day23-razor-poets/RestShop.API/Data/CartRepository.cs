using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestShop.API.Model;

namespace RestShop.API.Data
{
  public class CartRepository : ICartRepository
  {
    private readonly AppDbContext _context;

    public CartRepository(AppDbContext context) => _context = context;
    public Cart Create()
    {
      var cart = new Cart
      {
        Id = Guid.NewGuid().ToString()
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

    public void Delete(Cart item)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Cart> GetAll() => _context.Carts.ToList();

    // [HttpGet]
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
