using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebsiteTest.Webpage.Pages;

namespace WebsiteTest.Webpage.Steps
{
    [Binding]
    class OrderConfirmationStep
    {
        OrderConfirmationPage page = null;
        IWebDriver _driver = DriverHelper.Driver;


    }

}
