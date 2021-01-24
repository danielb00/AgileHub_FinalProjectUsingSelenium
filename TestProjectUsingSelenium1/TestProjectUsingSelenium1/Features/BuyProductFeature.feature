Feature: BuyProductFeatures
	In order to validate buy a product on automationpractice.com/index.php website.
	Navigate on the automationpractice.com/index.php website.
	Authenticate with valid user
    Select product "printed summer dress", size M, color blue
	Select product "printed chiffon dress", size M, color green
	Check the terms of service
	Complete checkout


@BuyProduct
Scenario: 001 BuyProduct
	Given I authenticate with valid user
	| userEmail		       | userPassword |
	| testdaniel@gmail.com | test12345    |
	When I select a products
	And I finish the checkout steps
	Then I validated if the flyout the order is placed is displayed

@CheckCartTotal
Scenario: 002 CheckCartTotal
	Given I authenticate with valid user
	| userEmail		       | userPassword |
	| testdaniel@gmail.com | test12345    |
	When I select a products
	Then I validated if the total price of the products is correct

@TermsOfServicePopup
Scenario: 003 TermsOfServicePopup
	Given I authenticate with valid user
	| userEmail		       | userPassword |
	| testdaniel@gmail.com | test12345    |
	When I select a products
	And I completed the payment steps
	Then I validated if the terms of service popup is displayed
