using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using UtilitaEnergy.Webpage.Pages;

namespace UtilitaEnergy.Webpage.Steps
{
    [Binding]
    class PersonalInfoStep
    {
        PersonalInfoPage page = null;
        IWebDriver _driver = DriverHelper.Driver;


        [When(@"update the (.*)")]
        public void WhenUpdateThe(String p0)
        {
            page = new PersonalInfoPage(_driver);
            page.firstName(p0);
        }

        [When(@"Enter the (.*)")]
        public void WhenEnterThe(String p0)
        {
            page = new PersonalInfoPage(_driver);
            page.oldPass(p0);
        }

        [When(@"click save")]
        public void WhenClickSave()
        {
            page = new PersonalInfoPage(_driver);
            page.save();
        }
    }
}
