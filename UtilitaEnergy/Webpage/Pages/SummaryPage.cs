using OpenQA.Selenium;

namespace WebsiteTest.Webpage.Pages
{
    class SummaryPage
    {
        public IWebDriver WebDriver { get; }
        public SummaryPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement btncheckout2 => WebDriver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]"));

        public void chk() => btncheckout2.Click();
    }
}
