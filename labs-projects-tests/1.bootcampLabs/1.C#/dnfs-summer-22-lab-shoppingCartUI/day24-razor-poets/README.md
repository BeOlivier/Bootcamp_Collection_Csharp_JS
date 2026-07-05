# Shopping Cart UI

### A. Scenario

> This is great! Have you built all of this already?! But ... where can I see it?

That's right, explaining APIs to business users is always a hustle. You should have known this. You rattle of an explanation that probably confused more than helped but also heard yourself say on the way out:

> I'll have a view for you to interact with, until tomorrow.

Well, that will be a challenge, you think to yourself as you open the door of the team room to break the news.

> Hey team - i know what we are going to do today ...

### B. What you will be working on

Today we will rebuild the shopping cart from yesterday but instead of returning JSON and Model classes we will return a view. We will do this by building an MVC application using the techniques you learned in the lecture.

We should present a list of products and then give the opportunity to put items into a basket.

Much of the "back-end" code will be familiar to you from yesterday, so the focus today is on getting the data onto the page and give opportunity to navigate the application.
Don't put time into styling the application today - there's a week coming up for that, but rather just do the minimal to get it to work. Keep the focus on how data is moved from the Model via Controller to the API.

Reflect about how the flow in an MVC app mimics the flow of in an WebAPI... (psst it's actually very similar) and you will gain a deeper understanding for how the web applications in ASP.NET have a common conceptual base.

### C. Setup

We have create a very simple skeleton application, that uses the same structure for data access as for the REST-api yesterday. All of that is found in the `Data`-directory, and can be connected through dependency injections, as we did in the REST-exercise:

```csharp
private readonly IProductRepository _repo;

public ProductsController(IProductRepository repo) : Controller
{
  _repo = repo;
}

[HttpGet]
public IEnumerable<Product> GetAll()
{
  return _repo.GetAll();
}
```

#### A few words on the session

This site uses something called `Sessions` which is a way for us to track a certain user for a certain visit, even without the user being logged in.

The id of the session (that you can get with `HttpContext.Session.Id`) is how we tie a certain `Cart` to a user. This id is the id that you're supposed to pass in the `ICartRepository.Create` method. You can then use it to retrieve the cart via the `ICartRepository.GetCartForSession` method.

### D. Lab instructions

1. Have a top navigation that
   1. Have a link to the product list
   1. Have a link to the Cart
   1. Defaults shows the product list
1. Present a list of products
   1. Just name and images (yes, there's an image URL for each product today)
   1. Allow the user to click on one product and see the details of that product
1. On the Product detail page
   1. Allow the user to add the product to their cart
      1. Create the cart if it doesn't exists
      1. Add to the cart if it exits
1. On the Cart page
   1. Shows all the product, in the cart and the sum of their value
      1. Allows the user to increase/decrease the quantity of the items in the cart
      1. Allows the user to remove items already in the cart
   1. Allows the user to "checkout", which shows a summary of the carts, as a receipt and clears the cart

---

Good luck and have fun!
