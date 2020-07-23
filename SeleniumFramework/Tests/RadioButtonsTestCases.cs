using NUnit.Framework;
using SeleniumFramework.Base;
using SeleniumFramework.Config;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Tests
{
    class RadioButtonsTestCases : TestInitializeHook
    {
        private RadioButtonsPage radioButtonPage;

        [OneTimeSetUp]
        public void Initialize()
        {
            HomePage menu = new HomePage();
            menu.ClosePopup();
            menu.MenuInputForms.Click();
            radioButtonPage = menu.ClickRadioButtons();
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
