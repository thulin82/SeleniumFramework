using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumFramework.Base;
using SeleniumFramework.Config;
using System;

namespace SeleniumFramework
{
    public class Actions
    {
        public static void InitializeDriver(int second, BrowserType browser = BrowserType.Chrome)
        {
            switch (browser)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Firefox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }

            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Driver.Navigate().GoToUrl(Settings.SUT);


            TimeSpan seconds = TimeSpan.FromSeconds(second);
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = seconds;
        }

        public static void ClosePopup()
        {
            bool exists = DriverContext.Driver.FindElements(By.Id("at-cv-lightbox")).Count != 0;
            if (exists)
            {
                DriverContext.Driver.FindElement(By.Id("at-cv-lightbox-close")).Click();
            }
        }
    }
}
