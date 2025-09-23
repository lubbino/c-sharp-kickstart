# Simple Banking System Project

## Overview
This project demonstrates selection statements (if/else, switch) by creating a simple banking system. The program will simulate basic banking operations with account balance management.

## Learning Objectives
- Practice using if/else statements
- Work with switch statements
- Implement input validation
- Handle different user choices
- Work with decimal numbers for currency

## Requirements
Create a program that:

1. **Displays a welcome message** and shows the current account balance (start with $1000.00)

2. **Shows a menu** with the following options:
   - 1. Check Balance
   - 2. Deposit Money
   - 3. Withdraw Money
   - 4. Transfer Money (to another account)
   - 5. Exit

3. **Implements each operation**:
   - **Check Balance**: Display current balance
   - **Deposit**: Ask for amount, validate it's positive, add to balance
   - **Withdraw**: Ask for amount, validate sufficient funds and positive amount
   - **Transfer**: Ask for amount and account number, validate funds
   - **Exit**: Display goodbye message

4. **Validates all inputs**:
   - Menu choices must be 1-5
   - Money amounts must be positive
   - Withdrawal/transfer amounts cannot exceed balance
   - Account numbers for transfers must be 6 digits

5. **Continues until user chooses to exit**

## Sample Output
```
=== Simple Banking System ===
Current Balance: $1,000.00

Menu:
1. Check Balance
2. Deposit Money
3. Withdraw Money
4. Transfer Money
5. Exit

Choose an option (1-5): 2

Enter deposit amount: $50.00
Deposit successful! New balance: $1,050.00

Menu:
1. Check Balance
2. Deposit Money
3. Withdraw Money
4. Transfer Money
5. Exit

Choose an option (1-5): 3

Enter withdrawal amount: $2000.00
Error: Insufficient funds. Current balance: $1,050.00

Choose an option (1-5): 5

Thank you for using Simple Banking System!
Final Balance: $1,050.00
```

## Tips
- Use `decimal` type for money to avoid floating-point precision issues
- Use `decimal.TryParse()` for safe number conversion
- Consider using a `switch` statement for the menu options
- Format currency using `ToString("C")` for proper currency display
- Validate inputs before processing transactions

## Challenge Extensions
- Add transaction history (last 5 transactions)
- Implement different account types (checking, savings) with different rules
- Add interest calculation for savings accounts
- Implement daily withdrawal limits