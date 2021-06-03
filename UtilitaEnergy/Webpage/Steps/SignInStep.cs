using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using WebTest.Webpage.Pages;

namespace WebTest.Webpage.Steps
{
    [Binding]
    class SignInStep
    {
        SignInPage page = null;

        IWebDriver _driver = DriverHelper.Driver;

        [Given(@"enters his credentials")]
        public void GivenEntersHisCredentials(Table table)
        {
            page = new SignInPage(_driver);
            page.EnterUserCred(table);
        }

        [Given(@"clicks Submit")]
        public void GivenClicksSubmit()
        {
            page = new SignInPage(_driver);
            page.Submit();
        }
    }
}
