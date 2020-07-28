using NUnit.Framework;
using SeleniumFramework.Base;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Tests
{
    class CheckBoxTestCases : TestInitializeHook
    {
        private CheckBoxPage checkBoxPage;

        [OneTimeSetUp]
        public void Initialize()
        {
            HomePage menu = new HomePage();
            menu.ClosePopup();
            menu.MenuInputForms.Click();
            checkBoxPage = menu.ClickCheckBox();
        }

        [Test]
        public void SingleCheckBox()
        {
            checkBoxPage.ClickSingle();
            Assert.That(checkBoxPage.SingleDisplay.Text == "Success - Check box is checked");
        }

        [Test]
        public void MultipleCheckBox()
        {
            checkBoxPage.ClickButton(true);
            foreach (var item in checkBoxPage.MultiCheckBoxes)
            {
                Assert.That(item.Selected == true);
            }
            checkBoxPage.ClickButton(false);
            foreach (var item in checkBoxPage.MultiCheckBoxes)
            {
                Assert.That(item.Selected == false);
            }
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            DriverContext.Driver.Quit();
        }
    }
}
