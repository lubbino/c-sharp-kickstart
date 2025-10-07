using System;
using System.Linq;

namespace TextAnalysis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Text Analysis Tool ===");
            Console.WriteLine();

            bool continueAnalyzing = true;

            while (continueAnalyzing)
            {
                // TODO: Prompt user for text input
                Console.WriteLine("Input text that should be analysed: ");
                string input = Console.ReadLine() ?? "";

                // TODO: Analyze the text and count:
                // - Total characters (with spaces)
                // - Total characters (without spaces)
                // - Number of words
                // - Number of vowels
                // - Number of consonants
                // - Number of digits
                // - Number of special characters
                int totalCharacters = input.Length;
                int totalCharactersWithoutSpaces = input.Replace(" ", "").Length;
                int wordCount = string.IsNullOrWhiteSpace(input) ? 0 : input.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
                //count the vowels
                
                int numOfVowels = 0;
                int numOfConsonants = 0;
                int numOfDigits = 0;
                int specialCharacters = 0;
                string[] vowels = {"a", "e", "i", "o", "u"};
                for (int i = 0; i < input.Length; i++)
                {
                    string letter = input[i].ToString();
                    foreach (string vowel in vowels)
                    {
                        if (letter.ToLower() == vowel) numOfVowels++;
                    }
                    if (Char.IsDigit(input[i])) numOfDigits++;
                    if (!char.IsLetter(input[i]) && !char.IsDigit(input[i])) specialCharacters++;
                }
                numOfConsonants = totalCharactersWithoutSpaces - numOfVowels - numOfDigits - specialCharacters;

                // TODO: Display the analysis results
                Console.WriteLine($"Number of characters (with spaces): {totalCharacters}");
                Console.WriteLine($"Number of characters (without spaces): {totalCharactersWithoutSpaces}");
                Console.WriteLine($"Number of words: {wordCount}");
                Console.WriteLine($"Number of vowels: {numOfVowels}");
                Console.WriteLine($"Number of consonants: {numOfConsonants}");
                Console.WriteLine($"Number of digits: {numOfDigits}");
                Console.WriteLine($"Number of special characters: {specialCharacters}");

                Console.WriteLine();
                Console.Write("Would you like to analyze another text? (y/n): ");
                string response = Console.ReadLine() ?? "";
                continueAnalyzing = response?.ToLower() == "y" || response?.ToLower() == "yes";
            }

            Console.WriteLine("Thank you for using the Text Analysis Tool!");
        }
    }
}