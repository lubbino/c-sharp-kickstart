// Exercise 08-01: Calculator Methods
// Create a calculator using separate methods for each operation

using System;

// TODO: Create arithmetic methods
// static double Add(double a, double b)
// {
//     return a + b;
// }

// static double Subtract(double a, double b)
// {
//     return a - b;
// }

// static double Multiply(double a, double b)
// {
//     return a * b;
// }

// static double Divide(double a, double b)
// {
//     if (b != 0)
//         return a / b;
//     else
//     {
//         Console.WriteLine("Error: Cannot divide by zero!");
//         return 0;
//     }
// }

// TODO: Create input validation method
// static double GetValidNumber(string prompt)
// {
//     double number;
//     bool valid = false;
//     
//     do
//     {
//         Console.WriteLine(prompt);
//         string input = Console.ReadLine();
//         
//         if (double.TryParse(input, out number))
//         {
//             valid = true;
//         }
//         else
//         {
//             Console.WriteLine("Please enter a valid number.");
//         }
//     } while (!valid);
//     
//     return number;
// }

// TODO: Create result display method
// static void DisplayResult(double num1, string operation, double num2, double result)
// {
//     Console.WriteLine($"Calculation: {num1} {operation} {num2} = {result:F2}");
// }

static void Main(string[] args)
{
    Console.WriteLine("Method-Based Calculator");
    Console.WriteLine("======================");
    Console.WriteLine("");
    
    bool continueCalculating = true;
    
    while (continueCalculating)
    {
        // TODO: Get numbers and operation using your methods
        // double num1 = GetValidNumber("Enter first number:");
        // double num2 = GetValidNumber("Enter second number:");
        
        Console.WriteLine("Choose operation (+, -, *, /):");
        string operation = Console.ReadLine();
        
        // TODO: Use switch statement to call appropriate method
        // double result = 0;
        // switch (operation)
        // {
        //     case "+":
        //         result = Add(num1, num2);
        //         DisplayResult(num1, operation, num2, result);
        //         break;
        //     // Add other cases...
        // }
        
        Console.WriteLine("");
        Console.WriteLine("Would you like to perform another calculation? (yes/no):");
        string continueInput = Console.ReadLine().ToLower();
        continueCalculating = continueInput == "yes" || continueInput == "y";
    }
    
    Console.WriteLine("Thank you for using the calculator!");
}