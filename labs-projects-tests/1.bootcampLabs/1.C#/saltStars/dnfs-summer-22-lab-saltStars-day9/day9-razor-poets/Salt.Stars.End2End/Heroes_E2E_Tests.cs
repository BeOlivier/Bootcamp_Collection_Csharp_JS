using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Salt.Stars.End2End
{
  [Collection("Browser automation collection")]
  public class Heroes_E2E_Tests
  {
    IWebDriver _driver = null;
    public Heroes_E2E_Tests(BrowserFixture browserFixture)
    {
      _driver = browserFixture.Driver;
    }

    [Fact]
    public void should_show_heroes_page()
    {
      // Act
      _driver.Navigate().GoToUrl($"http://localhost:6001/heroes");

      // Assert
      IWebElement mainHeader = _driver.FindElement(By.Id("mainHeader"));
      Assert.Contains("The Heroes list", mainHeader.Text);

      int rowCount = _driver.FindElements(By.XPath("//*[@id='heroesTable']/tbody/tr")).Count;
      Assert.Equal(10, rowCount);
    }
  }
}
