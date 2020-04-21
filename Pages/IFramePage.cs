using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestAssignmentPeach.Pages
{
    class IFramePage
    {
        public IFramePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#tinymce > p")]
        public IWebElement txtfieldbody { get; set; }
    }
}
