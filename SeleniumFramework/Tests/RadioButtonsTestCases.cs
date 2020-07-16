using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFramework.Base;
using System.Threading;

namespace SeleniumFramework.Tests
{
    class RadioButtonsTestCases
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver(5);
            NavigateTo.RadioButtonsDemo();
            Actions.ClosePopup();
        }

        [Test]
        public void DefaultTest()
        {
            Assert.That(DriverContext.Driver.Title == Config.Title.RadioButtonTitle);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            DriverContext.Driver.Quit();
        }
    }
}
