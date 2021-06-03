using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UtilitaEnergy.Webpage.Pages
{
    class AddressPage
    {
        public IWebDriver WebDriver { get; }
        public AddressPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement btncheckout3 => WebDriver.FindElement(By.XPath("//*[@id='center_column']/form/p/button"));

        public void checkout3() => btncheckout3.Click();
    }
}
