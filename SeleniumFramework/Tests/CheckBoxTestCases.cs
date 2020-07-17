using NUnit.Framework;
using SeleniumFramework.Base;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Tests
{
    class CheckBoxTestCases
    {
        private CheckBoxPage checkBoxPage;

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver(5);
            HomePage menu = new HomePage();
            menu.MenuInputForms.Click();
            checkBoxPage = menu.ClickCheckBox();
            Actions.ClosePopup();
        }

        [Test]
        public void DefaultTest()
        {
            Assert.That(DriverContext.Driver.Title == Config.Title.CheckBoxTitle);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            DriverContext.Driver.Quit();
        }
    }
}
