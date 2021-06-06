using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebsiteTest.Webpage.Pages;

namespace WebsiteTest.Webpage.Steps
{
    [Binding]
    class ShippingStep
    {
        ShippingPage page = null;
        IWebDriver _driver = DriverHelper.Driver;

        [When(@"Agrees to terms and condition")]
        public void WhenAgreesToTermsAndCondition()
        {
            page = new ShippingPage(_driver);
            page.terms();
        }

        [When(@"user clicks on proceed to checkout in shipping")]
        public void WhenUserClicksOnProceedToCheckoutInShipping()
        {
            page = new ShippingPage(_driver);
            page.checkout4();
        }
    }
}
