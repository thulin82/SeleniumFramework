using NUnit.Framework;
using SeleniumFramework.Base;
using SeleniumFramework.Config;
using DemoTest.Pages;

namespace DemoTest.Tests
{
    public class SimpleFormTestCases : TestInitializeHook
    {
        private SimpleFormPage formPage;

        [OneTimeSetUp]
        public void Initialize()
        {
            HomePage menu = new HomePage();
            HomePage.ClosePopup();
            menu.MenuInputForms.Click();
            formPage = menu.ClickSimpleForm();
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
