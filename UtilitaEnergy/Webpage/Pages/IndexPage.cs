using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace UtilitaEnergy.Webpage.Page
{
    class HomePage
    {
        public IWebDriver WebDriver { get; }
        public HomePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }


        public IWebElement btnSignIn => WebDriver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a"));
        public void Signin() => btnSignIn.Click();
        
        
        public IWebElement ngvAccount => WebDriver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a"));

        public void account() => ngvAccount.Click();
       

        

       
    }
}
