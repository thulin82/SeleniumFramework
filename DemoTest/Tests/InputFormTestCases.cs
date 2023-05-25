using NUnit.Framework;
using SeleniumFramework.Base;
using DemoTest.Pages;

namespace DemoTest.Tests
{
    class InputFormTestCases : TestInitializeHook
    {
        private InputFormPage inputFormPage;

        [OneTimeSetUp]
        public void Initialize()
        {
            HomePage menu = new HomePage();
            HomePage.ClosePopup();
            menu.MenuInputForms.Click();
            inputFormPage = menu.ClickInputForm();
        }

        [Test]
        public void FillInFormPartial()
        {
            inputFormPage.EnterFirstName("Oliver");
            inputFormPage.Submit();
            var collection = inputFormPage.EmptyError;
            Assert.That(collection, Has.Count.EqualTo(8));
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            DriverContext.Driver.Quit();
        }
    }
}
