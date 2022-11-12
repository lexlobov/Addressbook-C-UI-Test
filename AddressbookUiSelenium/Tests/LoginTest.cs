using NUnit.Framework;

namespace AddressbookUiSelenium
{
    public class Tests : TestBase
    {
        [Test]
        public void TestLogin()
        {
            Assert.True(app.session().isLoggedIn());
        }
    }
}