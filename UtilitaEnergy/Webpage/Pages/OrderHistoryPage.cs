using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebTest.Webpage.Pages
{
    class OrderHistoryPage
    {
        public IWebDriver WebDriver { get; }
        public OrderHistoryPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement reference => WebDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/table/tbody/tr[1]/td[1]/a"));
        public IWebElement btnorderHistoryconfirm => WebDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/table/tbody/tr[1]/td[7]/a[1]/span"));
        public IWebElement btnorderHistoryconfirm2 => WebDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div/div[3]/table/tbody/tr[2]/td[2]/span"));


        public String OrderHistoryConfirm(String paymentType)
        {
            btnorderHistoryconfirm.Click();
            Assert.IsTrue(btnorderHistoryconfirm2.GetAttribute("innerHTML").Contains(paymentType,StringComparison.OrdinalIgnoreCase));
            return reference.GetAttribute("innerHTML");
        }
    }
}
