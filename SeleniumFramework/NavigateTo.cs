using SeleniumFramework.Pages;

namespace SeleniumFramework
{
    public static class NavigateTo
    {
        public static void SimpleFormDemo()
        {
            Menu menu = new Menu();
            BasicItemPage biPage = new BasicItemPage();

            menu.BasicExamples.Click();
            biPage.SimpleFormDemo.Click();
        }

        public static void CheckBoxDemo()
        {
            Menu menu = new Menu();
            BasicItemPage biPage = new BasicItemPage();

            menu.BasicExamples.Click();
            biPage.CheckBoxDemo.Click();
        }

        public static void RadioButtonsDemo()
        {
            Menu menu = new Menu();
            BasicItemPage biPage = new BasicItemPage();

            menu.BasicExamples.Click();
            biPage.RadioButtonsDemo.Click();
        }
    }
}
