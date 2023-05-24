using OpenQA.Selenium;
using SeleniumFramework.Base;
using SeleniumFramework.Extensions;

namespace SeleniumFramework.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage() => _driver = DriverContext.Driver;

        public SimpleFormPage ClickSimpleForm()
        {
            _driver.WaitToBeClickable(LnkSimpleForm);
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

        public TableDataDownloadPage ClickTableDataDownload()
        {
            LnkTableDataDownload.Click();
            return new TableDataDownloadPage();
        }

        public DropDownPage ClickDropDown()
        {
            LnkDropDown.Click();
            return new DropDownPage();
        }

        public InputFormPage ClickInputForm()
        {
            LnkInputFormsSubmit.Click();
            return new InputFormPage();
        }

        public static void ClosePopup()
        {
            bool exists = DriverContext.Driver.FindElements(By.Id("at-cv-lightbox")).Count != 0;
            if (exists)
            {
                DriverContext.Driver.FindElement(By.Id("at-cv-lightbox-close")).Click();
            }
        }

        #region WebElements
        public IWebElement MenuInputForms => _driver.FindElement(By.XPath("//a[@class='dropdown-toggle'][contains(text(),'Input Forms')]"));
        public IWebElement LnkSimpleForm => _driver.FindElement(By.XPath("//ul[@class='dropdown-menu']//a[contains(text(),'Simple Form Demo')]"));
        public IWebElement LnkCheckBox => _driver.FindElement(By.XPath("//ul[@class='dropdown-menu']//a[contains(text(),'Checkbox Demo')]"));
        public IWebElement LnkRadioButton => _driver.FindElement(By.XPath("//ul[@class='dropdown-menu']//a[contains(text(),'Radio Buttons Demo')]"));
        public IWebElement LnkDropDown => _driver.FindElement(By.XPath("//ul[@class='dropdown-menu']//a[contains(text(),'Select Dropdown List')]"));
        public IWebElement MenuDatePickers => _driver.FindElement(By.XPath("//a[@class='dropdown-toggle'][contains(text(),'Date pickers')]"));
        public IWebElement MenuTable => _driver.FindElement(By.XPath("//a[@class='dropdown-toggle'][contains(text(),'Table')]"));
        public IWebElement LnkTableDataDownload => _driver.FindElement(By.XPath("//ul[@class='dropdown-menu']//a[contains(text(),'Table Data Download')]"));
        public IWebElement LnkInputFormsSubmit => _driver.FindElement(By.XPath("//ul[@class='dropdown-menu']//a[contains(text(),'Input Form Submit')]"));
        #endregion
    }
}


