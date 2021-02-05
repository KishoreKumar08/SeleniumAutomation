using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
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
            ClickAndSendKeys("id", "subjectsContainer", Subject);
            SendKeys("id", "currentAddress", CurrentAddress);
        }   
        [Then(@"I select Gender Male")]
        public void ThenISelectGenderMale()
        {
            Click("id", "gender-radio-1");
        }

    }
}
