using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;




namespace NunitExample.Pages
{
    class UsersPage
    {
        IWebDriver webDriver;
        public UsersPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        #region Objects
        #endregion

        #region Methods
        public string editUserValidation()
        {

            webDriver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(20);
            webDriver.FindElement(By.XPath(".//*[@id='148ba346-c348-4d52-8a36-23a0d8999ead']/td[1]")).Click();
            webDriver.FindElement(By.XPath(".//*[@id='FirstName']")).SendKeys(Keys.Home);
            webDriver.FindElement(By.XPath(".//*[@id='FirstName']")).Clear();
            webDriver.FindElement(By.XPath(".//*[@id='FirstName']")).SendKeys(Keys.Space);

            webDriver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(20);

            webDriver.FindElement(By.XPath(".//*[@id='root']/div/main/div/div[2]/form/footer/button[2]")).Click();
            webDriver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(20);
            string validationError = webDriver.FindElement(By.CssSelector("#FirstName-helper-text")).Text; ;
            return validationError;
          
        }
        #endregion
        //*[@id="148ba346-c348-4d52-8a36-23a0d8999ead"]/td[3]
    }
}
