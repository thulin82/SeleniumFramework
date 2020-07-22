using NUnit.Framework;
using SeleniumFramework.Base;
using SeleniumFramework.Config;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Tests
{
    class RadioButtonsTestCases
    {
        private RadioButtonsPage radioButtonPage;

        [OneTimeSetUp]
        public void Initialize()
        {
            ConfigReader.SetFrameworkSettings();
            Actions.InitializeDriver(5, Settings.BrowserType);
            HomePage menu = new HomePage();
            menu.MenuInputForms.Click();
            radioButtonPage = menu.ClickRadioButtons();
            Actions.ClosePopup();
        }

        [Test]
        public void DefaultTest()
        {
            Assert.That(DriverContext.Driver.Title == Settings.RadioButtonTitle);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            DriverContext.Driver.Quit();
        }
    }
}
