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
            var group = new Group().withName("New group").withHeader("New Header").withFooter("New footer");
            var loginPage = new LoginPage(Driver);
            var mainPage = loginPage.Login(Login, Password);
            var groupPage = mainPage.GoToGroupPage();
            var before = groupPage.getGroups();
            var groupCreatePage = groupPage.GoToGroupCreatePage();
            
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

            Assert.AreEqual(beforeSorted,afterSorted);
        }
        
    }
}