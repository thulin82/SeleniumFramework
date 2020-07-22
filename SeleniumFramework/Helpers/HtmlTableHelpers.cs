using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumFramework.Helpers
{
    public class HtmlTableHelpers
    {
        static List<TableDatacollection> _tableDatacollections = new List<TableDatacollection>();

        public static void ReadTable(IWebElement table)
        {
            //Get all columns
            var columns = table.FindElements(By.TagName("th"));
            //Get all rows
            var rows = table.FindElements(By.TagName("tr"));
            int rowIndex = 0;
            //Loop through all rows
            foreach (var row in rows)
            {
                int colIndex = 0;
                var colDatas = row.FindElements(By.TagName("td"));
                //Loop through all columns
                foreach (var colValue in colDatas)
                {
                    _tableDatacollections.Add(new TableDatacollection
                    {
                        RowNumber = rowIndex,
                        ColumnName = columns[colIndex].Text != "" ?
                                     columns[colIndex].Text : colIndex.ToString(),
                        ColumnValue = colValue.Text,
                    });
                    colIndex++;
                }
                rowIndex++;
            }
        }

        public static string ReadCell(string columnName, int rowNumber)
        {
            return _tableDatacollections.Where(x => x.ColumnName == columnName && x.RowNumber == rowNumber).SingleOrDefault().ColumnValue;
        }
    }

    public class TableDatacollection
    {
        public int RowNumber { get; set; }
        public string ColumnName { get; set; }
        public string ColumnValue { get; set; }
    }
}
