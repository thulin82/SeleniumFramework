using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumFramework.Base;
using System;

namespace SeleniumFramework
{
    public class Actions
    {
        public static void InitializeDriver(int second)
        {
            DriverContext.Driver = new ChromeDriver();
            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Driver.Navigate().GoToUrl(Config.BaseURL);


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
