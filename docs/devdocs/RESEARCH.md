# 📘 Research & Insights – C Sharp Kickstart
Version: 0.3 (draft) • Target: PRRPRR01 (Swedish high school Programming 1) • Format: Markdown-based course with .NET, VS Code and xUnit

──────────────────────────────────────────────────────────────────────────────

## 1) Purpose & Scope

**Purpose:**  
Build a complete, beginner-friendly C# curriculum that:
- aligns with the Swedish course *Programming 1 (PRRPRR01)*,
- gives quick results with runnable code from the very first lesson,
- uses **automated tests** for instant feedback,
- includes **assessment support** (rubrics, checklists, teacher guides),
- works cross-platform (Windows / macOS / Linux).

**Scope (core):** console apps, sequence → variables → conditionals → loops → methods → arrays/lists → algorithms, I/O, code quality, testing & debugging.

**Out of scope (optional extras):** OOP (classes/objects), file I/O, LINQ, GUI, Unity.

──────────────────────────────────────────────────────────────────────────────

## 2) Curriculum Mapping (PRRPRR01 ↔ Chapters)

| Curriculum requirement | Interpretation | Course chapter(s) |
|---|---|---|
| Basic programming in a text-based language | C# console apps, .NET SDK, VS Code | 01-intro, 02-sequence |
| Social perspective (gender, culture, socio-economic) | Reflection prompts, ethical case studies | reflection/01-society-ethics.md |
| Possibilities & limitations of programming | CPU/memory basics, data types, precision, complexity | theory/01-how-computers-work.md |
| Structured problem solving | Pseudocode, flowcharts, TDD loop | planning/01-pseudocode.md |
| Control structures & data types | if/switch, while/for/foreach, int/double/decimal/string/bool | 03-variables, 04-operators, 06-selections, 07-iterations |
| Preventing errors, testing, debugging | xUnit, VS Code debugging | 11-testing-debugging |
| Basic data structures & algorithms | Arrays, List<T>, Dictionary<K,V>, search, sort | 09-arrays-lists |
| Program–user interaction | Console I/O, input validation | 05-io |
| Norms & values (readability, documentation, testability) | Naming, comments, standards | 10-code-quality |

──────────────────────────────────────────────────────────────────────────────

## 3) Target Audience & Needs

- **Students:** need quick “wins” (Hello World, input/output), small steps, instant feedback, relatable examples (games, text challenges).  
- **Teachers:** want progression, assessable tasks, ready-made tests/solutions, lesson plans.  
- **Self-learners:** need clear structure, explanations, solutions.

**Pedagogical principles:**  
- *Code first* (show code → run → explain).  
- Micro-progression (small, cumulative steps).  
- Retrieval practice (quizzes, repetition).  
- Test-driven feedback (students learn through passing tests).  

──────────────────────────────────────────────────────────────────────────────

## 4) Technical Framework

- **Language/SDK:** C# (.NET SDK LTS).  
- **Editor:** VS Code with C# extension.  
- **Commands:** `dotnet new console`, `dotnet run`, `dotnet test`.  
- **Testing:** xUnit, AAA pattern (Arrange–Act–Assert).  
- **Repo structure:** aligned with JS course for familiarity.

──────────────────────────────────────────────────────────────────────────────

## 5) Repository Structure

csharp-kickstart/
│
├── book/
│ └── chapters/
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
├── templates/ # .NET console & xUnit templates
├── docs/ # research, PRD, teacher guides
└── README.md


