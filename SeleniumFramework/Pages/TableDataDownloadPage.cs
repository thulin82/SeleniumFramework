using OpenQA.Selenium;
using SeleniumFramework.Base;

namespace SeleniumFramework.Pages
{
    public class TableDataDownloadPage
    {
        private readonly IWebDriver _driver;

        public TableDataDownloadPage() => _driver = DriverContext.Driver;

        public IWebElement GetTable()
        {
            return Table;
        }

        #region WebElements
        private IWebElement Table => _driver.FindElement(By.Id("example"));
        #endregion
    }
}