﻿using OpenQA.Selenium;

namespace SeleniumFramework.Base
{
    public static class DriverContext
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }
    }
}
