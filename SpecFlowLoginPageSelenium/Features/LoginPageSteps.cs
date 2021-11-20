using FluentAssertions;
using SpecFlowLoginPageSelenium.Drivers;
using SpecFlowLoginPageSelenium.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowLoginPageSelenium.Features
{
    [Binding]
    public class LoginPageSteps
    {
        private readonly LoginPageObject _loginPageObject;

        public LoginPageSteps(BrowserDriver browserDriver)
        {
            _loginPageObject = new LoginPageObject(browserDriver.Current);
        }
        [Given(@"the login page opened")]
        public void GivenTheLoginPageOpened()
        {
            _loginPageObject.EnsureLoginPageIsOpen();
        }

        [When(@"type '(.*)' to field username")]
        public void WhenTypeToFieldUsername(string p0)
        {
            _loginPageObject.EnterName(p0);
        }

        [When(@"type '(.*)' to field password")]
        public void WhenTypeToFieldPassword(string p0)
        {
            _loginPageObject.EnterPass(p0);
        }

        [When(@"type '(.*)' to field captcha")]
        public void WhenTypeToFieldCaptcha(string p0)
        {
            _loginPageObject.EnterCaptcha(p0);
        }

        [When(@"click to button '(.*)'")]
        public void WhenClickToButton(string p0)
        {
            _loginPageObject.ClickSubmitButton();
        }

        [Then(@"the error message1 contain '(.*)'")]
        public void ThenTheErrorMessage1Contain(string p0)
        {
            _loginPageObject.ErrorMessageElement1.Text.Should().Be(p0);
        }
        [Then(@"the error message2 contain '(.*)'")]
        public void ThenTheErrorMessage2Contain(string p0)
        {
            _loginPageObject.ErrorMessageElement2.Text.Should().Be(p0);
        }
    }
}
