Project Purpose

DP Tracker is a Blazor Server web application that helps students centralize and monitor their academic performance in a single, interactive dashboard. What started as a personal grade‑tracking tool quickly grew into a solution validated by peer surveys, demonstrating strong demand for an easy‑to‑use, self‑contained grade management system.

Key Features
Dynamic Module Management
Create, rename and delete any number of “modules” (your courses), each with its own dedicated assessment table.

Assessment Entry and Editing
For each module, add or remove assessments (midterms, quizzes, projects) by entering assessment name, weight percentage and score value.

Weighted Average Calculation
Instantly compute the current weighted average for each module with a single button click.

Goal Setting and Comparison
Define a target weighted average for each module and receive clear pass/fail feedback based on your current average versus goal.

Local Data Persistence
All modules and assessments are saved to an embedded SQLite database, ensuring your data survives page reloads and server restarts.

Technical Details
Framework: .NET 9 Blazor Hosted Web App

Persistence: SQLite database via Entity Framework Core

Data Modeling

Module entity with ModuleId, Name and Goal properties

Assessment entity with AssessmentId, Title, Weight, Score and foreign key to Module

Database Setup

Installed EF Core tools and SQLite provider

Defined AppDbContext with DbSet<Module> and DbSet<Assessment>

Created and applied initial migrations to generate the local database file

Project Highlights
Solo Development
Architected, implemented and tested all aspects of the application independently, demonstrating end‑to‑end ownership.

First‑Time SQLite Integration
Overcame the challenge of configuring a local SQLite database for the first time by installing required packages, defining context and running migrations.

Function‑First UI Design
Based on simple, hand‑drawn wireframes, the user interface focuses on clarity and ease of use rather than visual complexity.

User Feedback
Early testers praised the application for its straightforward workflow and intuitive design. Students reported that having all their modules and assessments in one place made it easier to:

Track progress throughout the semester

Identify areas needing improvement before exams

Set realistic grade targets and stay motivated

No further feature requests have been made at this time, indicating that the current functionality meets user needs effectively.
