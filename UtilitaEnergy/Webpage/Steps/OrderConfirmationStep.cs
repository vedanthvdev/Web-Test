using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebTest.Webpage.Pages;

namespace WebTest.Webpage.Steps
{
    [Binding]
    class OrderConfirmationStep
    {
        OrderConfirmationPage page = null;
        IWebDriver _driver = DriverHelper.Driver;


    }

}
