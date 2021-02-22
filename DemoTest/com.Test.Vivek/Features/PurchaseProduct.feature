Feature: PurchaseProduct
	In order to purchase product
	As a valid user
	I want to purchase product and verify order history

Scenario Outline: Purchase product and verify purchase history
	Given User has successfully navigated to the application
	And User click on Login link
	When User enters username "<username>" and password "<password>"
	When User clicks on tshirt
	When User mouse hover the "<DesireOption>"
	When User clicks on Proceed to checkout option 
	Then user navigates to the summary tab
 	And User can verify his "<CorrectProduct>"
	When User clicks on Proceed to checkout option
	Then user navigates to the Address Tab
	And User can verify his Address details "<AddressDetails>"
	When User clicks on Proceed to checkout option
	Then user navigates to the Shipping Tab
	And User accepts the terms and conditions
	When User clicks on Proceed to checkout option
	When User chooses "<PaymentMethod>"
	And User clicks on I can confirm my order option 
	Then User can see the final confirmation
	When User clicks on the Back to order
	Then User can see the order history 
Examples: 
| username                | password       | DesireOption | CorrectProduct                        | AddressDetails                   | PaymentMethod             |
| khotvivek1393@gmail.com | OATP@ssword123 | tShirt       | Faded Short Sleeve T-shirts           | TestCity, Alaska 99501           | Pay by bank wire          |





