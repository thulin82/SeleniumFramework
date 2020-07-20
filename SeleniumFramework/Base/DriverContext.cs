﻿using OpenQA.Selenium;

namespace SeleniumFramework.Base
{
    public static class DriverContext
    {
        public static IWebDriver Driver { get; set; }

        public static Browser Browser { get; set; }
    }
}
