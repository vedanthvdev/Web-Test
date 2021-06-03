using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UtilitaEnergy.Webpage.Pages
{
    class OrderHistoryPage
    {
        public IWebDriver WebDriver { get; }
        public OrderHistoryPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement btnorderHistoryconfirm => WebDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/table/tbody/tr[1]/td[7]/a[1]/span"));
        public IWebElement btnorderHistoryconfirm2 => WebDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div/div[3]/table/tbody/tr[2]/td[2]/span"));


        public void OrderHistoryConfirm(String paymentType)
        {
            btnorderHistoryconfirm.Click();
            Assert.IsTrue(btnorderHistoryconfirm2.GetAttribute("innerHTML").Contains(paymentType,StringComparison.OrdinalIgnoreCase));

        }
    }
}
