using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace DemoTest.com.Test.Vivek.Utility
{
    class DriverFactory
    {

        static IWebDriver driver = null;
        public static IWebDriver InitateBrowser()
        {
            String BrowserName = ConfigurationManager.AppSettings["Browser"];
            String URL = "http://automationpractice.com/";
            if(BrowserName.ToLower().Equals("chrome"))
            {
                driver = new ChromeDriver();
            }
            
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(5);
            return driver;
        }

        public static void QuitBrowser()
        {
            driver.Quit();
        }
        


    }
}
