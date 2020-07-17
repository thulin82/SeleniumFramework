using NUnit.Framework;
using SeleniumFramework.Base;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Tests
{
    class RadioButtonsTestCases
    {
        private RadioButtonsPage radioButtonPage;

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver(5);
            HomePage menu = new HomePage();
            menu.MenuInputForms.Click();
            radioButtonPage = menu.ClickRadioButtons();
            Actions.ClosePopup();
        }

        [Test]
        public void DefaultTest()
        {
            Assert.That(DriverContext.Driver.Title == Config.Title.RadioButtonTitle);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            DriverContext.Driver.Quit();
        }
    }
}
