# Project 1: Number Guessing Game

## Background

This project combines everything you've learned in Chapters 1-7 to create a complete, interactive game. You'll use variables, input/output, selections, and iterations to build a fun number guessing game.

## Project Description

Create a number guessing game where the computer picks a random number and the player tries to guess it. The game should provide hints and track the player's progress.

## Requirements

### Core Features
1. Generate a random number between 1 and 100
2. Allow the player to make guesses
3. Provide feedback: "too high", "too low", or "correct"
4. Count the number of attempts
5. Allow the player to play multiple rounds
6. Display game statistics

### Advanced Features
7. Implement difficulty levels (different number ranges)
8. Add a scoring system based on number of guesses
9. Keep track of best score across multiple games
10. Validate all user input properly

## Expected Output

Your game should work similar to this:

```
🎯 Number Guessing Game
======================

Welcome! I'm thinking of a number between 1 and 100.
Can you guess what it is?

Attempt 1: Enter your guess: 50
Too high! Try a lower number.

Attempt 2: Enter your guess: 25
Too low! Try a higher number.

Attempt 3: Enter your guess: 37
Too high! Try a lower number.

Attempt 4: Enter your guess: 31
Too low! Try a higher number.

Attempt 5: Enter your guess: 34
Congratulations! You guessed it in 5 attempts!

Your Score: 95 points (100 - 5 attempts)

Would you like to play again? (yes/no): yes

🎯 Number Guessing Game - Round 2
================================

I'm thinking of a new number between 1 and 100...

Attempt 1: Enter your guess: 75
Too low! Try a higher number.

Attempt 2: Enter your guess: 88
Congratulations! You guessed it in 2 attempts!

Your Score: 98 points (100 - 2 attempts)
Best Score This Session: 98 points

Would you like to play again? (yes/no): no

Game Statistics:
===============
Games Played: 2
Total Attempts: 7
Average Attempts: 3.5
Best Score: 98 points

Thanks for playing!
```

## Technical Requirements

### Programming Concepts Used
- **Variables**: Store game state, scores, attempts
- **Input/Output**: Get guesses, display feedback
- **Selections**: Compare guesses, validate input, handle menu choices
- **Iterations**: Game loop, input validation loops
- **Random Numbers**: Generate secret number
- **Type Conversion**: Parse user input safely

### Code Quality
- Use meaningful variable names
- Add comments explaining complex logic
- Handle invalid input gracefully
- Follow C# naming conventions
- Organize code into logical sections

## Implementation Guide

### Step 1: Basic Game Structure
```csharp
using System;

Random random = new Random();
int secretNumber = random.Next(1, 101);
int attempts = 0;
bool gameWon = false;

Console.WriteLine("Number Guessing Game");
Console.WriteLine("===================");
Console.WriteLine("I'm thinking of a number between 1 and 100.");

while (!gameWon)
{
    // Get guess, provide feedback, check if correct
}
```

### Step 2: Add Input Validation
```csharp
int guess = 0;
bool validInput = false;

while (!validInput)
{
    Console.WriteLine($"Attempt {attempts + 1}: Enter your guess:");
    string input = Console.ReadLine();
    
    if (int.TryParse(input, out guess) && guess >= 1 && guess <= 100)
    {
        validInput = true;
    }
    else
    {
        Console.WriteLine("Please enter a number between 1 and 100.");
    }
}
```

### Step 3: Add Multiple Rounds
```csharp
bool playAgain = true;
int gamesPlayed = 0;
int totalAttempts = 0;
int bestScore = 0;

while (playAgain)
{
    // Play one round
    // Update statistics
    // Ask if player wants to continue
}
```

## Hints

- Use `Random.Next(1, 101)` for numbers 1-100
- Track attempts with a counter variable
- Use `if/else if/else` for guess feedback
- Use `while` loops for input validation
- Calculate score: `100 - attempts` (minimum 1 point)
- Use `ToLower()` for yes/no questions

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n NumberGuessingGame
   cd NumberGuessingGame
   ```

2. Open `Program.cs` in your editor

3. Start with the basic game structure

4. Add features incrementally

5. Test frequently:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your game should:
- Compile without errors
- Generate random numbers correctly
- Provide accurate feedback (too high/low/correct)
- Count attempts accurately
- Handle invalid input gracefully
- Allow multiple rounds
- Calculate and display statistics
- Use all required programming concepts

## Extension Ideas

Once you complete the basic requirements, try adding:
- Different difficulty levels (1-10, 1-1000, etc.)
- Hints system (show if guess is "very close")
- Time limits for guesses
- High score persistence between program runs
- Two-player mode where players take turns

## Assessment Criteria

This project demonstrates your mastery of:
- **Planning**: Breaking down a complex problem
- **Implementation**: Using variables, I/O, selections, iterations
- **Testing**: Ensuring the game works correctly
- **Code Quality**: Clean, readable, well-commented code
- **User Experience**: Clear instructions and feedback