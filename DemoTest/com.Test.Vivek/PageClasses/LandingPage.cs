using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
namespace DemoTest.com.Test.Vivek.PageClasses
{
    class LandingPage
    {
        IWebDriver driver = null;

        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By LinkLogin = By.ClassName("login");

        public String returnLandingPageTitle() // MyStore
        {
            return driver.Title;
        }
        public IWebDriver clickonLogin()
        {
            driver.FindElement(LinkLogin).Click();
            return driver;
        }

    }
}
