using OpenQA.Selenium;

namespace WebTest.Webpage.Pages
{
    class ShippingPage
    {
        public IWebDriver WebDriver { get; }
        public ShippingPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement blockterms => WebDriver.FindElement(By.Id("cgv"));

        public void terms() => blockterms.Click();

        public IWebElement btncheckout4 => WebDriver.FindElement(By.XPath("//*[@id='form']/p/button"));

        public void checkout4() => btncheckout4.Click();
    }
}
