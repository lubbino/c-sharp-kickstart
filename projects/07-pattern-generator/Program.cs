using System;
using System.Threading;

namespace PatternGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("=== Pattern Generator ===");
            Console.WriteLine();

            int rows = 0;
            bool continueRunning = true;

            while (continueRunning)
            {
                // Display menu
                WriteLine("Available Patterns:");
                WriteLine("1. Number Triangle (ascending)");
                WriteLine("2. Number Triangle (descending)");
                WriteLine("3. Star Pyramid");
                WriteLine("4. Diamond Pattern");
                WriteLine("5. Multiplication Table");
                WriteLine("6. Fibonacci Sequence");
                WriteLine("7. Prime Numbers");
                WriteLine("8. Exit");
                Console.WriteLine();

                Write("Choose a pattern (1-8): ");
                string choice = Console.ReadLine() ?? "";
                switch (choice)
                {
                    case "1":
                        // TODO: Implement Number Triangle (ascending)
                        // Ask for number of rows
                        // Use nested loops to generate pattern
                        Console.WriteLine();
                        WriteLine("Number Triangle (ascending)");
                        Write("Enter number of rows: ");
                        if (int.TryParse(Console.ReadLine() ?? "", out rows) && rows > 0 && rows <= 50)
                        {
                            for (int i = 1; i <= rows; i++)
                            {
                                for (int x = 1; x <= i; x++)
                                {
                                    Write(x + " ");
                                }
                                Console.WriteLine();
                            }
                            WriteLine($"Generated a number triangle with {rows} rows.");
                        }
                        else
                        {
                            WriteLine("Invalid input. Please enter a positive integer that's at most 50.");
                        }
                        break;

                    case "2":
                        // TODO: Implement Number Triangle (descending)
                        Console.WriteLine();
                        WriteLine("Number Triangle (descending)");
                        Write("Enter number of rows: ");
                        if (int.TryParse(Console.ReadLine() ?? "", out rows) && rows > 0 && rows <= 50)
                        {
                            for (int i = rows; i >= 1; i--)
                            {
                                for (int x = 1; x <= i; x++)
                                {
                                    Write(x + " ");
                                }
                                Console.WriteLine();
                            }
                            WriteLine($"Generated a number triangle with {rows} rows.");
                        }
                        else
                        {
                            WriteLine("Invalid input. Please enter a positive integer.");
                        }
                        break;

                    case "3":
                        // TODO: Implement Star Pyramid
                        Console.WriteLine();
                        WriteLine("Star Pyramid");
                        Write("Enter number of rows: ");
                        if (int.TryParse(Console.ReadLine() ?? "", out rows) && rows > 0 && rows <= 50)
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
                            WriteLine($"Generated a star pyramid with {rows} rows.");
                        }
                        else
                        {
                            WriteLine("Invalid input. Please enter a positive integer that's at most 50.");
                        }
                        break;

                    case "4":
                        // TODO: Implement Diamond Pattern
                        Console.WriteLine();
                        WriteLine("Diamond Pattern");
                        Write("Enter number of rows: ");
                        if (int.TryParse(Console.ReadLine() ?? "", out rows) && rows > 0 && rows <= 50)
                        {
                            // Upper part of diamond
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
                            // Lower part of diamond
                            for (int i = rows - 1; i >= 1; i--)
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
                            WriteLine($"Generated a diamond pattern with {rows*2} rows.");
                        }
                        else
                        {
                            WriteLine("Invalid input. Please enter a positive integer that's at most 50.");
                        }
                        break;

                    case "5":
                        // TODO: Implement Multiplication Table
                        Console.WriteLine();
                        WriteLine("Multiplication Table");
                        Write("Enter the number for which you want the multiplication table: ");
                        if (int.TryParse(Console.ReadLine() ?? "", out int tableNumber) && tableNumber > 0 && tableNumber <= 100)
                        {
                            Write("Enter the range up to which you want the multiplication table: ");
                            if (int.TryParse(Console.ReadLine() ?? "", out rows) && rows > 0 && rows <= 100)
                            {
                                WriteLine($"Multiplication Table for {tableNumber} up to {rows}:");
                                for (int i = 1; i <= rows; i++)
                                {
                                    WriteLine($"{tableNumber} x {i} = {tableNumber * i}");
                                }
                                WriteLine($"Generated multiplication table for the number {tableNumber} up to {rows}.");
                            }
                            else
                            {
                                WriteLine("Invalid input. Please enter a positive integer that's at most 100.");
                            }
                        }
                        else
                        {
                            WriteLine("Invalid input. Please enter a positive integer that's at most 100.");
                        }
                        break;

                    case "6":
                        // TODO: Implement Fibonacci Sequence
                        Console.WriteLine();
                        WriteLine("Fibonacci Sequence");
                        Write("Enter number of terms: ");
                        if (int.TryParse(Console.ReadLine() ?? "", out rows) && rows > 0 && rows <= 50)
                        {
                            int a = 0, b = 1, c;
                            Write("Fibonacci Series: ");
                            for (int i = 1; i <= rows; i++)
                            {
                                Write(a + " ");
                                c = a + b;
                                a = b;
                                b = c;
                            }
                            Console.WriteLine();
                            WriteLine($"Generated Fibonacci sequence with {rows} terms.");
                        }
                        else
                        {
                            WriteLine("Invalid input. Please enter a positive integer that's at most 50.");
                        }
                        break;

                    case "7":
                        // TODO: Implement Prime Numbers
                        Console.WriteLine();
                        WriteLine("Prime Numbers");
                        Write("Enter upper limit: ");
                        if (int.TryParse(Console.ReadLine() ?? "", out rows) && rows > 1 && rows <= 1000)
                        {
                            WriteLine($"Prime numbers up to {rows}:");
                            for (int num = 2; num <= rows; num++)
                            {
                                bool isPrime = true;
                                for (int i = 2; i <= Math.Sqrt(num); i++)
                                {
                                    if (num % i == 0)
                                    {
                                        isPrime = false;
                                        break;
                                    }
                                }
                                if (isPrime)
                                {
                                    Write(num + " ");
                                }
                            }
                            Console.WriteLine();
                            WriteLine($"Generated prime numbers up to {rows}.");
                        }
                        else
                        {
                            WriteLine("Invalid input. Please enter an integer greater than 1 and at most 1000.");
                        }
                        
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
                if (char.ToString(input[x]) != " ") Thread.Sleep(25); // Pauses execution for 25 milliseconds
            };
        }
        public static void WriteLine(string input)
        {
            for (int x = 0; x < input.Length; x++)
            {
                Console.Write(input[x]);
                if (char.ToString(input[x]) != " ") Thread.Sleep(25); // Pauses execution for 25 milliseconds
            };
            Console.WriteLine();
        }
    }
}