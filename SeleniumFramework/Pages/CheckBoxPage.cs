using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumFramework.Base;
using System;
using System.Collections.Generic;

namespace SeleniumFramework.Pages
{
    public class CheckBoxPage
    {
        private readonly IWebDriver _driver;

        public CheckBoxPage() => _driver = DriverContext.Driver;

        public void ClickSingle()
        {
            SingleCheckBox.Click();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            IWebElement element = wait.Until(
                    SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("txtAge")));
        }

        public void ClickButton(bool state)
        {
            SelectAllButton.Click();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            bool element = wait.Until(
                    SeleniumExtras.WaitHelpers.ExpectedConditions.ElementSelectionStateToBe(By.ClassName("cb1-element"), state));
        }

        #region WebElements
        private IWebElement SingleCheckBox => _driver.FindElement(By.Id("isAgeSelected"));
        public IWebElement SingleDisplay => _driver.FindElement(By.Id("txtAge"));
        private IWebElement SelectAllButton => _driver.FindElement(By.Id("check1"));
        public IReadOnlyCollection<IWebElement> MultiCheckBoxes => _driver.FindElements(By.ClassName("cb1-element"));
        #endregion
    }
}
