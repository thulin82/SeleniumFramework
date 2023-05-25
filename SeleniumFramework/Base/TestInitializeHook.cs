using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumFramework.Config;
using SeleniumFramework.Helpers;
using System;

namespace SeleniumFramework.Base
{
    public abstract class TestInitializeHook
    {
        public TestInitializeHook()
        {
            InitializeSettings();
        }
        public void InitializeSettings()
        {
            // Framework settings from appsettings.json
            ConfigReader.SetFrameworkSettings();
            // SUT settings from sutsettings.json
            ConfigReader.SetSUTSettings();

            //Log setting
            //LogHelpers.CreateLogFile();

            //Open Browser
            OpenBrowser(5, Settings.BrowserType);
        }

        private static void OpenBrowser(int second, BrowserType browser = BrowserType.Chrome)
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
    }
}
