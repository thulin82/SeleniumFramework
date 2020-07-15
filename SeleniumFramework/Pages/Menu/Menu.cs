using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumFramework.Pages
{
    public class Menu
    {
        public Menu(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "basic_example")]
        public IWebElement BasicExamples { get; set; }

        [FindsBy(How = How.Id, Using = "inter_example")]
        public IWebElement IntermediateExamples { get; set; }

        [FindsBy(How = How.Id, Using = "advanced_example")]
        public IWebElement AdvancedExample { get; set; }
    }
}
