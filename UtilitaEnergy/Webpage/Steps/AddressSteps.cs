using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UtilitaEnergy.Webpage.Pages;

namespace UtilitaEnergy.Webpage.Steps
{
    [Binding]
    class AddressSteps
    {
        AddressPage page = null;
        IWebDriver _driver = DriverHelper.Driver;

        [When(@"user clicks on proceed to checkout")]
        public void WhenUserClicksOnProceedToCheckout()
        {
            page = new AddressPage(_driver);
            page.checkout3();
        }
    }
}
