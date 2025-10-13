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
    
    Console.WriteLine($"🎯 Number Guessing Game - Round {gamesPlayed}");
    Console.WriteLine("I'm thinking of a number between 1 and 100...");
    Console.WriteLine("");
    
    // TODO: Guessing loop
    while (!gameWon)
    {
        // TODO: Get and validate user guess
        // TODO: Provide feedback (too high, too low, correct)
        // TODO: Count attempts
        // TODO: Check if game is won
    }
    
    // TODO: Calculate and display score
    // TODO: Update statistics
    // TODO: Ask if player wants to play again
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