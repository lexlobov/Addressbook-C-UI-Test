using System;
using System.Collections.Generic;
using System.Linq;
using AddressbookUiSelenium.Models;
using OpenQA.Selenium;

namespace AddressbookUiSelenium.PageObjects
{
    public class GroupPage : BasePage
    {
        public By NewBtn => By.Name("new");
        public By groupCheckboxes => By.CssSelector("span.group");
        public By GroupsHeader => By.XPath("//h1[text()='Groups']");

        


    }
}