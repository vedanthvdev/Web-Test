using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using UtilitaEnergy.Webpage.Pages;

namespace UtilitaEnergy.Webpage.Steps
{
    [Binding]
    class UserAccountStep
    {

        UserAccountPage page = null;
        IWebDriver _driver = DriverHelper.Driver;

        [Then(@"assert he enters his home page")]
        public void ThenAssertHeEntersHisHomePage()
        {
            page = new UserAccountPage(_driver);
            Assert.IsTrue(page.homepage());
        }

        [When(@"User Search for (.*)")]
        public void WhenUserSearchFor(String Item)
        {
            page = new UserAccountPage(_driver);
            page.Search(Item);
        }

        [When(@"navigate the order history and details")]
        public void WhenNavigateTheOrderHistoryAndDetails()
        {
            page = new UserAccountPage(_driver);
            page.orderHistory();
        }

        [When(@"go into personal information tab")]
        public void WhenGoIntoPersonalInformationTab()
        {
            page = new UserAccountPage(_driver);
            page.personalInfo();

        }
    }
}
