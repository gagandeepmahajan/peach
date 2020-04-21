using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestAssignmentPeach.Drivers;
using TestAssignmentPeach.Pages;

namespace TestAssignmentPeach.Steps
{
    [Binding]
    public class JSAlert
    {
        private readonly WebDriver _webDriver;
        AlertsPage alertsPage = null;
        IAlert alert = null;

        public JSAlert(WebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [When(@"user clicks on Click for JS Confirm button and select OK")]
        public void WhenUserClicksOnClickForJSConfirmButtonAndSelectOK_()
        {
            var driver = _webDriver.Current;
            alertsPage = new AlertsPage(driver);
            alertsPage.btnJSConfirm.Click();
            alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        [Then(@"result showing (.*)")]
        public void ThenResultShowingMessage(string msg)
        {
            var driver = _webDriver.Current;
            alertsPage = new AlertsPage(driver);
            string msgDisplayed = alertsPage.lblMsg.Text;
            Assert.AreEqual(msg, msgDisplayed.Replace("\r\n", string.Empty));
        }

        [When(@"user clicks on Click for JS Prompt button")]
        public void WhenUserClicksOnClickForJSPromptButton()
        {
            var driver = _webDriver.Current;
            alertsPage = new AlertsPage(driver);
        }

        [When(@"user enters the test (.*) and clicks Cancel")]
        public void WhenentertextAndClickCancel(string texttoinput)
        {
            var driver = _webDriver.Current;
            alertsPage.btnJSPrompt.Click();
            alert = driver.SwitchTo().Alert();
            alert.SendKeys(texttoinput);
            alert.Dismiss();
        }

    }
}