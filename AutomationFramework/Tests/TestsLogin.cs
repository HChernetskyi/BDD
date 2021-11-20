using AutomationFramework.UiElements;
using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class TestsLogin
    {
        [OneTimeTearDown]
        public void AfterAlltests()
        {
            Selenium.Driver.Quit();
        }

        public string _messageErrorNameOrPass = "Sorry, unrecognized username or password.";
        [Test]
        public void LoginPageNegativeTestWithWrongCaptcha()
        {
            LoginPage login = new LoginPage();
            login.Open();
            login.Name.SendKeys("имя");
            login.Pass.SendKeys("Пароль");
            login.Captcha.SendKeys("0");
            login.SubmitButton.Click();
            Assert.AreEqual("ВІдповідь, введена вами для Капчі - некоректна", login.MessageErrorCaptcha.Text, "Error string message for captcha check is not equal.");
            Assert.AreEqual(_messageErrorNameOrPass, login.MessageErrorNameOrPass.Text, "Error string for name or pass check is not equal.");
        }
    }
}
