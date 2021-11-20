Feature: LoginPage

@NegativeTestWithWrongCaptcha
Scenario: Enter credentials
	Given the login page opened
	When type 'имя' to field username
	When type 'Пароль' to field password
	When type '0' to field captcha
	When click to button 'Submit'
	Then the error message1 contain 'ВІдповідь, введена вами для Капчі - некоректна'
	Then the error message2 contain 'Sorry, unrecognized username or password.'