using System;
using FluentAssertions;
using Moq;
using Salt.Stars.Web.Models;
using Salt.Stars.Web.Pages;
using Salt.Stars.Web.Services;
using Xunit;

namespace Salt.Stars.Web.Tests
{
  public class HeroPageTests
  {
    HeroResponse MOCK_RESPONSE = new HeroResponse
    {
      RequestedAt = DateTime.Now,
      Hero = new Hero { Name = "Captain Kirk", StarRating = 4 }
    };

    HeroPage pageUnderTest;
    Mock<IHeroAPIClient> _apiClientMock;
    public HeroPageTests()
    {
      _apiClientMock = new Mock<IHeroAPIClient>();
      _apiClientMock.Setup(apiClient => apiClient.GetHero(It.IsAny<int>()).Result).Returns(MOCK_RESPONSE);

      pageUnderTest = new HeroPage(_apiClientMock.Object);
    }

    [Fact]
    public void should_create_page()
    {
      // Assert
      pageUnderTest.Should().NotBe(null);
      pageUnderTest.Should().BeOfType<HeroPage>();
    }

    [Fact]
    async public void should_get_hero()
    {
      // Act
      await pageUnderTest.OnGetAsync(123);

      // Assert
      pageUnderTest.HeroResponse.RequestedAt.Should().Be(MOCK_RESPONSE.RequestedAt);
      pageUnderTest.HeroResponse.Hero.Name.Should().Be(MOCK_RESPONSE.Hero.Name);
    }

    [Fact]
    async public void should_handle_exception_from_api()
    {
      // Arrange
      _apiClientMock = new Mock<IHeroAPIClient>(MockBehavior.Strict);
      _apiClientMock.Setup(apiClient => apiClient.GetHero(It.IsAny<int>()).Result).Throws<Exception>();
      pageUnderTest = new HeroPage(_apiClientMock.Object);

      // Act
      await pageUnderTest.OnGetAsync(123);

      // Assert;
      pageUnderTest.HeroResponse.Should().Be(null);
      pageUnderTest.ErrorMessage.Should().NotBe(String.Empty);
    }

    [Fact]
    async public void should_show_stars_for_hero()
    {
      // Act
      await pageUnderTest.OnGetAsync(123);

      // Assert
      pageUnderTest.HeroResponse.Hero.StarRating.Should().Be(MOCK_RESPONSE.Hero.StarRating);
    }

    [Fact]
    async public void should_update_stars_for_hero()
    {
      // Arrange
      var response = new StarUpdateResponse { HeroId = 1, CurrentNumberOfStars = 4, RequestedAt = DateTime.Now };
      _apiClientMock = new Mock<IHeroAPIClient>(MockBehavior.Strict);
      _apiClientMock.Setup(apiClient => apiClient.UpdateStars(It.IsAny<int>(), It.IsAny<int>()).Result).Returns(response);
      pageUnderTest = new HeroPage(_apiClientMock.Object);

      pageUnderTest.HeroResponse = new HeroResponse
      {
        Hero = new Hero
        {
          StarRating = 4
        }
      };

      // Act
      await pageUnderTest.OnPostAsync(1);

      // Assert;
      _apiClientMock.Verify(client => client.UpdateStars(1, 4));
      pageUnderTest.HeroResponse.Should().NotBe(null);
      pageUnderTest.HeroResponse.Hero.StarRating.Should().Be(4);
      pageUnderTest.ErrorMessage.Should().Be(null);
    }

    [Fact]
    async public void should_handle_error_when_update_stars_for_hero()
    {
      // Arrange
      _apiClientMock = new Mock<IHeroAPIClient>(MockBehavior.Strict);
      _apiClientMock.Setup(apiClient => apiClient.UpdateStars(It.IsAny<int>(), It.IsAny<int>()).Result).Throws<Exception>();
      pageUnderTest = new HeroPage(_apiClientMock.Object);

      pageUnderTest.HeroResponse = new HeroResponse
      {
        Hero = new Hero
        {
          StarRating = 2
        }
      };

      // Act
      await pageUnderTest.OnPostAsync(1);

      // Assert;
      pageUnderTest.HeroResponse.Should().NotBe(null);
      pageUnderTest.HeroResponse.Hero.StarRating.Should().Be(2);
      pageUnderTest.ErrorMessage.Should().NotBe(String.Empty);
    }
  }
}