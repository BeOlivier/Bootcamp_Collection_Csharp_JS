namespace MvCShop.Web.Models
{
  public class AddProductCartProductRequest
  {
    public string ProductId { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
  }
}
