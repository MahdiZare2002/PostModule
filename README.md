# ASP.NET Core Onion Architecture Demo – State, City, Post Management

This is a sample project developed with **ASP.NET Core** following the **Onion Architecture** pattern. It demonstrates how to build a scalable, testable, and maintainable backend by structuring the application into multiple clear layers.

## 🧱 Architecture

The project follows Onion Architecture and includes:

- **Domain Layer** – Contains core business models and interfaces.
- **Application Layer** – Includes use cases and service interfaces.
- **Infrastructure Layer** – Implements interfaces for data access and external services.
- **Presentation Layer** – ASP.NET Core Web API exposing endpoints for managing data.

## 🗂️ Features

- CRUD operations for:
  - **State**
  - **City**
  - **Post**
- Clean separation of concerns
- Dependency Injection
- Entity Framework Core for data access
- FluentValidation (optional)
- AutoMapper (optional)

## 🚀 Getting Started

1. Clone the repository:

   ```bash
   1. git clone https://github.com/MahdiZare2002/PostModule.git
   2. cd PostModule
   3. dotnet ef database update
   4. dotnet run
