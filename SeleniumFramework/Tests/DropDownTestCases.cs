using NUnit.Framework;
using SeleniumFramework.Base;
using SeleniumFramework.Config;
using SeleniumFramework.Extensions;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Tests
{
    class DropDownTestCases : TestInitializeHook
    {
        private DropDownPage dropDownPage;

        [OneTimeSetUp]
        public void Initialize()
        {
            HomePage menu = new HomePage();
            HomePage.ClosePopup();
            menu.MenuInputForms.Click();
            dropDownPage = menu.ClickDropDown();
        }

        [Test]
        public void SelectThursday()
        {
            dropDownPage.DropDown.SelectDropDownList("Thursday");
            Assert.That(dropDownPage.DayDisplay.Text == "Day selected :- Thursday", $"{dropDownPage.DayDisplay.Text} is not equal to 'Day selected :- Thursday'");
        }

        [Test]
        public void SelectSunday()
        {
            dropDownPage.DropDown.SelectDropDownList("Sunday");
            Assert.That(dropDownPage.DayDisplay.Text == "Day selected :- Sunday", $"{ dropDownPage.DayDisplay.Text} is not equal to 'Day selected :- Sunday'");
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            DriverContext.Driver.Quit();
        }
    }
}
