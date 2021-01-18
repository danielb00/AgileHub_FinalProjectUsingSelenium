Feature: SearchQueryFeature
	In order to validate search bar on automationpractice.com/index.php website.
	Navigate on the automationpractice.com/index.php website.
	Write a product in the search bar and click search

@SearchQueryFeature
Scenario: SearchQueryFeature
	Given I navigate to website 
	And I write 'Printed Summer Dress' in the search bar
	When I press the search button
	Then I validated if the product is displayed

