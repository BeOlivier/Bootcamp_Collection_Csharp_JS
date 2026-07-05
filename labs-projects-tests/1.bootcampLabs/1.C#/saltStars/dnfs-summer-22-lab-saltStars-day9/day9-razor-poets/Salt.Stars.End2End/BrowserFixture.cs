using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Salt.Stars.End2End
{
  public class BrowserFixture : IDisposable
  {
    public IWebDriver Driver { get; private set; }
    public BrowserFixture()
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
  }

  [CollectionDefinition("Browser automation collection")]
  public class BrowserCollection : ICollectionFixture<BrowserFixture>
  {
    // This class has no code, and is never created. Its purpose is simply
    // to be the place to apply [CollectionDefinition] and all the
    // ICollectionFixture<> interfaces.
  }
}