using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Script;
using Silverlakes.MedicalRecordAutomation.Base;
using Silverlakes.MedicalRecordAutomation.Pages;
using Silverlakes.MedicalRecordAutomation.Utilities;
using SilverlakesMedicalRecordAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silverlakes.MedicalRecordAutomation.Test
{
    public class LoginTest : AutomationWrapper
    {
        [Test]
        //[TestCase("accountant", "accountant", "OpenEMR")]
        //[TestCase("receptionist", "receptionist","OpenEMR")]
        //[TestCaseSource(typeof(DataUtils), nameof(DataUtils.ValidLoginData))]
        [TestCaseSource(typeof(DataUtils), nameof(DataUtils.LoadValidLoginExcelData))]
        public void ValidLoginTest(string username, string password, string expectedTitle)
        {
            LoginPage login = new LoginPage(driver);
            login.EnterUsername(username);
            login.EnterPassword(password);
            login.ClickOnLogin();

            MainPage main = new MainPage(driver);
            string actualTitle = main.getMainPageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        [TestCaseSource(typeof(DataUtils), nameof(DataUtils.InvalidLoginDataExcel))]
        public void InvalidLoginTest(string username,string password,string expectedError)
        {
            LoginPage login = new LoginPage(driver);
            login.EnterUsername(username);
            login.EnterPassword(password);
            login.ClickOnLogin();

            //Assert the error - Invalid username or password
            string actualError = login.getInvalidErrorMessage();
            Assert.That(actualError.Contains(expectedError)); //expect true
        }
    }
}
