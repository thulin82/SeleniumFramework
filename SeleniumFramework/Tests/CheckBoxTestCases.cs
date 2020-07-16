using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace SeleniumFramework.Tests
{
    [Parallelizable]
    class CheckBoxTestCases
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Initialize()
        {
            driver = Actions.InitializeDriver(5);
            NavigateTo.CheckBoxDemo(driver);
            Actions.ClosePopup(driver);
        }

        [Test]
        public void DefaultTest()
        {
            Assert.That(driver.Title == Config.Title.CheckBoxTitle);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
