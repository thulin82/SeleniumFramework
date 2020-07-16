using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace SeleniumFramework.Tests
{
    [Parallelizable]
    class RadioButtonsTestCases
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Initialize()
        {
            driver = Actions.InitializeDriver(5);
            NavigateTo.RadioButtonsDemo(driver);
            Actions.ClosePopup(driver);
        }

        [Test]
        public void DefaultTest()
        {
            Assert.That(driver.Title == Config.Title.RadioButtonTitle);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
