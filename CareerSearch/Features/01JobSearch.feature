Feature: Veeam careers search
	In order to hire new employees
	As a Manager
	I want to have careers website search working
	
@scopedBinding
Scenario: Veeam careers search for {Ro} and {En} with expected {5}
	Given I navigated to "https://careers.veeam.com" page
	When I have selected "Romania" in the Countries drop-down
	And I have selected "English" in the Languages drop-down
	Then 33 jobs should be found
