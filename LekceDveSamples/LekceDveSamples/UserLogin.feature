Feature: UserLogin
	To show another possible naming options


Scenario: Valid user can login
	Given user open applicaiton on login page
		When user fills valid username
		When user fills valid password
		And user clicks on login
	Then validate that login was successful