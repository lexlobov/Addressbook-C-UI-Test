using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using AddressbookUiSelenium.Models;
using AddressbookUiSelenium.PageObjects;
using OpenQA.Selenium;

namespace AddressbookUiSelenium.AppManagement
{
    public class GroupHelper : BaseHelper
    {
        public GroupHelper(IWebDriver driver) : base(driver)
        {
        }

        public List<Group> getGroups()
        {
            return findAll(gp.groupCheckboxes).Select(g => new Group().withName(g.Text)
                    .withId(Convert.ToInt32(g.FindElement(By.TagName("input")).GetAttribute("value"))))
                .ToList();
        }

        public void createNew(Group group)
        {
            click(gp.NewBtn);
            type(gcp.NameField, group.GroupName);
            type(gcp.HeaderField, group.GroupHeader);
            type(gcp.FooterField, group.GroupFooter);
            click(gcp.SubmitBtn);
        }
    }
}