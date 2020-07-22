using NUnit.Framework;
using SeleniumFramework.Base;
using SeleniumFramework.Config;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Tests
{
    class CheckBoxTestCases
    {
        private CheckBoxPage checkBoxPage;

        [OneTimeSetUp]
        public void Initialize()
        {
            ConfigReader.SetFrameworkSettings();
            Actions.InitializeDriver(5, Settings.BrowserType);
            HomePage menu = new HomePage();
            menu.MenuInputForms.Click();
            checkBoxPage = menu.ClickCheckBox();
            Actions.ClosePopup();
        }

        [Test]
        public void DefaultTest()
        {
            Assert.That(DriverContext.Driver.Title == Settings.CheckBoxTitle);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            DriverContext.Driver.Quit();
        }
    }
}
