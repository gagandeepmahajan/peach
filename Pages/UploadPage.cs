using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestAssignmentPeach.Pages
{
    class UploadPage
    {
        public UploadPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#file-submit")]
        public IWebElement btnUpload { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#file-upload")]
        public IWebElement btnChooseFile { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content > div > h3")]
        public IWebElement lblmsgTitle { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#uploaded-files")]
        public IWebElement lbluploadedFileDisplayMsg { get; set; }
    }
}
