Feature: Web Test

Background: User Log in
	Given the website 'http://automationpractice.com/index.php' has loaded
	And User clicks on Sign in Page 
	And enters his credentials
	| Email                     | password |
	| vedanth.vasudev@gmail.com | abcdef   |
	And clicks Submit
	Then assert he enters his home page


Scenario Outline: Order T-shirt (and Verify in order history)
	#Code can be used in future as the item could be changed according to user requirement
	When User Search for <Item>
	And User clicks on the add to cart
	And clicks on proceed to checkout
	And user clicks proceed to checkout
	And user clicks on proceed to checkout
	And Agrees to terms and condition
	And user clicks on proceed to checkout in shipping
	And user chooses <Payment>
	And user clicks on I confirm my order
	Then confirm the order is complete
	When clicked on your account
	And navigate the order history and details
	Then confirm the Item is present with <Payment>
	And Close the browser

	Examples:
	| Test              | Item     | Payment   |
	| Bank Wire T-shirt | T-shirts | bank wire |
	| Cheque T-shirt    | T-shirts | cheque    |



Scenario Outline: Update Personal Information(First Name)in My Accounts 
	When clicked on your account
	And go into personal information tab
	And update the <firstName>
	And Enter the <password>
	And click save
	Then assert the update was successful
	And Close the browser

	Examples: 
	| test | firstName | password |
	| name | Vedanth   | abcdef   |