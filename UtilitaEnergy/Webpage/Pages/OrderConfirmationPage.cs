using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace WebTest.Webpage.Pages
{
    class OrderConfirmationPage
    {
        String r;
        public IWebDriver WebDriver { get; }
        public OrderConfirmationPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement Ordercomplete => WebDriver.FindElement(By.XPath("//*[@id='center_column']/div"));


        public String COnfirmOrderComplete()
        {
            Assert.IsTrue(Ordercomplete.Displayed);
            r = Ordercomplete.GetAttribute("innerHTML");
            return r;
        }


    }
}
