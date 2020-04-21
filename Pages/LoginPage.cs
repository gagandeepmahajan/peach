using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestAssignmentPeach.Pages
{
    class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#login > button > i")]
        public IWebElement btnLoginButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#flash")]
        public IWebElement lblErrorMsg { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#username")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#password")]
        public IWebElement txtPassword { get; set; }

    }
}
