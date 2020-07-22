using NUnit.Framework;
using SeleniumFramework.Base;
using SeleniumFramework.Config;
using SeleniumFramework.Helpers;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Tests
{
    class TableDataDownloadTestCases
    {
        private TableDataDownloadPage tableDataDownloadPage;

        [OneTimeSetUp]
        public void Initialize()
        {
            ConfigReader.SetFrameworkSettings();
            Actions.InitializeDriver(5, Settings.BrowserType);
            HomePage menu = new HomePage();
            menu.MenuTable.Click();
            tableDataDownloadPage = menu.ClickTableDataDownload();
            Actions.ClosePopup();
        }

        [Test]
        public void VerifyTableExists()
        {
            Assert.That(tableDataDownloadPage.GetTable().Displayed);
        }

        [Test]
        public void GetTableData()
        {
            var table = tableDataDownloadPage.GetTable();
            HtmlTableHelpers.ReadTable(table);
            Assert.That(HtmlTableHelpers.ReadCell("Salary", 3) == "$86,000");
            Assert.That(HtmlTableHelpers.ReadCell("Age", 3) == "66");
            Assert.That(HtmlTableHelpers.ReadCell("Office", 2) == "Tokyo");
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            DriverContext.Driver.Quit();
        }
    }
}