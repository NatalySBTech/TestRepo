using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NunitExample.Pages;



namespace NunitExample
{
    //[TestFixture] // attribute
    public class EposPageTest
    {
        IWebDriver webDriver;
      //  public EposPageTest(IWebDriver webDriver)
       // {
      //      this.webDriver = webDriver;
      //  }
        [SetUp]
        public void InitBrowser()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Cookies.DeleteAllCookies();
            webDriver.Navigate().GoToUrl("http://retail-emp.testing.sbtech.com");
        }
   

        [Test]
        public void OpenEposPage()
        {
            HealthMonitorPage ObjHealthMonitorPage = new HealthMonitorPage(webDriver);
            DashboardPage ObjDashboardPage = new DashboardPage(webDriver);
            string dashboardPageTtl = ObjDashboardPage.goToEposPage();
            Assert.AreEqual("Dashboard", dashboardPageTtl);
            string healthMonitorPageTtl = ObjHealthMonitorPage.getHealthMonitorPageTitle();
            Assert.AreEqual("Health Monitor", healthMonitorPageTtl);
        }
        [TearDown]
        public void Close() {
            webDriver.Quit();
        }

    }
}
