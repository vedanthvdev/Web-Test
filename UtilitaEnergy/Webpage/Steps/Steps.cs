using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using UtilitaEnergy.Webpage.Page;

namespace UtilitaEnergy.Webpage.Steps
{
    [Binding]
    class Steps
    {
        HomePage page = null;
        IWebDriver _driver = DriverHelper.Driver;

        [Given(@"the website (.*) has loaded")]
        public void GivenTheWebsiteHasLoaded(string url)
        {
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            page = new HomePage(_driver);
            _driver.Navigate().GoToUrl(url);
        }

        [When(@"user clicks on Help")]
        public void WhenUserClicksOnHelp()
        {
            page = new HomePage(_driver);
            page.Cookies();
            page.Help();
        }

        [Then(@"Help screen '(.*)' will load")]
        public void ThenHelpScreenWillLoad(string p0)
        {
            Assert.That(_driver.Url.Equals(p0), Is.True);
        }

        [When(@"user clicks Manage your install")]
        public void WhenUserClicksManageYourInstall()
        {
            page = new HomePage(_driver);
            page.ManageYourInstall();
        }

        [Then(@"Manage your install screen will load")]
        public void ThenManageYourInstallScreenWillLoad()
        {
            Assert.That(page.ManageYourInstallScreen, Is.True);
        }

        [When(@"user clicks '(.*)'")]
        public void WhenUserClicks(string p0)
        {
            page = new HomePage(_driver);
            page.click(p0);
        }

        [Then(@"installing your Smart Meter screen will show")]
        public void ThenInstallingYourSmartMeterScreenWillShow()
        {
            Assert.IsTrue(page.Installating());
        }

        //[When(@"user selects '(.*)'")]
        //public void WhenUserSelects(string p0)
        //{
        //    page = new HomePage(_driver);
        //    page.SendUsEmail();
        //}

        [Then(@"Manage your install drop down will open")]
        public void ThenManageYourInstallDropDownWillOpen()
        {
            Assert.True(page.DropDown()); 
        }

        //[When(@"user clicks Have a question about your install\?")]
        //public void WhenUserClicksHaveAQuestionAboutYourInstall()
        //{
        //    page = new HomePage(_driver);
        //    page.HaveAquestionAboutYourInstall();
        //}

        [Then(@"contact form will load")]
        public void ThenContactFormWillLoad()
        {
            Assert.True(page.HowCanWeHelp());
        }

        [When(@"user chooses '(.*)' from the How can we help field")]
        public void WhenUserChoosesFromTheHowCanWeHelpField(string p0)
        {
            page = new HomePage(_driver);
            page.ChoiceHowCanWeHelp(p0);
        }


        [When(@"no other details are filled out")]
        public void WhenNoOtherDetailsAreFilledOut()
        {
            page = new HomePage(_driver);
        }

        [When(@"clicks Submit button")]
        public void WhenClicksSubmitButton()
        {
            page = new HomePage(_driver);
            page.Submit();
        }

        [Then(@"error message (.*) will show below the field '(.*)'")]
        public void ThenErrorMessageWillShowBelowTheField(string p0, string p1)
        {
            page = new HomePage(_driver);
            page.Error(p0,p1);
        }



    }
}
