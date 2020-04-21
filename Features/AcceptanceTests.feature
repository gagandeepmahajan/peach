Feature: AcceptanceTests
	Below are the tests written to verify the http://the-internet.herokuapp.com site behaviour

@LoginCheckFailure
Scenario: Login failure
	Given ​user on ​login page
	When ​user clicks on the Login button
	Then ​an error message stated Your username is invalid! appear 

@LoginCheckSuccess
@Smoke
Scenario: Login success 
	Given ​user on ​login page
	When ​user fill in username tomsmith, password SuperSecretPassword! and clicks on Login button
	Then ​a successful message stated You logged into a secure area! appear

@JavascriptAlert
@Smoke
Scenario: Alert - JS Confirm 
	Given ​user on ​javascript_alerts page
	When user clicks on Click for JS Confirm button and select OK
	Then result showing You clicked: Ok

@JavascriptAlert
Scenario: Text Verification
	Given ​user on ​javascript_alerts page
	When user clicks on Click for JS Prompt button
	And user enters the test Test JS Prompt and clicks Cancel
	Then result showing You entered: null

@Fileupload
@Smoke
Scenario: File upload
	Given ​user on ​upload page
	When user upload a file named as burrito.jpg and clicks Upload
	Then next screen should show File Uploaded! as title and filename burrito.jpg

@iFrameAccessing
@Smoke
Scenario: Accessing iFrame
	Given ​user on ​iframe page
	When user type I love pizza in the text box
	Then textbox shows I love pizza