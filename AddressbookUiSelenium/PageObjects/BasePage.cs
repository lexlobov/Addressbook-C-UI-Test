using OpenQA.Selenium;

namespace AddressbookUiSelenium.PageObjects
{
    public class BasePage
    {
        protected IWebDriver Driver;
        public IWebElement HomeLink =>Driver.FindElement(By.LinkText("home"));
        public  IWebElement AddNewLink =>Driver.FindElement(By.LinkText("add new"));
        public  IWebElement GroupsLink =>Driver.FindElement(By.LinkText("groups"));
        public  IWebElement NextBirthdaysLink =>Driver.FindElement(By.LinkText("next birthdays"));

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
        
        public GroupPage GoToGroupPage()
        {
            GroupsLink.Click();
            return new GroupPage(Driver);
        }
        
        
    }
}