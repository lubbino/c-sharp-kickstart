using System;

public namespace MathLibrary
{
    public class Program
    {
        public static void Main(string[] args)
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
                        Console.WriteLine($"result: {Power(4,5)}");
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
        public static void HandleBasicOperations()
        {
            Console.WriteLine("Basic Operations - Not implemented yet");
            // TODO: Show submenu for add, subtract, multiply, divide
            // TODO: Call appropriate functions

        }

        // TODO: Implement power and root functions
        public static void HandlePowerAndRoot()
        {
            Console.WriteLine("Power and Root Operations - Not implemented yet");
        }

        // TODO: Implement geometry functions
        public static void HandleGeometry()
        {
            Console.WriteLine("Geometry Calculations - Not implemented yet");
        }

        // TODO: Implement number analysis functions
        public static void HandleNumberAnalysis()
        {
            Console.WriteLine("Number Analysis - Not implemented yet");
        }

        // TODO: Implement statistics functions
        public static void HandleStatistics()
        {
            Console.WriteLine("Statistics - Not implemented yet");
        }

        // TODO: Implement number conversion functions
        public static void HandleNumberConversions()
        {
            Console.WriteLine("Number Conversions - Not implemented yet");
        }

        // TODO: Add mathematical functions here
        // Example:
        // static double Add(double a, double b) { return a + b; }
        // static double CircleArea(double radius) { return Math.PI * radius * radius; }
        // static bool IsPrime(int number) { /* implementation */ }
        
        public static double Add(double a, double b) { return a + b; }
        public static double Add(double[] numbers) 
        { 
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public static double Subtract(double a, double b) { return a - b; }
        public static double Multiply(double a, double b) { return a * b; }
        public static double Divide(double a, double b) 
        {
            if ( b == 0) { throw new DivideByZeroException("Cannot divide by zero."); }
            return a / b;
        }

        public static double Power(double baseNumber, double exponentNumber)
        {
            return Math.Pow(baseNumber, exponentNumber);
        }
        public static double SquareRoot(double number)
        {
            if (number < 0) { throw new ArgumentException("Cannot compute square root of a negative number."); }
            return Math.Sqrt(number);
        }

        public static double CircleArea(double radius)
        {
            if (radius < 0) { throw new ArgumentException("Radius cannot be negative."); }
            return Math.PI * radius * radius;
        }
        public static double CircleCircumference(double radius)
        {
            if (radius < 0) { throw new ArgumentException("Radius cannot be negative."); }
            return 2 * Math.PI * radius;
        }
        public static double RectangleArea(double length, double width)
        {
            if (length < 0 || width < 0) { throw new ArgumentException("Length and width cannot be negative."); }
            return length * width;
        }
        public static double TriangleArea(double baseLength, double height)
        {
            if (baseLength < 0 || height < 0) { throw new ArgumentException("Base length and height cannot be negative."); }
            return 0.5 * baseLength * height;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        public static bool IsPerfectSquare(int number)
        {
            if (number < 0) return false;
            int root = (int)Math.Sqrt(number);
            return root * root == number;
        }
        public static long Factorial(int number)
        {
            if (number < 0) { throw new ArgumentException("Number cannot be negative."); }
            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        public static double CtoF(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public static double FtoC(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

    }
}