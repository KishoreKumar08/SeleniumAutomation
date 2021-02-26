using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAutomation.Steps
{
    public class BaseClass
    { 
        public static ChromeDriver driver;
        public string ParetWindow;
        public static Actions mouse;
        //For handling pop-ups and alerts in web page
        public static IAlert alert;
        //For Scroll Functions
        public static IJavaScriptExecutor js;
        public string scrollDown= "arguments[0].scrollIntoView(true);";
        public static WebDriverWait wait;//= new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        public void BasicUIFunctions()
        {
            mouse = new Actions(driver);
            //Syntax for WebDriverWait
            //WebDriverWait w = new WebDriverWait(driver,TimeSpan.FromSeconds(20));
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            js = (IJavaScriptExecutor)driver;
            //Syantax to switch to my alert
            //alert = driver.SwitchTo().Alert();
        }
        public void Click(String locator, String value)
        {
            if (locator.ToLower().Contains("id"))
            {
                driver.FindElement(By.Id(value)).Click();
            }
            if (locator.ToLower().Contains("class") || locator.ToLower().Contains("classname"))
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
            if (locatorType.ToLower().Contains("class") || locatorType.ToLower().Contains("classname"))
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
                driver.FindElement(By.ClassName(value)).Click();
                driver.FindElement(By.ClassName(value)).SendKeys(text);
            }
            if (locatorType.ToLower().StartsWith("name"))
            {
                driver.FindElement(By.Name(value)).Click();
                driver.FindElement(By.Name(value)).SendKeys(text);
            }
            if (locatorType.ToLower().Contains("xpath"))
            {
                driver.FindElement(By.XPath(value)).Click();
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
        public void ClickAndSendKeysAndEnter(String locatorType, String value, String text)
        {
            if (locatorType.ToLower().Contains("id"))
            {
                driver.FindElement(By.Id(value)).Click();
                driver.FindElement(By.Id(value)).SendKeys(text + Keys.Enter);
            }
            if (locatorType.ToLower().Contains("class"))
            {
                driver.FindElement(By.ClassName(value)).Click();
                driver.FindElement(By.ClassName(value)).SendKeys(text + Keys.Enter);
            }
            if (locatorType.ToLower().StartsWith("name"))
            {
                driver.FindElement(By.Name(value)).Click();
                driver.FindElement(By.Name(value)).SendKeys(text + Keys.Enter);
            }
            if (locatorType.ToLower().Contains("xpath"))
            {
                driver.FindElement(By.XPath(value)).Click();
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
