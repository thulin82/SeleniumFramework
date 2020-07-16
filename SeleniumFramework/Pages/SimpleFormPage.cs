using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumFramework.Pages
{
    public class SimpleFormPage
    {

        public SimpleFormPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

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
    }
}




