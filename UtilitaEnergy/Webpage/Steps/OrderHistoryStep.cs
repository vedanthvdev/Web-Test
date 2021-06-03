using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using WebTest.Webpage.Pages;

namespace WebTest.Webpage.Steps
{
    [Binding]
    class OrderHistoryStep 
    {
        OrderHistoryPage page = null;
        OrderConfirmationPage sage = null;
        IWebDriver _driver = DriverHelper.Driver;

        string Reference = null;
        [Then(@"confirm the order is complete")]
        public void ThenConfirmtheOrderIsComplete()
        {
            sage = new OrderConfirmationPage(_driver);
            Reference = sage.COnfirmOrderComplete();
        }

        [Then(@"confirm the Item is present with (.*)")]
        public void ThenConfirmTheItemIsPresentWith(String p0)
        {
            page = new OrderHistoryPage(_driver);
            String OrderHistoryReference = page.OrderHistoryConfirm(p0).Substring(10,8);
            Assert.IsTrue(Reference.Contains(OrderHistoryReference, StringComparison.OrdinalIgnoreCase));
            
        }

    }
}
