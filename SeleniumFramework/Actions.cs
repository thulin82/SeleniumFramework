using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumFramework
{
    public class Actions
    {
        public static IWebDriver InitializeDriver(int second)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseURL);


            TimeSpan seconds = TimeSpan.FromSeconds(second);
            driver.Manage().Timeouts().ImplicitWait = seconds;

            return driver;
        }
    }
}
