Technology stack used:-
*********************
1. Langauge: C#
2. Selenium Webdriver
3. Specflow 
4. Nunit
5. Page Factory
6. CSS Selectors for object identification

Pre-requisite:
*************
1. Chrome browser version 77

Structure:
**********

- Features: It include 6 scenarios
  AcceptanceTests.feature
		Scenarios: Login failure
		Scenario: Login success
		Scenario: Alert - JS Confirm
		Scenario: Text Verification
		Scenario: File upload
		Scenario: Accessing iFrame

- Steps:
      Browser.cs: Generic steps
	  FileUpload.cs: File Upload page specific steps
	  IFrame.cs: IFrame page specific steps
	  JSAlert.cs: JS Alert page specific steps
	  Login.cs: Login page specific steps

- Support:
      Screenshots.cs
	   It generate screenshot after each action.

- Drivers:
      Webdriver.cs
	    It manages the driver configuration
	       
- App.config: For managing the browser

-Test Results:
     1. Html report is generated at the end of the execution
	 2. Along with html report, screenshot of each step and log of execution is also generated

Steps to execute test:
*********************

USING Commandline:
1. Go to command prompt and navigate to root location i.e. <drive>:\TestAssignmentPeach
2. dotnet test

USING Visual Studio:
1. Open Solution in Visual Studio
2. Build the solution
3. Navigate to Test Explorer
4. Click on green color play icon to run or select any specific test to execute




