using OpenQA.Selenium;
using Silverlakes.MedicalRecordAutomation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silverlakes.MedicalRecordAutomation.Pages
{
    public class MainPage : WebDriverKeywords
    {
        private IWebDriver driver;

        public MainPage(IWebDriver driver):base(driver) 
        {
            this.driver = driver;
        }

        public string getMainPageTitle()
        {
            return driver.Title;
        }
    }
}
