using System;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using TestAssignmentPeach.Drivers;
using TestAssignmentPeach.Pages;

namespace TestAssignmentPeach.Steps
{
    [Binding]
    public class FileUpload
    {
        private readonly WebDriver _webDriver;
        UploadPage uploadpage = null;

        public FileUpload(WebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [When(@"user upload a file named as (.*) and clicks Upload")]
        public void WhenUserUploadAFileNamedAsBurrito_JpgAndClicksUpload(string filename)
        {
            var driver = _webDriver.Current;
            WebDriver obj_driver = new WebDriver();
            string filePath = obj_driver.GetFrameworkPath() + "\\" +filename;
            uploadpage = new UploadPage(driver);
            uploadpage.btnChooseFile.SendKeys(filePath);
            uploadpage.btnUpload.Click();
        }

        [Then(@"next screen should show (.*) as title and filename (.*)")]
        public void ThenNextScreenShouldShowFileUploadedAsTitleAndFilenameJpg(string titlemsg, string fnamemsg)
        {
            var driver = _webDriver.Current;
            uploadpage = new UploadPage(driver);
            string msgtitle = uploadpage.lblmsgTitle.Text;
            string msgfileuploaded = uploadpage.lbluploadedFileDisplayMsg.Text;
            Assert.AreEqual(titlemsg, msgtitle.Replace("\r\n", string.Empty));
            Assert.AreEqual(fnamemsg, msgfileuploaded.Replace("\r\n", string.Empty));
        }
    }
}