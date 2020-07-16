using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFramework.Base;

namespace SeleniumFramework.Tests
{
    public class SimpleFormTestCases
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver(5);
            NavigateTo.SimpleFormDemo();
            Actions.ClosePopup();
        }

        [Test]
        public void SingleInput()
        {
            Assert.That(DriverContext.Driver.Title == Config.Title.SimpleFormTitle);
            var textDisplayed = Actions.UseSingleInputField(Config.Credentials.Valid.Username);
            Assert.That(textDisplayed == Config.Credentials.Valid.Username);
        }

        [Test]
        public void TwoInputValid()
        {
            Assert.That(DriverContext.Driver.Title == Config.Title.SimpleFormTitle);
            var sumDisplayed = Actions.UseTwoInputFields("1", "2");
            Assert.That(sumDisplayed == "3");
        }

        [Test]
        public void TwoInputInValid()
        {
            Assert.That(DriverContext.Driver.Title == Config.Title.SimpleFormTitle);
            var sumDisplayed = Actions.UseTwoInputFields("1", "a");
            Assert.That(sumDisplayed == "NaN");
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            DriverContext.Driver.Quit();
        }
    }
}
