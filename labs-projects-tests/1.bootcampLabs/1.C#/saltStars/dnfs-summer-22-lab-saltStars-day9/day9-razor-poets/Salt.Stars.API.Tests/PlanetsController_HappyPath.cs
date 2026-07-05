
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using Salt.Stars.API.Controllers;
using Salt.Stars.API.Models;
using Salt.Stars.API.Services;
using Xunit;

namespace Salt.Stars.API.Tests
{

  public class PlanetsController_HappyPath
  {
    PlanetsController controller;
    Mock<ISwApiClient> _apiMockClient;

    const int TEST_PLANET_ID = 3232;

    Planet MOCK_PLANET_DATA = new Planet
    {
      Name = "Earth",
      Url = "https://trekkiapi.dev/api/people/3232/",
      Diameter = "23452345",
      Population = "7.000.000.000",
      Gravity = "1.0"
    };
    public PlanetsController_HappyPath()
    {
      // Arrange
      _apiMockClient = new Mock<ISwApiClient>();
      _apiMockClient.Setup(apiClient => apiClient.getPlanetFromSwapi(It.IsAny<int>()).Result).Returns(MOCK_PLANET_DATA);

      this.controller = new PlanetsController(_apiMockClient.Object);
    }

    [Fact]
    public void get_planet_should_return_a_response()
    {
      // Act
      var response = controller.GetPlanetAsync(TEST_PLANET_ID);

      // Assert
      response.Should().NotBe(null);
      response.Status.Should().Be(TaskStatus.RanToCompletion);
    }

    [Fact]
    public void get_planet_should_return_a_mocked_data()
    {
      // Act
      var response = controller.GetPlanetAsync(TEST_PLANET_ID);

      // Assert
      var data = response.Result.Value;
      data.Planet.Name.Should().Be(MOCK_PLANET_DATA.Name);
      data.Planet.Url.Should().Be(MOCK_PLANET_DATA.Url);
      data.Planet.Id.Should().NotBe(null);
      data.RequestedAt.Should().NotBe(null);
    }
  }
}