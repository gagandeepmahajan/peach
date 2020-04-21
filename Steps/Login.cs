using TechTalk.SpecFlow;
using TestAssignmentPeach.Drivers;
using TestAssignmentPeach.Pages;
using NUnit.Framework;

namespace TestAssignmentPeach.Steps
{
    [Binding]
    public class Login
    {
        private readonly WebDriver _webDriver;
        LoginPage loginPage = null;
        public Login(WebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [When(@"​user clicks on the Login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            var driver = _webDriver.Current;
            loginPage = new LoginPage(driver);
            loginPage.btnLoginButton.Click();
        }

        [Then(@"​an error message stated (.*) appear")]
        public void ThenAnErrorMessageStatedYourUsernameIsInvalidAppear(string msg)
        {
            var driver = _webDriver.Current;
            loginPage = new LoginPage(driver);
            string msgDisplayed = loginPage.lblErrorMsg.Text;
            Assert.AreEqual(msg, msgDisplayed.Replace("\r\n×", string.Empty));
        }

        [When(@"​user fill in username (.*), password (.*) and clicks on Login button")]
        public void WhenUserFillInUsernamePasswordAndClicksOnLoginButton(string username, string password)
        {
            var driver = _webDriver.Current;
            loginPage = new LoginPage(driver);
            loginPage.txtUserName.SendKeys(username);
            loginPage.txtPassword.SendKeys(password);
            loginPage.btnLoginButton.Click();
        }

        [Then(@"​a successful message stated (.*) appear")]
        public void ThenASuccessfulMessageStatedYouLoggedIntoASecureAreaAppear(string msg)
        {
            var driver = _webDriver.Current;
            loginPage = new LoginPage(driver);
            string msgDisplayed = loginPage.lblErrorMsg.Text;
            Assert.AreEqual(msg, msgDisplayed.Replace("\r\n×", string.Empty));
        }

        [AfterScenario()]
        public void CloseBrowserAfterTest()
        {
            _webDriver.Quit();
        }
    }
}