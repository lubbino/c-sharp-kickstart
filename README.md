# C# Kickstart

> A comprehensive, beginner-friendly C# curriculum.

Learn modern C# and .NET development through hands-on exercises, real projects, and automated testing. This course provides structured learning with immediate feedback to build solid programming foundations.

## Overview

**C# Kickstart** is a complete educational curriculum that takes students from zero programming experience to confident C# developers. The course emphasizes practical learning through:

- **Progressive skill building** with 9 comprehensive chapters
- **Hands-on exercises** with automated validation
- **Real-world projects** that demonstrate practical applications
- **Professional development practices** including testing and debugging
- **Immediate feedback** through comprehensive test suites

## What You'll Learn

### Core Programming Concepts
- **Variables and Data Types**: Understanding `int`, `double`, `string`, `bool`
- **Operators**: Arithmetic, comparison, and logical operations
- **Control Flow**: Conditional statements and decision making
- **Loops and Iterations**: Repetitive operations and data processing
- **Functions and Methods**: Code organization and reusability
- **Data Structures**: Arrays, lists, and collections

### Professional Skills
- **Problem Solving**: Structured approach with pseudocode and flowcharts
- **Code Quality**: Best practices, naming conventions, and documentation
- **Testing**: xUnit framework and test-driven development
- **Debugging**: VS Code debugging tools and techniques
- **Version Control**: Git basics and collaborative development

## Prerequisites

- **Computer**: Windows, macOS, or Linux
- **Internet Connection**: For downloading .NET SDK and VS Code
- **Time Commitment**: 2-3 hours per week for 8-10 weeks
- **No Prior Programming Experience Required**

## Quick Start

### 1. Install Development Environment

