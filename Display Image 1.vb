Display Image 1
If the user touched the screen go to Step 8
Display Image 2
If the user touched the screen go to Step 8
Display Image 3
If the user touched the screen go to Step 8
Go to Step 1
Display Text "Welcome to ATM"
Display Text "Insert Card"
Get user card
Validate card if account exists go to Step 13
If card is invalid Display Text "Invalid Card" return card and go to Step 1
Display Text "Enter Pin"
If the user entered the correct pin go to Step 18
If the user entered the incorrect pin Display Text "Invalid Pin" go to Step 13
If the user entered the incorrect pin for 2nd time Display Text "Invalid Pin" go to Step 13
If the user entered the incorrect pin for 3rd time Display Text "Invalid Pin" return card and go to Step 1
Display Text "Select 1 for Withdraw"
Display Text "Select 2 for Deposit"
Display Text "Select 3 for Check Balance"
Display Text "Select 4 for EXIT"
Declare and initialize Balance, Withdraw, and Deposit
Initial ATMbalance = 25000
Initial Withdraw, Deposit, Balance
Get user selected option
If user selected 1 Withdraw go to Step 27
Display Text "Select 1 for Checkings"
Display Text "Select 2 for Savings"

Display Text "Enter Amount to be Withdrawn"
Check withdraw amount from user if it is less than or equal to ATMbalance 
If yes go to Step 30
If no Display Text "ATM Insufficient Funds" go to Step 26
Check withdraw amount from user if it less than or equal to UserBalance
If yes go to Step *
If no Display Text "Insufficient Funds" go to Step 26
Accept withdraw amount withdrawAmount - userBalance = dispensedAmount
Display Text "Please take your card, funds will be dispensed after"
Return card, print reciept, dispense funds
If user selected 2 Deposit got to Step *
Display Text "Enter Amount to be Deposited"
Accept the depositAmount from user
