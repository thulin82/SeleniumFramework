using OpenQA.Selenium;
using SeleniumFramework.Base;

namespace SeleniumFramework.Pages
{
    public class RadioButtonsPage
    {
        private readonly IWebDriver _driver;

        public RadioButtonsPage() => _driver = DriverContext.Driver;
    }
}
