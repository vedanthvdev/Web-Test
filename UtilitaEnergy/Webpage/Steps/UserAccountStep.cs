using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using WebTest.Webpage.Pages;

namespace WebTest.Webpage.Steps
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

        [Then(@"assert the update was successful")]
        public void ThenAssertTheUpdateWasSuccessful()
        {
            page = new UserAccountPage(_driver);
            page.UpdateSuccess();
        }

    }
}