**Why this structure?**  
- Mirrors JS course → easier onboarding for students/teachers.  
- Arrays → Arrays & Lists (important in C#).  
- Adds *Code Quality* + *Testing & Debugging* as dedicated chapters.  
- `templates/` supports ready-made starter projects for .NET.  

──────────────────────────────────────────────────────────────────────────────

## 6) Learning Design & Progression

**Chapters:**
1. Intro & Hello World  
2. Sequence  
3. Variables & data types  
4. Operators  
5. I/O  
6. Selections (if/switch)  
7. Iterations (for/while/foreach)  
8. Functions/methods  
9. Arrays & Lists  
10. Code quality & standards  
11. Testing & debugging  

**Lesson loop:**  
Intro → Run example code → Guided practice → Automated test → Reflection → Exit ticket.  

──────────────────────────────────────────────────────────────────────────────

## 7) Mini Projects

- **Number Guessing Game** – random numbers, loops, validation.  
- **Calculator** – switch/case, decimal arithmetic, menu-driven.  
- **Word Statistics** – strings, Dictionary<K,V>, frequency analysis.  
- **Store Checkout** – decimals, receipts, discounts.  
- **Text Adventure** – state handling, conditionals, loops.  

──────────────────────────────────────────────────────────────────────────────

## 8) Testing & Debugging

- **Tests per chapter:** small, focused, xUnit-based.  
- **Students read tests** → treated as executable requirements.  
- **Debugging tools:** breakpoints, step-through, watch variables in VS Code.  
- **Error types:** syntax errors, runtime errors (exceptions), logic errors.  

──────────────────────────────────────────────────────────────────────────────

## 9) Code Quality

- **Naming conventions:** PascalCase for types/methods, camelCase for locals/params.  
- **Small methods:** single responsibility.  
- **Comments:** explain “why” rather than “what”.  
- **Documentation:** XML doc comments for methods (later chapters).  
- **Refactoring:** split large methods, replace duplication with helper methods.  

──────────────────────────────────────────────────────────────────────────────

## 10) Assessment (aligned with PRRPRR01)

**Student deliverables:**
- Pseudocode/flowcharts (≥2 assignments).  
- 6–8 chapter exercises.  
- 2 mini projects.  
- At least 1 student-written test suite.  
- Reflection notes (ethics + design choices).  

**Rubric (simplified):**
- **E:** simple pseudocode, correct but basic code, minimal tests, basic reflection.  
- **C:** systematic planning, structured code, robust testing, clear reflection.  
- **A:** motivated design choices, modular code, edge-case handling, nuanced reflections.  

──────────────────────────────────────────────────────────────────────────────

## 11) Risks & Mitigation

| Risk | Impact | Mitigation |
|---|---|---|
| Installation issues | Lost class time | Pre-install guide, offline ZIP, ready templates |
| Too difficult at start | Low motivation | Micro exercises, quick Hello World success |
| Students avoid testing | Lack of assessment data | Start with trivial tests, build complexity |
| Uneven class skill levels | Advanced students get bored | Add “challenge tracks” |
| Time constraints | Course unfinished | Prioritize core chapters + 1–2 projects |

──────────────────────────────────────────────────────────────────────────────

## 12) Success Metrics

- ≥80% students complete chapters 1–5.  
- ≥70% tests passed in core chapters.  
- ≥30% teacher grading workload reduced (autotests).  
- Self-reported confidence +1 level after 4 weeks.  

──────────────────────────────────────────────────────────────────────────────

## 13) Deliverables

- **Student package:** course book (Markdown/PDF), exercises, tests, guides.  
- **Teacher package:** lesson plans, solutions, rubrics, CI workflow.  
- **Templates:** ready-made .NET console app & xUnit projects.  

──────────────────────────────────────────────────────────────────────────────

## 14) Next Steps

1. Set up repo according to structure.  
2. Develop chapters 01–03 (Intro, Sequence, Variables).  
3. Implement automated testing (xUnit).  
4. Pilot in classroom, gather feedback.  
5. Iterate on tests and assessment rubrics.  

──────────────────────────────────────────────────────────────────────────────

## 15) Summary

C Sharp Kickstart is a **structured, test-driven curriculum** for Programming 1 (PRRPRR01). It mirrors the structure of the existing JavaScript course for consistency, but adapts to C# specifics (arrays vs lists, strong typing, xUnit).  
Focus: console apps, testable code, input/output, robustness, code quality, and reflection. Teachers get clear assessment tools; students get quick feedback and achievable milestones.
