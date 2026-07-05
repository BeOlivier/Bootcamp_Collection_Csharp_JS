
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvCShop.Web.Data;
using MvcShop.Web.Models;
using MvCShop.Web.Models;

//a very powerful receptionist
namespace MvcShop.Web.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly IProductRepository _productRepository;
    private readonly ICartRepository _cartRepository;
    private string sessionID;

    public HomeController(ILogger<HomeController> logger, IProductRepository productRepo, ICartRepository cartrepo)
    {
      _logger = logger;
      _productRepository = productRepo;
      _cartRepository = cartrepo;
    }

    public IActionResult Index()
    {
        var products = _productRepository.GetAll();
        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult ProductPage(string id)
    {
        var product = _productRepository.GetOne(id);
        return View(product);
    }

    public Cart CreateCart()
    {
        sessionID =  HttpContext.Connection.Id;
        Cart cart;
        if (_cartRepository.GetCartForSession(sessionID) == null)
        {
            cart = _cartRepository.Create(sessionID);
        }
        else
        {
            cart = _cartRepository.GetCartForSession(sessionID);
        }
        return cart;
    }

    public Cart AddProductToCart(Product product)
    {
        var cart = CreateCart();
        var request = new AddProductCartProductRequest()
        {
            ProductId = product.Id,
            Quantity = 1,
            Price = product.Price,
        };
        return _cartRepository.Update(cart.Id, request);
    }

    public IActionResult ProductAddedToCart(string id)
    {
        AddProductToCart(_productRepository.GetOne(id));
        return View();
    }

    public IActionResult CartPage()
    {
        var cart = CreateCart();
        return View(cart);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
