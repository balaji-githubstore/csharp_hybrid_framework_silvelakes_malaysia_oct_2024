using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silverlakes.MedicalRecordAutomation.Base
{
    public class AutomationWrapper
    {
        protected IWebDriver driver;

        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://demo.openemr.io/b/openemr");
        }

        [TearDown]
        public void teardown()
        {
            driver.Dispose();
        }
    }
}
