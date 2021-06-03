using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace WebTest.Webpage.Pages
{
    class UserAccountPage
    {
        public IWebDriver WebDriver { get; }
        public UserAccountPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement btnpersonalInfo => WebDriver.FindElement(By.XPath("//*[@id='center_column']/div/div[1]/ul/li[4]/a/span"));

        public void personalInfo() => btnpersonalInfo.Click();

        public IWebElement btnsignout => WebDriver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[2]/a"));
        public bool homepage() => btnsignout.Displayed;
        public IWebElement ItemSearch => WebDriver.FindElement(By.Id("search_query_top"));


        public void Search(String item)
        {
            ItemSearch.SendKeys(item);
            ItemSearch.SendKeys(Keys.Enter);
        }
        public IWebElement btnorderHistory => WebDriver.FindElement(By.XPath("//*[@id='center_column']/div/div[1]/ul/li[1]/a"));

        public void orderHistory() => btnorderHistory.Click();

        public IWebElement viewChangeSuccess => WebDriver.FindElement(By.XPath("//*[@id='center_column']/div/p"));

        public void UpdateSuccess() => Assert.IsTrue(viewChangeSuccess.Displayed);
    }
}
