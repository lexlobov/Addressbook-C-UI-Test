using OpenQA.Selenium;

namespace AddressbookUiSelenium.PageObjects
{
    public class GroupCreatePage : BasePage
    {
        public By NameField => By.Name("group_name");
        public By HeaderField => By.Name("group_header");
        public By FooterField => By.Name("group_footer");
        public By SubmitBtn => By.Name("submit");
        
    }
}