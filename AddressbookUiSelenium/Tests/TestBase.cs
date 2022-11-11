using AddressbookUiSelenium.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AddressbookUiSelenium
{
    public class TestBase
    {
        protected IWebDriver Driver;
        protected const string Url = "http://localhost/addressbook/";
        protected const string Login = "admin";
        protected const string Password = "secret";

        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
        }
        

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}