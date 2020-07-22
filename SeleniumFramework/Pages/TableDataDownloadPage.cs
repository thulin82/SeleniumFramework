using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumFramework.Base;

namespace SeleniumFramework.Pages
{
    public class TableDataDownloadPage : BasePage
    {
        public IWebElement GetTable()
        {
            return Table;
        }
        #region WebElements
        [FindsBy(How = How.Id, Using = "example")]
        private IWebElement Table { get; set; }
        #endregion
    }
}