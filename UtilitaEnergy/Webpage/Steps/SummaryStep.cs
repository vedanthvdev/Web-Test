using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UtilitaEnergy.Webpage.Pages;

namespace UtilitaEnergy.Webpage.Steps
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
