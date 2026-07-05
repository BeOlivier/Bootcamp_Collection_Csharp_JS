using System.ComponentModel.DataAnnotations;

namespace MvCShop.Web.Models
{
  public class CartProduct
  {
    [Key]
    public string CartProductId { get; set; }
    public string ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
  }
}
