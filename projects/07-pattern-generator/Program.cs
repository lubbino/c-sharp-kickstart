using System;
using System.Threading;

namespace PatternGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Pattern Generator ===");
            Console.WriteLine();

            int rows = 0;
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
                        Console.WriteLine("Number Triangle (ascending)");
                        Console.Write("Enter number of rows: ");
                        if (int.TryParse(Console.ReadLine(), out rows) && rows > 0 && rows <= 50)
                        {
                            for (int i = 1; i <= rows; i++)
                            {
                                for (int x = 1; x <= i; x++)
                                {
                                    Write(x + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a positive integer that's at most 50.");
                        }
                        break;

                    case "2":
                        // TODO: Implement Number Triangle (descending)
                        Console.WriteLine("Number Triangle (descending)");
                        Console.Write("Enter number of rows: ");
                        if (int.TryParse(Console.ReadLine(), out rows) && rows > 0 && rows <= 50)
                        {
                            for (int i = rows; i >= 1; i--)
                            {
                                for (int x = 1; x <= i; x++)
                                {
                                    Write(x + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a positive integer.");
                        }
                        break;

                    case "3":
                        // TODO: Implement Star Pyramid
                        Console.WriteLine("Star Pyramid - Not implemented yet");
                        Console.Write("Enter number of rows: ");
                        if (int.TryParse(Console.ReadLine(), out rows) && rows > 0 && rows <= 50)
                        {
                            for (int i = 1; i <= rows; i++)
                            {
                                for (int j = 1; j <= rows - i; j++)
                                {
                                    Write(" ");
                                }
                                for (int k = 1; k <= (2 * i - 1); k++)
                                {
                                    Write("*");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a positive integer that's at most 50.");
                        }
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
        public static void Write(string input)
        {
            for (int x = 0; x < input.Length; x++)
            {
                Console.Write(input[x]); 
                Thread.Sleep(35); // Pauses execution for 30 milliseconds
            };
        }
    }
}