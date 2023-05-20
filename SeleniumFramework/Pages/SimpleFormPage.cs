using OpenQA.Selenium;
using SeleniumFramework.Base;

namespace SeleniumFramework.Pages
{
    public class SimpleFormPage
    {
        private readonly IWebDriver _driver;

        public SimpleFormPage() => _driver = DriverContext.Driver;

        public string UseSingleInputField(string msg)
        {
            MessageBox.Clear();
            MessageBox.SendKeys(msg);
            ShowMessageButton.Click();
            return MessageDisplay.Text;
        }

        public string UseTwoInputFields(string msg1, string msg2)
        {
            MessageA.Clear();
            MessageA.SendKeys(msg1);
            MessageB.Clear();
            MessageB.SendKeys(msg2);
            GetTotalButton.Click();
            return SumDisplay.Text;
        }

        #region WebElements
        public IWebElement MessageBox => _driver.FindElement(By.Id("user-message"));
        public IWebElement ShowMessageButton => _driver.FindElement(By.XPath("//button[contains(text(),'Show Message')]"));
        public IWebElement MessageDisplay => _driver.FindElement(By.Id("display"));
        public IWebElement MessageA => _driver.FindElement(By.Id("value1"));
        public IWebElement MessageB => _driver.FindElement(By.Id("value2"));
        public IWebElement GetTotalButton => _driver.FindElement(By.XPath("//button[contains(text(),'Get Total')]"));
        public IWebElement SumDisplay => _driver.FindElement(By.Id("displayvalue"));
        #endregion
    }
}