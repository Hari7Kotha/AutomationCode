Feature: Maintenance_DeleteJob
	Login to Property.Community
	 Navigate to Maintenance Manage Job Property Manager
	delete job from maintenance

@mytag
Scenario: Delete Job from Maintenance
	Given i have logged in to the site
	And I have Navigated to Manage job property manger
	Then  delete job from maintenance
