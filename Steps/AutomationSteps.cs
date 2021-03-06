﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace SeleniumAutomation.Steps
{
    [Binding]
    public sealed class AutomationSteps : BaseClass
    {        
        [Given(@"Open chrome Browser")]
        public void GivenOpenChromeBrowser()
        {
            driver = new ChromeDriver(@"E:\Selenium\Chrome Driver 87");
            driver.Manage().Window.Maximize();
            BasicUIFunctions();
            Thread.Sleep(2000);
        }

        [Then(@"Navigate to DemoQA URL")]
        public void ThenNavigateToDemoQAURL()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            Thread.Sleep(2000);
        }

        [Then(@"I Close the browser")]
        public void ThenICloseTheBrowser()
        {
            driver.Close();
        }

        [Given(@"I click on Elements tab")]
        public void GivenIClickOnElementsTab()
        {
            Click("ClassName", "card-up");
            Thread.Sleep(2000);
        }
        [Given(@"I click on Forms Tab")]
        public void GivenIClickOnFormsTab()
        {
            Click("xpath", "//div[@class='card-body']//child::h5[text()='Forms']//parent::div//parent::div");
            Thread.Sleep(2000);
        }
        [Given(@"I Click on Alert and Frames button")]
        public void GivenIClickOnAlertAndFramesButton()
        {
            Click("xpath", "//h5[contains(text(),'Alerts')]//parent::div//parent::div");
            Thread.Sleep(2000);
        }
        [When(@"I click on Alerts tab")]
        [Obsolete]
        public void WhenIClickOnAlertsTab()
        {
            // wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='element-list collapse show']//li[2]")));
            //mouse.MoveToElement(driver.FindElement(By.Id("item-1")));
            var alerts = driver.FindElement(By.XPath("//span[contains(text(),'Alerts')]"));
            js.ExecuteScript(scrollDown, alerts);
            Thread.Sleep(4000);
            Click("xpath", "//span[contains(text(),'Alerts')]");
            Thread.Sleep(2000);
        }

        [When(@"I Click on Text box tab")]
        public void WhenIClickOnTextBoxTab()
        {
            Click("Id", "item-0");
            Thread.Sleep(2000);
        }

        [Then(@"I enter (.*) and (.*) and (.*) and (.*)")]
        public void ThenIEnterAndAndAnd(string UserName, string Email, string CurrentAddress, string PermanentAddress)
        {
            SendKeys("Id", "userName", UserName);
            SendKeys("Id", "userEmail", Email);
            SendKeys("Id", "currentAddress", CurrentAddress);
            SendKeys("Id", "permanentAddress", PermanentAddress);
            Thread.Sleep(2000);
        }

        [Then(@"I Click on Submit")]
        public void ThenIClickOnSubmit()
        {
            Click("Id", "submit");
        }
        [When(@"I Click on Forms")]
        public void WhenIClickOnForms()
        {
            Click("class", "card-up");
            Thread.Sleep(2000);
        }

        [Then(@"I Choose the option Practice Form")]
        public void ThenIChooseTheOptionPracticeForm()
        {
            Click("xpath", "//span[contains(text(),'Practice')]");
            Thread.Sleep(2000);            
        }

        [Then(@"I fill all columns")]
        public void ThenIFillAllColumns(Table table)
        {
           String dataTable=table.ToString();
           Console.WriteLine("The complete string is "+dataTable);            
           Thread.Sleep(2000);
        }

        [Then(@"I am selecting my hobbies")]
        public void ThenIAmSelectingMyHobbies()
        {
            Click("xpath", "//label[@for='hobbies-checkbox-1']");
            Click("xpath", "//label[@for='hobbies-checkbox-3']");
            Thread.Sleep(2000);
        }

        [Then(@"Selecting the State and City from drop down")]
        public void ThenSelectingTheStateAndCityFromDropDown()
        {
            var state = driver.FindElement(By.Id("state"));
            var script = "arguments[0].scrollIntoView(true);";
            //syntax for javaScriptExecuter
            IJavaScriptExecutor jss = (IJavaScriptExecutor)driver;
            jss.ExecuteScript(script, state);
            IWebElement State = driver.FindElement(By.Id("state"));
            State.Click();
            SelectElement S = new SelectElement(State);
            S.SelectByText("Haryana");
            /*String size=S.AllSelectedOptions.Count.ToString();
            int.Parse(size);
            Console.WriteLine("The size of the drop down is" + int.Parse(size));*/
            Thread.Sleep(2000);
        }

        [Then(@"Clicking on Submit button")]
        public void ThenClickingOnSubmitButton()
        {
            Click("id", "submit");
            Thread.Sleep(2000);
        }
        [Then(@"I fill registration columns (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*)")]
        public void ThenIFillRegistrationColumnsAndAndAndAndAndAnd(string First_Name, string Last_Name, string Email, string Mobile, string DOB, string Subject, string CurrentAddress)
        {
            SendKeys("id", "firstName", First_Name);
            SendKeys("id", "lastName", Last_Name);
            SendKeys("id", "userEmail", Email);
            SendKeys("id", "userNumber", Mobile);
            SelectAllSendKeysAndEnter("id", "dateOfBirthInput", DOB);
            //ClickAndSendKeysAndEnter("id", "subjectsContainer", Subject);
            IWebElement sub=driver.FindElement(By.Id("subjectsContainer"));
            //sub.SendKeys(Subject+Keys.Down+Keys.Down)
            mouse.MoveToElement(sub).Click();
            mouse.SendKeys(Subject + Keys.Enter).Perform();
            Thread.Sleep(3000);
            /*WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(sub));*/
            SendKeys("id", "currentAddress", CurrentAddress);
        }   
        [Then(@"I select Gender Male")]
        public void ThenISelectGenderMale()
        {
            Click("xpath", "//input[@id='gender-radio-2']/following-sibling::label");
        }
        [Then(@"I Choose an (.*) to upload")]
        public void ThenIChooseAnToUpload(string Filepath)
        {
            IWebElement upload = driver.FindElement(By.ClassName("form-control-file"));
            upload.SendKeys(Filepath.ToString());
        }
        [Then(@"I am selecting (.*) and (.*)")]
        public void ThenIAmSelectingAnd(string State, string City)
        {
            Click("id","state");
            Thread.Sleep(2000);
            Click("xpath", $"//div[text()='{State}']");
            Thread.Sleep(2000);
            Click("id", "city");
            Thread.Sleep(2000);
            Click("xpath", $"//div[text()='{City}']");
            Thread.Sleep(2000);
            Click("id", "submit");
        }
        [Then(@"I am reading the Data provided")]
        public void ThenIAmReadingTheDataProvided()
        {
            IWebElement table=driver.FindElement(By.ClassName("table-responsive"));
            //Console.WriteLine(table.Text);
            //List<IWebElement> tableDatas = table.FindElements(By.XPath("//table/tbody/tr")).ToList();
            List<IWebElement> tableData = driver.FindElements(By.XPath("//div[@class='table-responsive']//tbody/tr")).ToList();
            Console.WriteLine("Total Rows in table is "+ tableData.Count);
            for(int i=1; i<= tableData.Count; i++)
            {
                List<IWebElement> tablevalues = table.FindElements(By.XPath($"//table/tbody/tr[{i}]/td")).ToList();
                for(int j=1; j<=tablevalues.Count; j++)
                {
                    if(j==1)
                    {
                        Console.Write($"The label is {driver.FindElement(By.XPath($"//table/tbody/tr[{i}]/td[{j}]")).Text}");
                        
                    }
                    else
                    {
                        Console.Write($" The value is {driver.FindElement(By.XPath($"//table/tbody/tr[{i}]/td[{j}]")).Text}");
                        
                    }
                    Console.WriteLine();
                }
            }
        }
        [Then(@"I am clicking on the Close button")]
        public void ThenIAmClickingOnTheCloseButton()
        {
            Click("id", "closeLargeModal");
        }
        [Then(@"I click on Click button to see Alert")]
        public void ThenIClickOnClickButtonToSeeAlert()
        {
            Click("id", "alertButton");
            driver.SwitchTo().Alert().Accept();
        }

        [Then(@"I Click on Alert that appears after five seconds")]
        [Obsolete]
        public void ThenIClickOnAlertThatAppearsAfterFiveSeconds()
        {
            Click("id", "timerAlertButton");
            wait.Until(ExpectedConditions.AlertIsPresent());
            driver.SwitchTo().Alert().Accept();
        }

        [Then(@"I Click on Alert with Confirm to select (.*)")]
        public void ThenIClickOnAlertWithConfirmToSelect(string AlertAction)
        {
            Click("id", "confirmButton");
            if (AlertAction.ToLower().Contains("ok"))
            {
                driver.SwitchTo().Alert().Accept();
            }
            if (AlertAction.ToLower().Contains("cancel"))
            {
                driver.SwitchTo().Alert().Dismiss();
            }
        }
        [Then(@"I Click on Alert with Prompt box with (.*)")]
        public void ThenIClickOnAlertWithPromptBoxWith(string AlertText)
        {
            Click("id", "promtButton");
            driver.SwitchTo().Alert().SendKeys(AlertText);
            driver.SwitchTo().Alert().Accept();
        }
        [When(@"I Click on Browser Windows")]
        public void WhenIClickOnBrowserWindows()
        {
            Click("xpath", "//div[@class='element-list collapse show']//li[@id='item-0']");
        }

        [Then(@"I CLick on New tab")]
        [Obsolete]
        public void ThenICLickOnNewTab()
        {
           ParetWindow = driver.CurrentWindowHandle;
            Click("id", "tabButton");
            Console.WriteLine($"Im currently in new tab {driver.Title}");
            //wait.Until(ExpectedConditions.ElementExists(By.Id("tabButton")));
            driver.SwitchTo().Window(ParetWindow);
            string title=driver.Title;
            Console.WriteLine($"Im currently in {title} page");
           /* var Windows=driver.WindowHandles.ToList();
            for(int i=0;i<Windows.Count;i++)
            {
                driver.SwitchTo().Window(Windows[i]);
                //driver.GetScreenshot().SaveAsFile("New tab Screenshot");
                //driver.Close();
            }*/
        }

        [Then(@"I Click on New Window")]
        [Obsolete]
        public void ThenIClickOnNewWindow()
        {
           // driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(10));
            Click("id", "windowButton");
            Console.WriteLine($"Im currently in new window {driver.Title}");
            //wait.Until(ExpectedConditions.ElementExists(By.Id("windowButton")));
            driver.SwitchTo().Window(ParetWindow);
            string title = driver.Title;
            Console.WriteLine($"Im currently in {title} page");
        }

        [Then(@"I Click on New Window message")]
        [Obsolete]
        public void ThenIClickOnNewWindowMessage()
        {
            Click("id", "messageWindowButton");
            Console.WriteLine($"Im currently in new window {driver.Title}");
            string windowMessage=driver.FindElement(By.XPath("//body")).Text;
            Console.WriteLine(windowMessage);
           //wait.Until(ExpectedConditions.ElementExists(By.Id("messageWindowButton")));
            driver.SwitchTo().Window(ParetWindow);
            string title = driver.Title;
            Console.WriteLine($"Im currently in {title} page");
        }
        [Given(@"This is a step for data table")]
        public void GivenThisIsAStepForDataTable(Table table)
        {
            string op = table.ToString();
            string[] opp = op.Split("|");
            HashSet<string> a = new HashSet<string>(opp); 
            Console.WriteLine($"The length of the opp is {opp.Length}");
            Console.WriteLine($"The length of the opp before is {a.Count}");
            foreach (var y in a.ToHashSet())
            {
                if(y == "")
                {
                    a.Remove(""); 
                }
            }
            foreach(var z in a)
            {
                Console.WriteLine(z);
            }
            Console.WriteLine($"The length of the opp after is {a.Count}");
            //List<string> lst = new List<string>(table);
        }
    }
}
