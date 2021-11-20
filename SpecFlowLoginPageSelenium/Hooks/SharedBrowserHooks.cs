using BoDi;
using SpecFlowLoginPageSelenium.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlowLoginPageSelenium.Hooks
{
    [Binding]
    class SharedBrowserHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun(ObjectContainer testThreadContainer)
        {
            testThreadContainer.BaseContainer.Resolve<BrowserDriver>();
        }
    }
}
