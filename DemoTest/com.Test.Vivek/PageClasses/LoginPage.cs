using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
namespace DemoTest.com.Test.Vivek.PageClasses
{
    public class LoginPage
    {

        IWebDriver driver = null;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By txtEmail = By.Id("email");
        private By txtPassword = By.Id("passwd");
        private By btnSignIn = By.Id("SubmitLogin");
        public IWebDriver PerformLogin(String username, String password)
        {
            driver.FindElement(txtEmail).SendKeys(username);
            driver.FindElement(txtPassword).SendKeys(password);
            driver.FindElement(btnSignIn).Click();
            return driver;
        }


    }
}
