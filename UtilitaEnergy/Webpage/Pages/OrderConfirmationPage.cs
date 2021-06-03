using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UtilitaEnergy.Webpage.Pages
{
    class OrderConfirmationPage
    {
        public IWebDriver WebDriver { get; }
        public OrderConfirmationPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement OrdercompleteBank => WebDriver.FindElement(By.XPath("//*[@id='center_column']/div"));
        public void COnfirmOrderComplete()
        {
            Assert.IsTrue(OrdercompleteBank.Displayed);

        }
    }
}
