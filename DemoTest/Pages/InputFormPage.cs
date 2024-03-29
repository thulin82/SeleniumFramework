﻿using OpenQA.Selenium;
using SeleniumFramework.Base;
using System.Collections.Generic;

namespace DemoTest.Pages
{
    public class InputFormPage
    {
        private readonly IWebDriver _driver;

        public InputFormPage() => _driver = DriverContext.Driver;

        public void EnterFirstName(string name)
        {
            FirstName.SendKeys(name);
        }

        public void Submit()
        {
            SubmitButton.Click();
        }

        #region WebElements
        private IWebElement FirstName => _driver.FindElement(By.Name("first_name"));
        public IReadOnlyCollection<IWebElement> EmptyError => _driver.FindElements(By.ClassName("has-error"));
        private IWebElement SubmitButton => _driver.FindElement(By.XPath("//button[contains(text(),'Send')]"));
        #endregion
    }
}
