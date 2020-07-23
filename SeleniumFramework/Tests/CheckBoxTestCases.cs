using NUnit.Framework;
using SeleniumFramework.Base;
using SeleniumFramework.Config;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Tests
{
    class CheckBoxTestCases : TestInitializeHook
    {
        private CheckBoxPage checkBoxPage;

        [OneTimeSetUp]
        public void Initialize()
        {
            HomePage menu = new HomePage();
            menu.ClosePopup();
            menu.MenuInputForms.Click();
            checkBoxPage = menu.ClickCheckBox();
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
