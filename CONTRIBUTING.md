# 🤝 Contributing to C# Kickstart

Thank you for your interest in contributing to C# Kickstart! This guide will help you get started with contributing to this educational project.

## 📋 Table of Contents

- [Code of Conduct](#code-of-conduct)
- [Content Style Guide](#content-style-guide)
- [Getting Started](#getting-started)
- [Development Setup](#development-setup)
- [Contributing Guidelines](#contributing-guidelines)
- [Pull Request Process](#pull-request-process)
- [Issue Guidelines](#issue-guidelines)
- [Coding Standards](#coding-standards)
- [Testing Requirements](#testing-requirements)

## 🤗 Code of Conduct

This project is an educational resource. We expect all contributors to:

- Be respectful and inclusive
- Focus on what's best for students and teachers
- Provide constructive feedback
- Help maintain a welcoming learning environment

## 📝 Content Style Guide

**IMPORTANT**: Before contributing any content, please read our [Content Style Guide](docs/content-style-guide.md).

### Key Rules for Content:

#### 📖 **Book Chapters & Exercises - MINIMAL EMOJI USAGE**
- **Book chapters**: Use emojis ONLY for major section headers
- **Exercises**: NO emojis in instructions, keep professional tone
- **Focus**: Clear, educational content over visual decoration

#### ✅ **Good Example**:
```markdown
# Chapter 03: Variables and Data Types

## Learning Objectives
## Core Concepts
```

#### ❌ **Avoid**:
```markdown
# 🎯 Chapter 03: Variables and Data Types 🔢
## 📚 Learning Objectives 🎯
- ✨ Learn about variables! 🎉
```

**Why**: Students and teachers need professional, distraction-free content that focuses on learning programming concepts.

## 🚀 Getting Started

### Prerequisites

- .NET 8.0 SDK or later
- Visual Studio Code with C# Dev Kit extension
- Git for version control
- Basic understanding of C# and educational content development

### Development Setup

1. **Fork the repository** on GitHub
2. **Clone your fork** locally:
   ```bash
   git clone https://github.com/YOUR-USERNAME/c-sharp-kickstart.git
   cd c-sharp-kickstart
   ```
3. **Set up the upstream remote**:
   ```bash
   git remote add upstream https://github.com/ORIGINAL-OWNER/c-sharp-kickstart.git
   ```
4. **Test your setup**:
   ```bash
   # Test console template
   cd templates/console-app
   dotnet run
   
   # Test xUnit template
   cd ../xunit-project
   dotnet test
   ```

## 📝 Contributing Guidelines

### Types of Contributions

We welcome contributions in these areas:

#### 📚 **Content Development**
- New chapters or exercises
- Improved explanations or examples
- Additional practice problems
- Translation improvements

#### 🧪 **Testing & Quality**
- New test cases
- Bug fixes in existing tests
- Performance improvements
- Code quality enhancements

#### 📖 **Documentation**
- README improvements
- API documentation
- Teacher guides and lesson plans
- Troubleshooting guides

#### 🛠️ **Infrastructure**
- CI/CD improvements
- Build process enhancements
- Development tooling

### What We're Looking For

- **Beginner-friendly content**: Remember our audience is new to programming
- **Clear, concise explanations**: Avoid jargon, explain concepts step-by-step
- **Practical examples**: Real-world applications students can relate to
- **Comprehensive testing**: All code should have corresponding tests
- **Curriculum alignment**: Content should align with PRRPRR01 standards

## 🔄 Pull Request Process

### Before You Start

1. **Check existing issues** to avoid duplicate work
2. **Create an issue** to discuss major changes
3. **Get feedback** from maintainers before starting large contributions

### Creating a Pull Request

1. **Create a feature branch**:
   ```bash
   git checkout -b feature/your-feature-name
   ```

2. **Make your changes** following our coding standards

3. **Test thoroughly**:
   ```bash
   # Run all tests
   dotnet test
   
   # Check formatting
   dotnet format --verify-no-changes
   ```

4. **Commit with clear messages**:
   ```bash
   git commit -m "feat: add exercise for loops chapter
   
   - Add 3 new exercises covering for, while, foreach
   - Include comprehensive test coverage
   - Update chapter documentation"
   ```

5. **Push and create PR**:
   ```bash
   git push origin feature/your-feature-name
   ```

### PR Requirements

- [ ] **Clear description** of changes and motivation
- [ ] **Tests pass** locally and in CI
- [ ] **Code follows** our style guidelines
- [ ] **Documentation updated** if needed
- [ ] **No breaking changes** without discussion
- [ ] **Linked to relevant issue** if applicable

## 🐛 Issue Guidelines

### Reporting Bugs

Use the **Bug Report** template and include:

- **Clear description** of the problem
- **Steps to reproduce** the issue
- **Expected vs actual behavior**
- **Environment details** (OS, .NET version, VS Code version)
- **Code samples** if relevant

### Suggesting Features

Use the **Feature Request** template and include:

- **Clear description** of the proposed feature
- **Educational value** and target audience
- **Implementation ideas** if you have them
- **Curriculum alignment** considerations

### Content Issues

For content-related issues:

- **Chapter/exercise reference** (e.g., "Chapter 03, Exercise 2")
- **Type of issue** (unclear explanation, incorrect example, missing test)
- **Suggested improvement** if you have one
- **Student feedback** if available

## 📏 Coding Standards

### C# Code Style

We follow standard C# conventions with these specifics:

```csharp
// ✅ Good: Clear, descriptive names
public int CalculateSum(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}

// ❌ Bad: Unclear names
public int calc(int a, int b)
{
    return a + b;
}
```

### Key Guidelines

- **PascalCase** for types, methods, properties
- **camelCase** for local variables, parameters
- **Descriptive names** over short names
- **XML documentation** for public methods
- **Consistent formatting** (use `.editorconfig`)

### Exercise Structure

Each exercise should follow this pattern:

```
exercises/XX-topic/
├── README.md           # Exercise instructions
├── Program.cs          # Starter code
├── Exercise.csproj     # Project file
└── Solution/           # Reference solution
    ├── Program.cs
    └── Exercise.csproj
```

### Test Structure

```
tests/XX-topic.Tests/
├── ExerciseTests.cs    # Main test file
├── TestProject.csproj  # Test project file
└── TestData/           # Test data files (if needed)
```

## 🧪 Testing Requirements

### Test Coverage

- **All exercises** must have corresponding tests
- **Edge cases** should be covered
- **Error conditions** should be tested
- **Performance** considerations for larger exercises

### Test Naming

```csharp
[Fact]
public void CalculateSum_WithPositiveNumbers_ReturnsCorrectSum()
{
    // Arrange
    int firstNumber = 5;
    int secondNumber = 3;
    int expected = 8;
    
    // Act
    int actual = Calculator.CalculateSum(firstNumber, secondNumber);
    
    // Assert
    Assert.Equal(expected, actual);
}
```

### Test Categories

Use these attributes to categorize tests:

```csharp
[Fact]
[Trait("Category", "Basic")]
public void BasicTest() { }

[Fact]
[Trait("Category", "Advanced")]
public void AdvancedTest() { }

[Fact]
[Trait("Category", "Performance")]
public void PerformanceTest() { }
```

## 📚 Content Guidelines

### Writing Style

- **Clear and concise**: Explain concepts simply
- **Step-by-step**: Break complex topics into smaller parts
- **Examples first**: Show code before explaining theory
- **Beginner-friendly**: Assume no prior programming knowledge

### Chapter Structure

```markdown
# Chapter Title

## Learning Objectives
- What students will learn
- Specific skills they'll gain

## Concepts
- Core concepts explained
- Code examples
- Common pitfalls

## Exercises
- Hands-on practice
- Progressive difficulty
- Real-world applications

## Summary
- Key takeaways
- Next steps
```

### Exercise Design

- **Start simple**: Basic examples first
- **Build complexity**: Gradually add features
- **Real-world context**: Practical applications
- **Clear instructions**: Unambiguous requirements
- **Helpful hints**: Guide without giving away solutions

## 🏷️ Labels and Milestones

We use these labels to organize work:

### Type Labels
- `chapter` - Chapter content
- `exercise` - Exercise development
- `tests` - Testing improvements
- `docs` - Documentation
- `infra` - Infrastructure/tooling

### Priority Labels
- `priority:high` - Critical issues
- `priority:medium` - Important improvements
- `priority:low` - Nice-to-have features

### Status Labels
- `good-first-issue` - Great for new contributors
- `help-wanted` - Community input needed
- `blocked` - Waiting on dependencies
- `needs-design` - Requires design discussion

### Feedback Labels
- `pilot-feedback` - From classroom testing
- `teacher-feedback` - From educator input
- `student-feedback` - From learner experience

## 🎯 Review Process

### Content Review

All content changes require review from:

1. **Curriculum expert** - Educational content and pedagogy
2. **C# expert** - Technical accuracy and best practices
3. **Teacher advisor** - Classroom practicality

### Code Review

Technical changes require:

- **Automated tests** passing
- **Code style** compliance
- **Performance** considerations
- **Security** review (if applicable)

## 🚀 Release Process

We follow semantic versioning:

- **Major** (1.0.0): Breaking changes, major curriculum updates
- **Minor** (0.1.0): New chapters, significant features
- **Patch** (0.0.1): Bug fixes, small improvements

## 📞 Getting Help

- **Questions**: Open a discussion on GitHub
- **Technical issues**: Create a bug report
- **Content ideas**: Start with a feature request
- **General chat**: Join our community discussions

## 🙏 Recognition

Contributors are recognized in:

- **README acknowledgments**
- **Release notes**
- **Contributor hall of fame**
- **Annual contributor report**

Thank you for helping make programming education better! 🎉

---

**Questions?** Feel free to ask in our [Discussions](https://github.com/OWNER/c-sharp-kickstart/discussions) section.