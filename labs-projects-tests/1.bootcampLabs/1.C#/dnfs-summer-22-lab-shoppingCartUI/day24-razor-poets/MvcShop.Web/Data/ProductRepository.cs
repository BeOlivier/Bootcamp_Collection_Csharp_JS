using System;
using System.Collections.Generic;
using System.Linq;
using MvCShop.Web.Models;

namespace MvCShop.Web.Data
{
  public class ProductRepository : IProductRepository
  {
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context) => _context = context;
    public void Create(Product item)
    {
      if (item == null)
        throw new ArgumentNullException(nameof(item));

      _context.Products.Add(item);
    }

    public Product Create()
    {
      throw new NotImplementedException();
    }

    public void Delete(Product item)
    {
      if (item == null)
        throw new ArgumentNullException(nameof(item));

      _context.Products.Remove(item);
    }

    public IEnumerable<Product> GetAll() => _context.Products.ToList();

    public Product GetOne(string id) =>
      _context.Products.FirstOrDefault(p => p.Id == id);

    public bool SaveChanges() => (_context.SaveChanges() >= 0);

    public void Update(Product item)
    {
      if (item == null)
        throw new ArgumentNullException(nameof(item));

      _context.Products.Update(item);
    }

  }
}
