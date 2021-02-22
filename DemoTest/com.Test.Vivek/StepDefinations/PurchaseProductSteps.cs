using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using DemoTest.com.Test.Vivek.PageClasses;

namespace DemoTest.com.Test.Vivek.StepDefinations
{
  
    public class PurchaseProductSteps:ApplicationHooks
    {

        LandingPage objLP = null;
        LoginPage objLogin = null;
        HomePage objHP = null;
        TShirtPage objTshirt = null;
        [Given(@"User has successfully navigated to the application")]
        public void GivenUserHasSuccessfullyNavigatedToTheApplication()
        {

            objLP = new LandingPage(driver);
            Assert.AreEqual("My Store", objLP.returnLandingPageTitle());

        }
        
        [Given(@"User click on Login link")]
        public void GivenUserClickOnLoginLink()
        {
            driver = objLP.clickonLogin();

            objLogin = new LoginPage(driver);

        }
        
        [When(@"User enters username ""(.*)"" and password ""(.*)""")]
        public void WhenUserEntersUsernameAndPassword(string username, string password)
        {
            driver = objLogin.PerformLogin(username, password);
        }
        

        [When(@"User clicks on tshirt")]
        public void WhenUserClicksOnTshirt()
        {
            objHP = new HomePage(driver);
            driver = objHP.clickOnTshirtLink();
            objTshirt = new TShirtPage(driver);
        }
        
        [When(@"User mouse hover the ""(.*)""")]
        public void WhenUserMouseHoverThe(string p0)
        {
            objTshirt.NavigateToAddCart();
        }
        
      
        [When(@"User clicks on Proceed to checkout option")]
        public void WhenUserClicksOnProceedToCheckoutOption()
        {
            objTshirt.clickOnProceedToCheckOut();
        }
        
        [When(@"User chooses ""(.*)""")]
        public void WhenUserChooses(string PaymentMethod)
        {
            objTshirt.SelectPaymentMethod(PaymentMethod);
        }
        
        [When(@"User clicks on I can confirm my order option")]
        public void WhenUserClicksOnICanConfirmMyOrderOption()
        {
            objTshirt.ConfirmOrder();
        }

        [Then(@"user navigates to the summary tab")]
        public void ThenUserNavigatesToTheSummaryTab()
        {
            Assert.IsTrue(objTshirt.isSummaryPageDisplayed());
        }
        
        [Then(@"User can verify his ""(.*)""")]
        public void ThenUserCanVerifyHis(string productName)
        {
            Assert.AreEqual(objTshirt.getProductNameInCart(), productName);
        }
        
        [Then(@"user navigates to the Address Tab")]
        public void ThenUserNavigatesToTheAddressTab()
        {
            Assert.IsTrue(objTshirt.isAddressPageDisplayed());
        }

        [Then(@"User can verify his Address details ""(.*)""")]
        public void ThenUserCanVerifyHisAddressDetails(string Address)
        {

            Assert.AreEqual(Address, objTshirt.getAddressDetails());

        }

        [Then(@"user navigates to the Shipping Tab")]
        public void ThenUserNavigatesToTheShippingTab()
        {
          //  Assert.IsTrue(objTshirt.isShippingPageDisplayed());
            
        }
        
        [Then(@"User accepts the terms and conditions")]
        public void ThenUserAcceptsTheTermsAndConditions()
        {
            objTshirt.AcceptTermsAndConditions();
        }
                
        [Then(@"User can see the final confirmation")]
        public void ThenUserCanSeeTheFinalConfirmation()
        {
            Assert.AreEqual("Your order on My Store is complete.", objTshirt.getOrderConfirmation());
        }
        
        [Then(@"User can see the order history")]
        public void ThenUserCanSeeTheOrderHistory()
        {
            Assert.IsTrue(objTshirt.verifyOrderTable());
        }

        [When(@"User clicks on the Back to order")]
        public void WhenUserClicksOnTheBackToOrder()
        {
            objTshirt.ClickOnBackToOrders();
        }

    }
}
