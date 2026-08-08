# Airport Management System

This is a .NET application for managing airport operations using a layered architecture and object-oriented design.

## Overview

The system covers core airport workflows such as:

- flight management
- passenger management
- airport resources
- operational coordination

## Architecture

The project follows an n-tier architecture:

- `AM.UI.Console` presentation layer
- `AM.Core.Domain` domain models and business entities
- `AM.Core.Services` service layer
- `AM.Core.Extensions` shared extensions and helpers
- `AM.Data` data access layer

## Tech Stack

- C#
- .NET
- Layered architecture

## Repository Structure

- `AirportManagement.sln` solution file
- `AM.UI.Console/` presentation layer
- `AM.Core.Domain/` domain entities
- `AM.Core.Services/` application services
- `AM.Core.Extensions/` utility extensions
- `AM.Data/` persistence layer

## Getting Started

- Open the solution in Visual Studio or your preferred .NET IDE
- Restore dependencies
- Build the solution
- Run the console or UI project

## Branching and Commits

- Use branches such as `feat/<area>`, `fix/<area>`, `docs/<area>`, or `refactor/<area>`
- Keep commits focused on one domain or service change
- Prefer Conventional Commits such as `feat(airport): add flight scheduling flow`
- Avoid vague messages like `update`, `final`, or `test`

## Contributing

- Keep concerns separated across layers
- Update service contracts and data access together when needed
- Avoid committing binaries or IDE-specific temporary files
