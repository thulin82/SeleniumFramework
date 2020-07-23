using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumFramework.Base;

namespace SeleniumFramework.Pages
{
    public class DropDownPage : BasePage
    {
        #region WebElements
        [FindsBy(How = How.Id, Using = "select-demo")]
        public IWebElement DropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='selected-value']")]
        public IWebElement DayDisplay { get; set; }
        #endregion
    }
}