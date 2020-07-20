using OpenQA.Selenium;

namespace SeleniumFramework.Base
{
    public class Browser
    {
        private readonly IWebDriver _driver;

        public Browser(IWebDriver driver)
        {
            _driver = driver;

        }

        public BrowserType Type { get; set; }

        public void GoToUrl(string url)
        {
            DriverContext.Driver.Navigate().GoToUrl(url);
        }
    }

    public enum BrowserType
    {
        InternetExplorer,
        Firefox,
        Chrome
    }
}
