using System;
using System.IO;
using Xunit;

namespace VariablesExercises.Tests
{
    public class VariablesExerciseTests
    {
        private readonly string _basePath;

        public VariablesExerciseTests()
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
        public void PersonalInfo_Exercise_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "03-variables", "01-personal-info", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Exercise file should exist at {programPath}");
        }

        [Fact]
        public void PersonalInfo_Exercise_ShouldContainRequiredElements()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "03-variables", "01-personal-info", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("using System", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("TODO", content);
            Assert.Contains("variable", content.ToLower());
        }

        [Fact]
        public void TypeConversion_Exercise_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "03-variables", "02-type-conversion", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Exercise file should exist at {programPath}");
        }

        [Fact]
        public void TypeConversion_Exercise_ShouldContainRequiredElements()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "03-variables", "02-type-conversion", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("using System", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("TODO", content);
            Assert.Contains("conversion", content.ToLower());
        }

        [Fact]
        public void PersonalInfo_Solution_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "03-variables", "01-personal-info", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Solution file should exist at {programPath}");
        }

        [Fact]
        public void PersonalInfo_Solution_ShouldContainVariableTypes()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "03-variables", "01-personal-info", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("int", content);
            Assert.Contains("string", content);
            Assert.Contains("double", content);
            Assert.Contains("Console.WriteLine", content);
        }

        [Fact]
        public void TypeConversion_Solution_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "03-variables", "02-type-conversion", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Solution file should exist at {programPath}");
        }

        [Fact]
        public void TypeConversion_Solution_ShouldContainConversion()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "03-variables", "02-type-conversion", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("ToString", content);
            Assert.Contains("Parse", content);
            Assert.Contains("(int)", content);
            Assert.Contains("Console.WriteLine", content);
        }

        [Theory]
        [InlineData("01-personal-info")]
        [InlineData("02-type-conversion")]
        public void Exercise_ShouldHaveProjectFile(string exerciseName)
        {
            // Arrange
            string exercisePath = Path.Combine(_basePath, "exercises", "03-variables", exerciseName);
            
            // Act
            string[] csprojFiles = Directory.GetFiles(exercisePath, "*.csproj");
            
            // Assert
            Assert.Single(csprojFiles);
        }

        [Theory]
        [InlineData("01-personal-info")]
        [InlineData("02-type-conversion")]
        public void Solution_ShouldHaveProjectFile(string exerciseName)
        {
            // Arrange
            string solutionPath = Path.Combine(_basePath, "solutions", "03-variables", exerciseName);
            
            // Act
            string[] csprojFiles = Directory.GetFiles(solutionPath, "*.csproj");
            
            // Assert
            Assert.Single(csprojFiles);
        }
    }
}