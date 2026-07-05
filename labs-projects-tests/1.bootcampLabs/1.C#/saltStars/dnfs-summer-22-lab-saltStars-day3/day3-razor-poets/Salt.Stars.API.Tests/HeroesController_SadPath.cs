using Salt.Stars.API.Controllers;
using Xunit;
using FluentAssertions;
using Moq;
using System;

namespace Salt.Stars.API.Tests
{

  public class HeroesController_SadPath
  {
    HeroesController controller;
    Mock<ISwApiService> _apiServiceMock;

    public HeroesController_SadPath()
    {
      // Arrange
      _apiServiceMock = new Mock<ISwApiService>();
      _apiServiceMock.Setup(apiService => apiService.getHerosFromSwapi().Result).Throws<Exception>();
      _apiServiceMock.Setup(apiService => apiService.getHeroFromSwapi(It.IsAny<short>()).Result).Throws<Exception>();

      this.controller = new HeroesController(_apiServiceMock.Object);
    }

    [Fact]
    public void getHeroes_should_handle_exception_from_API()
    {
      // Act
      var response = controller.GetHeroListAsync();

      // Assert
      response.Should().NotBe(null);
      response.Result.Value.Should().Be(null);
    }

    [Fact]
    public void getHero_should_handle_exception_from_API()
    {
      // Act
      var response = controller.GetHeroAsync(10);

      // Assert
      response.Should().NotBe(null);
      response.Result.Value.Should().Be(null);
    }
  }
}
