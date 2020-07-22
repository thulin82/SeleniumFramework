using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumFramework.Base;

namespace SeleniumFramework.Pages
{
    public class SimpleFormPage : BasePage
    {
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
        [FindsBy(How = How.XPath, Using = "//input[@id='user-message']")]
        public IWebElement MessageBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Show Message')]")]
        public IWebElement ShowMessageButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@id='display']")]
        public IWebElement MessageDisplay { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='sum1']")]
        public IWebElement MessageA { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='sum2']")]
        public IWebElement MessageB { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Get Total')]")]
        public IWebElement GetTotalButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@id='displayvalue']")]
        public IWebElement SumDisplay { get; set; }
        #endregion
    }
}