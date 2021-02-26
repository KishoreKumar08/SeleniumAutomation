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

#@mytag
#Scenario Outline: Open DemoQA Site then fill the Student Registration Form

	#Given I click on Forms Tab
	#Then I Choose the option Practice Form
	#Then I fill registration columns <First_Name> and <Last_Name> and <Email> and <Mobile> and <DOB> and <Subject> and <Current_Address>
	#Then I select Gender Male
	#Then I Choose an <File> to upload
	#And I am selecting my hobbies
	#Then I am selecting <State> and <City>
	#Then I am reading the Data provided
	#Then I am clicking on the Close button
	#Examples:
	#| First_Name | Last_Name | Email          | Mobile     | DOB        | Subject          | Current_Address             | File                                            | State   | City    |
	#| Automation | Selenium  | Test@email.com | 1234567891 | 01 05 2000 | Computer Science | Auto Fill Automated Address | E:\Selenium Codes\Selenium often used codes.txt | Haryana | Panipat |

#@mytag
#Scenario Outline: Alert handling

#	Given I Click on Alert and Frames button
#	When I click on Alerts tab
#	Then I click on Click button to see Alert
#	And I Click on Alert that appears after five seconds
#	And I Click on Alert with Confirm to select <Ok/Cancel>
#	Then I Click on Alert with Prompt box with <text>
#	Then I Close the browser
#	Examples:
#	| Ok/Cancel		| text			|
#	| Cancel        | Automatedtext |

@mytag
Scenario: Windows handling

	Given I Click on Alert and Frames button
	When I Click on Browser Windows
	Then I CLick on New tab
	Then I Click on New Window
	Then I Click on New Window message

#@TestTag
#Scenario: Test For Data Table

#	Given This is a step for data table
#	When This is another step
#	| data1 | data2 | Data3 | data4 | data5 |
#	| hi    | hello | how   | are   | you   |








