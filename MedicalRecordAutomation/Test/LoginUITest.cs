using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Silverlakes.MedicalRecordAutomation.Base;

namespace Silverlakes.MedicalRecordAutomation.Test
{
    public class LoginUITest : AutomationWrapper
    {
        [Test]
        public void TitleTest()
        {
            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo("OpenEMR Login"));
        }

        [Test]
        public void AppDescriptionTest()
        {
            //Assert the description - The most popular open-source Electronic Health Record and Medical Practice Management solution.
            string actualDesc = driver.FindElement(By.XPath("//p[contains(text(),'most')]")).Text;
            Assert.That(actualDesc, Is.EqualTo("The most popular open-source Electronic Health Record and Medical Practice Management solution."));
        }
    }
}
