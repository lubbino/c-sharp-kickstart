// Project 2: Word Statistics Analyzer
// A comprehensive text analysis application using methods, lists, and dictionaries

using System;
using System.Collections.Generic;

// TODO: Create text input method
// static List<string> GetTextInput()
// {
//     List<string> lines = new List<string>();
//     Console.WriteLine("Enter text to analyze (type 'END' on a new line to finish):");
//     
//     string line;
//     while ((line = Console.ReadLine()) != "END")
//     {
//         lines.Add(line);
//     }
//     
//     return lines;
// }

// TODO: Create word extraction method
// static List<string> ExtractWords(string text)
// {
//     string cleanText = "";
//     foreach (char c in text)
//     {
//         if (char.IsLetter(c) || char.IsWhiteSpace(c))
//             cleanText += c;
//         else
//             cleanText += " ";
//     }
//     
//     string[] wordArray = cleanText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     List<string> words = new List<string>();
//     
//     foreach (string word in wordArray)
//     {
//         words.Add(word.ToLower());
//     }
//     
//     return words;
// }

// TODO: Create frequency analysis method
// static Dictionary<string, int> CountWordFrequency(List<string> words)
// {
//     Dictionary<string, int> frequency = new Dictionary<string, int>();
//     
//     foreach (string word in words)
//     {
//         if (frequency.ContainsKey(word))
//             frequency[word]++;
//         else
//             frequency[word] = 1;
//     }
//     
//     return frequency;
// }

// TODO: Create statistical methods
// static double CalculateAverageWordLength(List<string> words)
// static string FindLongestWord(List<string> words)
// static string FindShortestWord(List<string> words)
// static int CountVowels(string text)
// static int CountConsonants(string text)
// static int CountSentences(string text)

// TODO: Create display methods
// static void DisplayBasicStatistics(string text, List<string> words)
// static void DisplayWordFrequency(Dictionary<string, int> frequency)
// static void DisplayCharacterAnalysis(string text)

static void Main(string[] args)
{
    Console.WriteLine("📊 Word Statistics Analyzer");
    Console.WriteLine("===========================");
    Console.WriteLine("");
    
    bool analyzeMore = true;
    
    while (analyzeMore)
    {
        // TODO: Get text input
        // List<string> inputLines = GetTextInput();
        // string fullText = string.Join(" ", inputLines);
        
        // TODO: Process text
        // List<string> words = ExtractWords(fullText);
        // Dictionary<string, int> wordFrequency = CountWordFrequency(words);
        
        Console.WriteLine("");
        Console.WriteLine("Text Analysis Report");
        Console.WriteLine("===================");
        Console.WriteLine("");
        
        // TODO: Display input text
        // Console.WriteLine("Input Text:");
        // Console.WriteLine("----------");
        // Console.WriteLine(fullText);
        // Console.WriteLine("");
        
        // TODO: Display basic statistics
        // DisplayBasicStatistics(fullText, words);
        
        // TODO: Display word frequency
        // DisplayWordFrequency(wordFrequency);
        
        // TODO: Display character analysis
        // DisplayCharacterAnalysis(fullText);
        
        Console.WriteLine("");
        Console.WriteLine("Would you like to analyze another text? (yes/no):");
        string continueInput = Console.ReadLine().ToLower();
        analyzeMore = continueInput == "yes" || continueInput == "y";
        Console.WriteLine("");
    }
    
    Console.WriteLine("Thank you for using Word Statistics Analyzer!");
}