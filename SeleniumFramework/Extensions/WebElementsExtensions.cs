using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumFramework.Extensions
{
    public static class WebElementsExtensions
    {
        public static void SelectDropDownList(this IWebElement element, string value)
        {
            SelectElement list = new SelectElement(element);
            list.SelectByIndex(0);
            list.SelectByText(value);
        }

        public static string GetSelectedDropDown(this IWebElement element)
        {
            SelectElement list = new SelectElement(element);
            return list.AllSelectedOptions.First().ToString();
        }

        public static IList<IWebElement> GetSelectedListOptions(this IWebElement element)
        {
            SelectElement list = new SelectElement(element);
            return list.AllSelectedOptions;
        }
    }
}
