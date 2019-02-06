Feature: CustomerCanAddItemToBasket
	In order to for Customer to Add an Item to Basket
	As a Customer I want the ability to add an Item of my choice into basket
	So that I can pay for it.


Scenario: Customer can add an Item to Basket
	Given I am on Amazon homepage
	When I enter "echo dot" in the search bar
	And i click on submit button
	And the result of "echo dot" is displayed
	And I select the echo dot of my choice
	And I select "1" as the quantity of my choice
	And I click on add to basket button
	Then "echo dot" is added to the basket

Scenario: Customer can delete an Item from Basket
	Given I am on Amazon homepage
	When I enter "echo dot" in the search bar
	And i click on submit button
	And the result of "echo dot" is displayed
	And I select the echo dot of my choice
	And I select "1" as the quantity of my choice
	And I click on add to basket button
	And "echo dot" is added to the basket
	And I click on the basket icon
	And I click on delete link
	Then echo do is deleted from the basket
