﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
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
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, state);
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
            //sub.SendKeys(Subject+Keys.Down+Keys.Down);
            Actions mouse = new Actions(driver);
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
            //List<IWebElement> tableData = table.FindElements(By.XPath("//table/tbody/tr")).ToList();
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


    }
}
