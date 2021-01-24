Feature: AccountUserFeatures
	In order to validate create new account on automationpractice.com/index.php website.
	Navigate on the automationpractice.com/index.php website.
	Click on the sign in button.
    Fill in the email address and click on the create an account button.
	Fill in the text boxes and click on the register button.
	Fill in the registered address again and receive a message alert, duplicate email address.

@CreateNewAccount
Scenario: 001 CreateNewAccount
	Given I navigate to website and click sign in
	And I fill in the email and click register
	| userEmail        |
	| <userEmailValue> |
	When I fill in the text boxex with following data
		| userFirstName        | userLastName        | userEmail        | userPassword        | userAddressFirstName		| userAddressLastName        | userAddress        | userCity        | userZipCode        | userMobilePhone        |
		| <userFirstNameValue> | <userLastNameValue> | <userEmailValue> | <userPasswordValue> | <userAddressFirstNameValue> | <userAddressLastNameValue> | <userAddressValue> | <userCityValue> | <userZipCodeValue> | <userMobilePhoneValue> |
	And I click on the register button
	Then I validated if the logout button is displayed

Examples: 
    | userFirstNameValue| userLastNameValue | userEmailValue		| userPasswordValue | userAddressFirstNameValue | userAddressLastNameValue | userAddressValue     | userCityValue | userZipCodeValue | userMobilePhoneValue  |
    | Daniel			| Test				| testdaniel@gmail.com  | test12345			| DanielAdress              | TestAdress               | Brasov, 13 Decembrie | Brasov        | 33555            | 0722-455-253			 |

@AlertDuplicateEmail
Scenario: 002 AlertDuplicateEmail
	Given I navigate to website and click sign in
	When I fill in the email and click register
	| userEmail        |
	| <userEmailValue> |
	Then I validated if the flyout with alert message is displayed

Examples: 
	| userEmailValue		 |
	| testdaniel@gmail.com   |