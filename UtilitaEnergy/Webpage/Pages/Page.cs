using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace UtilitaEnergy.Webpage.Page
{
    class HomePage
    {
        public IWebDriver WebDriver { get; }
        public HomePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement btnCookie => WebDriver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll"));

        public IWebElement nvgHelp => WebDriver.FindElement(By.XPath("/html/body/div[2]/div/ul/div[1]/div[1]/li[4]/a"));
        public IWebElement btnManageYourInstall => WebDriver.FindElement(By.XPath("/html/body/section[2]/div/div/div[1]/div/div/ul/li[7]/a"));
        public IWebElement txtManageYourInstallScreen => WebDriver.FindElement(By.XPath("/html/body/section[1]/div/div/div[2]/h1"));
        public IWebElement nvgInstallation => WebDriver.FindElement(By.XPath("/html/body/section[1]/div/div/div[1]/div/ul[3]/li[1]/a"));
        public IWebElement txtInstallating => WebDriver.FindElement(By.XPath("/html/body/section[1]/div/div/div[2]/h1"));
        public IWebElement btnSendUsEmail => WebDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/section/ul/li[1]/a"));
        public IWebElement btnHaveAquestionAboutYourInstall => WebDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/section/ul/li[1]/div/div/div/section/div/div[3]/a/div[1]/h3"));
        public IWebElement dropDownHowCanWeHelp => WebDriver.FindElement(By.XPath("/html/body/section[1]/div/div/div[2]/form/div[1]/div[2]/select"));
        public IWebElement btnSubmit => WebDriver.FindElement(By.XPath("/html/body/section[1]/div/div/div[2]/form/div[20]/div[2]/input"));
        public IWebElement cs_title_error => WebDriver.FindElement(By.XPath("//*[@id='cs_form']/div[3]/div[2]/label"));
        public IWebElement cs_first_name_error => WebDriver.FindElement(By.XPath("//*[@id='cs_form']/div[4]/div[2]/label"));
        public IWebElement cs_last_name_error => WebDriver.FindElement(By.XPath("//*[@id='cs_form']/div[5]/div[2]/label"));
        public IWebElement cs_address_1 => WebDriver.FindElement(By.XPath("//*[@id='cs_form']/div[12]/div[3]/div[2]/label"));
        public IWebElement cs_extra_enquiry => WebDriver.FindElement(By.XPath("//*[@id='cs_form']/div[16]/div[2]/label"));
        public IWebElement cs_preferred_contact => WebDriver.FindElement(By.XPath("//*[@id='cs_form']/div[17]/fieldset/label[1]"));


        public void Cookies() => btnCookie.Click();
        public void Help() => nvgHelp.Click();
        public void ManageYourInstall() => btnManageYourInstall.Click();
        public bool ManageYourInstallScreen() => txtManageYourInstallScreen.Displayed;
        public void click(String word) 
        {
            if (word.Equals(nvgInstallation.GetAttribute("innerHTML"), StringComparison.OrdinalIgnoreCase))
            {
                nvgInstallation.Click();
            } 
            else if (word.Equals(btnHaveAquestionAboutYourInstall.GetAttribute("innerHTML"), StringComparison.OrdinalIgnoreCase))
            {
                btnHaveAquestionAboutYourInstall.Click();
            } 
            else if (word.Equals(btnSendUsEmail.GetAttribute("innerHTML"), StringComparison.OrdinalIgnoreCase))
            {
                btnSendUsEmail.Click();
            }
        }
        public bool Installating() => txtInstallating.Enabled;
        //public void SendUsEmail() => btnSendUsEmail.Click();
        public bool DropDown() => btnSendUsEmail.GetAttribute("aria-selected").Equals("true");
       // public void HaveAquestionAboutYourInstall() => btnHaveAquestionAboutYourInstall.Click();
        public bool HowCanWeHelp() => dropDownHowCanWeHelp.Enabled;

        public void ChoiceHowCanWeHelp(String choice) {
            if (choice.Equals("A question about my install", StringComparison.OrdinalIgnoreCase))
            {
                dropDownHowCanWeHelp.Click();
                dropDownHowCanWeHelp.SendKeys(Keys.ArrowDown);
                dropDownHowCanWeHelp.SendKeys(Keys.Enter);
            }
            else {
                dropDownHowCanWeHelp.Click();
                dropDownHowCanWeHelp.SendKeys(Keys.ArrowDown);
                dropDownHowCanWeHelp.SendKeys(Keys.ArrowDown);
                dropDownHowCanWeHelp.SendKeys(Keys.Enter);
            }
        }

        public void Submit() => btnSubmit.Click();

        public void Error(String msg, String block) {

            switch (block) {

                case "Title":
                    Assert.True(msg.Equals(cs_title_error.GetAttribute("innerHTML"), StringComparison.OrdinalIgnoreCase));
                    break;

                case "First name":
                    Assert.True(msg.Equals(cs_first_name_error.GetAttribute("innerHTML"), StringComparison.OrdinalIgnoreCase));
                    break;

                case "Last name":
                    Assert.True(msg.Equals(cs_last_name_error.GetAttribute("innerHTML"), StringComparison.OrdinalIgnoreCase));
                    break;

                case "Address 1":
                    Assert.True(msg.Equals(cs_address_1.GetAttribute("innerHTML"), StringComparison.OrdinalIgnoreCase));
                    break;

                case "Preferred contact method":
                    Assert.True(msg.Equals(cs_preferred_contact.GetAttribute("innerHTML"), StringComparison.OrdinalIgnoreCase));
                    break;

                case "Your question":
                    Assert.True(msg.Equals(cs_extra_enquiry.GetAttribute("innerHTML"), StringComparison.OrdinalIgnoreCase));
                    break;

            }
        }
    }
}
