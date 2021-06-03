using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebTest.Webpage.Pages;

namespace WebTest.Webpage.Steps
{
    [Binding]
    class SummaryStep
    {
        SummaryPage page = null;
        IWebDriver _driver = DriverHelper.Driver;


        [When(@"user clicks proceed to checkout")]
        public void WhenUserClicksProceedToCheckout()
        {
            page = new SummaryPage(_driver);
            page.chk();
        }
    }
}
