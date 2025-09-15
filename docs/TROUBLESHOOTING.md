# Troubleshooting Guide

> A comprehensive guide to solving common issues you might encounter while learning C# with this course.

## 🚨 Quick Help

**Having trouble?** Follow this checklist first:

1. **Check your syntax** - Missing semicolons, brackets, or quotes?
2. **Read error messages carefully** - They often tell you exactly what's wrong
3. **Test with simple examples** - Start small and build up
4. **Check the console** - Look for error messages in your terminal
5. **Compare with solutions** - Each exercise has a `solution` file

---

## 📋 Common Issues by Category

### 🔧 Setup and Installation Issues

#### .NET SDK Not Found
**Problem:** `'dotnet' is not recognized as an internal or external command`

**Solution:**
1. Install the .NET SDK from [dot.net/download](https://dotnet.microsoft.com/download)
2. Choose the recommended LTS (Long Term Support) version
3. Restart your terminal or command prompt after installation
4. Test with: `dotnet --version`

#### Visual Studio Code C# Extension Issues
**Problem:** IntelliSense (code completion), debugging, or syntax highlighting isn't working in VS Code.

**Solution:**
1. **Install the C# Dev Kit extension:** Open VS Code, go to Extensions (Ctrl+Shift+X), search for "C# Dev Kit" and install it. This bundle includes the core C# extension.
2. **Reload VS Code:** Sometimes a simple reload (Ctrl+R or `Developer: Reload Window` from Command Palette) fixes issues.
3. **Check Output Panel:** Go to `View > Output` and select "C#" or "OmniSharp" from the dropdown. Look for error messages.
4. **Ensure .NET SDK is installed:** The extension relies on a working .NET SDK installation.

#### Project Won't Build or Run
**Problem:** `dotnet build` or `dotnet run` fails with errors.

**Common Causes & Solutions:**
1. **Syntax Errors:** C# is strict. Missing semicolons, curly braces, or incorrect casing will cause build errors.
   - **Solution:** Carefully read the error messages. They usually point to the exact line and column number.
2. **Missing `using` Directives:** If you use types from a namespace (e.g., `List<T>` from `System.Collections.Generic`), you need a `using` directive at the top of your file.
   - **Solution:** Add `using System.Collections.Generic;` (or the appropriate namespace) at the top. VS Code often suggests this.
3. **Incorrect Project Context:** You might be running `dotnet build` from the wrong directory.
   - **Solution:** Navigate to the directory containing your `.csproj` file.
4. **Conflicting Project Files:** Sometimes, old build artifacts can cause issues.
   - **Solution:** Run `dotnet clean` in your project directory, then try `dotnet build` again.

#### Tests Won't Run (xUnit)
**Problem:** `dotnet test` fails or reports no tests found.

**Solutions:**
1. **Ensure xUnit is installed:** Your test project needs the `xunit`, `xunit.runner.visualstudio`, and `Microsoft.NET.Test.Sdk` NuGet packages. Check your `.csproj` file.
   ```xml
   <ItemGroup>
       <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.x.x" />
       <PackageReference Include="xunit" Version="2.x.x" />
       <PackageReference Include="xunit.runner.visualstudio" Version="2.x.x" />
   </ItemGroup>
   ```
2. **Build the project first:** Tests run against compiled code.
   - **Solution:** Run `dotnet build` before `dotnet test`.
3. **Correct Directory:** Make sure you are in the directory of your test project (the one with the `.csproj` file for tests).
4. **Public Test Methods:** xUnit test methods must be `public void` and decorated with `[Fact]` or `[Theory]`.
   ```csharp
   public class MyTests
   {
       [Fact]
       public void MyTestMethod()
       {
           // ... test code
       }
   }
   ```

#### Understanding Test Results
**Problem:** Tests fail but you're not sure why.

**What the tests check:**
- **Student tests** (`dotnet test`) check your code against expected outcomes.
- Tests will fail until you complete the exercises (this is normal!).
- Error messages show what's expected versus what your code produced. Look for `Expected: ... Actual:

### 5. Test Early and Often
- Test each function as you write it
- Use simple test cases first
- Don't wait until everything is complete

---

## 📞 Still Stuck?

If you're still having trouble:

1. **Re-read the exercise instructions** carefully
2. **Check the solution file** for that exercise
3. **Review the relevant chapter** in the book
4. **Start over with a simpler version** and build up
5. **Take a break** and come back with fresh eyes

Remember: Debugging is a normal part of programming! Even experienced developers spend time troubleshooting. Each error you fix makes you a better programmer.

---