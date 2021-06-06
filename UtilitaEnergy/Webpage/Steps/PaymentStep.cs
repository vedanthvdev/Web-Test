using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebsiteTest.Webpage.Pages;

namespace WebsiteTest.Webpage.Steps
{
    [Binding]
    class PaymentStep
    {
        PaymentPage page = null;
        IWebDriver _driver = DriverHelper.Driver;

        [When(@"user chooses (.*)")]
        public void WhenUserChooses(string p0)
        {
            page = new PaymentPage(_driver);
            page.payment(p0);
        }


        [When(@"user clicks on I confirm my order")]
        public void WhenUserClicksOnIConfirmMyOrder()
        {
            page = new PaymentPage(_driver);
            page.ConfirmOrder();
        }
    }
}
