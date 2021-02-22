using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DemoTest.com.Test.Vivek.PageClasses
{
    public class TShirtPage
    {


        private IWebDriver driver = null;

        public TShirtPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By btnInStock = By.XPath("//*[contains(@class,'available-now')]");

        private By btnAddToCart = By.XPath("//*[contains(text(),'Add to cart')]");

        private By btnProceedToCheckOut = By.XPath("//*[contains(text(),'Proceed to checkout')]");

        private By btnProceedToCheckOut2 = By.XPath("//*[contains(text(),'Proceed to checkout')]");

        private By txtAddress = By.XPath("//*[@class='address_address1']");

        private By dropdownAddress = By.Id("id_address_delivery");

        private By checkboxTermsOfService = By.XPath("//p[@class='checkbox']//input");

        private By productName = By.XPath("(//p[@class='product-name']/a)[2]");

        private By summaryPage = By.Id("cart_summary");

        private By postCode = By.XPath("//*[contains(@class,'address_postcode')]");

        private By optionPayByBank = By.XPath("//a[contains(text(),'Pay by bank wire')]");

        private By btnIConfirmOrder = By.XPath("//*[@class='cart_navigation clearfix']//span[contains(text(),'I confirm my order')]");

        private By txtConfirmOrder = By.XPath("//*[contains(text(),'Your order on My Store is complete.')]");

        private By lnkBackToOrder = By.XPath("//*[text()='Back to orders']");

        private By tblOrder = By.XPath("//*[@id='order-list']");
        public void NavigateToAddCart()
        {
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(btnInStock)).Build().Perform();

            driver.FindElement(btnAddToCart).Click();

        }

        public Boolean isSummaryPageDisplayed()
        {
           if(driver.FindElement(summaryPage).Displayed)
            {
                return true;
            }
           else
            {
                return false;
            }

        }

        public String getProductNameInCart()
        {
            
            return driver.FindElement(productName).Text;
           


        }

        public void clickOnProceedToCheckOut()
        {
            try
            {
                driver.FindElement(btnProceedToCheckOut).Click();
            }
            catch(Exception e)
            {
              
                ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0, 900)");
                
                driver.FindElement(By.XPath("//*[@class='cart_navigation clearfix']//span[contains(text(),'Proceed to checkout')]")).Click();
            }
        }

        public String getAddressDetails()
        {
            return driver.FindElement(postCode).Text;
        }

        public Boolean isAddressPageDisplayed()
        {
            if(driver.FindElement(postCode).Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       public Boolean isShippingPageDisplayed()
        {
            driver.FindElement(checkboxTermsOfService).Click();
            return driver.FindElement(checkboxTermsOfService).Displayed;
        }

        public void AcceptTermsAndConditions()
        {
            driver.FindElement(checkboxTermsOfService).Click();
        }


        public void SelectPaymentMethod(String paymentMethod)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0, 400)");
            driver.FindElement(By.XPath("//a[contains(text(),'"+ paymentMethod + "')]")).Click();
        }

        public void ConfirmOrder()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0, 900)");
            driver.FindElement(btnIConfirmOrder).Click();
        }

        public String getOrderConfirmation()
        {
            return driver.FindElement(txtConfirmOrder).Text;
        }

        public void ClickOnBackToOrders()
        {
            driver.FindElement(lnkBackToOrder).Click();
        }

        public Boolean verifyOrderTable()
        {
            if(driver.FindElement(tblOrder).Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
