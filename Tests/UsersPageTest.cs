using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NunitExample.Pages;



namespace NunitExample
{
    //[TestFixture] // attribute
    public class UsersPageTest
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
            webDriver.Navigate().GoToUrl("http://retail-emp.testing.sbtech.com/");
        }
   

        [Test]
        public void EditUser()
        {
            DashboardPage ObjDashboardPage = new DashboardPage(webDriver);
            ObjDashboardPage.goToUsersPage();
            webDriver.Manage().Timeouts().AsynchronousJavaScript = System.TimeSpan.FromMilliseconds(30);

            UsersPage ObjUsersPage = new UsersPage(webDriver);
            string mandatoryError = ObjUsersPage.editUserValidation();
            Assert.AreEqual("This field is mandatory", mandatoryError);
        }
        [TearDown]
        public void Close() {
            webDriver.Quit();
        }

    }
}
