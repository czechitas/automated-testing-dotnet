Feature: UserLogin
	To show another possible naming options


Scenario: Platny uzivatel se muze prihlasit
	Given user open applicaiton on login page
		When user fill valid username
		When user fill valid password
		And user click on login
	Then validate that login was successful