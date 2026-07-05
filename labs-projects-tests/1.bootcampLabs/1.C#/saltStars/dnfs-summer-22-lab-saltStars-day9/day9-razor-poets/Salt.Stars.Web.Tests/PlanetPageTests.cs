using System;
using FluentAssertions;
using Moq;
using Salt.Stars.Web.Models;
using Salt.Stars.Web.Pages;
using Salt.Stars.Web.Services;
using Xunit;

namespace Salt.Stars.Web.Tests
{
  public class PlanetPageTests
  {
    PlanetResponse MOCK_RESPONSE = new PlanetResponse
    {
      RequestedAt = DateTime.Now,
      Planet = new Planet { Name = "Earth" }
    };

    PlanetPage pageUnderTest;
    Mock<IPlanetAPIClient> _apiMockClient;
    public PlanetPageTests()
    {
      _apiMockClient = new Mock<IPlanetAPIClient>();
      _apiMockClient.Setup(apiService => apiService.GetPlanet(It.IsAny<int>()).Result).Returns(MOCK_RESPONSE);

      pageUnderTest = new PlanetPage(_apiMockClient.Object);
    }

    [Fact]
    public void should_create_page()
    {
      // Assert
      pageUnderTest.Should().NotBe(null);
      pageUnderTest.Should().BeOfType<PlanetPage>();
    }

    [Fact]
    async public void should_get_planet()
    {
      // Act
      await pageUnderTest.OnGetAsync(123);

      // Assert
      pageUnderTest.PlanetResponse.RequestedAt.Should().Be(MOCK_RESPONSE.RequestedAt);
      pageUnderTest.PlanetResponse.Planet.Name.Should().Be(MOCK_RESPONSE.Planet.Name);
    }

    [Fact]
    async public void should_handle_exception_from_api()
    {
      // Arrange
      _apiMockClient = new Mock<IPlanetAPIClient>(MockBehavior.Strict);
      _apiMockClient.Setup(apiService => apiService.GetPlanet(It.IsAny<int>()).Result).Throws<Exception>();
      pageUnderTest = new PlanetPage(_apiMockClient.Object);

      // Act
      await pageUnderTest.OnGetAsync(123);

      // Assert;
      pageUnderTest.PlanetResponse.Should().Be(null);
      pageUnderTest.ErrorMessage.Should().NotBe(String.Empty);
    }
  }
}