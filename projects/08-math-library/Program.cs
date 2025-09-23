using System;

namespace MathLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Math Library ===");
            Console.WriteLine();

            bool continueRunning = true;

            while (continueRunning)
            {
                // Display main menu
                Console.WriteLine("Available Operations:");
                Console.WriteLine("1. Basic Operations (Add, Subtract, Multiply, Divide)");
                Console.WriteLine("2. Power and Root Operations");
                Console.WriteLine("3. Geometry Calculations");
                Console.WriteLine("4. Number Analysis");
                Console.WriteLine("5. Statistics");
                Console.WriteLine("6. Number Conversions");
                Console.WriteLine("7. Exit");
                Console.WriteLine();

                Console.Write("Choose an operation (1-7): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        HandleBasicOperations();
                        break;

                    case "2":
                        HandlePowerAndRoot();
                        break;

                    case "3":
                        HandleGeometry();
                        break;

                    case "4":
                        HandleNumberAnalysis();
                        break;

                    case "5":
                        HandleStatistics();
                        break;

                    case "6":
                        HandleNumberConversions();
                        break;

                    case "7":
                        continueRunning = false;
                        Console.WriteLine("Thank you for using Math Library!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose 1-7.");
                        break;
                }

                Console.WriteLine();
            }
        }

        // TODO: Implement basic operations functions
        static void HandleBasicOperations()
        {
            Console.WriteLine("Basic Operations - Not implemented yet");
            // TODO: Show submenu for add, subtract, multiply, divide
            // TODO: Call appropriate functions
        }

        // TODO: Implement power and root functions
        static void HandlePowerAndRoot()
        {
            Console.WriteLine("Power and Root Operations - Not implemented yet");
        }

        // TODO: Implement geometry functions
        static void HandleGeometry()
        {
            Console.WriteLine("Geometry Calculations - Not implemented yet");
        }

        // TODO: Implement number analysis functions
        static void HandleNumberAnalysis()
        {
            Console.WriteLine("Number Analysis - Not implemented yet");
        }

        // TODO: Implement statistics functions
        static void HandleStatistics()
        {
            Console.WriteLine("Statistics - Not implemented yet");
        }

        // TODO: Implement number conversion functions
        static void HandleNumberConversions()
        {
            Console.WriteLine("Number Conversions - Not implemented yet");
        }

        // TODO: Add mathematical functions here
        // Example:
        // static double Add(double a, double b) { return a + b; }
        // static double CircleArea(double radius) { return Math.PI * radius * radius; }
        // static bool IsPrime(int number) { /* implementation */ }
    }
}