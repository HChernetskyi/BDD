using OpenQA.Selenium;

namespace SpecFlowLoginPageSelenium.PageObjects
{
    public class LoginPageObject
    {
        private const string LoginPageUrl = "http://www.nbuv.gov.ua/user/login";
        private readonly IWebDriver _webDriver;

        public LoginPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _webDriver.Url = LoginPageUrl;
        }

        private IWebElement NameElement => _webDriver.FindElement(By.CssSelector("#edit-name"));
        private IWebElement PassElement => _webDriver.FindElement(By.CssSelector("#edit-pass"));
        private IWebElement CaptchaElement => _webDriver.FindElement(By.CssSelector("#edit-captcha-response"));
        private IWebElement SubmitButtonElement => _webDriver.FindElement(By.CssSelector("#edit-submit"));
        public IWebElement ErrorMessageElement1 => _webDriver.FindElement(By.XPath("//*[@id=\"container\"]/div[1]/ul/li[1]"));
        public IWebElement ErrorMessageElement2 => _webDriver.FindElement(By.XPath("//*[@id=\"container\"]/div[1]/ul/li[2]"));

        public void EnterName(string name)
        {
            NameElement.Clear();
            NameElement.SendKeys(name);
        }

        public void EnterPass(string pass)
        {
            PassElement.Clear();
            PassElement.SendKeys(pass);
        }

        public void EnterCaptcha(string captcha)
        {
            CaptchaElement.Clear();
            CaptchaElement.SendKeys(captcha);
        }

        public void ClickSubmitButton()
        {
            SubmitButtonElement.Click();
        }

        public void EnsureLoginPageIsOpen()
        {
            if (_webDriver.Url != LoginPageUrl)
            {
                _webDriver.Url = LoginPageUrl;
            }
        }
    }
}
