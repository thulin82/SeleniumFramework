using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumFramework.Pages;
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

        public static void ClosePopup(IWebDriver driver)
        {
            bool exists = driver.FindElements(By.Id("at-cv-lightbox")).Count != 0;
            if (exists)
            {
                driver.FindElement(By.Id("at-cv-lightbox-close")).Click();
            }
        }

        public static string UseSingleInputField(string msg, IWebDriver driver)
        {
            SimpleFormPage page = new SimpleFormPage(driver);

            page.MessageBox.Clear();
            page.MessageBox.SendKeys(msg);
            page.ShowMessageButton.Click();
            return page.MessageDisplay.Text;
        }

        public static string UseTwoInputFields(string msg1, string msg2, IWebDriver driver)
        {
            SimpleFormPage page = new SimpleFormPage(driver);
            page.MessageA.Clear();
            page.MessageA.SendKeys(msg1);
            page.MessageB.Clear();
            page.MessageB.SendKeys(msg2);
            page.GetTotalButton.Click();
            return page.SumDisplay.Text;

            
        }
    }
}
