Feature: Veeam careers search
	In order to hire new employees
	As a Manager
	I want to have careers website search working

	@smoke
	Scenario: Veeam careers search results
		Given I am on "https://careers.veeam.com" page
		When I select Romania in the Countries
		And I select English in the Languages
		Then 31 jobs should be found

#	@smoke
#	Scenario Outline: Veeam careers search results
#		Given I am on "https://careers.veeam.com" page
#		When I select "<country>" in the Countries
#		And I select "<language>" in the Languages
#		Then "<amount>" jobs should be found
#		Examples:
#			| country        | language | amount |
#			| Romania        | English  | 31     | 
#			| France         | French   | 3      | 
#			| Czech Republic | Russian  | 1      |