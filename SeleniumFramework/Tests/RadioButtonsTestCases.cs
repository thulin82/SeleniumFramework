using NUnit.Framework;
using SeleniumFramework.Base;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Tests
{
    class RadioButtonsTestCases : TestInitializeHook
    {
        private RadioButtonsPage radioButtonPage;

        [OneTimeSetUp]
        public void Initialize()
        {
            HomePage menu = new HomePage();
            menu.ClosePopup();
            menu.MenuInputForms.Click();
            radioButtonPage = menu.ClickRadioButtons();
        }

        [Test]
        public void SingeMale()
        {
            radioButtonPage.SingleMaleRadio.Click();
            radioButtonPage.GetSingleCheckedButton.Click();
            Assert.That(radioButtonPage.SingleDisplay.Text == "Radio button 'Male' is checked");
        }

        [Test]
        public void SingeFemale()
        {
            radioButtonPage.SingleFemaleRadio.Click();
            radioButtonPage.GetSingleCheckedButton.Click();
            Assert.That(radioButtonPage.SingleDisplay.Text == "Radio button 'Female' is checked");
        }

        [Test]
        public void MultiMaleFiveToFifteen()
        {
            radioButtonPage.MultiMaleRadio.Click();
            radioButtonPage.MultiFiveToFifteen.Click();
            radioButtonPage.MultiGetValuesButton.Click();
            Assert.That(radioButtonPage.MultiDisplay.Text == "Sex : Male\r\nAge group: 5 - 15");
        }

        [Test]
        public void MultiFemaleZeroToFive()
        {
            radioButtonPage.MultiFemaleRadio.Click();
            radioButtonPage.MultiZeroToFive.Click();
            radioButtonPage.MultiGetValuesButton.Click();
            Assert.That(radioButtonPage.MultiDisplay.Text == "Sex : Female\r\nAge group: 0 - 5");
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            DriverContext.Driver.Quit();
        }
    }
}
