using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvCShop.Web.Models
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
    public string SessionId { get; set; }
    public List<CartProduct> Products { get; set; }
  }
}