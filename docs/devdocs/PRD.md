# 📑 PRD – C Sharp Kickstart
Version: 0.1 (draft) • Target: Programming 1 (PRRPRR01) • Format: Markdown-based course with .NET, VS Code and xUnit

---

## 1. Product Summary

**Name:** C Sharp Kickstart  
**Tagline:** “Learn programming with modern C# and .NET – step by step.”  
**Type:** Curriculum / textbook + exercises + automated tests.  
**Audience:**  
- Swedish high school students (Programming 1 / PRRPRR01).  
- Teachers needing curriculum-aligned material with assessments.  
- Self-learners starting with C#.  

---

## 2. Goals & Objectives

- Teach **fundamental programming concepts** using C#.  
- Provide **immediate feedback** via xUnit tests.  
- Mirror structure of *JavaScript: Get Started* for familiarity.  
- Deliver **teacher resources**: lesson plans, rubrics, solutions.  
- Cross-platform, minimal install requirements.  

**Success Criteria:**  
- ≥80% students complete core chapters (1–5).  
- ≥70% tests passed in exercises.  
- Teachers report ≥30% grading time saved.  
- Adopted in ≥5 schools in year 1.  

---

## 3. Scope

### In Scope
- C# basics: sequence, variables, conditionals, loops, methods.  
- Data structures: arrays, lists, dictionaries, simple algorithms.  
- Console I/O, input validation.  
- Code quality (naming, documentation, refactoring).  
- Automated testing (xUnit).  
- Debugging in VS Code.  
- Reflection: ethics, social perspectives of programming.  

### Out of Scope
- Advanced OOP (inheritance, polymorphism).  
- File I/O, LINQ, async.  
- GUI/Unity/web development.  

---

## 4. Repository Structure

csharp-kickstart/
├── book/chapters/
│ ├── 01-intro.md
│ ├── 02-sequence.md
│ ├── 03-variables.md
│ ├── 04-operators.md
│ ├── 05-io.md
│ ├── 06-selections.md
│ ├── 07-iterations.md
│ ├── 08-functions.md
│ ├── 09-arrays-lists.md
│ ├── 10-code-quality.md
│ └── 11-testing-debugging.md
│
├── exercises/
│ ├── 01-intro/
│ ├── 02-sequence/
│ ├── 03-variables/
│ ├── 04-operators/
│ ├── 05-io/
│ ├── 06-selections/
│ ├── 07-iterations/
│ ├── 08-functions/
│ ├── 09-arrays-lists/
│ ├── 10-code-quality/
│ └── 11-testing-debugging/
│
├── tests/
│ ├── 01-intro.Tests/
│ ├── 02-sequence.Tests/
│ ├── ...
│ └── 11-testing-debugging.Tests/
│
├── templates/ # starter console & xUnit projects
├── docs/ # research, PRD, teacher guides
└── README.md


---

## 5. Chapter Breakdown

| Chapter | Title | Content Focus | Deliverables |
|---------|-------|---------------|--------------|
| 01 | Intro & Hello World | Setup .NET SDK, VS Code, CLI commands, first program | Simple console app |
| 02 | Sequence | Expressions, operators, print, execution order | 2 exercises |
| 03 | Variables & Data Types | int, double, decimal, string, bool, casting | Exercises + tests |
| 04 | Operators | Arithmetic, comparison, logical, precedence | Exercises + tests |
| 05 | Input/Output | Console.ReadLine, parsing, validation | Small programs |
| 06 | Selections | if/else, switch, nested conditions | Decision exercises |
| 07 | Iterations | for, while, foreach, counters, accumulators | Looping exercises |
| 08 | Functions | Methods, parameters, return values | Refactoring tasks |
| 09 | Arrays & Lists | Array basics, List<T>, search, min/max/avg | Data structure tasks |
| 10 | Code Quality | Naming, comments, documentation, refactoring | Checklist + refactor exercise |
| 11 | Testing & Debugging | xUnit basics, AAA, Theory tests, VS Code debugger | Write a test suite |

---

## 6. Exercises & Projects

- **Per chapter:** 2–3 structured exercises with automated tests.  
- **Mini projects:**  
  - Number Guessing Game  
  - Calculator  
  - Word Statistics (Dictionary frequency count)  
  - Store Checkout (decimal handling, receipts)  
  - Text Adventure  

---

## 7. Testing Strategy

- xUnit used for all exercises.  
- Test files live under `/tests/` mapped 1:1 with exercises.  
- `Fact` for single-case tests, `Theory` for parameterized cases.  
- Students read tests as “executable requirements.”  

---

## 8. Assessment & Deliverables

**Student outputs:**  
- Pseudocode or flowcharts (≥2).  
- 6–8 exercises + 2 projects.  
- At least 1 self-written test suite.  
- Reflection notes (ethics, design choices).  

**Assessment dimensions (aligned with PRRPRR01):**  
- Planning (pseudocode/diagrams).  
- Code style & readability.  
- Correctness & robustness.  
- Testing & debugging skills.  
- Interaction & validation.  
- Reflection (ethics, limitations of programming).  

---

## 9. Risks & Mitigation

| Risk | Impact | Mitigation |
|------|--------|------------|
| Installation problems | Students can’t get started | Pre-built templates, install guide, offline ZIP |
| Too steep learning curve | Drop in motivation | Micro exercises, fast Hello World |
| Students avoid testing | No feedback / assessment | Start with trivial tests, build gradually |
| Mixed skill levels | Fast learners get bored | Add “challenge track” tasks |
| Time pressure | Core not finished | Prioritize chapters 1–9 + 1 project |

---

## 10. Timeline (Sprints)

- **Sprint 0:** Repo setup, templates, CI.  
- **Sprint 1:** Chapters 01–04 (Intro, Sequence, Variables, Operators).  
- **Sprint 2:** Chapters 05–07 (I/O, Selections, Iterations) + Project 1.  
- **Sprint 3:** Chapters 08–09 (Functions, Arrays/Lists) + Project 2.  
- **Sprint 4:** Chapters 10–11 (Code Quality, Testing/Debugging), teacher resources.  
- **Pilot:** Test in class, gather feedback, iterate.  

---

## 11. Success Metrics

- ≥80% students complete core chapters.  
- ≥70% test pass rate.  
- Teacher grading workload reduced by ≥30%.  
- Adoption in ≥5 schools within first year.  

---

## 12. Summary

C Sharp Kickstart delivers a **structured, test-driven C# course** tailored to *Programming 1*.  
It mirrors the *JavaScript: Get Started* repo structure, but adds C#-specific content: arrays vs lists, strong typing, xUnit.  
The goal is hands-on learning with immediate feedback, robust assessment support for teachers, and a modern technical setup.
