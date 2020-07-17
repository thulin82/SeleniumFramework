using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumFramework.Base;

namespace SeleniumFramework.Pages
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[@class='dropdown-toggle'][contains(text(),'Input Forms')]")]
        public IWebElement MenuInputForms { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[contains(text(),'Simple Form Demo')]")]
        public IWebElement LnkSimpleForm { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[contains(text(),'Checkbox Demo')]")]
        public IWebElement LnkCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[contains(text(),'Radio Buttons Demo')]")]
        public IWebElement LnkRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='dropdown-toggle'][contains(text(),'Date pickers')]")]
        public IWebElement MenuDatePickers { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='dropdown-toggle'][contains(text(),'Table')]")]
        public IWebElement MenuTable { get; set; }


        public SimpleFormPage ClickSimpleForm()
        {
            LnkSimpleForm.Click();
            return new SimpleFormPage();
        }

        public CheckBoxPage ClickCheckBox()
        {
            LnkCheckBox.Click();
            return new CheckBoxPage();
        }

        public RadioButtonsPage ClickRadioButtons()
        {
            LnkRadioButton.Click();
            return new RadioButtonsPage();
        }

    }
}


