using System;

using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace TestAssignmentPeach.Drivers
{
    public class WebDriver
    {
        private IWebDriver _currentWebDriver;
        private WebDriverWait _wait;

        public IWebDriver Current
        {
            get
            {
                if (_currentWebDriver == null)
                {
                    _currentWebDriver = GetWebDriver();
                }

                return _currentWebDriver;
            }
        }

        public WebDriverWait Wait
        {
            get
            {
                if (_wait == null)
                {
                    this._wait = new WebDriverWait(Current, TimeSpan.FromSeconds(10));
                }
                return _wait;
            }
        }

        private IWebDriver GetWebDriver()
        {
            switch (ConfigurationManager.AppSettings["BrowserName"])
            {
                case "IE": return new InternetExplorerDriver(new InternetExplorerOptions { IgnoreZoomLevel = true }) { };
                case "Chrome": return new ChromeDriver(GetFrameworkPath()) { };
                case "Firefox": return new FirefoxDriver { };
                case string browser: throw new NotSupportedException($"{browser} is not a supported browser");
                default: throw new NotSupportedException("not supported browser: <null>");
            }
        }

        public string GetFrameworkPath()
        {
            string sCurrentDir = System.Environment.CurrentDirectory;
            int length = sCurrentDir.Length;
            string sPath = sCurrentDir.Replace("\\TestResults", "");
            return sPath;
        }

        public void Quit()
        {
            _currentWebDriver?.Quit();
        }
    }
}
