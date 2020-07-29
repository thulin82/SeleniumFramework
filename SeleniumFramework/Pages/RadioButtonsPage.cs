using OpenQA.Selenium;
using SeleniumFramework.Base;

namespace SeleniumFramework.Pages
{
    public class RadioButtonsPage
    {
        private readonly IWebDriver _driver;

        public RadioButtonsPage() => _driver = DriverContext.Driver;

        #region WebElements
        public IWebElement SingleMaleRadio => _driver.FindElement(By.XPath("//body/div[@id='easycont']/div[@class='row']/div[@class='col-md-6 text-left']/div[@class='panel panel-default']/div[@class='panel-body']/label[1]"));
        public IWebElement SingleFemaleRadio => _driver.FindElement(By.XPath("//body/div[@id='easycont']/div[@class='row']/div[@class='col-md-6 text-left']/div[@class='panel panel-default']/div[@class='panel-body']/label[2]"));
        public IWebElement GetSingleCheckedButton => _driver.FindElement(By.Id("buttoncheck"));
        public IWebElement SingleDisplay => _driver.FindElement(By.ClassName("radiobutton"));
        public IWebElement MultiFemaleRadio => _driver.FindElement(By.XPath("//div[@class='panel-body']//div//label[@class='radio-inline'][contains(text(),'Female')]"));
        public IWebElement MultiMaleRadio => _driver.FindElement(By.XPath("//div[@class='panel-body']//div//label[@class='radio-inline'][contains(text(),'Male')]"));
        public IWebElement MultiZeroToFive => _driver.FindElement(By.XPath("//label[contains(text(),'0 to 5')]"));
        public IWebElement MultiFiveToFifteen => _driver.FindElement(By.XPath("//label[contains(text(),'5 to 15')]"));
        public IWebElement MultiFifteenToFifty => _driver.FindElement(By.XPath("//label[contains(text(),'15 to 50')]"));
        public IWebElement MultiGetValuesButton => _driver.FindElement(By.XPath("//button[contains(text(),'Get values')]"));
        public IWebElement MultiDisplay => _driver.FindElement(By.ClassName("groupradiobutton"));
        #endregion
    }
}
