using System;

namespace SimpleBankingSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Simple Banking System ===");
            
            decimal balance = 1000.00m; // Starting balance
            decimal amount;
            string inputAmount;
            string accountNumber;
            int accountIsValid;
            bool continueRunning = true;
            //Displays current balance at startup
            Console.WriteLine($"Current Balance: {balance:C}");

            while (continueRunning)
            {

                // Display menu
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Transfer Money");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                Console.Write("Choose an option (1-5): ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        // TODO: Implement check balance
                        Console.WriteLine("Account balance:");
                        Console.WriteLine($"Current balance: {balance:C}");
                        break;
                    case "2":
                        // TODO: Implement deposit
                        // - Ask for amount
                        // - Validate amount is positive
                        // - Add to balance
                        Console.WriteLine($"Balance Deposit (Available balance: {balance:C})");
                        Console.Write("Enter deposit amount: ");
                        inputAmount = (Console.ReadLine() ?? "").Replace(".", ",");
                        if (decimal.TryParse(inputAmount, out amount) && Convert.ToDecimal(inputAmount) > decimal.Zero)
                        {
                            balance += amount;
                            Console.WriteLine($"{amount:C} successfully added to balance. New balance is {balance:C}");
                        }
                        else Console.WriteLine($"{inputAmount} is not a valid amount or amount is negative or amount exceeds account balance. Please try again!");
                        break;

                    case "3":
                        // TODO: Implement withdrawal
                        // - Ask for amount
                        // - Validate amount is positive
                        // - Check sufficient funds
                        // - Subtract from balance
                        Console.WriteLine($"Balance withdrawal (Available balance: {balance:C})");
                        Console.Write("Enter withdrawal amount: ");
                        inputAmount = (Console.ReadLine() ?? "").Replace(".", ",");
                        if (decimal.TryParse(inputAmount, out amount) && Convert.ToDecimal(inputAmount) > decimal.Zero && Convert.ToDecimal(inputAmount) < balance)
                        {
                            balance -= amount;
                            Console.WriteLine($"{amount:C} successfully withdrawn. New balance is {balance:C}");
                        }
                        else Console.WriteLine($"{inputAmount} is not a valid amount or amount is negative. Please try again!");
                        break;

                    case "4":
                        // TODO: Implement transfer
                        // - Ask for amount and account number
                        // - Validate amount and account number
                        // - Check sufficient funds
                        // - Subtract from balance
                        Console.WriteLine($"Account transfer (Available balance: {balance:C})");
                        Console.Write("Enter withdrawal amount: ");
                        inputAmount = (Console.ReadLine() ?? "").Replace(".", ",");
                        Console.Write("Enter account number: ");
                        accountNumber = (Console.ReadLine() ?? "").Replace(" ", "").Replace(",", "").Replace(".", "");
                        if (decimal.TryParse(inputAmount, out amount) && Convert.ToDecimal(inputAmount) > decimal.Zero && Convert.ToDecimal(inputAmount) < balance && accountNumber.Length >= 6 && int.TryParse(accountNumber, out accountIsValid))
                        {
                            balance -= amount;
                            Console.WriteLine($"{amount:C} successfully sent to account number: {accountNumber}. New balance is {balance:C}");
                        }
                        else Console.WriteLine($"{inputAmount} is not a valid amount or amount is negative or account number is invalid. Please try again!");
                        break;

                    case "5":
                        continueRunning = false;
                        Console.WriteLine("Thank you for using Simple Banking System!");
                        Console.WriteLine($"Final Balance: {balance:C}");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose 1-5.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}