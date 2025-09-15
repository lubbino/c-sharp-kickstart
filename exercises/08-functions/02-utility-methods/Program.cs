// Exercise 08-02: Utility Methods
// Create a collection of useful utility methods

using System;

public static class Utilities
{
    // TODO: Create a method 'IsEven' that takes an integer and returns true if it's even
    // public static bool IsEven(int number)
    // {
    //     return number % 2 == 0;
    // }

    // TODO: Create a method 'GetMax' that takes two integers and returns the larger one
    // public static int GetMax(int a, int b)
    // {
    //     return a > b ? a : b;
    // }

    // TODO: Create a method 'ReverseString' that takes a string and returns it reversed
    // public static string ReverseString(string text)
    // {
    //     char[] chars = text.ToCharArray();
    //     Array.Reverse(chars);
    //     return new string(chars);
    // }

    // TODO: Create a method 'CountVowels' that counts vowels in a string
    // public static int CountVowels(string text)
    // {
    //     int count = 0;
    //     string vowels = "aeiouAEIOU";
    //     
    //     foreach (char c in text)
    //     {
    //         if (vowels.Contains(c))
    //             count++;
    //     }
    //     
    //     return count;
    // }

    // TODO: Create a method 'IsPrime' that checks if a number is prime
    // public static bool IsPrime(int number)
    // {
    //     if (number < 2) return false;
    //     
    //     for (int i = 2; i <= Math.Sqrt(number); i++)
    //     {
    //         if (number % i == 0)
    //             return false;
    //     }
    //     
    //     return true;
    // }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Utility Methods Tester");
        Console.WriteLine("======================");
        Console.WriteLine();

        // TODO: Test the IsEven method
        // Console.WriteLine("Testing IsEven method:");
        // Console.WriteLine($"Is 4 even? {Utilities.IsEven(4)}");
        // Console.WriteLine($"Is 7 even? {Utilities.IsEven(7)}");
        // Console.WriteLine();

        // TODO: Test the GetMax method
        // Console.WriteLine("Testing GetMax method:");
        // Console.WriteLine($"Max of 15 and 23: {Utilities.GetMax(15, 23)}");
        // Console.WriteLine($"Max of 100 and 50: {Utilities.GetMax(100, 50)}");
        // Console.WriteLine();

        // TODO: Test the ReverseString method
        // Console.WriteLine("Testing ReverseString method:");
        // Console.WriteLine($"Reverse of 'Hello': {Utilities.ReverseString("Hello")}");
        // Console.WriteLine($"Reverse of 'Programming': {Utilities.ReverseString("Programming")}");
        // Console.WriteLine();

        // TODO: Test the CountVowels method
        // Console.WriteLine("Testing CountVowels method:");
        // Console.WriteLine($"Vowels in 'Hello World': {Utilities.CountVowels("Hello World")}");
        // Console.WriteLine($"Vowels in 'Programming': {Utilities.CountVowels("Programming")}");
        // Console.WriteLine();

        // TODO: Test the IsPrime method
        // Console.WriteLine("Testing IsPrime method:");
        // Console.WriteLine($"Is 17 prime? {Utilities.IsPrime(17)}");
        // Console.WriteLine($"Is 20 prime? {Utilities.IsPrime(20)}");
        // Console.WriteLine($"Is 2 prime? {Utilities.IsPrime(2)}");

        Console.WriteLine("All tests completed!");
    }
}