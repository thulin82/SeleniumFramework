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
            menu.ClosePopup();
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
        public void SelectSaturday()
        {
            dropDownPage.DropDown.SelectDropDownList("Saturday");
            Assert.That(dropDownPage.DayDisplay.Text == "Day selected :- Saturday", $"{ dropDownPage.DayDisplay.Text} is not equal to 'Day selected :- Saturday'");
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            DriverContext.Driver.Quit();
        }
    }
}
