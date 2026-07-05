using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Newtonsoft.Json;
using RestShop.API.Model;
using Xunit;
using RestShop.Api.Controllers;

namespace RestShop.Tests
{
  [Collection(nameof(HttpClientCollection))]
  public class CartsControllerTests
  {
    readonly HttpClient _client;

    const string BASE_URL = "/api/Carts";
    AddProductCartProductRequest TEST_PRODUCT_TO_ADD_TO_CART =
      new AddProductCartProductRequest
      {
        ProductId = "2f81a686-7531-11e8-86e5-f0d5bf731f68",
        Quantity = 3,
        Price = 10.53,
      };

    public CartsControllerTests(HttpClientFixture fixture) // fake, black magic
    {
      _client = fixture.Client;
    }

    private async Task<HttpResponseMessage> CreateNewCart() => await _client.PostAsync(BASE_URL, null);
    private async Task<string> CreateNewCartAndGetLocation()
    {
      var createResponse = await _client.PostAsync(BASE_URL, null);
      return createResponse.Headers.Location.AbsoluteUri;
    }

    private static StringContent ToJson(AddProductCartProductRequest cartProduct)
    {
      var serializedDoc = JsonConvert.SerializeObject(cartProduct);
      var requestContent = new StringContent(serializedDoc, Encoding.UTF8, "application/json");
      return requestContent;
    }

    private static StringContent ToFormData(AddProductCartProductRequest cartProduct)
    {
      var serializedDoc = JsonConvert.SerializeObject(cartProduct);
      var requestContent = new StringContent(serializedDoc, Encoding.UTF8, "application/x-www-form-urlendcoded");
      return requestContent;
    }

    [Fact]
    public async Task create_new_cart_returns_created()
    {
      // act
      var response = await CreateNewCart();

      // arrange
      response.StatusCode.Should().Be(HttpStatusCode.Created);
    }


    [Fact]
    public async Task create_new_cart_returns_location()
    {
      // act
      var response = await CreateNewCart();

      // arrange
      var cart = JsonConvert.DeserializeObject<Cart>(await response.Content.ReadAsStringAsync());
      response.Headers.Location.AbsoluteUri.Should().ContainAll(BASE_URL, cart.Id);
    }

    [Fact]
    public async Task create_new_cart_returns_cart()
    {
      // act
      var response = await CreateNewCart();

      // arrange
      var cart = JsonConvert.DeserializeObject<Cart>(await response.Content.ReadAsStringAsync());
      cart.Id.Should().NotBe(string.Empty);
      cart.Products.Count.Should().Be(0);
    }


    [Fact]
    public async Task adding_product_to_existing_cart_should_work()
    {
      // arrange
      var cartUrl = await CreateNewCartAndGetLocation();

      // act
      var response = await _client.PatchAsync(cartUrl, ToJson(TEST_PRODUCT_TO_ADD_TO_CART));

      // assert
      var cart = JsonConvert.DeserializeObject<Cart>(await response.Content.ReadAsStringAsync());
      cart.Id.Should().NotBe(string.Empty);
      cart.Products.Count.Should().Be(1);
    }


    [Fact]
    public async Task adding_product_to_existing_cart_should_return_ok()
    {
      // arrange
      var cartUrl = await CreateNewCartAndGetLocation();


      // act
      var response = await _client.PatchAsync(cartUrl, ToJson(TEST_PRODUCT_TO_ADD_TO_CART));

      // assert
      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]
    public async Task adding_product_to_existing_cart_should_work_with_form_data()
    {
      // arrange
      var cartUrl = await CreateNewCartAndGetLocation();

      // act
      var response = await _client.PatchAsync(cartUrl + "/form", ToFormData(TEST_PRODUCT_TO_ADD_TO_CART));

      // assert
      var cart = JsonConvert.DeserializeObject<Cart>(await response.Content.ReadAsStringAsync());
      cart.Id.Should().NotBe(string.Empty);
      cart.Products.Count.Should().Be(1);
    }

    [Fact]
    public async Task deleting_existing_cart_should_return_accepted()
    {
      // arrange
      var cartUrl = await CreateNewCartAndGetLocation();

      // act
      var response = await _client.DeleteAsync(cartUrl);

      // assert
      response.StatusCode.Should().Be(HttpStatusCode.Accepted);
    }

    [Fact]
    public async Task deleting_existing_cart_should_delete_the_cart()
    {
      // arrange
      var cartUrl = await CreateNewCartAndGetLocation();
      await _client.DeleteAsync(cartUrl);

      // act
      var response = await _client.GetAsync(cartUrl);

      // assert
      response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }

    [Fact]
    public async Task deleting_existing_cart_twice_should_return_accepted_since_accepted_just_means_that_the_command_is_accepted()
    {
      // arrange
      var cartUrl = await CreateNewCartAndGetLocation();

      // act
      var response = await _client.DeleteAsync(cartUrl);
      var response2 = await _client.DeleteAsync(cartUrl);

      // assert
      response.StatusCode.Should().Be(HttpStatusCode.Accepted);
      response2.StatusCode.Should().Be(HttpStatusCode.Accepted);
    }
  }
}
