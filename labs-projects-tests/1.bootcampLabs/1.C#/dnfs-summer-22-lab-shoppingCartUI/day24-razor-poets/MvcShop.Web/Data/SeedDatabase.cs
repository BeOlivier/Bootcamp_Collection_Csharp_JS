using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MvCShop.Web.Models;

namespace MvCShop.Web.Data
{
  public class SeedDatabase
  {
    public void PrepPopulation(IApplicationBuilder app)
    {
      using (var serviceScope = app.ApplicationServices.CreateScope())
      {
        SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
      }
    }
    private void SeedData(AppDbContext context)
    {
      clearCarts(context);
      if (!context.Products.Any())
      {
        addProducts(context);
      }
      context.SaveChanges();
    }

    private void addProducts(AppDbContext context)
    {
      Console.WriteLine("### Adding products to the empty database");

      context.Products.AddRange(
        new Product
        {
          Id = "2f81a686-7531-11e8-86e5-f0d5bf731f68",
          Name = "Keychain Phone Charger",
          Price = 29.99,
          Description = "This keychain lightning charger comes with a plug so you’ll be able to charge anywhere with an outlet. Great for the traveller on the go who always needs their phone."
        },
        new Product
        {
          Id = "4c1aa7d4-7531-11e8-86e5-f0d5bf731f68",
          Name = "Heat Sensitive Coffee Mug",
          Price = 12.99,
          Description = "This cool coffee will flow with color as you pour warm coffee into it."
        },
        new Product
        {
          Id = "5d3b9e7e-7531-11e8-86e5-f0d5bf731f68",
          Name = "Tiny Zip Knife",
          Price = 21.65,
          Description = "It’s always convenient to have a tiny knife with you. This is the most portable knife we have seen!"
        },
        new Product
        {
          Id = "39ac2118-7531-11e8-86e5-f0d5bf731f68",
          Name = "Coffee Mug",
          Price = 11.80,
          Description = "Classic white coffee mug."
        },
        new Product
        {
          Id = "55bb6ef4-7531-11e8-86e5-f0d5bf731f68",
          Name = "Heart Shaped Tea Mug",
          Price = 18.55,
          Description = "These glass mugs are perfect for romantic tea in the mornings."
        },
        new Product
        {
          Id = "4262b2c2-7531-11e8-86e5-f0d5bf731f68",
          Name = "Coffee Mug",
          Price = 11.80,
          Description = "Classic red coffee mug."
        }
      );
    }

    private void clearCarts(AppDbContext context)
    {
      Console.WriteLine("### Removing all carts");
      context.CartProducts.RemoveRange(context.CartProducts.ToList());
      context.Carts.RemoveRange(context.Carts.ToList());
    }
  }
}