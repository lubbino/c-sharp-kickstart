using System;
using System.Collections.Generic;

namespace Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<List<double>> grades = new List<List<double>>();
            string[] subjects = {"Math", "Science", "English", "History"};
            
            Console.Write("Enter number of students: ");
            int numStudents = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < numStudents; i++)
            {
                Console.Write($"Enter name for student {i+1}: ");
                names.Add(Console.ReadLine());
                
                List<double> studentGrades = new List<double>();
                for(int j = 0; j < subjects.Length; j++)
                {
                    Console.Write($"Enter {subjects[j]} grade for {names[i]}: ");
                    studentGrades.Add(double.Parse(Console.ReadLine()));
                }
                grades.Add(studentGrades);
            }
            
            while(true)
            {
                Console.Clear();
                Console.WriteLine("=== Student Grade Management System ===");
                Console.WriteLine("1. Display all students");
                Console.WriteLine("2. Display student averages");
                Console.WriteLine("3. Display subject averages");
                Console.WriteLine("4. Display top student");
                Console.WriteLine("5. Display students below average");
                Console.WriteLine("6. Display grade distribution");
                Console.WriteLine("7. Exit");
                Console.Write("Enter choice: ");
                
                int choice = int.Parse(Console.ReadLine());
                
                if(choice == 1)
                {
                    Console.WriteLine("\n=== All Students ===");
                    Console.Write("Name".PadRight(15));
                    for(int i = 0; i < subjects.Length; i++)
                    {
                        Console.Write(subjects[i].PadRight(10));
                    }
                    Console.WriteLine("Average");
                    Console.WriteLine(new string('-', 60));
                    
                    for(int i = 0; i < names.Count; i++)
                    {
                        Console.Write(names[i].PadRight(15));
                        double sum = 0;
                        for(int j = 0; j < grades[i].Count; j++)
                        {
                            Console.Write(grades[i][j].ToString("F1").PadRight(10));
                            sum += grades[i][j];
                        }
                        Console.WriteLine((sum / grades[i].Count).ToString("F1"));
                    }
                }
                else if(choice == 2)
                {
                    Console.WriteLine("\n=== Student Averages ===");
                    for(int i = 0; i < names.Count; i++)
                    {
                        double sum = 0;
                        for(int j = 0; j < grades[i].Count; j++)
                        {
                            sum += grades[i][j];
                        }
                        double avg = sum / grades[i].Count;
                        char letterGrade;
                        if(avg >= 90) letterGrade = 'A';
                        else if(avg >= 80) letterGrade = 'B';
                        else if(avg >= 70) letterGrade = 'C';
                        else if(avg >= 60) letterGrade = 'D';
                        else letterGrade = 'F';
                        
                        Console.WriteLine($"{names[i]}: {avg:F1} ({letterGrade})");
                    }
                }
                else if(choice == 3)
                {
                    Console.WriteLine("\n=== Subject Averages ===");
                    for(int j = 0; j < subjects.Length; j++)
                    {
                        double sum = 0;
                        for(int i = 0; i < grades.Count; i++)
                        {
                            sum += grades[i][j];
                        }
                        Console.WriteLine($"{subjects[j]}: {(sum / grades.Count):F1}");
                    }
                }
                else if(choice == 4)
                {
                    Console.WriteLine("\n=== Top Student ===");
                    double highestAvg = 0;
                    int topStudentIndex = 0;
                    
                    for(int i = 0; i < names.Count; i++)
                    {
                        double sum = 0;
                        for(int j = 0; j < grades[i].Count; j++)
                        {
                            sum += grades[i][j];
                        }
                        double avg = sum / grades[i].Count;
                        if(avg > highestAvg)
                        {
                            highestAvg = avg;
                            topStudentIndex = i;
                        }
                    }
                    
                    Console.WriteLine($"Top student: {names[topStudentIndex]} with average {highestAvg:F1}");
                }
                else if(choice == 5)
                {
                    Console.WriteLine("\n=== Students Below Average ===");
                    double totalSum = 0;
                    int totalGrades = 0;
                    
                    for(int i = 0; i < grades.Count; i++)
                    {
                        for(int j = 0; j < grades[i].Count; j++)
                        {
                            totalSum += grades[i][j];
                            totalGrades++;
                        }
                    }
                    double overallAvg = totalSum / totalGrades;
                    
                    Console.WriteLine($"Overall average: {overallAvg:F1}");
                    Console.WriteLine("Students below average:");
                    
                    for(int i = 0; i < names.Count; i++)
                    {
                        double sum = 0;
                        for(int j = 0; j < grades[i].Count; j++)
                        {
                            sum += grades[i][j];
                        }
                        double avg = sum / grades[i].Count;
                        if(avg < overallAvg)
                        {
                            Console.WriteLine($"  {names[i]}: {avg:F1}");
                        }
                    }
                }
                else if(choice == 6)
                {
                    Console.WriteLine("\n=== Grade Distribution ===");
                    int countA = 0, countB = 0, countC = 0, countD = 0, countF = 0;
                    
                    for(int i = 0; i < names.Count; i++)
                    {
                        double sum = 0;
                        for(int j = 0; j < grades[i].Count; j++)
                        {
                            sum += grades[i][j];
                        }
                        double avg = sum / grades[i].Count;
                        
                        if(avg >= 90) countA++;
                        else if(avg >= 80) countB++;
                        else if(avg >= 70) countC++;
                        else if(avg >= 60) countD++;
                        else countF++;
                    }
                    
                    Console.WriteLine($"A: {countA} students");
                    Console.WriteLine($"B: {countB} students");
                    Console.WriteLine($"C: {countC} students");
                    Console.WriteLine($"D: {countD} students");
                    Console.WriteLine($"F: {countF} students");
                }
                else if(choice == 7)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }
                
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}