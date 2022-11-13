using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using AddressbookUiSelenium.Models;
using AddressbookUiSelenium.PageObjects;
using NUnit.Framework;
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
            fillGroupForm(group);
            click(gcp.SubmitBtn);
        }

        private void fillGroupForm(Group group)
        {
            clearEntryField(gcp.NameField);
            type(gcp.NameField, @group.GroupName);
            clearEntryField(gcp.HeaderField);
            type(gcp.HeaderField, @group.GroupHeader);
            clearEntryField(gcp.FooterField);
            type(gcp.FooterField, @group.GroupFooter);
        }

        public Group randomGroupFromList()
        {
            var rand = new Random();
            List<Group> groups = getGroups();
            var modifiedGroup = groups[rand.Next(groups.Count)];
            return modifiedGroup;
        }

        public void modify(Group modifiedGroupInList, Group newModifiedGroup)
        {
            click(By.CssSelector("input[value='" + modifiedGroupInList.Id + "']"));
            click(By.Name("edit"));
            fillGroupForm(newModifiedGroup);
            click(gcp.UpdateBtn);
        }
    }
}