using OpenQA.Selenium;

namespace AddressbookUiSelenium.PageObjects
{
    public class BasePage
    {
        public By HomeLink =>By.LinkText("home");
        public  By AddNewLink =>By.LinkText("add new");
        public  By GroupsLink =>By.LinkText("groups");
        public  By NextBirthdaysLink =>By.LinkText("next birthdays");
        
    }
}