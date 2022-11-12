using System.Collections.Generic;
using AddressbookUiSelenium.PageObjects;
using OpenQA.Selenium;

namespace AddressbookUiSelenium.AppManagement
{
    public class BaseHelper
    {
        protected IWebDriver driver;

        public BaseHelper(IWebDriver driver){
            this.driver=driver;
        }
        protected GroupPage gp = new GroupPage();
        protected LoginPage lp = new LoginPage();
        protected MainPage mp = new MainPage();
        protected GroupCreatePage gcp = new GroupCreatePage();


        protected void type(By locator, string text)
        {
            driver.FindElement(locator).SendKeys(text);
        }
        
        protected void click(By locator){
            driver.FindElement(locator).Click();
        }

        protected void clickAlert()
        {
            driver.SwitchTo().Alert().Accept();
        }

        protected IWebElement find(By locator)
        {
            return driver.FindElement(locator);
        }

        protected List<IWebElement> findAll(By locator)
        {
            return new List<IWebElement>(driver.FindElements(locator));
        }

        protected void login(string login, string password)
        {
            
        }

    }
}