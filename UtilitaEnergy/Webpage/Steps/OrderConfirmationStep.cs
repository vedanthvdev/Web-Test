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


    }

}
