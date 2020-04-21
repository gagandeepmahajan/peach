using System.Configuration;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;
using TestAssignmentPeach.Drivers;

namespace TestAssignmentPeach.Steps
{
    [Binding]
    public class Browser
    {
        readonly WebDriver _webDriver;

        public Browser(WebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Given(@"​user on (.*) page")]
        public void GivenUserOn(string pagetoOpen)
        {
            var driver = _webDriver.Current;
            driver.Manage().Window.Maximize();
            string baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            string url = Regex.Replace(pagetoOpen, @"[^\u0009\u000A\u000D\u0020-\u007E]", string.Empty);
            driver.Navigate().GoToUrl(baseUrl + url);
        }

        [AfterScenario()]
        public void CloseBrowserAfterTest()
        {
            _webDriver.Quit();
        }
    }
}
//Added comment1
