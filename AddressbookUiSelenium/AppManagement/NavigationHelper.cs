using AddressbookUiSelenium.PageObjects;
using OpenQA.Selenium;

namespace AddressbookUiSelenium.AppManagement
{
    public class NavigationHelper : BaseHelper
    {
        public NavigationHelper(IWebDriver driver) : base(driver)
        {
        }

        public void groupPage()
        {
            click(gp.GroupsLink);
        }

        public void mainPage()
        {
            click(mp.HomeLink);
        }

        public void addContactPage()
        {
            click(mp.AddNewLink);
        }
        
        

    }
}