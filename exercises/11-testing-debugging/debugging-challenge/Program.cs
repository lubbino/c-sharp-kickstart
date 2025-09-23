using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DebuggingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var analyzer = new StudentGradeAnalyzer();
            
            // Add some test data
            analyzer.AddStudent("Alice", new List<double> { 85.5, 92.0, 78.5, 88.0 });
            analyzer.AddStudent("Bob", new List<double> { 76.0, 84.5, 91.0, 79.5 });
            analyzer.AddStudent("Charlie", new List<double> { 95.0, 88.5, 92.5, 90.0 });
            analyzer.AddStudent("Diana", new List<double> { 67.5, 72.0, 69.5, 71.0 });
            
            // Test various operations
            Console.WriteLine("=== Student Grade Analyzer ===");
            
            try
            {
                Console.WriteLine("\n1. All Students:");
                analyzer.DisplayAllStudents();
                
                Console.WriteLine("\n2. Student Averages:");
                analyzer.DisplayStudentAverages();
                
                Console.WriteLine("\n3. Top Student:");
                var topStudent = analyzer.FindTopStudent();
                Console.WriteLine($"Top student: {topStudent}");
                
                Console.WriteLine("\n4. Assignment Averages:");
                analyzer.DisplayAssignmentAverages();
                
                Console.WriteLine("\n5. Students Needing Help:");
                analyzer.DisplayStudentsNeedingHelp();
                
                Console.WriteLine("\n6. Grade Distribution:");
                analyzer.DisplayGradeDistribution();
                
                Console.WriteLine("\n7. Saving to file...");
                analyzer.SaveToFile("grades.csv");
                Console.WriteLine("Data saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    public class StudentGradeAnalyzer
    {
        private List<string> studentNames;
        private List<List<double>> studentGrades;
        private string[] subjects = { "Math", "Science", "English", "History" };

        public StudentGradeAnalyzer()
        {
            studentNames = new List<string>();
            studentGrades = new List<List<double>>();
        }

        public void AddStudent(string name, List<double> grades)
        {
            studentNames.Add(name);
            studentGrades.Add(grades);
        }

        public void DisplayAllStudents()
        {
            Console.WriteLine("Name".PadRight(15) + "Math".PadRight(8) + "Science".PadRight(8) + "English".PadRight(8) + "History".PadRight(8) + "Average");
            Console.WriteLine(new string('-', 60));
            
            // BUG: Off-by-one error - should use < instead of <=
            for (int i = 0; i <= studentNames.Count; i++)
            {
                Console.Write(studentNames[i].PadRight(15));
                double sum = 0;
                for (int j = 0; j < studentGrades[i].Count; j++)
                {
                    Console.Write(studentGrades[i][j].ToString("F1").PadRight(8));
                    sum += studentGrades[i][j];
                }
                Console.WriteLine((sum / studentGrades[i].Count).ToString("F1"));
            }
        }

        public void DisplayStudentAverages()
        {
            for (int i = 0; i < studentNames.Count; i++)
            {
                double average = CalculateStudentAverage(i);
                char letterGrade = GetLetterGrade(average);
                Console.WriteLine($"{studentNames[i]}: {average:F1} ({letterGrade})");
            }
        }

        public double CalculateStudentAverage(int studentIndex)
        {
            double sum = 0;
            // BUG: No check for empty grades list
            for (int i = 0; i < studentGrades[studentIndex].Count; i++)
            {
                sum += studentGrades[studentIndex][i];
            }
            return sum / studentGrades[studentIndex].Count;
        }

        public char GetLetterGrade(double percentage)
        {
            // BUG: Should use >= instead of > for inclusive boundaries
            if (percentage > 90) return 'A';
            if (percentage > 80) return 'B';
            if (percentage > 70) return 'C';
            if (percentage > 60) return 'D';
            return 'F';
        }

        public string FindTopStudent()
        {
            // BUG: Wrong initialization - should handle case where all averages might be negative
            double highestAverage = 0;
            int topStudentIndex = 0;

            for (int i = 0; i < studentNames.Count; i++)
            {
                double average = CalculateStudentAverage(i);
                if (average > highestAverage)
                {
                    highestAverage = average;
                    topStudentIndex = i;
                }
            }

            return $"{studentNames[topStudentIndex]} ({highestAverage:F1})";
        }

        public void DisplayAssignmentAverages()
        {
            for (int j = 0; j < subjects.Length; j++)
            {
                double sum = 0;
                // BUG: No check for empty student list
                for (int i = 0; i < studentNames.Count; i++)
                {
                    sum += studentGrades[i][j];
                }
                double average = sum / studentNames.Count;
                Console.WriteLine($"{subjects[j]}: {average:F1}");
            }
        }

        public void DisplayStudentsNeedingHelp()
        {
            double overallAverage = CalculateOverallAverage();
            Console.WriteLine($"Overall average: {overallAverage:F1}");
            Console.WriteLine("Students below average:");

            for (int i = 0; i < studentNames.Count; i++)
            {
                double studentAverage = CalculateStudentAverage(i);
                // BUG: Should use < instead of <= for "below average"
                if (studentAverage <= overallAverage)
                {
                    Console.WriteLine($"  {studentNames[i]}: {studentAverage:F1}");
                }
            }
        }

        public double CalculateOverallAverage()
        {
            double totalSum = 0;
            int totalGrades = 0;

            for (int i = 0; i < studentNames.Count; i++)
            {
                for (int j = 0; j < studentGrades[i].Count; j++)
                {
                    totalSum += studentGrades[i][j];
                    totalGrades++;
                }
            }

            // BUG: No check for division by zero
            return totalSum / totalGrades;
        }

        public void DisplayGradeDistribution()
        {
            int[] gradeCounts = new int[5]; // A, B, C, D, F

            for (int i = 0; i < studentNames.Count; i++)
            {
                double average = CalculateStudentAverage(i);
                char grade = GetLetterGrade(average);

                // BUG: This logic is flawed - should use switch or if-else
                if (grade == 'A') gradeCounts[0]++;
                if (grade == 'B') gradeCounts[1]++;
                if (grade == 'C') gradeCounts[2]++;
                if (grade == 'D') gradeCounts[3]++;
                if (grade == 'F') gradeCounts[4]++;
            }

            string[] gradeLabels = { "A", "B", "C", "D", "F" };
            for (int i = 0; i < gradeLabels.Length; i++)
            {
                Console.WriteLine($"{gradeLabels[i]}: {gradeCounts[i]} students");
            }
        }

        public double FindHighestGrade(int assignmentIndex)
        {
            // BUG: Wrong initialization for finding maximum
            double highest = 0;

            // BUG: No bounds checking for assignmentIndex
            for (int i = 0; i < studentNames.Count; i++)
            {
                if (studentGrades[i][assignmentIndex] > highest)
                {
                    highest = studentGrades[i][assignmentIndex];
                }
            }

            return highest;
        }

        public void SaveToFile(string filename)
        {
            // BUG: No error handling for file operations
            StreamWriter writer = new StreamWriter(filename);
            
            // Write header
            writer.Write("Name,");
            for (int i = 0; i < subjects.Length; i++)
            {
                writer.Write(subjects[i]);
                if (i < subjects.Length - 1) writer.Write(",");
            }
            writer.WriteLine(",Average");

            // Write student data
            for (int i = 0; i < studentNames.Count; i++)
            {
                writer.Write($"{studentNames[i]},");
                for (int j = 0; j < studentGrades[i].Count; j++)
                {
                    writer.Write($"{studentGrades[i][j]:F1}");
                    if (j < studentGrades[i].Count - 1) writer.Write(",");
                }
                double average = CalculateStudentAverage(i);
                writer.WriteLine($",{average:F1}");
            }

            // BUG: Not properly disposing of the StreamWriter
            writer.Close();
        }
    }
}