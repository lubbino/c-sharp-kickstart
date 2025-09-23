# Student Grade Manager Project

## Overview
This project demonstrates arrays and lists by creating a comprehensive student grade management system. Students will learn to work with collections, perform data analysis, and implement CRUD (Create, Read, Update, Delete) operations.

## Learning Objectives
- Practice working with arrays and Lists
- Learn collection manipulation (add, remove, search, sort)
- Understand the difference between arrays and Lists
- Practice data analysis with collections
- Work with multi-dimensional data structures
- Learn LINQ basics for data querying

## Requirements
Create a program that:

1. **Manages student information** including:
   - Student names
   - Multiple grades per student
   - Subject names
   - Grade calculations

2. **Provides the following functionality**:
   - 1. Add New Student
   - 2. Add Grade to Student
   - 3. View All Students
   - 4. View Student Details
   - 5. Calculate Class Statistics
   - 6. Find Top Performers
   - 7. Search Students
   - 8. Remove Student
   - 9. Export Grade Report
   - 10. Exit

3. **Implements data analysis features**:
   - Individual student averages
   - Class average
   - Highest and lowest grades
   - Grade distribution
   - Subject-wise analysis

4. **Validates all inputs** and handles edge cases

5. **Uses both arrays and Lists** appropriately:
   - Arrays for fixed-size data (e.g., grade categories)
   - Lists for dynamic collections (students, grades)

## Sample Output
```
=== Student Grade Manager ===

Current Students: 3

Menu:
1. Add New Student
2. Add Grade to Student
3. View All Students
4. View Student Details
5. Calculate Class Statistics
6. Find Top Performers
7. Search Students
8. Remove Student
9. Export Grade Report
10. Exit

Choose an option (1-10): 1

Enter student name: Alice Johnson
Student 'Alice Johnson' added successfully!

Choose an option (1-10): 2

Available students:
1. Alice Johnson
2. Bob Smith
3. Carol Davis

Select student (1-3): 1
Enter subject: Mathematics
Enter grade (0-100): 95

Grade added: Mathematics - 95

Choose an option (1-10): 5

=== Class Statistics ===
Total Students: 3
Total Grades Recorded: 12

Class Average: 87.5
Highest Grade: 98 (Bob Smith - Physics)
Lowest Grade: 72 (Carol Davis - History)

Grade Distribution:
A (90-100): 5 grades (41.7%)
B (80-89):  4 grades (33.3%)
C (70-79):  3 grades (25.0%)
D (60-69):  0 grades (0.0%)
F (0-59):   0 grades (0.0%)

Choose an option (1-10): 10

Thank you for using Student Grade Manager!
```

## Data Structures

### Student Class
```csharp
class Student
{
    public string Name { get; set; }
    public List<Grade> Grades { get; set; }
    public double Average => Grades.Count > 0 ? Grades.Average(g => g.Score) : 0;
}

class Grade
{
    public string Subject { get; set; }
    public double Score { get; set; }
    public DateTime DateAdded { get; set; }
}
```

### Collections Used
```csharp
List<Student> students = new List<Student>();
string[] gradeLetters = { "A", "B", "C", "D", "F" };
double[] gradeThresholds = { 90, 80, 70, 60, 0 };
```

## Key Features

### Student Management
- Add new students to the system
- Remove students (with confirmation)
- Search students by name (partial matching)
- View detailed student information

### Grade Management
- Add grades for specific subjects
- View all grades for a student
- Calculate individual and class averages
- Track grade history with dates

### Statistics and Analysis
- Class-wide statistics
- Grade distribution analysis
- Top performer identification
- Subject-wise performance analysis

### Data Export
- Generate formatted grade reports
- Export to console or file
- Summary statistics included

## Tips
- Use `List<T>` for dynamic collections that grow/shrink
- Use arrays for fixed-size data like grade categories
- Consider using LINQ for data queries (`Where`, `OrderBy`, `Average`)
- Validate grade ranges (0-100)
- Handle empty collections gracefully
- Use meaningful variable names for collections

## Challenge Extensions
- Add grade weighting (tests vs homework)
- Implement grade curves and adjustments
- Add semester/term organization
- Create graphical grade distribution
- Add import from CSV file
- Implement grade prediction based on trends
- Add parent/teacher access levels
- Create automated grade alerts for low performance