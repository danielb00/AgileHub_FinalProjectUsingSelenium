Feature: BuyProduct
	In order to validate buy a product on automationpractice.com/index.php website.
	Navigate on the automationpractice.com/index.php website.
	Authenticate with valid user
    Select product "printed summer dress", size M, color blue
	Complete checkout

@BuyProduct
Scenario: BuyProduct
	Given I authenticate with valid user
	| userEmail		       | userPassword |
	| testdaniel@gmail.com | test12345    |
	When I select a product
	And I finish the checkout steps
	Then I validated if the flyout the order is placed is displayed

