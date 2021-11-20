using SpecFlowLoginPageSelenium.Drivers;
using SpecFlowLoginPageSelenium.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowLoginPageSelenium.Hooks
{
    [Binding]
    class LoginPageHooks
    {
        [BeforeScenario("Enter credentials")]
        public static void BeforeScenario(BrowserDriver browserDriver)
        {
            var LoginPageObject = new LoginPageObject(browserDriver.Current);
            LoginPageObject.EnsureLoginPageIsOpen();
        }
    }
}
