using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebsiteTest.Webpage.Pages;

namespace WebsiteTest.Webpage.Steps
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
