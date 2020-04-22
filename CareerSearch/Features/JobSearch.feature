Feature: Veeam careers search
	In order to hire new employees
	As a Manager
	I want to have careers website search working

	@smoke @debug
	Scenario: Veeam careers search resuts
		Given I am on "https://careers.veeam.com" page
		When I select "Romania" in the Countries
		And I select "English" in the Languages
		Then "31" jobs should be found