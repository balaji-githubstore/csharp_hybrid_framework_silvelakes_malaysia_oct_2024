using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silverlakes.MedicalRecordAutomation.Utilities
{
    public class ExcelUtils
    {
        public static object[] GetSheetIntoObjectArray(string fileDetail, string sheetName)
        {
            XLWorkbook book = new XLWorkbook(fileDetail);
            var sheet = book.Worksheet(sheetName);
            var range = sheet.RangeUsed();

            int rowCount = range.RowCount();
            int cellCount = range.ColumnCount();

            object[] main = new object[rowCount - 1];

            for (int r = 2; r <= rowCount; r++)
            {
                string[] testData = new string[cellCount];
                for (int c = 1; c <= cellCount; c++)
                {
                    testData[c - 1] = range.Cell(r, c).GetString();

                }
                main[r - 2] = testData;
            }
            book.Dispose();

            return main;
        }
    }
}
