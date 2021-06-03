using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using WebTest.Webpage.Pages;

namespace WebTest.Webpage.Steps
{
    [Binding]
    class SearchStep
    {
        SearchPage page = null;
        IWebDriver _driver = DriverHelper.Driver;


        [When(@"User clicks on the add to cart")]
        public void WhenUserClicksOnTheAddToCart()
        {
            page = new SearchPage(_driver);
            page.addToCart();
        }

        [When(@"clicks on proceed to checkout")]
        public void WhenClicksOnProceedToCheckout()
        {
            page = new SearchPage(_driver);
            page.checkout();
        }
    }
}
