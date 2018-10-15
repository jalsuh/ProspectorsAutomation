using Microsoft.VisualStudio.TestTools.UnitTesting;
using QAPOW_SeleniumCSharp_DriverUtils;
using OpenQA.Selenium;
using QAPOW_SeleniumCSharp_UIUtils;
using ProspectorsAutomation.PageObjects;

namespace ProspectorsAutomation
{
    [TestClass]
    public class LOLALoginTest : BaseTest
    {
        // Create instnce of WebDriver
        //  public static IWebDriver _webdriver = driver;

        //  public SampleTest(IWebDriver driver) {  }

        LOLALoginScreen ls = new LOLALoginScreen(); 


        public LOLALoginTest() { }
            
        [TestMethod]
        public void TestMethod1()
        {
           
            driver.Navigate().GoToUrl("http://lolatestfe/");

            // ls.userTxtBox.SendKeys("");

            ls.userTxtBox.SendKeys("jsuhra01");
            ls.passwordTxtBox.SendKeys("rock123");
            ls.loginBtn.Click(); 

        }
    }
}
