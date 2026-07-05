using Salt.Stars.API.Controllers;
using Xunit;
using FluentAssertions;
using Moq;
using System;
using Salt.Stars.API.Services;

namespace Salt.Stars.API.Tests
{

  public class PlanetsController_SadPath
  {
    PlanetsController controller;
    Mock<ISwApiClient> _apiMockClient;

    public PlanetsController_SadPath()
    {
      // Arrange
      _apiMockClient = new Mock<ISwApiClient>();
      _apiMockClient.Setup(apiClient => apiClient.getPlanetFromSwapi(It.IsAny<int>()).Result).Throws<Exception>();

      this.controller = new PlanetsController(_apiMockClient.Object);
    }

    [Fact]
    public void getPlanet_should_handle_exception_from_API()
    {
      // Act
      var response = controller.GetPlanetAsync(-1);

      // Assert
      response.Should().NotBe(null);
      response.Result.Value.Should().Be(null);
    }
  }
}
