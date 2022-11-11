using AddressbookUiSelenium.Models;
using OpenQA.Selenium;

namespace AddressbookUiSelenium.PageObjects
{
    public class GroupCreatePage : BasePage
    {
        public GroupCreatePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement NameField => Driver.FindElement(By.Name("group_name"));
        public IWebElement HeaderField => Driver.FindElement(By.Name("group_header"));
        public IWebElement FooterField => Driver.FindElement(By.Name("group_footer"));
        public IWebElement SubmitBtn => Driver.FindElement(By.Name("submit"));
        
        public void createGroup(Group group)
        {
            NameField.SendKeys(group.GroupName);
            HeaderField.SendKeys(group.GroupHeader);
            FooterField.SendKeys(group.GroupFooter);
            SubmitBtn.Click();
            GoToGroupPage();
        }


    }
}