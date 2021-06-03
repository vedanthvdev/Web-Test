using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebTest.Webpage.Pages
{
    class PersonalInfoPage
    {
        public IWebDriver WebDriver { get; }
        public PersonalInfoPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement blkFirstName => WebDriver.FindElement(By.Id("firstname"));

        public void firstName(String name)
        {
            blkFirstName.Clear();
            blkFirstName.SendKeys(name);

        }

        public IWebElement blkoldPassword => WebDriver.FindElement(By.Id("old_passwd"));

        public void oldPass(String pass)
        {

            blkoldPassword.SendKeys(pass);
        }

        public IWebElement btnsave => WebDriver.FindElement(By.XPath("//*[@id='center_column']/div/form/fieldset/div[11]/button/span"));

        public void save() => btnsave.Click();


    }
}
