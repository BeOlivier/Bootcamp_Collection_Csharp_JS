using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Newtonsoft.Json;
using RestShop.API.Model;
using Xunit;

namespace RestShop.Tests
{

  [Collection(nameof(HttpClientCollection))]
  public class ProductsControllerTests
  {
    readonly HttpClient _client;
    const string BASE_URL = "/api/Products"; 

    public ProductsControllerTests(HttpClientFixture fixture)
    {
      _client = fixture.Client;
    }

    [Fact]
    public async Task getAllProducts_returns_OK()
    {
      // act
      var response = await _client.GetAsync(BASE_URL);

      // arrange
      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }


    [Fact]
    public async Task getAllProducts_returns_6_products()
    {
      // act
      var response = await _client.GetAsync(BASE_URL);

      // arrange
      var products = JsonConvert.DeserializeObject<List<Product>>(await response.Content.ReadAsStringAsync());
      products.Should().HaveCount(6);
    }

    [Fact]
    public async Task getOne_returns_a_well_known_product()
    {
      // act
      var response = await _client.GetAsync($"{BASE_URL}/5d3b9e7e-7531-11e8-86e5-f0d5bf731f68");

      // arrange
      var product = JsonConvert.DeserializeObject<Product>(await response.Content.ReadAsStringAsync());
      product.Id.Should().Be("5d3b9e7e-7531-11e8-86e5-f0d5bf731f68");
    }

    [Fact]
    public async Task getOne_returns_OK()
    {
      // act
      var response = await _client.GetAsync($"{BASE_URL}/5d3b9e7e-7531-11e8-86e5-f0d5bf731f68");

      // arrange
      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }


    [Fact]
    public async Task getOne_for_non_existing_product_return_404()
    {
      // act
      var response = await _client.GetAsync($"{BASE_URL}/-1");

      // arrange
      response.StatusCode.Should().Be(HttpStatusCode.NotFound);
    }
  }
}
