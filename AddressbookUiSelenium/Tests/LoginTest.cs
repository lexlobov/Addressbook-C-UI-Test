using AddressbookUiSelenium.PageObjects;
using NUnit.Framework;

namespace AddressbookUiSelenium
{
    public class Tests : TestBase
    {
        
        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl(Url);
            LoginPage loginPage = new LoginPage(Driver);
            MainPage mainPage = loginPage.Login(Login, Password);
            Assert.True(mainPage.HomeLink.Displayed);
        }


        
    }
}