#### .NET SDK Installation
1. Visit [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
2. Download the latest **LTS (Long Term Support)** version
3. Run the installer and follow the setup wizard
4. Verify installation in terminal:
   ```bash
   dotnet --version
   ```
   Expected output: `8.0.xxx` or higher

#### Visual Studio Code Setup
1. Download from [code.visualstudio.com](https://code.visualstudio.com)
2. Install VS Code following the platform-specific instructions
3. Install the **C# Dev Kit** extension:
   - Open VS Code
   - Press `Ctrl+Shift+X` (Windows/Linux) or `Cmd+Shift+X` (Mac)
   - Search for "C# Dev Kit"
   - Click Install

### 2. Get Course Materials

#### Option A: Download ZIP (Recommended for Beginners)
1. Click the green "Code" button on this repository
2. Select "Download ZIP"
3. Extract to your preferred location (e.g., `Documents/Programming/`)
4. Open the extracted folder in VS Code

#### Option B: Clone with Git
```bash
git clone https://github.com/r-/c-sharp-kickstart.git
cd c-sharp-kickstart
```

### 3. Verify Setup

#### Test Console Application Template
```bash
cd templates/console-app
dotnet run
```
Expected output: `Hello, World!`

#### Test xUnit Testing Template
```bash
cd ../xunit-project
dotnet test
```
Expected output: `Passed! - Failed: 0, Passed: 3, Skipped: 0`

## Using Project Templates

The [`templates`](templates/) folder provides ready-to-use project blueprints that save time and ensure consistency across all your work.

### When to Use Templates

- **Starting a new exercise**: Copy the `console-app` template
- **Creating practice projects**: Use `console-app` for experimentation
- **Writing tests**: Copy the `xunit-project` template for test projects

### How to Use Templates

#### Creating a New Console Application
```bash
# Copy the console app template
cp -r templates/console-app my-new-project
cd my-new-project

# Rename the project (optional)
mv ConsoleApp.csproj MyProject.csproj

# Start coding in Program.cs
code Program.cs
```

#### Creating a Test Project
```bash
# Copy the xUnit template
cp -r templates/xunit-project my-tests
cd my-tests

# Rename the project (optional)
mv XUnitProject.csproj MyTests.csproj

# Start writing tests in UnitTest1.cs
code UnitTest1.cs
```

### Template Contents

| Template | Contains | Purpose |
|----------|----------|---------|
| [`console-app`](templates/console-app/) | `Program.cs`, `ConsoleApp.csproj` | Standard C# console application |
| [`xunit-project`](templates/xunit-project/) | `UnitTest1.cs`, `XUnitProject.csproj` | xUnit test project with examples |

**Note**: The templates include all necessary dependencies and are pre-configured for .NET 8.0, so you can start coding immediately without setup overhead.

## Course Structure

### Learning Path

| Chapter | Topic | Key Concepts | Exercises | Status |
|---------|-------|--------------|-----------|--------|
| [01](book/chapters/01-intro.md) | Introduction & Hello World | Setup, first program, compilation | 2 | Complete |
| [02](book/chapters/02-sequence.md) | Sequential Execution | Expressions, execution order | 2 | Complete |
| [03](book/chapters/03-variables.md) | Variables & Data Types | `int`, `double`, `string`, `bool` | 2 | Complete |
| [04](book/chapters/04-operators.md) | Operators | Arithmetic, comparison, logical | 2 | Complete |
| [05](book/chapters/05-io.md) | Input/Output | Console interaction, validation | 2 | Complete |
| [06](book/chapters/06-selections.md) | Conditional Logic | `if/else`, `switch` statements | 2 | Complete |
| [07](book/chapters/07-iterations.md) | Loops & Iterations | `for`, `while`, `foreach` | 2 | Complete |
| [08](book/chapters/08-functions.md) | Functions & Methods | Parameters, return values, scope | 2 | Complete |
| [09](book/chapters/09-arrays-lists.md) | Collections | Arrays, Lists, algorithms | 3 | Complete |
| [10](book/chapters/10-code-quality.md) | Code Quality | Standards, refactoring | 2 | Planned |
| [11](book/chapters/11-testing-debugging.md) | Testing & Debugging | xUnit, VS Code debugger | 2 | Planned |

### Practical Projects

| Project | Description | Skills Applied | Status |
|---------|-------------|----------------|--------|
| [Number Guessing Game](projects/01-number-guessing-game/) | Interactive console game with random numbers | Loops, validation, user input | Available |
| [Word Statistics](projects/02-word-statistics/) | Text analysis and reporting tool | Strings, collections, file I/O | Available |
| Calculator | Multi-operation calculator | Switch statements, decimal arithmetic | Planned |
| Store Checkout | Point-of-sale system | Object-oriented design, data persistence | Planned |

## How to Use This Course

### For Students

1. **Study the Chapter**: Read the theory and examples in `book/chapters/`
2. **Practice with Exercises**: Complete hands-on coding in `exercises/XX-topic/`
3. **Validate Your Work**: Run `dotnet test` to check your solutions
4. **Debug and Iterate**: Fix issues until all tests pass
5. **Apply Knowledge**: Work on chapter projects
6. **Reflect and Review**: Understand the concepts before moving forward

### For Educators

- **Lesson Plans**: Structured teaching materials in `docs/teacher/`
- **Assessment Tools**: Rubrics aligned with PRRPRR01 standards
- **Reference Solutions**: Complete solutions for all exercises in `solutions/`
- **Common Issues**: Troubleshooting guide for typical student problems
- **Progress Tracking**: Automated testing provides objective assessment

## Development Workflow

### Working with Exercises

```bash
# Navigate to an exercise
cd exercises/03-variables

# Edit your solution
code Program.cs

# Test your work
dotnet test

# View detailed test results
dotnet test --verbosity normal

# Run your program
dotnet run
```

### Understanding Test Results

- **Passed (Green)**: Your implementation meets all requirements
- **Failed (Red)**: Code needs modification to meet specifications
- **Skipped (Yellow)**: Test intentionally disabled (usually for advanced features)

### Essential Commands

| Task | Command | Description |
|------|---------|-------------|
| Create console app | `dotnet new console` | Initialize new C# console application |
| Create test project | `dotnet new xunit` | Initialize new xUnit test project |
| Build project | `dotnet build` | Compile code and check for errors |
| Run application | `dotnet run` | Execute the compiled program |
| Run tests | `dotnet test` | Execute all unit tests |
| Clean artifacts | `dotnet clean` | Remove compiled files |

## Testing Infrastructure

### Comprehensive Validation

This course includes **134 automated tests** across **9 test suites** ensuring:

- **Structural Integrity**: All required files and folders exist
- **Code Quality**: Solutions compile without warnings
- **Functional Correctness**: Programs produce expected outputs
- **Cross-Platform Compatibility**: Works on Windows, macOS, and Linux

### Test Execution

```bash
# Test specific chapter
cd tests/01-intro.Tests
dotnet test

# Test all chapters (Windows)
cd tests && for /d %i in (*) do (cd %i && dotnet test --verbosity quiet && cd ..)

# Test all chapters (macOS/Linux)
cd tests && for dir in */; do (cd "$dir" && dotnet test --verbosity quiet); done
```

## Assessment & Standards

### PRRPRR01 Alignment

This curriculum fully aligns with Swedish Programming 1 (PRRPRR01) requirements:

| Standard | Implementation |
|----------|----------------|
| **Planning & Design** | Pseudocode exercises, flowchart creation |
| **Implementation** | Progressive C# programming exercises |
| **Testing & Validation** | Comprehensive xUnit test suites |
| **Code Quality** | Style guides, best practices, documentation |
| **Reflection & Ethics** | Discussion questions, design choice analysis |

### Learning Outcomes

Upon completion, students will be able to:

- Design and implement console applications using C#
- Apply fundamental programming concepts (variables, control flow, functions)
- Write clean, well-documented code following industry standards
- Use testing frameworks to validate program correctness
- Debug programs using modern development tools
- Collaborate using version control systems

## Support & Resources

### Getting Help

- **Instructor Support**: Contact your teacher for personalized assistance
- **Peer Learning**: Collaborate with classmates on concepts (not solutions)
- **Documentation**: Comprehensive guides in `docs/` directory
- **Issue Reporting**: Use GitHub Issues for technical problems

### External Resources

- [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [.NET API Reference](https://docs.microsoft.com/en-us/dotnet/api/)
- [xUnit Testing Framework](https://xunit.net/)
- [VS Code C# Development](https://code.visualstudio.com/docs/languages/csharp)

### Troubleshooting

Common issues and solutions are documented in:
- [Troubleshooting Guide](docs/TROUBLESHOOTING.md)
- [Setup Problems](docs/SETUP_ISSUES.md)
- [Testing Issues](docs/TESTING_HELP.md)

## Contributing

We welcome contributions to improve this educational resource:

1. **Report Issues**: Use GitHub Issues for bugs or content problems
2. **Suggest Improvements**: Propose enhancements via Pull Requests
3. **Share Feedback**: Help us improve the learning experience
4. **Translate Content**: Assist with localization efforts

## Project Statistics

- **9 Chapters**: Complete theoretical foundation
- **17 Exercises**: Hands-on programming practice
- **17 Reference Solutions**: Professional-quality implementations
- **2 Major Projects**: Real-world application development
- **134 Automated Tests**: Comprehensive validation coverage
- **95% Complete**: Ready for classroom deployment

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- **Swedish Education Agency**: For PRRPRR01 curriculum standards
- **Microsoft**: For excellent C# and .NET documentation
- **xUnit Community**: For robust testing framework
- **Open Source Community**: For inspiration and best practices
- **Educators and Students**: For feedback and continuous improvement

---

**Ready to begin your C# journey?** Start with [Chapter 01: Introduction & Hello World](book/chapters/01-intro.md)