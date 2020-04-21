using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestAssignmentPeach.Drivers;
using TestAssignmentPeach.Pages;

namespace TestAssignmentPeach.Steps
{
    [Binding]
    public class IFrame
    {

        private readonly WebDriver _webDriver;
        IFramePage iframePage = null;
        public IFrame(WebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [When(@"user type (.*) in the text box")]
        public void WhenUserTypeILovePizzaInTheTextBox(string inputText)
        {
            var driver = _webDriver.Current;
            iframePage = new IFramePage(driver);
            driver.SwitchTo().Frame(0);
            iframePage.txtfieldbody.Clear();
            iframePage.txtfieldbody.SendKeys(inputText);
        }

        [Then(@"textbox shows (.*)")]
        public void ThenTextboxShowsILovePizza(string msgdisplayed)
        {
            var driver = _webDriver.Current;
            iframePage = new IFramePage(driver);
            string textententered = iframePage.txtfieldbody.Text;
            Assert.AreEqual(msgdisplayed, textententered.Replace("\r\n", string.Empty));
        }
    }
}