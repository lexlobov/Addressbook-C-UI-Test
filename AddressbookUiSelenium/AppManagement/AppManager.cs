using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AddressbookUiSelenium.AppManagement
{
    public class AppManager
    {
        private IWebDriver driver;
        private GroupHelper groupHelper;
        private NavigationHelper navigationHelper;
        private ContactHelper contactHelper;
        private DbHelper dbHelper;
        private SessionHelper sessionHelper;
        
        private const string Login = "admin";
        private const string Password = "secret";
        private const string Url = "http://localhost/addressbook/";
        
        public void init()
        {
            driver = new ChromeDriver();
            groupHelper = new GroupHelper(driver);
            navigationHelper = new NavigationHelper(driver);
            contactHelper = new ContactHelper(driver);
            sessionHelper = new SessionHelper(driver);
            driver.Navigate().GoToUrl(Url);
            sessionHelper.login(Login, Password);
        }
        
        public GroupHelper group() {
            return groupHelper;
        }

        public NavigationHelper goTo() {
            return navigationHelper;
        }

        public DbHelper db(){
            return dbHelper;
        }

        public SessionHelper session()
        {
            return sessionHelper;
        }
        
        public void stop() {
            driver.Quit();
        }
        
    }
}