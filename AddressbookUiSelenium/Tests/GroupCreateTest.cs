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
            var group = new Group().withName("New group").withHeader("New Header").withFooter("New footer");

            app.goTo().groupPage();
            
            var before = app.group().getGroups();
            
            app.group().createNew(group);
            app.goTo().groupPage();

            var after = app.group().getGroups();
            
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