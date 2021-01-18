Feature: ContactUsFeature
	In order to validate customer service - contact us on automationpractice.com/index.php website.
	Navigate on the automationpractice.com/index.php website.
	Authenticate with valid user
	Click on the contact us button.
	Fill in the text boxes and click on the send button.

@ContactUsFeature
Scenario: ContactUsFeature
	Given I navigate to website and I authenticate with valid user
	| userEmail		       | userPassword |
	| testdaniel@gmail.com | test12345    |
	And I click on contact us button
	When I fill in the message text box with following data
		| messageText        | 
		| <messageTextValue> | 
	And I click on send message button
	Then I validated if the flyout with message it was successfull sent is displayed

Examples: 
    | messageTextValue                                                       |  
    | Unfortunately, the size of the dress is not good. How can I return it? | 