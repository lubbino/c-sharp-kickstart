
---

## 2) Roles
- **Lead Author (Curriculum):** owns chapter texts, examples, pedagogy.
- **Exercise Engineer:** builds exercises, reference solutions, tests.
- **Reviewer (C#/.NET):** code quality, analyzers, idiomatic C#.
- **Teacher Advisor:** rubrics, lesson pacing, classroom constraints.
- **Integrator:** CI, repo hygiene, release packaging.

---

## 3) Tooling & Standards
- **.NET SDK:** LTS version (document exact version in README)
- **Editor:** VS Code + C# extension
- **Testing:** xUnit (`Fact`, `Theory` with `InlineData`)
- **Analyzers:** .NET analyzers + `.editorconfig` (warning as error for CI)
- **CI:** GitHub Actions (`dotnet restore/build/test`)
- **Style:** PascalCase (types/methods), camelCase (locals/params), `var` for obvious types
- **Docs:** Markdown, fenced C# blocks, runnable snippets where practical

---

## 4) Sprint Plan (6 sprints)

### Sprint 0 – Bootstrap (Repo & Templates)
**Goals**
- Initialize repo, CI, analyzers, starter templates.
- Produce CONTRIBUTING, issue labels, and PR templates.

**Backlog**
- Create repo skeleton (folders as above)
- `templates/console-app` and `templates/xunit-project`
- GitHub Actions: `dotnet build` + `dotnet test`
- `.editorconfig` + analyzers baseline
- `README.md` (install, run, test), `CONTRIBUTING.md`
- Labels: `chapter`, `exercise`, `tests`, `docs`, `good-first-issue`, `help-wanted`, `blocked`
- Teacher docs stubs in


---

## 2) Roles
- **Lead Author (Curriculum):** owns chapter texts, examples, pedagogy.
- **Exercise Engineer:** builds exercises, reference solutions, tests.
- **Reviewer (C#/.NET):** code quality, analyzers, idiomatic C#.
- **Teacher Advisor:** rubrics, lesson pacing, classroom constraints.
- **Integrator:** CI, repo hygiene, release packaging.

---

## 3) Tooling & Standards
- **.NET SDK:** LTS version (document exact version in README)
- **Editor:** VS Code + C# extension
- **Testing:** xUnit (`Fact`, `Theory` with `InlineData`)
- **Analyzers:** .NET analyzers + `.editorconfig` (warning as error for CI)
- **CI:** GitHub Actions (`dotnet restore/build/test`)
- **Style:** PascalCase (types/methods), camelCase (locals/params), `var` for obvious types
- **Docs:** Markdown, fenced C# blocks, runnable snippets where practical

---

## 4) Sprint Plan (6 sprints)

### Sprint 0 – Bootstrap (Repo & Templates)
**Goals**
- Initialize repo, CI, analyzers, starter templates.
- Produce CONTRIBUTING, issue labels, and PR templates.

**Backlog**
- Create repo skeleton (folders as above)
- `templates/console-app` and `templates/xunit-project`
- GitHub Actions: `dotnet build` + `dotnet test`
- `.editorconfig` + analyzers baseline
- `README.md` (install, run, test), `CONTRIBUTING.md`
- Labels: `chapter`, `exercise`, `tests`, `docs`, `good-first-issue`, `help-wanted`, `blocked`
- Note: Teacher resources will be developed separately in a future project

**Exit Criteria**
- CI green on a sample test project
- Templates compile & run locally and in CI

---

### Sprint 1 – Chapters 01–04 (Core Basics)
**Chapters**
- 01 Intro & Hello World
- 02 Sequence
- 03 Variables & Data Types
- 04 Operators

**Deliverables**
- Each chapter: 2–3 exercises + xUnit tests
- Reference solutions (compile & pass)
- Teacher notes: misconceptions, pacing, exit ticket
- Mini “cheatsheet” for CLI commands

**Risks/Mitigation**
- Install friction → include step-by-step install guide with screenshots
- Type confusion → targeted tests for casting/precision

**Exit Criteria**
- 4 chapters meet DoD, CI green

---

### Sprint 2 – Chapters 05–07 (Control Flow & Loops) + Project 1
**Chapters**
- 05 Input/Output (Console.ReadLine, parsing, validation)
- 06 Selections (if/else, switch)
- 07 Iterations (for/while/foreach)

**Project 1 (choose one)**
- Number Guessing Game **or** Calculator

**Deliverables**
- Exercises + tests per chapter
- Project 1 spec, starter, tests (seeded randomness where needed)
- Teacher guide for project assessment

**Exit Criteria**
- 3 chapters + 1 project meet DoD, CI green

---

### Sprint 3 – Chapters 08–09 (Functions + Collections) + Project 2
**Chapters**
- 08 Functions/Methods (parameters, return)
- 09 Arrays & Lists (search/min/max/avg)

**Project 2 (choose one)**
- Word Statistics **or** Store Checkout

**Deliverables**
- Exercises + tests
- Project 2 spec, starter, tests
- Teacher guide with rubric anchors for data structures

**Exit Criteria**
- 2 chapters + 1 project meet DoD, CI green

---

### Sprint 4 – Chapters 10–11 (Quality & Testing/Debugging)
**Chapters**
- 10 Code Quality (naming, comments, refactors)
- 11 Testing & Debugging (xUnit AAA, Theory, VS Code debugger)

**Deliverables**
- Refactor exercise with pre/post tests
- Student-written test suite assignment (template + examples)
- Debug walkthrough (breakpoints, watch, step into/over)

**Exit Criteria**
- 2 chapters meet DoD
- Teacher artifact: consolidated rubric & exemplar solutions

---

### Sprint 5 – Pilot, Feedback, Hardening
**Goals**
- Classroom pilot with 1–2 groups
- Collect data: pass rates, time per chapter, friction points

**Backlog**
- Instrument simple reporting (manual or CI artifacts)
- Adjust exercises/tests based on student errors
- Improve docs where confusion was observed
- Tag issues: `pilot-feedback`, prioritize fixes

**Exit Criteria**
- v1.0 release candidate ready
- CHANGELOG documents improvements

---

## 5) Work Breakdown (per chapter)

**Template checklist**
- [ ] `book/chapters/NN-title.md` (learning objectives, examples, pitfalls)
- [ ] `exercises/NN-title/` (1–3 exercises with starter code)
- [ ] `tests/NN-title.Tests/` (xUnit tests; `Fact` + `Theory`)
- [ ] Solutions under `exercises/.../Solution/` or `docs/solutions/`
- [ ] Teacher notes: misconceptions, pacing, exit ticket
- [ ] Update `README.md` chapter index

**Acceptance criteria**
- Exercises pass in CI on clean checkout
- No analyzer warnings
- Examples compile and run as-is
- Teacher notes include at least 3 common mistakes with remedies

---

## 6) Issue Tracking & Labels

**Core labels**
- `chapter`, `exercise`, `tests`, `project`, `docs`, `infra`
- `priority:high|med|low`
- `pilot-feedback`, `blocked`, `needs-design`, `good-first-issue`

**Milestones**
- `M0 Bootstrap`, `M1 Basics`, `M2 Control Flow`, `M3 Collections`, `M4 Quality & Testing`, `M5 Pilot`

---

## 7) CI/CD

**Pipeline (GitHub Actions)**
- Trigger on PR and `main`
- Steps:
  1. `actions/setup-dotnet` (pin exact SDK)
  2. `dotnet restore`
  3. `dotnet build -warnaserror`
  4. `dotnet test --collect:"XPlat Code Coverage"` (optional)
  5. Upload `TestResults/` as artifact

**Status checks**
- All tests passing
- No warnings (treat warnings as errors)

---

## 8) Risk Register (live)

| Risk | Likelihood | Impact | Plan |
|------|------------|--------|------|
| Install fails on school PCs | Med | High | Offline ZIP, video guide, IT contact checklist |
| Students skip tests | Med | Med | Put tests in the grade rubric, start trivial |
| Time overrun | Med | Med | Chapter thin slices, drop extras first |
| Content drift vs JS course | Low | Med | Mapping doc, shared glossary |
| Accessibility gaps | Low | Med | Style guide for code blocks, contrast, captions |

---

## 9) Communication

- **Weekly standup (30 min):** progress, blockers, next steps
- **Review cadence:** PR review within 48h, 2 reviewers (curriculum + C#)
- **Pilot sync:** after each classroom session, log top 5 friction points
- **Docs:** keep `docs/` as the single source of truth (PRD, Research, Rubrics)

---

## 10) Mapping (JS → C#) – High Level

| JS Chapter | C# Chapter | Notes |
|------------|------------|-------|
| 01 intro | 01 intro | CLI differs (`node` vs `dotnet`) |
| 02 sequence | 02 sequence | Syntax differences, same concepts |
| 03 variables | 03 variables | Strong typing, casting, `decimal` |
| 04 operators | 04 operators | Operator precedence similar |
| 05 io | 05 io | `Console.ReadLine`, parsing |
| 06 selections | 06 selections | `switch` patterns optional later |
| 07 iterations | 07 iterations | `foreach` idioms |
| 08 functions | 08 functions | Method signatures & returns |
| 09 arrays | 09 arrays-lists | Add `List<T>` and basic `Dictionary` in 09 or 07/08 |
| mini-project | projects 1–2 | Add tests and seed RNG |
| testing | 11 testing-debugging | xUnit vs Jest/assert |

---

## 11) Release Plan

- **v0.1 (internal):** Sprints 0–1 done (01–04 chapters)
- **v0.2 (beta):** Sprints 2–3 done + 2 projects
- **v1.0 (pilot-ready):** Sprint 4 done (quality/testing) + teacher pack
- **v1.1 (post-pilot):** Sprint 5 improvements

---

## 12) Artifacts to Deliver

- Course book (Markdown + optional PDF)
- Exercises + tests (xUnit) with reference solutions
- Teacher guides: pacing, rubrics, exemplar answers
- Templates: console app, xUnit project
- CI workflow and developer onboarding guide

---

## 13) Glossary (shared with JS course)
- **AAA:** Arrange–Act–Assert test pattern
- **DoD:** Definition of Done
- **PRD:** Product Requirements Document
- **RC:** Release Candidate

---

## 14) Change Management
- Use conventional commits (`feat:`, `fix:`, `docs:`, `test:`)
- Maintain `CHANGELOG.md` per release
- Major content changes require 2 approvals (curriculum + C# reviewer)

---

## 15) Post-Launch Ideas (Backlog)
- Optional OOP module (classes/objects)
- File I/O micro-chapter (read/write text)
- LINQ sampler (map/filter/reduce patterns)
- Light GUI/ASCII UI extension
- Localized translations (SV/EN split build)

---
