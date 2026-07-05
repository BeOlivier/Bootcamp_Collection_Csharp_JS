using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Salt.Stars.End2End
{

  [Collection("Browser automation collection")]
  public class Planet_E2E_Tests
  {
    IWebDriver _driver;
    public Planet_E2E_Tests(BrowserFixture browserFixture)
    {
      _driver = browserFixture.Driver;
    }

    [Fact]
    public void should_show_planet_page()
    {
      // Act
      _driver.Navigate().GoToUrl($"http://localhost:6001/Planet?id=1");

      // Assert
      IWebElement mainHeader = _driver.FindElement(By.Id("mainHeader"));
      Assert.Contains("Tatooine", mainHeader.Text);
    }
  }
}
