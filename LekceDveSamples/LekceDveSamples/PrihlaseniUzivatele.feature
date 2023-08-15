Feature: PrihlaseniUzivatele
	To show another possible naming options


Scenario: Platny uzivatel se muze prihlasit
	Given otevru aplikaci na prihlasovaci strance
		When zadam validni jmeno
		And zadam validni heslo
		And klinu na prihlasit
	Then overim ze prihlasni bylo uspesnes