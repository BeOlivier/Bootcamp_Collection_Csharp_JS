using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Salt.Stars.End2End
{
  [Collection("Browser automation collection")]
  public class Index_E2E_Tests
  {
    IWebDriver _driver = null;
    public Index_E2E_Tests(BrowserFixture browserFixture)
    {
      _driver = browserFixture.Driver;
    }

    [Fact]
    public void Index_Page_Shows_without_name()
    {
      // Act
      _driver.Navigate().GoToUrl($"http://localhost:6001/");

      // Assert
      IWebElement mainHeader = _driver.FindElement(By.Id("mainHeader"));
      Assert.Contains("Get your greeting below", mainHeader.Text);
    }

    [Fact]
    public void Index_Page_Shows_for_name()
    {
      // Arrange
      var testName = "Marcus";

      // Act
      _driver.Navigate().GoToUrl($"http://localhost:6001/?DeveloperName={testName}");

      // Assert
      IWebElement mainHeader = _driver.FindElement(By.Id("greeting"));
      Assert.Contains(testName, mainHeader.Text);
    }
  }
}
