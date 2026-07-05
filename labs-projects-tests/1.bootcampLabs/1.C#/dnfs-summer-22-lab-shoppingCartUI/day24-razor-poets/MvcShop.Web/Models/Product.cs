using System.ComponentModel.DataAnnotations;

namespace MvCShop.Web.Models
{
  public class Product
  {
    [Key]
    [Required]
    public string Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
  }
}