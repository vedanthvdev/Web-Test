using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using UtilitaEnergy.Webpage.Page;

namespace UtilitaEnergy.Webpage.Steps
{
    [Binding]
    class HomeStep
    {
        HomePage page = null;
        IWebDriver _driver = DriverHelper.Driver;

        [Given(@"the website '(.*)' has loaded")]
        public void GivenTheWebsiteHasLoaded(string url)
        {
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            page = new HomePage(_driver);
            _driver.Navigate().GoToUrl(url);
        }

        [Given(@"User clicks on Sign in Page")]
        public void GivenUserClicksOnSignInPage()
        {
            page = new HomePage(_driver);
            page.Signin();
        }

        [When(@"clicked on your account")]
        public void WhenClickedOnYourAccount()
        {
            page = new HomePage(_driver);
            page.account();
        }

        [Then(@"Close the browser")]
        public void ThenCloseTheBrowser()
        {
            _driver.Close();
        }

    }
}
