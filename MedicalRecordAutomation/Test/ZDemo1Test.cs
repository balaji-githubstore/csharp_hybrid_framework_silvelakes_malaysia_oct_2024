using ClosedXML.Excel;
using Silverlakes.MedicalRecordAutomation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRecordAutomation.Test
{
    public class ZDemo1Test
    {

        [Test]
        public void ReadExcelTest()
        {
            XLWorkbook book = new XLWorkbook(@"C:\Mine\Company\Silverlakes Oct 2024\CSharp\AutomationFramework\MedicalRecordAutomation\TestData\openemr_data.xlsx");
            var sheet = book.Worksheet("InvalidLoginTest");
            var range = sheet.RangeUsed();

            int rowCount = range.RowCount();
            int cellCount = range.ColumnCount();

            object[] main= new object[rowCount-1];

            for (int r = 2; r <= rowCount; r++)
            {
                string[] testData=new string[cellCount];
                for (int c = 1; c <= cellCount; c++)
                {
                    testData[c-1]= range.Cell(r, c).GetString();
                    
                }
                main[r-2] = testData;
            }
            book.Dispose();
        }

    }
}
