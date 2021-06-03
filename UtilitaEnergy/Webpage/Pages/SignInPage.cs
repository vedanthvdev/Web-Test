using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace WebTest.Webpage.Pages
{
    class SignInPage
    {
        public IWebDriver WebDriver { get; }
        public SignInPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement email => WebDriver.FindElement(By.Id("email"));
        public IWebElement passwd => WebDriver.FindElement(By.Id("passwd"));
        public void EnterUserCred(Table table)
        {

            dynamic data = table.CreateDynamicInstance();
            email.SendKeys((String)data.Email);
            passwd.SendKeys((String)data.password);

        }
        public IWebElement btnsubmit => WebDriver.FindElement(By.Id("SubmitLogin"));
        public void Submit() => btnsubmit.Click();



    }
}
