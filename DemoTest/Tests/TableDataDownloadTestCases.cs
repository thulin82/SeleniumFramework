﻿using DemoTest.Pages;
using NUnit.Framework;
using SeleniumFramework.Base;
using SeleniumFramework.Helpers;

namespace DemoTest.Tests
{
    class TableDataDownloadTestCases : TestInitializeHook
    {
        private TableDataDownloadPage tableDataDownloadPage;

        [OneTimeSetUp]
        public void Initialize()
        {
            HomePage menu = new HomePage();
            HomePage.ClosePopup();
            menu.MenuTable.Click();
            tableDataDownloadPage = menu.ClickTableDataDownload();
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