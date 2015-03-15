Feature: SpecFlowFeature1
	As a user 
	I should be able to save my details
	
	

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen


Scenario: User Details Entry
	Given  User On a home page
	When   User Enter below details and click save
	| initial | FirstNAme | MiddleNAme | Gender | Language | Title |
	| D  | abc       | xyz        | male   | hindi    | Mr.|
	Then  Userdetails should be saved