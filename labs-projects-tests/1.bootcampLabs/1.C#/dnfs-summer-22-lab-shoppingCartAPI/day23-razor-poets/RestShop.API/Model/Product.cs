using System.ComponentModel.DataAnnotations;

namespace RestShop.API.Model
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