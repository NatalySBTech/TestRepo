using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace NunitExample.Pages
{
    class DashboardPage
    {
        IWebDriver webDriver;
        public DashboardPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        #region Objects
        private IWebElement HealthMonitorLink
        {
            get {
                return webDriver.FindElement(By.CssSelector("#root > div > div > div > ul > a:nth-child(2)"));
            }
        }
        #endregion

        #region Methods
        public string goToEposPage()
        {
            //webDriver.Manage().Timeouts().AsynchronousJavaScript= System.TimeSpan.FromMilliseconds(30);
            webDriver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(20);
            var header = webDriver.FindElement(By.CssSelector("#root > div > main > div > div:nth-child(1) > div > h5"));
            string DashboardPageTitle = header.Text;
            webDriver.Manage().Timeouts().AsynchronousJavaScript = System.TimeSpan.FromMilliseconds(30);
            HealthMonitorLink.Click();
            return DashboardPageTitle;
        }
        #endregion

    }
}
