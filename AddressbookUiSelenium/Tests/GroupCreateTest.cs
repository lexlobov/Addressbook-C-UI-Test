using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using AddressbookUiSelenium.Models;
using AddressbookUiSelenium.PageObjects;
using NUnit.Framework;

namespace AddressbookUiSelenium
{
    public class GroupCreateTest : TestBase
    {
        
        [Test]
        public void TestGroupCreate()
        {
            Driver.Navigate().GoToUrl(Url);
            Group group = new Group().withName("New group").withHeader("New Header").withFooter("New footer");
            LoginPage loginPage = new LoginPage(Driver);
            MainPage mainPage = loginPage.Login(Login, Password);
            GroupPage groupPage = mainPage.GoToGroupPage();
            var before = groupPage.getGroups();
            GroupCreatePage groupCreatePage = groupPage.GoToGroupCreatePage();
            groupCreatePage.createGroup(group);
            Assert.True(groupPage.GroupsHeader.Displayed);
            var after = groupPage.getGroups();
            before.Add(group
                .withFooter(null)
                .withHeader(null)
                .withId(
                after.Select(g=>g.Id).Max()));
            var beforeSorted = before.OrderBy(g => g.Id).ToList();
            var afterSorted = after.OrderBy(g => g.Id).ToList();
            Console.WriteLine(after[^1]);

            Assert.AreEqual(beforeSorted,afterSorted);
        }
        
    }
}