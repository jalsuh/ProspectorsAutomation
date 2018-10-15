using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using ProspectorsAutomation;

namespace ProspectorsAutomation.PageObjects
{
    class LOLALoginScreen : BaseTest
    {
        public LOLALoginScreen() { }
        public LOLALoginScreen(IWebElement webElement) { }

       

        public IWebElement userTxtBox => driver.FindElement(By.Id("id_username"));
        public IWebElement passwordTxtBox => driver.FindElement(By.Id("id_password"));
        public IWebElement loginBtn => driver.FindElement(By.Id("id_submit"));

    }
}
