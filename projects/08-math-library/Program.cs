using System;

namespace MathLibrary
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
                string choice = Console.ReadLine() ?? "";

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
            Console.WriteLine("Basic Operations");
            Console.WriteLine();
            Console.WriteLine("a) Add two numbers");
            Console.WriteLine("b) Add multiple numbers");
            Console.WriteLine("c) Subtract two numbers");
            Console.WriteLine("d) Multiply two numbers");
            Console.WriteLine("e) Divide two numbers");
            Console.WriteLine();
            Console.Write("Choose an operation (a-e): ");
            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "a":
                    Console.Write("Enter first number: ");
                    double addNum1 = Convert.ToDouble(Console.ReadLine() ?? "");
                    Console.Write("Enter second number: ");
                    double addNum2 = Convert.ToDouble(Console.ReadLine() ?? "");
                    Console.WriteLine($"Result: {Add(addNum1, addNum2)}");
                    break;
                case "b":
                    Console.Write("Enter numbers separated by commas: ");
                    string input = Console.ReadLine() ?? "";
                    string[] parts = input.Split(',');
                    double[] numbers = Array.ConvertAll(parts, Double.Parse);
                    Console.WriteLine($"Result: {Add(numbers)}");
                    break;
                case "c":
                    Console.Write("Enter first number: ");
                    double subNum1 = Convert.ToDouble(Console.ReadLine() ?? "");
                    Console.Write("Enter second number: ");
                    double subNum2 = Convert.ToDouble(Console.ReadLine() ?? "");
                    Console.WriteLine($"Result: {Subtract(subNum1, subNum2)}");
                    break;
                case "d":
                    Console.Write("Enter first number: ");
                    double mulNum1 = Convert.ToDouble(Console.ReadLine() ?? "");
                    Console.Write("Enter second number: ");
                    double mulNum2 = Convert.ToDouble(Console.ReadLine() ?? "");
                    Console.WriteLine($"Result: {Multiply(mulNum1, mulNum2)}");
                    break;
                case "e":
                    Console.Write("Enter first number: ");
                    double divNum1 = Convert.ToDouble(Console.ReadLine() ?? "");
                    Console.Write("Enter second number: ");
                    double divNum2 = Convert.ToDouble(Console.ReadLine() ?? "");
                    try
                    {
                        Console.WriteLine($"Result: {Divide(divNum1, divNum2)}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a-e.");
                    break;
            }

        }

        // TODO: Implement power and root functions
        public static void HandlePowerAndRoot()
        {
            Console.WriteLine("Power and Root Operations");
            Console.WriteLine();
            Console.WriteLine("a) Power");
            Console.WriteLine("b) Square Root");
            Console.WriteLine();
            Console.Write("Choose an operation (a-b): ");
            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "a":
                    Console.Write("Enter base number: ");
                    double baseNum = Convert.ToDouble(Console.ReadLine() ?? "");
                    Console.Write("Enter exponent number: ");
                    double expNum = Convert.ToDouble(Console.ReadLine() ?? "");
                    Console.WriteLine($"Result: {Power(baseNum, expNum)}");
                    break;
                case "b":
                    Console.Write("Enter number: ");
                    double rootNum = Convert.ToDouble(Console.ReadLine() ?? "");
                    try
                    {
                        Console.WriteLine($"Result: {SquareRoot(rootNum)}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a-b.");
                    break;
            }
        }

        // TODO: Implement geometry functions
        public static void HandleGeometry()
        {
            Console.WriteLine("Geometry Calculations");
            Console.WriteLine();
            Console.WriteLine("a) Circle Area");
            Console.WriteLine("b) Circle Circumference");
            Console.WriteLine("c) Rectangle Area");
            Console.WriteLine("d) Rectangle Perimeter");
            Console.WriteLine("e) Triangle Area");
            Console.WriteLine();
            Console.Write("Choose an operation (a-e): ");
            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "a":
                    Console.Write("Enter radius: ");
                    double radiusArea = Convert.ToDouble(Console.ReadLine() ?? "");
                    try
                    {
                        Console.WriteLine($"Result: {CircleArea(radiusArea)}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "b":
                    Console.Write("Enter radius: ");
                    double radiusCircum = Convert.ToDouble(Console.ReadLine() ?? "");
                    try
                    {
                        Console.WriteLine($"Result: {CircleCircumference(radiusCircum)}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "c":
                    Console.Write("Enter length: ");
                    double lengthArea = Convert.ToDouble(Console.ReadLine() ?? "");
                    Console.Write("Enter width: ");
                    double widthArea = Convert.ToDouble(Console.ReadLine() ?? "");
                    try
                    {
                        Console.WriteLine($"Result: {RectangleArea(lengthArea, widthArea)}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "d":
                    Console.Write("Enter length: ");
                    double lengthPerim = Convert.ToDouble(Console.ReadLine() ?? "");
                    Console.Write("Enter width: ");
                    double widthPerim = Convert.ToDouble(Console.ReadLine() ?? "");
                    try
                    {
                        Console.WriteLine($"Result: {RectanglePerimeter(lengthPerim, widthPerim)}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "e":
                    Console.Write("Enter base length: ");
                    double baseLength = Convert.ToDouble(Console.ReadLine() ?? "");
                    Console.Write("Enter height: ");
                    double height = Convert.ToDouble(Console.ReadLine() ?? "");
                    try
                    {
                        Console.WriteLine($"Result: {TriangleArea(baseLength, height)}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a-e.");
                    break;
            }
        }

        // TODO: Implement number analysis functions
        public static void HandleNumberAnalysis()
        {
            Console.WriteLine("Number Analysis");
            Console.WriteLine();
            Console.WriteLine("a) Check Prime");
            Console.WriteLine("b) Check Perfect Square");
            Console.WriteLine("c) Factorial");
            Console.WriteLine();
            Console.Write("Choose an operation (a-c): ");
            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "a":
                    Console.Write("Enter number: ");
                    int primeNum = Convert.ToInt32(Console.ReadLine() ?? "");
                    Console.WriteLine($"Is Prime: {IsPrime(primeNum)}");
                    break;
                case "b":
                    Console.Write("Enter number: ");
                    int squareNum = Convert.ToInt32(Console.ReadLine() ?? "");
                    Console.WriteLine($"Is Perfect Square: {IsPerfectSquare(squareNum)}");
                    break;
                case "c":
                    Console.Write("Enter number: ");
                    int factNum = Convert.ToInt32(Console.ReadLine() ?? "");
                    try
                    {
                        Console.WriteLine($"Factorial: {Factorial(factNum)}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a-c.");
                    break;
            }
        }

        // TODO: Implement statistics functions
        public static void HandleStatistics()
        {
            Console.WriteLine("Statistics");
            Console.WriteLine();
            Console.WriteLine("a) Mean");
            Console.WriteLine("b) Max");
            Console.WriteLine("c) Min");
            Console.WriteLine();
            Console.Write("Choose an operation (a-c): ");
            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "a":
                    Console.Write("Enter numbers separated by commas: ");
                    string inputMean = Console.ReadLine() ?? "";
                    string[] partsMean = inputMean.Split(',');
                    double[] numbersMean = Array.ConvertAll(partsMean, Double.Parse);
                    try
                    {
                        Console.WriteLine($"Mean: {Mean(numbersMean)}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "b":
                    Console.Write("Enter numbers separated by commas: ");
                    string inputMax = Console.ReadLine() ?? "";
                    string[] partsMax = inputMax.Split(',');
                    double[] numbersMax = Array.ConvertAll(partsMax, Double.Parse);
                    try
                    {
                        Console.WriteLine($"Max: {Max(numbersMax)}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "c":
                    Console.Write("Enter numbers separated by commas: ");
                    string inputMin = Console.ReadLine() ?? "";
                    string[] partsMin = inputMin.Split(',');
                    double[] numbersMin = Array.ConvertAll(partsMin, Double.Parse);
                    try
                    {
                        Console.WriteLine($"Min: {Min(numbersMin)}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a-c.");
                    break;
            }
        }

        // TODO: Implement number conversion functions
        public static void HandleNumberConversions()
        {
            Console.WriteLine("Number Conversions");
            Console.WriteLine();
            Console.WriteLine("a) Celsius to Fahrenheit");
            Console.WriteLine("b) Fahrenheit to Celsius");
            Console.WriteLine("c) Decimal to Binary");
            Console.WriteLine("d) Binary to Decimal");
            Console.WriteLine("e) Decimal to Hexadecimal");
            Console.WriteLine("f) Hexadecimal to Decimal");
            Console.WriteLine();
            Console.Write("Choose an operation (a-f): ");
            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "a":
                    Console.Write("Enter Celsius temperature: ");
                    double celsius = Convert.ToDouble(Console.ReadLine() ?? "");
                    Console.WriteLine($"Fahrenheit: {CtoF(celsius)}");
                    break;
                case "b":
                    Console.Write("Enter Fahrenheit temperature: ");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine() ?? "");
                    Console.WriteLine($"Celsius: {FtoC(fahrenheit)}");
                    break;
                case "c":
                    Console.Write("Enter decimal number: ");
                    int decimalNum = Convert.ToInt32(Console.ReadLine() ?? "");
                    Console.WriteLine($"Binary: {DecimalToBinary(decimalNum)}");
                    break;
                case "d":
                    Console.Write("Enter binary string: ");
                    string binaryStr = Console.ReadLine() ?? "";
                    Console.WriteLine($"Decimal: {BinaryToDecimal(binaryStr)}");
                    break;
                case "e":
                    Console.Write("Enter decimal number: ");
                    int decimalNumHex = Convert.ToInt32(Console.ReadLine() ?? "");
                    Console.WriteLine($"Hexadecimal: {DecimalToHexadecimal(decimalNumHex)}");
                    break;
                case "f":
                    Console.Write("Enter hexadecimal string: ");
                    string hexStr = Console.ReadLine() ?? "";
                    Console.WriteLine($"Decimal: {HexadecimalToDecimal(hexStr)}");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a-f.");
                    break;
            }
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
        public static double Divide(double a, double b) { return a / b; }

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
        public static double RectanglePerimeter(double length, double width)
        {
            if (length < 0 || width < 0) { throw new ArgumentException("Length and width cannot be negative."); }
            return 2 * (length + width);
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
        public static string DecimalToBinary(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2);
        }
        public static int BinaryToDecimal(string binaryString)
        {
            return Convert.ToInt32(binaryString, 2);
        }
        public static string DecimalToHexadecimal(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 16).ToUpper();
        }
        public static int HexadecimalToDecimal(string hexString)
        {
            return Convert.ToInt32(hexString, 16);
        }

        public static double Mean(double[] numbers)
        {
            if (numbers.Length == 0) { throw new ArgumentException("Array cannot be empty."); }
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }
        public static double Max(double[] numbers)
        {
            if (numbers.Length == 0) { throw new ArgumentException("Array cannot be empty."); }
            double max = numbers[0];
            foreach (double num in numbers)
            {
                if (num > max) { max = num; }
            }
            return max;
        }
        public static double Min(double[] numbers)
        {
            if (numbers.Length == 0) { throw new ArgumentException("Array cannot be empty."); }
            double min = numbers[0];
            foreach (double num in numbers)
            {
                if (num < min) { min = num; }
            }
            return min;
        }
    }
}