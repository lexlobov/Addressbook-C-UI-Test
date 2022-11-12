using OpenQA.Selenium;

namespace AddressbookUiSelenium.AppManagement
{
    public class SessionHelper : BaseHelper
    {
        public SessionHelper(IWebDriver driver) : base(driver)
        {
        }

        public void login(string userName, string password)
        {
            type(lp.LoginField, userName);
            type(lp.PasswordField, password);
            click(lp.LoginBtn);
        }

        public bool isLoggedIn()
        {
            return find(mp.HomeLink).Displayed;
        }
    }
}