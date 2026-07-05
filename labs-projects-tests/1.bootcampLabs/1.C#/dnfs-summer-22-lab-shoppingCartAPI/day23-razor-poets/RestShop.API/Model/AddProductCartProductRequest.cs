namespace RestShop.API.Model
{
  public class AddProductCartProductRequest
  {
    public string ProductId { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
  }
}
