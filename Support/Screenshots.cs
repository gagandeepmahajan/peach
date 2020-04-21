using System;
using System.IO;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestAssignmentPeach.Drivers;

namespace TestAssignmentPeach.Support
{
    [Binding]
    class Screenshots
    {
        private readonly WebDriver _webDriver;

        public Screenshots(WebDriver webDriver)
        {
            _webDriver = webDriver;
        }
//comment
        [AfterStep()]
        public void MakeScreenshotAfterStep()
        {
            var takesScreenshot = _webDriver.Current as ITakesScreenshot;
            if (takesScreenshot != null)
            {
                var screenshot = takesScreenshot.GetScreenshot();
                var tempFileName = Path.Combine(Directory.GetCurrentDirectory(), Path.GetFileNameWithoutExtension(Path.GetTempFileName())) + ".jpg";
                screenshot.SaveAsFile(tempFileName, ScreenshotImageFormat.Jpeg);

                Console.WriteLine($"SCREENSHOT[ file:///{tempFileName} ]SCREENSHOT");
            }
        }
    }
}
