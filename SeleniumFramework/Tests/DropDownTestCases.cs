using NUnit.Framework;
using SeleniumFramework.Base;
using SeleniumFramework.Config;
using SeleniumFramework.Extensions;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Tests
{
    class DropDownTestCases
    {
        private DropDownPage dropDownPage;

        [OneTimeSetUp]
        public void Initialize()
        {
            ConfigReader.SetFrameworkSettings();
            Actions.InitializeDriver(5, Settings.BrowserType);
            HomePage menu = new HomePage();
            menu.MenuInputForms.Click();
            dropDownPage = menu.ClickDropDown();
            Actions.ClosePopup();
        }

        [Test]
        public void SelectThursday()
        {
            dropDownPage.DropDown.SelectDropDownList("Thursday");
            Assert.That(dropDownPage.DayDisplay.Text == "Day selected :- Thursday");
        }

        [Test]
        public void SelectSaturday()
        {
            dropDownPage.DropDown.SelectDropDownList("Saturday");
            Assert.That(dropDownPage.DayDisplay.Text == "Day selected :- Saturday");
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            DriverContext.Driver.Quit();
        }
    }
}
