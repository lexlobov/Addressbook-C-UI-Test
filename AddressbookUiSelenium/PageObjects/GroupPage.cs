using System;
using System.Collections.Generic;
using System.Linq;
using AddressbookUiSelenium.Models;
using OpenQA.Selenium;

namespace AddressbookUiSelenium.PageObjects
{
    public class GroupPage : BasePage
    {
        public GroupPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement NewBtn => Driver.FindElement(By.Name("new"));
        public IEnumerable<IWebElement> groupCheckboxes => Driver.FindElements(By.CssSelector("span.group"));
        public IWebElement GroupsHeader => Driver.FindElement(By.XPath("//h1[text()='Groups']"));

        public GroupCreatePage GoToGroupCreatePage()
        {
            NewBtn.Click();
            return new GroupCreatePage(Driver);
        }
        
        public List<Group> getGroups()
        {
            return groupCheckboxes.Select(@group => new Group().withName(@group.Text)
                    .withId(Convert.ToInt32(@group.FindElement(By.TagName("input")).GetAttribute("value"))))
                .ToList();
        }

    }
}