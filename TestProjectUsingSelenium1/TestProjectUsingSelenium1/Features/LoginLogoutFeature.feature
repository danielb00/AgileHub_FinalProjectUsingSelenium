Feature: LoginLogoutFeatures
	In order to validate login and logout on automationpractice.com/index.php website.
	Navigate on the automationpractice.com/index.php website.
	Login and logout of the website.

@LoginWithValidUser
Scenario: 001 LoginWithValidUser
	Given I navigate to website and click signin button
	When I login with following credentials
	| userEmail		   | userPassword		|
	| <userEmailValue> | <userPasswordValue>|
	Then I validated if the my personal information button is displayed

Examples: 
	| userEmailValue		 | userPasswordValue |  
	| testdaniel@gmail.com   | test12345         |

@LogoutOfWebsite
Scenario: 002 LogoutOfWebsite
	Given I navigate to website and click signin button
	When I login with following credentials
	| userEmail		   | userPassword		|
	| <userEmailValue> | <userPasswordValue>|
	And I logout of the account
	Then I validated if the login button is displayed

Examples: 
	| userEmailValue		 | userPasswordValue |  
	| testdaniel@gmail.com   | test12345		 |

	