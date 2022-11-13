using System.Linq;
using AddressbookUiSelenium.Models;
using NUnit.Framework;

namespace AddressbookUiSelenium
{
    public class GroupModifyTest : TestBase
    {
        [Test]
        public void TestModifyGroup()
        {
            app.ensureGroupPreconditions();
            
            var newModifiedGroup = new Group()
                .withName("Modified group name")
                .withHeader("Modified group Header")
                .withFooter("Modified group footer");
            
            app.goTo().groupPage();
            var before = app.group().getGroups();
            var modifiedGroupFromList = app.group().randomGroupFromList();
            app.group().modify(modifiedGroupFromList, newModifiedGroup);
            app.goTo().groupPage();
            var after = app.group().getGroups();

            var modifiedId = modifiedGroupFromList.Id;

            before.Remove(modifiedGroupFromList);
            before.Add(newModifiedGroup
                .withFooter(null)
                .withHeader(null)
                .withId(modifiedId));
            
            
            var beforeSorted = before.OrderBy(g => g.Id).ToList();
            var afterSorted = after.OrderBy(g => g.Id).ToList();
            
            Assert.AreEqual(beforeSorted,afterSorted);
        }
    }
}