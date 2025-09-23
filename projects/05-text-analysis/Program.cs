using System;

namespace TextAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Text Analysis Tool ===");
            Console.WriteLine();

            bool continueAnalyzing = true;

            while (continueAnalyzing)
            {
                // TODO: Prompt user for text input
                
                // TODO: Analyze the text and count:
                // - Total characters (with spaces)
                // - Total characters (without spaces)
                // - Number of words
                // - Number of vowels
                // - Number of consonants
                // - Number of digits
                // - Number of special characters

                // TODO: Display the analysis results

                // TODO: Ask if user wants to analyze another text
                
                Console.WriteLine();
                Console.Write("Would you like to analyze another text? (y/n): ");
                string response = Console.ReadLine();
                continueAnalyzing = response?.ToLower() == "y" || response?.ToLower() == "yes";
            }

            Console.WriteLine("Thank you for using the Text Analysis Tool!");
        }
    }
}