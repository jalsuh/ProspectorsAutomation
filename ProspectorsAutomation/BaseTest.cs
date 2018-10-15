using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QAPOW_SeleniumCSharp_DriverUtils;
using QAPOW_SeleniumCSharp_UIUtils;
//using OSCEUITest.PageObjects;
using System.IO;
using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Remote;
using OpenQA.Selenium.IE;
using ProspectorsAutomation.PageObjects;

namespace ProspectorsAutomation
{
    public class BaseTest
    {
        public static IWebDriver driver;
      //public static LOLALoginScreen ls = new LOLALoginScreen();



        [ClassInitialize]
        public void TestClassInitialize(TestContext context)
        {

            

        }

        [TestInitialize]
        public void Initialize()
        {
            InternetExplorerOptions IEcaps = new InternetExplorerOptions();
            IEcaps.IgnoreZoomLevel = true;
            IEcaps.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            IEcaps.RequireWindowFocus = true;
            driver = new InternetExplorerDriver(IEcaps);
            driver.Manage().Window.Maximize();
            //isInitialized = true;
            driver.Navigate().GoToUrl("http://lolatestfe/");

        }

        [TestCleanup]
        public void TearDown()
        {
            // _webdriver.Close();
           // UIUtils.ExitCriteria(_webdriver);
        }
    }

}
