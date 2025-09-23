using System;

namespace PatternGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Pattern Generator ===");
            Console.WriteLine();

            bool continueRunning = true;

            while (continueRunning)
            {
                // Display menu
                Console.WriteLine("Available Patterns:");
                Console.WriteLine("1. Number Triangle (ascending)");
                Console.WriteLine("2. Number Triangle (descending)");
                Console.WriteLine("3. Star Pyramid");
                Console.WriteLine("4. Diamond Pattern");
                Console.WriteLine("5. Multiplication Table");
                Console.WriteLine("6. Fibonacci Sequence");
                Console.WriteLine("7. Prime Numbers");
                Console.WriteLine("8. Exit");
                Console.WriteLine();

                Console.Write("Choose a pattern (1-8): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // TODO: Implement Number Triangle (ascending)
                        // Ask for number of rows
                        // Use nested loops to generate pattern
                        Console.WriteLine("Number Triangle (ascending) - Not implemented yet");
                        break;

                    case "2":
                        // TODO: Implement Number Triangle (descending)
                        Console.WriteLine("Number Triangle (descending) - Not implemented yet");
                        break;

                    case "3":
                        // TODO: Implement Star Pyramid
                        Console.WriteLine("Star Pyramid - Not implemented yet");
                        break;

                    case "4":
                        // TODO: Implement Diamond Pattern
                        Console.WriteLine("Diamond Pattern - Not implemented yet");
                        break;

                    case "5":
                        // TODO: Implement Multiplication Table
                        Console.WriteLine("Multiplication Table - Not implemented yet");
                        break;

                    case "6":
                        // TODO: Implement Fibonacci Sequence
                        Console.WriteLine("Fibonacci Sequence - Not implemented yet");
                        break;

                    case "7":
                        // TODO: Implement Prime Numbers
                        Console.WriteLine("Prime Numbers - Not implemented yet");
                        break;

                    case "8":
                        continueRunning = false;
                        Console.WriteLine("Thank you for using Pattern Generator!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose 1-8.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}