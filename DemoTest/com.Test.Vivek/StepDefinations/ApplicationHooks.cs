using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using DemoTest.com.Test.Vivek.PageClasses;
using OpenQA.Selenium;
using DemoTest.com.Test.Vivek.Utility;
namespace DemoTest.com.Test.Vivek.StepDefinations
{
    public class ApplicationHooks
    {
        public IWebDriver driver = null;

        [Before]
        public void StartBrowSer()
        {

            driver = DriverFactory.InitateBrowser();

        }

        [After]
        public void CloseBrowser()
        {

            driver.Close();

        }

    }
}
