using NUnit.Framework;
using SeleniumFramework.Base;

namespace SeleniumFramework.Tests
{
    class CheckBoxTestCases
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver(5);
            NavigateTo.CheckBoxDemo();
            Actions.ClosePopup();
        }

        [Test]
        public void DefaultTest()
        {
            Assert.That(DriverContext.Driver.Title == Config.Title.CheckBoxTitle);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            DriverContext.Driver.Quit();
        }
    }
}
