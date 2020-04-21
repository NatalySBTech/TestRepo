using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;




namespace NunitExample.Pages
{
    class HealthMonitorPage
    {
        IWebDriver webDriver;
        public HealthMonitorPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        #region Objects
        #endregion

        #region Methods
        public string getHealthMonitorPageTitle()
        {
            string  HealthMonitorPageTitle = webDriver.FindElement(By.CssSelector("#root > div > main > div > div.makeStyles-header-351 > div.makeStyles-actionsWrap-352 > h1")).Text; ;
            return HealthMonitorPageTitle;
        }
        #endregion

    }
}
