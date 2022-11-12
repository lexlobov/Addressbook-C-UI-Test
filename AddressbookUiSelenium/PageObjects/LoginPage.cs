using OpenQA.Selenium;

namespace AddressbookUiSelenium.PageObjects
{
    public class LoginPage : BasePage
    {

        public By LoginField => By.Name("user");
        public By PasswordField => By.Name("pass");
        public By LoginBtn => By.XPath("//input[@type='submit']");
        
    }
}