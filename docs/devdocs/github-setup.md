# GitHub Repository Setup Guide

This document provides instructions for setting up the GitHub repository with the necessary labels, milestones, and configurations for the C# Kickstart project.

## 🏷️ Issue Labels

The following labels should be created in the GitHub repository. These align with the project's workflow and the PLAN.md specifications.

### Type Labels
| Label | Color | Description |
|-------|-------|-------------|
| `chapter` | `#0075ca` | Chapter content development |
| `exercise` | `#7057ff` | Exercise creation or improvement |
| `tests` | `#008672` | Testing improvements or new test cases |
| `docs` | `#0052cc` | Documentation updates |
| `infra` | `#5319e7` | Infrastructure, CI/CD, tooling |
| `project` | `#1d76db` | Mini-project development |

### Priority Labels
| Label | Color | Description |
|-------|-------|-------------|
| `priority:high` | `#d73a4a` | Critical issues that block progress |
| `priority:medium` | `#fbca04` | Important improvements |
| `priority:low` | `#0e8a16` | Nice-to-have features |

### Status Labels
| Label | Color | Description |
|-------|-------|-------------|
| `good-first-issue` | `#7057ff` | Great for new contributors |
| `help-wanted` | `#008672` | Community input needed |
| `blocked` | `#d73a4a` | Waiting on dependencies |
| `needs-design` | `#fbca04` | Requires design discussion |
| `needs-triage` | `#ededed` | Needs initial review and categorization |

### Feedback Labels
| Label | Color | Description |
|-------|-------|-------------|
| `pilot-feedback` | `#ff6b6b` | From classroom testing |
| `teacher-feedback` | `#4ecdc4` | From educator input |
| `student-feedback` | `#45b7d1` | From learner experience |

### Bug/Enhancement Labels
| Label | Color | Description |
|-------|-------|-------------|
| `bug` | `#d73a4a` | Something isn't working |
| `enhancement` | `#a2eeef` | New feature or request |
| `duplicate` | `#cfd3d7` | This issue or pull request already exists |
| `invalid` | `#e4e669` | This doesn't seem right |
| `question` | `#d876e3` | Further information is requested |
| `wontfix` | `#ffffff` | This will not be worked on |

## 🎯 Milestones

Create the following milestones to track sprint progress:

| Milestone | Description | Due Date |
|-----------|-------------|----------|
| `M0 Bootstrap` | Sprint 0 - Repository setup and templates | [Set based on timeline] |
| `M1 Basics` | Sprint 1 - Chapters 01-04 (Core Basics) | [Set based on timeline] |
| `M2 Control Flow` | Sprint 2 - Chapters 05-07 + Project 1 | [Set based on timeline] |
| `M3 Collections` | Sprint 3 - Chapters 08-09 + Project 2 | [Set based on timeline] |
| `M4 Quality & Testing` | Sprint 4 - Chapters 10-11 + Teacher Resources | [Set based on timeline] |
| `M5 Pilot` | Sprint 5 - Pilot testing and feedback | [Set based on timeline] |

## 📋 Repository Settings

### Branch Protection Rules
Set up branch protection for the `main` branch:

- ✅ Require pull request reviews before merging
- ✅ Require status checks to pass before merging
  - ✅ `build-and-test` (from CI workflow)
  - ✅ `code-quality` (from CI workflow)
- ✅ Require branches to be up to date before merging
- ✅ Restrict pushes that create files larger than 100MB
- ✅ Require linear history

### Repository Topics
Add these topics to help with discoverability:
- `csharp`
- `dotnet`
- `education`
- `programming-course`
- `xunit`
- `beginner-friendly`
- `swedish-curriculum`
- `prrprr01`

### Repository Description
```
Learn programming with modern C# and .NET – step by step. A comprehensive curriculum for Programming 1 (PRRPRR01) with automated testing and teacher resources.
```

## 🔧 GitHub Actions Setup

The CI workflow is already configured in `.github/workflows/ci.yml`. Ensure the following secrets and variables are set if needed:

### Repository Secrets
Currently, no secrets are required for the basic CI workflow.

### Repository Variables
Consider setting these for future use:
- `DOTNET_VERSION`: `8.0.x` (for consistency across workflows)

## 📝 Issue Templates

The following issue templates are already configured:
- 🐛 Bug Report (`.github/ISSUE_TEMPLATE/bug_report.yml`)
- ✨ Feature Request (`.github/ISSUE_TEMPLATE/feature_request.yml`)

## 🔄 Pull Request Template

The pull request template is configured in `.github/PULL_REQUEST_TEMPLATE.md`.

## 👥 Team Setup

### Recommended Team Structure
- **Maintainers**: Core team with admin access
- **Contributors**: Regular contributors with write access
- **Reviewers**: Subject matter experts for content review

### Review Requirements
- **Content changes**: Require review from curriculum expert
- **Code changes**: Require review from C# expert
- **Infrastructure changes**: Require review from maintainer

## 📊 Project Boards (Optional)

Consider setting up GitHub Projects for sprint management:

### Sprint Board
Columns:
- 📋 Backlog
- 🔄 In Progress
- 👀 In Review
- ✅ Done

### Content Development Board
Columns:
- 📝 Planning
- ✍️ Writing
- 🧪 Testing
- 📖 Review
- 🎉 Published

## 🚀 Quick Setup Commands

For repository administrators, here are the key setup steps:

1. **Create Labels**: Use the GitHub web interface or GitHub CLI to create the labels listed above
2. **Set up Milestones**: Create milestones with appropriate due dates
3. **Configure Branch Protection**: Apply the rules listed above to the `main` branch
4. **Add Topics**: Include the suggested topics for discoverability
5. **Set Description**: Use the provided repository description

### Using GitHub CLI (if available)
```bash
# Example label creation (repeat for all labels)
gh label create "chapter" --color "0075ca" --description "Chapter content development"
gh label create "priority:high" --color "d73a4a" --description "Critical issues that block progress"

# Create milestones
gh milestone create "M0 Bootstrap" --description "Sprint 0 - Repository setup and templates"
```

## ✅ Setup Checklist

- [ ] All labels created
- [ ] Milestones configured
- [ ] Branch protection rules applied
- [ ] Repository description set
- [ ] Topics added
- [ ] Team permissions configured
- [ ] Issue templates working
- [ ] PR template working
- [ ] CI workflow running successfully

---

**Note**: This setup should be completed by a repository administrator before the first sprint begins. The labels and milestones align with the project plan and will help organize work throughout the development process.