using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAutomation.Steps
{
    public class BaseClass
    { 
        public ChromeDriver driver;
        public void Click(String locator, String value)
        {
            if (locator.ToLower().Contains("id"))
            {
                driver.FindElement(By.Id(value)).Click();
            }
            if (locator.ToLower().Contains("class"))
            {
                driver.FindElement(By.ClassName(value)).Click();
            }
            if (locator.ToLower().StartsWith("name"))
            {
                driver.FindElement(By.Name(value)).Click();
            }
            if (locator.ToLower().Contains("xpath"))
            {
                driver.FindElement(By.XPath(value)).Click();
            }
        }
        
        public void SendKeys(String locatorType, String value, String text)
        {
            if (locatorType.ToLower().Contains("id"))
            {
                driver.FindElement(By.Id(value)).SendKeys(text);
            }
            if (locatorType.ToLower().Contains("class"))
            {
                driver.FindElement(By.ClassName(value)).SendKeys(text);
            }
            if (locatorType.ToLower().StartsWith("name"))
            {
                driver.FindElement(By.Name(value)).SendKeys(text);
            }
            if (locatorType.ToLower().Contains("xpath"))
            {
                driver.FindElement(By.XPath(value)).SendKeys(text);
            }
        }
        public void ClickAndSendKeys(String locatorType, String value, String text)
        {
            if (locatorType.ToLower().Contains("id"))
            {
                driver.FindElement(By.Id(value)).Click();
                driver.FindElement(By.Id(value)).SendKeys(text);
            }
            if (locatorType.ToLower().Contains("class"))
            {
                driver.FindElement(By.Id(value)).Click();
                driver.FindElement(By.ClassName(value)).SendKeys(text);
            }
            if (locatorType.ToLower().StartsWith("name"))
            {
                driver.FindElement(By.Id(value)).Click();
                driver.FindElement(By.Name(value)).SendKeys(text);
            }
            if (locatorType.ToLower().Contains("xpath"))
            {
                driver.FindElement(By.Id(value)).Click();
                driver.FindElement(By.XPath(value)).SendKeys(text);
            }
        }
        public void SendKeysAndEnter(String locatorType, String value, String text)
        {
            if (locatorType.ToLower().Contains("id"))
            {
                driver.FindElement(By.Id(value)).SendKeys(text+Keys.Enter);
            }
            if (locatorType.ToLower().Contains("class"))
            {
                driver.FindElement(By.ClassName(value)).SendKeys(text + Keys.Enter);
            }
            if (locatorType.ToLower().StartsWith("name"))
            {
                driver.FindElement(By.Name(value)).SendKeys(text + Keys.Enter);
            }
            if (locatorType.ToLower().Contains("xpath"))
            {
                driver.FindElement(By.XPath(value)).SendKeys(text + Keys.Enter);
            }
        }
        public void SelectAllSendKeysAndEnter(String locatorType, String value, String text)
        {
            if (locatorType.ToLower().Contains("id"))
            {
                driver.FindElement(By.Id(value)).SendKeys(Keys.Control + "A");
                driver.FindElement(By.Id(value)).SendKeys(text + Keys.Enter);
            }
            if (locatorType.ToLower().Contains("class"))
            {
                driver.FindElement(By.Id(value)).SendKeys(Keys.Control + "A");
                driver.FindElement(By.ClassName(value)).SendKeys(text + Keys.Enter);
            }
            if (locatorType.ToLower().StartsWith("name"))
            {
                driver.FindElement(By.Id(value)).SendKeys(Keys.Control + "A");
                driver.FindElement(By.Name(value)).SendKeys(text + Keys.Enter);
            }
            if (locatorType.ToLower().Contains("xpath"))
            {
                driver.FindElement(By.Id(value)).SendKeys(Keys.Control + "A");
                driver.FindElement(By.XPath(value)).SendKeys(text + Keys.Enter);
            }
        }
    }
}
