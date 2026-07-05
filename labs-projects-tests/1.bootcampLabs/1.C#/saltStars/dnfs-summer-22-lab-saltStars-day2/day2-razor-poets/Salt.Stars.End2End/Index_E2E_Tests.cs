using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Salt.Stars.End2End
{
  public class Index_E2E_Tests : IDisposable
  {
    IWebDriver Driver = null;
    public Index_E2E_Tests()
    {
      Driver = new ChromeDriver();
    }

    public void Dispose()
    {
      if (Driver != null)
      {
        Driver.Quit();
        Driver = null;
      }
    }

    [Fact]
    public void Test1()
    {
      // Arrange
      var testName = "Marcus";

      // Act
      Driver.Navigate().GoToUrl($"http://localhost:6001/?DeveloperName={testName}");

      // Assert
      IWebElement greeting = Driver.FindElement(By.Id("greeting"));
      Assert.Contains(testName.ToLower(), greeting.Text.ToLower());
    }
  }
}
