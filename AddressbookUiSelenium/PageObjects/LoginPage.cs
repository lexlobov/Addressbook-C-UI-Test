using OpenQA.Selenium;

namespace AddressbookUiSelenium.PageObjects
{
    public class LoginPage : BasePage
    {

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        
        private IWebElement LoginField => Driver.FindElement(By.Name("user"));
        private IWebElement PasswordField => Driver.FindElement(By.Name("pass"));
        private IWebElement LoginBtn => Driver.FindElement(By.XPath("//input[@type='submit']"));

        public MainPage Login(string login, string password)
        {
            LoginField.SendKeys(login);
            PasswordField.SendKeys(password);
            LoginBtn.Click();
            MainPage mainPage = new MainPage(Driver);
            return mainPage;
        }

        
    }
}