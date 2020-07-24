using OpenQA.Selenium;
using SeleniumFramework.Base;

namespace SeleniumFramework.Pages
{
    public class CheckBoxPage
    {
        private readonly IWebDriver _driver;

        public CheckBoxPage() => _driver = DriverContext.Driver;
    }
}
