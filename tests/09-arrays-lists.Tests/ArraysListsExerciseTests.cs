using System;
using System.IO;
using Xunit;

namespace ArraysListsExercises.Tests
{
    public class ArraysListsExerciseTests
    {
        private readonly string _basePath;

        public ArraysListsExerciseTests()
        {
            // Find the project root by looking for the exercises folder
            string currentDir = Directory.GetCurrentDirectory();
            string searchDir = currentDir;
            
            // Navigate up until we find the project root (contains exercises and solutions folders)
            while (searchDir != null && !Directory.Exists(Path.Combine(searchDir, "exercises")))
            {
                string? parentDir = Directory.GetParent(searchDir)?.FullName;
                if (parentDir == null || parentDir == searchDir)
                {
                    break; // Reached root
                }
                searchDir = parentDir;
            }
            
            _basePath = searchDir ?? throw new DirectoryNotFoundException("Could not find project root containing exercises folder");
        }

        [Fact]
        public void GradeAnalyzer_Exercise_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "09-arrays-lists", "01-grade-analyzer", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Exercise file should exist at {programPath}");
        }

        [Fact]
        public void GradeAnalyzer_Exercise_ShouldContainRequiredElements()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "09-arrays-lists", "01-grade-analyzer", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("using System", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("TODO", content);
            Assert.Contains("List", content);
        }

        [Fact]
        public void ShoppingList_Exercise_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "09-arrays-lists", "02-shopping-list", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Exercise file should exist at {programPath}");
        }

        [Fact]
        public void ShoppingList_Exercise_ShouldContainRequiredElements()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "09-arrays-lists", "02-shopping-list", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("using System", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("TODO", content);
            Assert.Contains("List", content);
        }

        [Fact]
        public void GradeAnalyzer_Solution_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "09-arrays-lists", "01-grade-analyzer", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Solution file should exist at {programPath}");
        }

        [Fact]
        public void GradeAnalyzer_Solution_ShouldContainArrayOperations()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "09-arrays-lists", "01-grade-analyzer", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("List<double>", content);
            Assert.Contains("CalculateAverage", content);
            Assert.Contains("FindHighest", content);
            Assert.Contains("Console.WriteLine", content);
        }

        [Fact]
        public void ShoppingList_Solution_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "09-arrays-lists", "02-shopping-list", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Solution file should exist at {programPath}");
        }

        [Fact]
        public void ShoppingList_Solution_ShouldContainListOperations()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "09-arrays-lists", "02-shopping-list", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("List<string>", content);
            Assert.Contains("Add", content);
            Assert.Contains("Remove", content);
            Assert.Contains("Console.WriteLine", content);
        }

        [Theory]
        [InlineData("01-grade-analyzer")]
        [InlineData("02-shopping-list")]
        public void Exercise_ShouldHaveProjectFile(string exerciseName)
        {
            // Arrange
            string exercisePath = Path.Combine(_basePath, "exercises", "09-arrays-lists", exerciseName);
            
            // Act
            string[] csprojFiles = Directory.GetFiles(exercisePath, "*.csproj");
            
            // Assert
            Assert.Single(csprojFiles);
        }

        [Theory]
        [InlineData("01-grade-analyzer")]
        [InlineData("02-shopping-list")]
        public void Solution_ShouldHaveProjectFile(string exerciseName)
        {
            // Arrange
            string solutionPath = Path.Combine(_basePath, "solutions", "09-arrays-lists", exerciseName);
            
            // Act
            string[] csprojFiles = Directory.GetFiles(solutionPath, "*.csproj");
            
            // Assert
            Assert.Single(csprojFiles);
        }
    }
}