using AddressbookUiSelenium.Models;
using NUnit.Framework;

namespace AddressbookUiSelenium
{
    public class GroupDeleteTest : TestBase
    {
        [SetUp]
        public void ensurePreconditions()
        {
            app.goTo().groupPage();
            var group = new Group().withName("New group").withHeader("New Header").withFooter("New footer");
            if (!(app.group().getGroups().Count>0))
            {
                app.group().createNew(group);
            }
        }

        [Test]
        public void TestDeleteContact()
        {
            app.goTo().groupPage();
            //app.group().
        }
    }
}