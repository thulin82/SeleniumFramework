using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumFramework.Tests
{
    [Parallelizable]
    public class SimpleFormTestCases
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Initialize()
        {
            driver = Actions.InitializeDriver(5);
            NavigateTo.SimpleFormDemo(driver);
            Actions.ClosePopup(driver);
        }

        [Test]
        public void SingleInput()
        {
            Assert.That(driver.Title == Config.Title.SimpleFormTitle);
            var textDisplayed = Actions.UseSingleInputField(Config.Credentials.Valid.Username, driver);
            Assert.That(textDisplayed == Config.Credentials.Valid.Username);
        }

        [Test]
        public void TwoInputValid()
        {
            Assert.That(driver.Title == Config.Title.SimpleFormTitle);
            var sumDisplayed = Actions.UseTwoInputFields("1", "2", driver);
            Assert.That(sumDisplayed == "3");
        }

        [Test]
        public void TwoInputInValid()
        {
            Assert.That(driver.Title == Config.Title.SimpleFormTitle);
            var sumDisplayed = Actions.UseTwoInputFields("1", "a", driver);
            Assert.That(sumDisplayed == "NaN");
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
