using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UtilitaEnergy.Webpage.Pages
{
    class SummaryPage
    {
        public IWebDriver WebDriver { get; }
        public SummaryPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement btncheckout2 => WebDriver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]"));

        public void chk() => btncheckout2.Click();
    }
}
