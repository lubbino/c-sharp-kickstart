# Exercise 06-01: Grade Classifier

## Background

This exercise helps you practice using if/else statements to make decisions based on user input and classify data into different categories.

## Instructions

Create a C# console application that asks for a student's test score and classifies it into a letter grade with additional feedback.

## Requirements

1. Prompt the user to enter a test score (0-100)
2. Use if/else if/else statements to determine the letter grade
3. Provide additional feedback based on the grade
4. Handle invalid scores (negative numbers or scores over 100)
5. Display the score, letter grade, and feedback clearly

## Grading Scale

- A: 90-100 (Excellent work!)
- B: 80-89 (Good job!)
- C: 70-79 (Satisfactory)
- D: 60-69 (Needs improvement)
- F: 0-59 (Please see teacher)

## Expected Output

Your program should produce output similar to this:

```
Grade Classifier
===============

Enter your test score (0-100): 85

Results:
Score: 85
Letter Grade: B
Feedback: Good job!
```

**Invalid Input Example:**
```
Enter your test score (0-100): 105

Error: Score must be between 0 and 100.
Please enter a valid score: 92

Results:
Score: 92
Letter Grade: A
Feedback: Excellent work!
```

## Hints

- Use `if (score >= 90)` for the highest grade first
- Use `else if` for the remaining grade ranges
- Use `else` for the failing grade
- Check for invalid input before processing grades
- Use logical operators: `score < 0 || score > 100`

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n GradeClassifier
   cd GradeClassifier
   ```

2. Open `Program.cs` in your editor

3. Implement the grade classification logic

4. Run your program:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Handle all grade ranges correctly (A, B, C, D, F)
- Provide appropriate feedback for each grade
- Validate input and reject invalid scores
- Display results in a clear, formatted way
- Use proper if/else if/else structure