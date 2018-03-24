Feature: FeatureFileAdminpage
	In order to navigate to Admin Page
	
	
	@mytag
	Scenario: Specflow-Navigate to Admin page
	Given User have logged into keys application
	Then User will be navigated to Admin module

	@mytag
	Scenario: Specflow-Edit user details in Admin page
	Given User have logged into keys application
	Then User details are edited and saved

	@mytag
	Scenario: Specflow-Check field validations for invalid data
	Given User have logged into keys application
	Then Field validation messages are displayed for invalid data