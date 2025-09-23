# Project 2: Word Statistics Analyzer

## Background

This project combines everything you've learned in Chapters 1-9 to create a comprehensive text analysis application. You'll use methods, arrays, lists, and all previous concepts to analyze text and provide detailed statistics.

## Project Description

Create a word statistics analyzer that processes text input and provides detailed analysis including word frequency, character counts, and various text metrics.

## Requirements

### Core Features
1. Accept text input from the user (single line or multiple lines)
2. Count total words, characters, and sentences
3. Find the most and least frequent words
4. Calculate average word length
5. Display word frequency table
6. Show character frequency analysis

### Advanced Features
7. Identify longest and shortest words
8. Count vowels and consonants
9. Find palindromic words
10. Generate reading statistics (estimated reading time)
11. Export results to formatted report

## Expected Output

Your program should work similar to this:

```
📊 Word Statistics Analyzer
===========================

Enter text to analyze (type 'END' on a new line to finish):
The quick brown fox jumps over the lazy dog.
This is a sample text for analysis.
END

Text Analysis Report
===================

Input Text:
----------
The quick brown fox jumps over the lazy dog. This is a sample text for analysis.

Basic Statistics:
----------------
Total characters: 78
Total words: 15
Total sentences: 2
Average word length: 4.2 characters
Estimated reading time: 3 seconds

Word Frequency Analysis:
-----------------------
the: 2 occurrences
is: 2 occurrences
a: 2 occurrences
quick: 1 occurrence
brown: 1 occurrence
fox: 1 occurrence
jumps: 1 occurrence
over: 1 occurrence
lazy: 1 occurrence
dog: 1 occurrence
this: 1 occurrence
sample: 1 occurrence
text: 1 occurrence
for: 1 occurrence
analysis: 1 occurrence

Word Length Analysis:
--------------------
Longest word: "analysis" (8 characters)
Shortest word: "a" (1 character)
Words by length:
1 character: a (2 words)
2 characters: is (2 words)
3 characters: the, fox, dog (3 words)
4 characters: over, lazy, this, text (4 words)
5 characters: quick, brown, jumps (3 words)
6 characters: sample (1 word)
7 characters: for (1 word)
8 characters: analysis (1 word)

Character Analysis:
------------------
Vowels: 23 (29.5%)
Consonants: 42 (53.8%)
Spaces: 13 (16.7%)
Punctuation: 2 (2.6%)

Special Features:
----------------
Palindromic words: None found
Most common letter: 'e' (6 occurrences)
Unique words: 13 out of 15 total words

Would you like to analyze another text? (yes/no): no

Thank you for using Word Statistics Analyzer!
```

## Technical Requirements

### Programming Concepts Used
- **Methods**: Organize analysis functions
- **Lists**: Store words, characters, frequencies
- **Arrays**: Process character data
- **Loops**: Iterate through text and collections
- **Selections**: Categorize and filter data
- **String manipulation**: Clean and process text
- **Input/Output**: Get text and display results

### Required Methods
```csharp
static List<string> ExtractWords(string text)
static Dictionary<string, int> CountWordFrequency(List<string> words)
static int CountCharacters(string text, bool includeSpaces)
static int CountSentences(string text)
static double CalculateAverageWordLength(List<string> words)
static string FindLongestWord(List<string> words)
static string FindShortestWord(List<string> words)
static int CountVowels(string text)
static int CountConsonants(string text)
static List<string> FindPalindromes(List<string> words)
static void DisplayWordFrequency(Dictionary<string, int> frequency)
static void DisplayCharacterAnalysis(string text)
```

## Implementation Guide

### Step 1: Text Input and Basic Processing
```csharp
using System;
using System.Collections.Generic;

static List<string> GetTextInput()
{
    List<string> lines = new List<string>();
    Console.WriteLine("Enter text to analyze (type 'END' on a new line to finish):");
    
    string line;
    while ((line = Console.ReadLine()) != "END")
    {
        lines.Add(line);
    }
    
    return lines;
}

static List<string> ExtractWords(string text)
{
    // Remove punctuation and split into words
    string cleanText = "";
    foreach (char c in text)
    {
        if (char.IsLetter(c) || char.IsWhiteSpace(c))
            cleanText += c;
        else
            cleanText += " ";  // Replace punctuation with space
    }
    
    string[] wordArray = cleanText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    List<string> words = new List<string>();
    
    foreach (string word in wordArray)
    {
        words.Add(word.ToLower());
    }
    
    return words;
}
```

### Step 2: Statistical Analysis Methods
```csharp
static Dictionary<string, int> CountWordFrequency(List<string> words)
{
    Dictionary<string, int> frequency = new Dictionary<string, int>();
    
    foreach (string word in words)
    {
        if (frequency.ContainsKey(word))
            frequency[word]++;
        else
            frequency[word] = 1;
    }
    
    return frequency;
}

static double CalculateAverageWordLength(List<string> words)
{
    if (words.Count == 0) return 0;
    
    int totalLength = 0;
    foreach (string word in words)
    {
        totalLength += word.Length;
    }
    
    return (double)totalLength / words.Count;
}
```

### Step 3: Advanced Analysis
```csharp
static List<string> FindPalindromes(List<string> words)
{
    List<string> palindromes = new List<string>();
    
    foreach (string word in words)
    {
        if (word.Length > 1 && IsPalindrome(word))
        {
            palindromes.Add(word);
        }
    }
    
    return palindromes;
}

static bool IsPalindrome(string word)
{
    for (int i = 0; i < word.Length / 2; i++)
    {
        if (word[i] != word[word.Length - 1 - i])
            return false;
    }
    return true;
}
```

## Hints

- Use `Dictionary<string, int>` for word frequency counting
- Use `char.IsLetter()`, `char.IsVowel()` for character analysis
- Split text into sentences using '.', '!', '?' as delimiters
- Clean text by removing punctuation before word extraction
- Use `string.Join()` to combine multiple input lines
- Calculate reading time: ~200 words per minute average

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n WordStatistics
   cd WordStatistics
   ```

2. Open `Program.cs` in your editor

3. Start with basic text input and word extraction

4. Add statistical methods incrementally

5. Test frequently:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Handle multi-line text input correctly
- Extract words properly (removing punctuation)
- Count frequencies accurately using appropriate data structures
- Calculate all required statistics correctly
- Display results in a clear, organized format
- Handle edge cases (empty input, single words, etc.)

## Extension Ideas

Once you complete the basic requirements, try adding:
- Reading level analysis (Flesch-Kincaid score)
- Most common word patterns or phrases
- Sentiment analysis (positive/negative word counting)
- Export results to a text file
- Compare statistics between multiple texts
- Graphical representation of word frequencies

## Assessment Criteria

This project demonstrates your mastery of:
- **Methods**: Creating reusable analysis functions
- **Collections**: Using lists and dictionaries effectively
- **String Processing**: Cleaning and analyzing text data
- **Loops**: Processing collections efficiently
- **Problem Solving**: Breaking complex analysis into steps
- **Code Organization**: Structuring a large program clearly