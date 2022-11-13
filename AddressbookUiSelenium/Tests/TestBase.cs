using AddressbookUiSelenium.AppManagement;
using NUnit.Framework;

namespace AddressbookUiSelenium
{
    public class TestBase
    {
        protected AppManager app = new AppManager();

        [SetUp]
        public void SetUp()
        {
            app.init();
        }
        

        [TearDown]
        public void TearDown()
        {
            app.stop();
        }
    }
}