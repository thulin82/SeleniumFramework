using OpenQA.Selenium;
using SeleniumFramework.Pages;

namespace SeleniumFramework
{
    public static class NavigateTo
    {
        public static void SimpleFormDemo(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            BasicItemPage biPage = new BasicItemPage(driver);

            menu.BasicExamples.Click();
            biPage.SimpleFormDemo.Click();
        }

        public static void CheckBoxDemo(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            BasicItemPage biPage = new BasicItemPage(driver);

            menu.BasicExamples.Click();
            biPage.CheckBoxDemo.Click();
        }

        public static void RadioButtonsDemo(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            BasicItemPage biPage = new BasicItemPage(driver);

            menu.BasicExamples.Click();
            biPage.RadioButtonsDemo.Click();
        }
    }
}
