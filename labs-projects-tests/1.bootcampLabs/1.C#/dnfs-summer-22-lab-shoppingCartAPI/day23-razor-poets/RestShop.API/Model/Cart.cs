using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestShop.API.Model
{
  public class Cart
  {
    public Cart()
    {
      Products = new List<CartProduct>();
    }

    [Key]
    [Required]
    public string Id { get; set; }
    public List<CartProduct> Products { get; set; }
  }
}