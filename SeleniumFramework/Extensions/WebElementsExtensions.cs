using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFramework.Extensions
{
    public static class WebElementsExtensions
    {
        public static void SelectDropDownList(this IWebElement element, string value)
        {
            SelectElement list = new SelectElement(element);
            list.SelectByText(value);
        }
    }
}
