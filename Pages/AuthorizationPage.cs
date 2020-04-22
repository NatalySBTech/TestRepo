using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace NunitExample.Pages
{
    class AuthorizationPage
    {
        IWebDriver webDriver;
        public AuthorizationPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        #region Objects
        private IWebElement LoginButton
        {
            get {
                return webDriver.FindElement(By.XPath(".//*[@id='login']/div/form/div[3]/button"));
            }
        }
        #endregion

        #region Methods
        public void Login()
        {
            webDriver.FindElement(By.XPath(".//*[@id='user']")).SendKeys("admin");
            webDriver.FindElement(By.XPath(".//*[@id='password']")).SendKeys("admin");
            LoginButton.Click();
            webDriver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(60);

        }

        #endregion
    }
}
