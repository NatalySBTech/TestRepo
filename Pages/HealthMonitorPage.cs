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
            string  HealthMonitorPageTitle = webDriver.FindElement(By.CssSelector("#root > div > main > div.MuiBox-root.MuiBox-root-298 > h5")).Text; ;
            return HealthMonitorPageTitle;
        }
        #endregion

    }
}
