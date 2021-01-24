Feature: EditPersonalInformationUser
	In order to validate edit personal informartion user on automationpractice.com/index.php website.
	Navigate on the automationpractice.com/index.php website.
	Click the signin button.
    Click the my personal information button.
	Edit the text boxes and click on the save button.


@EditPersonalInformationUser
Scenario: EditPersonalInformationUser
	Given I navigate to website and I login with following credentials
	| userEmail		       | userPassword |
	| testdaniel@gmail.com | test12345    |
	And I click on the my personal information button
	When I edit the text boxex with following data
		| editUserFirstName        | editUserLastName        | editUserEmail        | currentPassword        | newPassword		  | confirmationPassword        | 
		| <editUserFirstNameValue> | <editUserLastNameValue> | <editUserEmailValue> | <currentPasswordValue> | <newPasswordValue> | <confirmationPasswordValue> | 
	And I click on the save button
	Then I validated if the flyout succes alert is displayed

Examples: 
    | editUserFirstNameValue| editUserLastNameValue | editUserEmailValue		| currentPasswordValue | newPasswordValue | confirmationPasswordValue | 
    | EditDaniel		    | EditTest			    | testdaniel16@gmail.com    | test12345			   | test123          | test123                   |