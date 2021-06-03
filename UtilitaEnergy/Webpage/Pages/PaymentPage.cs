using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UtilitaEnergy.Webpage.Pages
{
    class PaymentPage
    {
        public IWebDriver WebDriver { get; }
        public PaymentPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement btnpaymentbank => WebDriver.FindElement(By.XPath("//*[@id='HOOK_PAYMENT']/div[1]/div/p/a"));
        public IWebElement btnpaymentcheck => WebDriver.FindElement(By.XPath("//*[@id='HOOK_PAYMENT']/div[2]/div/p/a"));


        public void payment(String type)
        {

            if (type.Contains("Bank wire",StringComparison.OrdinalIgnoreCase))
            {
                btnpaymentbank.Click();
            }
            else
            {
                btnpaymentcheck.Click();
            }

        }
        public IWebElement btnconfirmOrder => WebDriver.FindElement(By.XPath("//*[@id='cart_navigation']/button"));

        public void ConfirmOrder() => btnconfirmOrder.Click();
    }
}
