using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silverlakes.MedicalRecordAutomation.Base
{
    /// <summary>
    /// WebDriverKeyword will be used by Page Object Model Classes
    /// </summary>
    public class WebDriverKeywords
    {

        private IWebDriver driver;

        public WebDriverKeywords(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnElement(By locator)
        {
            driver.FindElement(locator).Click();
        }

        public void TypeOnElement(By locator, string text)
        {
            driver.FindElement(locator).SendKeys(text);
        }

        public string GetTextFromElement(By locator)
        {
            return driver.FindElement(locator).Text;
        }

        public string GetAttributeValueFromElement(By locator, string attributeName)
        {
            return driver.FindElement(locator).GetAttribute(attributeName);
        }

        public void SwitchTabByTitle(string title)
        {
            foreach (string window in driver.WindowHandles)
            {
                driver.SwitchTo().Window(window);
                if (driver.Title.Equals(title))
                {
                    break;
                }
            }
        }
    }
}
