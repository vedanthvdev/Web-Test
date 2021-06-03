using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebTest.Webpage.Pages
{
    class SearchPage
    {
        public IWebDriver WebDriver { get; }
        public SearchPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        Actions act = null;

        public IWebElement btnAddToCart => WebDriver.FindElement(By.XPath("//*[@id='center_column']/ul/li/div/div[2]/div[2]/a[1]"));
        public IWebElement hover => WebDriver.FindElement(By.XPath("//*[@id='center_column']/ul/li/div/div[2]/span/span"));


        public void addToCart()
        {
            act = new Actions(WebDriver);
            act.MoveToElement(hover).Perform();
            btnAddToCart.Click();
        }
        public IWebElement btncheckout => WebDriver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/a"));
        public void checkout() => btncheckout.Click();
    }
}
