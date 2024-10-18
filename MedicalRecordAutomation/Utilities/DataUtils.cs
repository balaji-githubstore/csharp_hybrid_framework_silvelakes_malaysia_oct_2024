using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silverlakes.MedicalRecordAutomation.Utilities
{
    /// <summary>
    /// This class contains all Test data for [TestCaseSource]
    /// </summary>
    public class DataUtils
    {

        public static object[] LoadValidLoginExcelData { get; set; } = CommonDataSource("ValidLoginTest");
        public static object[] LoadInValidLoginExcelData { get; set; } = CommonDataSource("InvalidLoginTest");
        public static object[] ValidLoginData()
        {
            //Create object[] for each set of test data
            //number of parameters
            string[] testData1 = new string[3];
            testData1[0] = "accountant";
            testData1[1] = "accountant";
            testData1[2] = "OpenEMR";

            //number of parameters
            string[] testData2 = new string[3];
            testData2[0] = "physician";
            testData2[1] = "physician";
            testData2[2] = "OpenEMR";

            //Number of testcase
            object[] main = new object[2];
            main[0] = testData1;
            main[1] = testData2;

            return main;
        }

        public static object[] InvalidLoginDataExcel()
        {
            //string fileDetail = @"C:\Mine\Company\Silverlakes Oct 2024\CSharp\AutomationFramework\MedicalRecordAutomation\TestData\openemr_data.xlsx";

            string fileDetail = TestContext.CurrentContext.TestDirectory.Split("bin")[0] + "/TestData/openemr_data.xlsx";
            object[] data = ExcelUtils.GetSheetIntoObjectArray(fileDetail, "InvalidLoginTest");
            return data;
        }

        //public static object[] ValidLoginDataExcel()
        //{
        //    //string fileDetail = @"C:\Mine\Company\Silverlakes Oct 2024\CSharp\AutomationFramework\MedicalRecordAutomation\TestData\openemr_data.xlsx";

        //    string fileDetail = TestContext.CurrentContext.TestDirectory.Split("bin")[0] + "/TestData/openemr_data.xlsx";
        //    object[] data = ExcelUtils.GetSheetIntoObjectArray(fileDetail, "ValidLoginTest");
        //    return data;
        //}

        public static object[] CommonDataSource(string sheetName)
        {
            string fileDetail = TestContext.CurrentContext.TestDirectory.Split("bin")[0] + "/TestData/openemr_data.xlsx";
            object[] data = ExcelUtils.GetSheetIntoObjectArray(fileDetail, sheetName);
            return data;
        }

    }
}
