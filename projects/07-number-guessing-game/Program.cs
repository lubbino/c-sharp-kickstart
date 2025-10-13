// Project 1: Number Guessing Game
// A complete game that combines variables, I/O, selections, and iterations

using System;

Console.WriteLine("🎯 Number Guessing Game");
Console.WriteLine("======================");
Console.WriteLine("");

// TODO: Initialize game variables
Random random = new Random();
bool playAgain = true;
int gamesPlayed = 0;
int totalAttempts = 0;
int bestScore = 0;

// TODO: Main game loop
while (playAgain)
{
    // Start new round
    gamesPlayed++;
    int secretNumber = random.Next(1, 101);
    int attempts = 0;
    bool gameWon = false;
    string guess;
    int guessInterger;
    int score;
    string newGame;

    Console.WriteLine();
    Console.WriteLine($"🎯 Number Guessing Game - Round {gamesPlayed}");
    Console.WriteLine("I'm thinking of a number between 1 and 100...");
    Console.WriteLine("Can you guess what it is?");

    // TODO: Guessing loop
    while (!gameWon)
    {
        // TODO: Get and validate user guess
        // TODO: Provide feedback (too high, too low, correct)
        // TODO: Count attempts
        // TODO: Check if game is won
        attempts++;
        Console.WriteLine();
        Console.Write($"Attempt {attempts}: Enter your guess: ");
        guess = Console.ReadLine() ?? "";
        if (int.TryParse(guess, out guessInterger))
        {
            if (guessInterger < secretNumber)
            {
                Console.WriteLine("Too low! Try a higher number.");
            }
            else if (guessInterger > secretNumber)
            {
                Console.WriteLine("Too high! Try a lower number.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed it in {attempts} attempts!");
                gameWon = true;
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Guess is not valid try again.");
            attempts--;
        }
        ;
    }

    // TODO: Calculate and display score
    // TODO: Update statistics
    // TODO: Ask if player wants to play again
    score = 100 - attempts;
    totalAttempts += attempts;
    if (score > bestScore) bestScore = score;
    Console.WriteLine();
    Console.WriteLine($"Your Score: {score} points (100 - {attempts} attempts!)");
    Console.WriteLine();
    Console.Write("Would you like to play again? (yes/no): ");
    newGame = Console.ReadLine() ?? "".ToLower();
    if (newGame == "n" || newGame == "no") playAgain = false;
    
}

// TODO: Display final statistics
Console.WriteLine("Game Statistics:");
Console.WriteLine("===============");
Console.WriteLine($"Games Played: {gamesPlayed}");
Console.WriteLine($"Total Attempts: {totalAttempts}");
Console.WriteLine($"Average Attempts: {(double)totalAttempts / gamesPlayed:F1}");
Console.WriteLine($"Best Score: {bestScore} points");

Console.WriteLine("");
Console.WriteLine("Thanks for playing!");