using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumFramework.Pages
{
    public class BasicItemPage
    {
        public BasicItemPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='list-group-item'][contains(text(),'Simple Form Demo')]")]
        public IWebElement SimpleFormDemo { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='list-group-item'][contains(text(),'Check Box Demo')]")]
        public IWebElement CheckBoxDemo { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='list-group-item'][contains(text(),'Radio Buttons Demo')]")]
        public IWebElement RadioButtonsDemo { get; set; }
    }
}
