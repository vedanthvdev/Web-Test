using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UtilitaEnergy.Webpage.Pages;

namespace UtilitaEnergy.Webpage.Steps
{
    [Binding]
    class OrderConfirmationStep
    {
        OrderConfirmationPage page = null;
        IWebDriver _driver = DriverHelper.Driver;

        [Then(@"confirm the order is complete")]
        public void ThenConfirmtheOrderIsComplete()
        {
            page = new OrderConfirmationPage(_driver);
            page.COnfirmOrderComplete();
        }
    }
}
