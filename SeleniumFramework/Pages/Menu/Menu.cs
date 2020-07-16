using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumFramework.Base;

namespace SeleniumFramework.Pages
{
    public class Menu : BasePage
    {
        [FindsBy(How = How.Id, Using = "basic_example")]
        public IWebElement BasicExamples { get; set; }

        [FindsBy(How = How.Id, Using = "inter_example")]
        public IWebElement IntermediateExamples { get; set; }

        [FindsBy(How = How.Id, Using = "advanced_example")]
        public IWebElement AdvancedExample { get; set; }
    }
}
