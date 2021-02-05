Feature: UI_Automation

Background: Doing startup options
	Given Open chrome Browser
	Then Navigate to DemoQA URL

#@mytag
#Scenario Outline: Open DemoQA Site and fill the Form
	
#	Given I click on Elements tab
#	When I Click on Text box tab
#	Then I enter <FullName> and <Email> and <Current_Address> and <Permanent_Address>
#	Then I Close the browser
#	Then I fill all columns
#	|Selenium|Automation|examplemail@example.com|1234567891|01022021|Bio-Maths|Automation Address Fill|
#	Examples: 
#	| FullName | Email          | Current_Address          | Permanent_Address       |
#	| Kishore  | Test@email.com | Automaition Address Fill | Automation Address Fill |

#@mytag
#Scenario: Open DemoQA Site and fill the Student Form

#	Given I click on Forms Tab
#	Then I Choose the option Practice Form
#	And I am selecting my hobbies
#	And Selecting the State and City from drop down
#	Then Clicking on Submit button
#	Then I Close the browser

@mytag
Scenario Outline: Open DemoQA Site then fill the Student Registration Form

	Given I click on Forms Tab
	Then I Choose the option Practice Form
	Then I fill registration columns <First_Name> and <Last_Name> and <Email> and <Mobile> and <DOB> and <Subject> and <Current_Address>
	Then I select Gender Male
	And I am selecting my hobbies

	Examples:
	| First_Name | Last_Name      | Email          | Mobile     | DOB		  | Subject   | Current_Address             |
	| Automation | Selenium		  | Test@email.com | 1234567891 | 01 05 2000 | Bio-Maths | Auto Fill Automated Address |






