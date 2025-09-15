using System;
using System.IO;
using Xunit;

namespace IOExercises.Tests
{
    public class IOExerciseTests
    {
        private readonly string _basePath;

        public IOExerciseTests()
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
        public void UserInfoCollector_Exercise_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "05-io", "01-user-info-collector", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Exercise file should exist at {programPath}");
        }

        [Fact]
        public void UserInfoCollector_Exercise_ShouldContainRequiredElements()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "05-io", "01-user-info-collector", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("using System", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("Console.ReadLine", content);
            Assert.Contains("TODO", content);
        }

        [Fact]
        public void SafeInputCalculator_Exercise_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "05-io", "02-safe-input-calculator", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Exercise file should exist at {programPath}");
        }

        [Fact]
        public void SafeInputCalculator_Exercise_ShouldContainRequiredElements()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "05-io", "02-safe-input-calculator", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("using System", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("Console.ReadLine", content);
            Assert.Contains("TODO", content);
            Assert.Contains("safe", content.ToLower());
        }

        [Fact]
        public void UserInfoCollector_Solution_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "05-io", "01-user-info-collector", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Solution file should exist at {programPath}");
        }

        [Fact]
        public void UserInfoCollector_Solution_ShouldContainInputOutput()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "05-io", "01-user-info-collector", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("Console.ReadLine", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("name", content.ToLower());
            Assert.Contains("age", content.ToLower());
        }

        [Fact]
        public void SafeInputCalculator_Solution_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "05-io", "02-safe-input-calculator", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Solution file should exist at {programPath}");
        }

        [Fact]
        public void SafeInputCalculator_Solution_ShouldContainSafeInput()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "05-io", "02-safe-input-calculator", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("Parse", content);
            Assert.Contains("Console.ReadLine", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("double", content);
        }

        [Theory]
        [InlineData("01-user-info-collector")]
        [InlineData("02-safe-input-calculator")]
        public void Exercise_ShouldHaveProjectFile(string exerciseName)
        {
            // Arrange
            string exercisePath = Path.Combine(_basePath, "exercises", "05-io", exerciseName);
            
            // Act
            string[] csprojFiles = Directory.GetFiles(exercisePath, "*.csproj");
            
            // Assert
            Assert.Single(csprojFiles);
        }

        [Theory]
        [InlineData("01-user-info-collector")]
        [InlineData("02-safe-input-calculator")]
        public void Solution_ShouldHaveProjectFile(string exerciseName)
        {
            // Arrange
            string solutionPath = Path.Combine(_basePath, "solutions", "05-io", exerciseName);
            
            // Act
            string[] csprojFiles = Directory.GetFiles(solutionPath, "*.csproj");
            
            // Assert
            Assert.Single(csprojFiles);
        }
    }
}