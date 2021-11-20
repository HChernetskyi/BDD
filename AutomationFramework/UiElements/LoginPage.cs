using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.UiElements
{
    public class LoginPage : BasePage
    {
        public override string Url { get => "http://www.nbuv.gov.ua/user/login"; }

        [FindsBy(How = How.CssSelector, Using = "#edit-name")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#edit-pass")]
        public IWebElement Pass { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#edit-captcha-response")]
        public IWebElement Captcha { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#edit-submit")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"container\"]/div[1]/ul/li[1]")]
        public IWebElement MessageErrorCaptcha { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"container\"]/div[1]/ul/li[2]")]
        public IWebElement MessageErrorNameOrPass { get; set; }

        public LoginPage()
        {
            PageFactory.InitElements(Selenium.Driver, this);
        }
    }
}
