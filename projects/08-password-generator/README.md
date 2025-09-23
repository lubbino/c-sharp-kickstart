# Password Generator Project

## Overview
This project demonstrates advanced function concepts by creating a customizable password generator. Students will learn about functions with multiple parameters, default values, random number generation, and string manipulation functions.

## Learning Objectives
- Practice creating functions with multiple parameters
- Learn about default parameter values
- Work with random number generation
- Practice string manipulation and building
- Understand function composition (calling functions from other functions)
- Learn about validation functions

## Requirements
Create a program that:

1. **Displays a welcome message** and shows password generation options

2. **Offers different password types**:
   - 1. Simple Password (letters only)
   - 2. Standard Password (letters + numbers)
   - 3. Strong Password (letters + numbers + symbols)
   - 4. Custom Password (user chooses character sets)
   - 5. Memorable Password (pronounceable)
   - 6. PIN Generator (numbers only)
   - 7. Exit

3. **For each password type, asks for**:
   - Password length (with validation)
   - Number of passwords to generate
   - Additional options based on type

4. **Generates and displays passwords** with strength analysis

5. **Includes password strength checker** that evaluates:
   - Length
   - Character variety
   - Common patterns
   - Overall strength score

6. **Validates all inputs** and provides helpful error messages

## Sample Output
```
=== Password Generator ===

Password Types:
1. Simple Password (letters only)
2. Standard Password (letters + numbers)
3. Strong Password (letters + numbers + symbols)
4. Custom Password (choose character sets)
5. Memorable Password (pronounceable)
6. PIN Generator (numbers only)
7. Exit

Choose password type (1-7): 3

Enter password length (8-128): 16
Enter number of passwords to generate: 3

Generated Strong Passwords:
1. K9#mP2$vX8@nQ4!z - Strength: Very Strong (95/100)
2. R7&bN5%wL3*jH9@s - Strength: Very Strong (92/100)
3. F4#dM8$yT6!cV2&x - Strength: Very Strong (94/100)

Password Analysis:
✓ Length: Excellent (16 characters)
✓ Uppercase letters: Yes
✓ Lowercase letters: Yes
✓ Numbers: Yes
✓ Special characters: Yes
✓ No common patterns detected

Choose password type (1-7): 5

Enter password length (6-20): 12
Enter number of passwords to generate: 2

Generated Memorable Passwords:
1. BlueCat47Sun - Strength: Good (78/100)
2. RedDog23Moon - Strength: Good (76/100)

Choose password type (1-7): 7

Thank you for using Password Generator!
```

## Function Examples

### Core Generation Functions
```csharp
static string GenerateSimplePassword(int length)
static string GenerateStandardPassword(int length)
static string GenerateStrongPassword(int length)
static string GenerateCustomPassword(int length, bool includeUpper, bool includeLower, bool includeNumbers, bool includeSymbols)
static string GenerateMemorablePassword(int length)
static string GeneratePIN(int length)
```

### Helper Functions
```csharp
static char GetRandomCharacter(string characterSet)
static string ShuffleString(string input)
static bool IsValidLength(int length, int min, int max)
static int CalculatePasswordStrength(string password)
static void DisplayPasswordAnalysis(string password)
```

### Validation Functions
```csharp
static bool ContainsUppercase(string password)
static bool ContainsLowercase(string password)
static bool ContainsNumbers(string password)
static bool ContainsSymbols(string password)
static bool HasCommonPatterns(string password)
```

## Tips
- Use `Random` class for generating random characters
- Define character sets as constants (e.g., `const string UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"`)
- Use `StringBuilder` for efficient string building
- Consider using default parameter values for optional settings
- Validate password length ranges for different types
- Use functions to break down complex operations into smaller parts

## Character Sets
```csharp
const string UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
const string LOWERCASE = "abcdefghijklmnopqrstuvwxyz";
const string NUMBERS = "0123456789";
const string SYMBOLS = "!@#$%^&*()_+-=[]{}|;:,.<>?";
const string MEMORABLE_WORDS = "Cat,Dog,Sun,Moon,Star,Blue,Red,Green";
```

## Challenge Extensions
- Add password history (avoid duplicates)
- Implement password export to file
- Add password complexity requirements
- Create password templates (e.g., "Word-Number-Symbol")
- Add pronunciation guide for memorable passwords
- Implement password expiration suggestions
- Add batch generation with different criteria