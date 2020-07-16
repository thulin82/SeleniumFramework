using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumFramework.Base;
using SeleniumFramework.Pages;
using System;

namespace SeleniumFramework
{
    public class Actions
    {
        public static void InitializeDriver(int second)
        {
            DriverContext.Driver = new ChromeDriver();
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

        public static string UseSingleInputField(string msg)
        {
            SimpleFormPage page = new SimpleFormPage();

            page.MessageBox.Clear();
            page.MessageBox.SendKeys(msg);
            page.ShowMessageButton.Click();
            return page.MessageDisplay.Text;
        }

        public static string UseTwoInputFields(string msg1, string msg2)
        {
            SimpleFormPage page = new SimpleFormPage();
            page.MessageA.Clear();
            page.MessageA.SendKeys(msg1);
            page.MessageB.Clear();
            page.MessageB.SendKeys(msg2);
            page.GetTotalButton.Click();
            return page.SumDisplay.Text;

            
        }
    }
}
