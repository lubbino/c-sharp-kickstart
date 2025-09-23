# Text Analysis Project

## Overview
This project demonstrates input/output concepts by creating a text analysis tool. The program will prompt the user to enter text and then analyze various properties of that text.

## Learning Objectives
- Practice reading user input
- Work with string manipulation
- Display formatted output
- Handle different types of input validation

## Requirements
Create a program that:

1. **Prompts the user** to enter a sentence or paragraph
2. **Analyzes the text** and displays:
   - Total number of characters (including spaces)
   - Total number of characters (excluding spaces)
   - Number of words
   - Number of vowels (a, e, i, o, u)
   - Number of consonants
   - Number of digits
   - Number of special characters

3. **Asks if the user wants to analyze another text** and repeats if yes

## Sample Output
```
=== Text Analysis Tool ===

Enter text to analyze: Hello World! 123

Analysis Results:
- Total characters (with spaces): 16
- Total characters (without spaces): 13
- Number of words: 3
- Number of vowels: 3
- Number of consonants: 7
- Number of digits: 3
- Number of special characters: 1

Would you like to analyze another text? (y/n): n

Thank you for using the Text Analysis Tool!
```

## Tips
- Use `Console.ReadLine()` to read user input
- Consider using `char.IsLetter()`, `char.IsDigit()`, and `char.IsWhiteSpace()` methods
- Remember to handle both uppercase and lowercase vowels
- Think about how to count words (hint: split by spaces)

## Challenge Extensions
- Add analysis for most frequent character
- Count sentences (by periods, exclamation marks, question marks)
- Calculate average word length