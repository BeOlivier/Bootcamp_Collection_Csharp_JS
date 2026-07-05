# REST Shopping API

## A. Scenario

> It was the best course I ever took - EVERYTHING needs to be RESTful now, so help me Roy!

You have seen this look in her eyes before. Samantha has been to yet another course (how many course can one person take without learning a thing...) and has, yet again, seen the light.

Normally you would shy away from this, but this gives you an opportunity to finally make something useful out of the old monolith. You raise your voice:

> That would be great - how about if we make a version of the Shopping API that is RESTful?

She giggles and runs up to her father, also the CTO:

> Dad, dad - they said we could

You can't believe how this company is run, but at least you get to get your hands dirty with REST apis

## B. What you will be working on

We are going to build a RESTful API for a product list and a shopping cart. This will give us plenty of opportunities to learn and try to follow the rules and principles of REST.

Since we haven't used databases yet, we will keep the data in an in-memory database that we have prepared and wrapped access to in the `Data`-class. You can just use the methods and don't have to care too much about the implementation

## C. Setup

Today your solution will be guided through a series of integration-tests that we have setup for you; `RestShop.Tests`.

The WebAPI has a skeleton implementation in `RestShop.API`.

You can, also, verify the code through the Swagger client - or use a tool like [Postman](https://www.postman.com/) (installed on your computers) or [Insomnia](https://insomnia.rest/)

## D. Lab instructions

- Run the tests with `dotnet test`
  - See what fails and fix the implementation
  - Some tests might pass without you "doing anything" - reflect over this and think about why the test passed
- I've set up the WebAPI so that it will restore the database on every restart of the server, while developing

  - That means that the products will be re-created (see `SeedDatabase.cs`) and remove the carts
  - This will run automatic on every test run to reset the test data

- In the `RestShop.API.Data`-directory there are quite a lot of code, but you can disregard most of that and just use the injected repositories. For example:

  ```csharp
  private readonly IProductRepository _repo;

  public ProductsController(IProductRepository repo)
  {
    _repo = repo;
  }

  [HttpGet]
  public IEnumerable<Product> GetAll()
  {
    return _repo.GetAll();
  }
  ```

  - There are other methods that you will find useful to accomplish the task. You should not have to modify any code in the `Data`-directory

---

Good luck and have fun!
