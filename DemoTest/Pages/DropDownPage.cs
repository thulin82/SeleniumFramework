using OpenQA.Selenium;
using SeleniumFramework.Base;

namespace DemoTest.Pages
{
    public class DropDownPage
    {

        private readonly IWebDriver _driver;

        public DropDownPage() => _driver = DriverContext.Driver;

        #region WebElements
        public IWebElement DropDown => _driver.FindElement(By.Id("select-demo"));
        public IWebElement DayDisplay => _driver.FindElement(By.XPath("//p[@class='selected-value']"));
        #endregion
    }
}