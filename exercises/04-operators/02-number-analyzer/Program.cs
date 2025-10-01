using System;

Console.WriteLine("Number Analyzer");
Console.WriteLine("==============");
Console.WriteLine("");

int number = 42;

Console.WriteLine("Analyzing number: " + number);
Console.WriteLine("");

Console.WriteLine("Basic Properties:");
bool isPositive = number > 0;
bool isNegative = number < 0;
bool isZero = number == 0;
bool isEven = number % 2 == 0;
bool isOdd = !isEven;

Console.WriteLine("Is positive: " + isPositive);
Console.WriteLine("Is negative: " + isNegative);
Console.WriteLine("Is zero: " + isZero);
Console.WriteLine("Is even: " + isEven);
Console.WriteLine("Is odd: " + isOdd);

Console.WriteLine("");
Console.WriteLine("Divisibility Tests:");
bool divisibleBy2 = number % 2 == 0;
bool divisibleBy3 = number % 3 == 0;
bool divisibleBy5 = number % 5 == 0;
bool divisibleBy10 = number % 10 == 0;

Console.WriteLine("Divisible by 2: " + divisibleBy2);
Console.WriteLine("Divisible by 3: " + divisibleBy3);
Console.WriteLine("Divisible by 5: " + divisibleBy5);
Console.WriteLine("Divisible by 10: " + divisibleBy10);

Console.WriteLine("");
Console.WriteLine("Number Categories:");
bool isSingleDigit = number >= 0 && number <= 9;
bool isDoubleDigit = number >= 10 && number <= 99;
bool isTripleDigit = number >= 100 && number <= 999;
bool smallNumber = number < 50;
bool mediumNumber = number >= 50 && number <= 100;
bool bigNumber = number > 100; 

Console.WriteLine("Is single digit (0-9): " + isSingleDigit);
Console.WriteLine("Is double digit (10-99): " + isDoubleDigit);
Console.WriteLine("Is triple digit (100-999): " + isTripleDigit);
Console.WriteLine("Is small (< 50): " + smallNumber);
Console.WriteLine("Is medium (50-100): " + mediumNumber);
Console.WriteLine("Is large (> 100): " + bigNumber);

Console.WriteLine("");
Console.WriteLine("Special Properties:");
int lastDigit = number % 10;

Console.WriteLine("Last digit: " + lastDigit);