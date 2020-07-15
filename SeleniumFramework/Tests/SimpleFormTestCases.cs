using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

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
        }

        [Test]
        public void DefaultTest()
        {
            Assert.That(driver.Title == Config.Title.SimpleFormTitle);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
