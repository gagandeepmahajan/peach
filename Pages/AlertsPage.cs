using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestAssignmentPeach.Pages
{
    class AlertsPage
    {
        public AlertsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(2) > button")]
        public IWebElement btnJSConfirm { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(3) > button")]
        public IWebElement btnJSPrompt { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#result")]
        public IWebElement lblMsg { get; set; }

    }
}
