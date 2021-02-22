using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
namespace DemoTest.com.Test.Vivek.PageClasses
{
    public class HomePage
    {

        IWebDriver driver = null;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By tShirt = By.XPath("//*[contains(text(),'T-shirts')]");

        public IWebDriver clickOnTshirtLink()
        {
            driver.FindElement(By.XPath("//*[contains(@class,'sf-menu')]/li[3]")).Click();
            return driver;
        }


    }
}
