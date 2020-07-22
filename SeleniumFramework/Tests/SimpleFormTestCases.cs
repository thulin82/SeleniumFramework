using NUnit.Framework;
using SeleniumFramework.Base;
using SeleniumFramework.Config;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Tests
{
    public class SimpleFormTestCases
    {
        private SimpleFormPage formPage;

        [OneTimeSetUp]
        public void Initialize()
        {
            ConfigReader.SetFrameworkSettings();
            Actions.InitializeDriver(5, Settings.BrowserType);
            HomePage menu = new HomePage();
            menu.MenuInputForms.Click();
            formPage = menu.ClickSimpleForm();
            Actions.ClosePopup();
        }

        [Test]
        public void SingleInput()
        {
            var textDisplayed = formPage.UseSingleInputField(Settings.UserName);
            Assert.That(textDisplayed == Settings.UserName);
        }

        [Test]
        public void TwoInputValid()
        {
            var sumDisplayed = formPage.UseTwoInputFields("1", "2");
            Assert.That(sumDisplayed == "3");
        }

        [Test]
        public void TwoInputInValid()
        {
            var sumDisplayed = formPage.UseTwoInputFields("1", "a");
            Assert.That(sumDisplayed == "NaN");
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            DriverContext.Driver.Quit();
        }
    }
}
