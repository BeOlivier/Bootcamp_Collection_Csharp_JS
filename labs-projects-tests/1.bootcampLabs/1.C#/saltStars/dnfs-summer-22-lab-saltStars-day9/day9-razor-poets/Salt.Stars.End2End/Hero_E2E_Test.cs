using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Salt.Stars.End2End
{
  [Collection("Browser automation collection")]
  public class Hero_E2E_Tests
  {
    IWebDriver _driver = null;
    public Hero_E2E_Tests(BrowserFixture browserFixture)
    {
      _driver = browserFixture.Driver;
    }

    [Fact]
    public void should_show_hero_page()
    {
      // Act
      _driver.Navigate().GoToUrl($"http://localhost:6001/Hero?id=1");

      // Assert
      IWebElement mainHeader = _driver.FindElement(By.Id("mainHeader"));
      Assert.Contains("Skywalker", mainHeader.Text);
    }


    [Fact]
    public void should_update_star_rating_for_hero()
    {
      // Arrange
      _driver.Navigate().GoToUrl($"http://localhost:6001/Hero?id=1");

      // Act
      _driver.FindElement(By.Id("HeroResponse_Hero_StarRating")).SendKeys("4");
      _driver.FindElement(By.Id("btnUpdateStars")).Click();

      // Assert
      IWebElement starRating = _driver.FindElement(By.Id("HeroResponse_Hero_StarRating"));

      Assert.Contains("4", starRating.GetAttribute("value"));
    }
  }
}
