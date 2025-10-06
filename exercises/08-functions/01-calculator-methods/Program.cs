// Exercise 08-01: Calculator Methods
// Create a calculator using separate methods for each operation

using System;

public static class Utilities
{
    // TODO: Create arithmetic methods
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b != 0)
            return a / b;
        else
        {
            Console.WriteLine("Error: Cannot divide by zero!");
            return 0;
        }
    }

    // TODO: Create input validation method
    public static double GetValidNumber(string prompt)
    {
        double number;
        bool valid = false;

        do
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine() ?? "";

            if (double.TryParse(input, out number))
            {
                valid = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        } while (!valid);

        return number;
    }

    // TODO: Create result display method
    public static void DisplayResult(double num1, string operation, double num2, double result)
    {
        Console.WriteLine($"Calculation: {num1} {operation} {num2} = {result:F2}");
    }
}

public class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Method-Based Calculator");
            Console.WriteLine("======================");
            Console.WriteLine("");

            bool continueCalculating = true;

            while (continueCalculating)
            {
                // TODO: Get numbers and operation using your methods

                Console.WriteLine("Choose operation (+, -, *, /):");
                string operation = Console.ReadLine() ?? "";
                double number1 = Utilities.GetValidNumber("Enter the first number: ");
                double number2 = Utilities.GetValidNumber("Enter the second number: ");
                // TODO: Use switch statement to call appropriate method

                switch (operation)
                {
                    case "+":
                        {
                            double result = Utilities.Add(number1, number2);
                            Utilities.DisplayResult(number1, "+", number2, result);
                            break;
                        }
                    case "-":
                        {
                            double result = Utilities.Subtract(number1, number2);
                            Utilities.DisplayResult(number1, "-", number2, result);
                            break;
                        }
                    case "*":
                        {
                            double result = Utilities.Multiply(number1, number2);
                            Utilities.DisplayResult(number1, "*", number2, result);
                            break;
                        }
                    case "/":
                        {
                            double result = Utilities.Divide(number1, number2);
                            Utilities.DisplayResult(number1, "/", number2, result);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid operation try again.");
                            break;
                        }
                };

                Console.WriteLine("");
                Console.WriteLine("Would you like to perform another calculation? (yes/no):");
                string continueInput = Console.ReadLine() ?? "".ToLower();
                continueCalculating = continueInput == "yes" || continueInput == "y";
            }

            Console.WriteLine("Thank you for using the calculator!");
        }
}