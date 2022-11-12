using AddressbookUiSelenium.Models;
using NUnit.Framework;

namespace AddressbookUiSelenium
{
    public class GroupDeleteTest : TestBase
    {
        [Test]
        public void TestDeleteContact()
        {
            app.ensureGroupPreconditions();
            app.goTo().groupPage();
            //app.group().
        }
    }
}