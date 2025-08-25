# 🧅 Simple Onion Architecture API

A practical, example Web API built with ASP.NET Core 8.0, demonstrating the fundamental principles of **Onion Architecture.** This project provides a clear separation of concerns, making it a great template for building maintainable and testable enterprise applications.

## ✨ Features

- **🧅 Clear Onion Architecture**: Strict separation into Domain, Application, Infrastructure, and API layers.
- **🛡️ API Best Practices**: Clean controllers using service classes for business logic.
- **🗄️ Entity Framework Core**: Data access with migrations and a generic repository pattern.
- **✅ SOLID Principles**: Emphasis on interfaces, dependency injection, and loose coupling.
- **🚀 Swagger/OpenAPI**: Interactive API documentation included.

## 🏗️ Solution Structure

The solution is organized into four core projects, ensuring dependencies flow inward towards the domain.
OnionArchitecture.sln
├── OnionArchitecture.API/
│ ├── Controllers/
│ │ └── ProductsController.cs
│ ├── Program.cs 
│ └── appsettings.json
│
├── OnionArchitecture.Application/ 
│ ├── DTOs/
│ │ └── ProductDto.cs 
│ ├── Interfaces/
│ │ └── IProductService.cs 
│ └── Services/
│ └── ProductService.cs
│
├── OnionArchitecture.Domain/ 
│ ├── Entities/
│ │ └── Product.cs 
│ └── Interfaces/
│ └── IProductRepository.cs
│
└── OnionArchitecture.Infrastructure/ 
├── Migrations/ 
├── Persistence/
│ └── AppDbContext.cs 
└── Repositories/
└── ProductRepository.cs 

### Dependency Graph
`API` → `Application` → `Domain` ← `Infrastructure`

The **Domain** layer has no dependencies on any other project, making it the stable core of the application.

## 📦 Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- A compatible database (e.g., SQL Server, SQLite, PostgreSQL)

### Installation & Setup

1.  **Clone the repository**
    ```bash
    git clone https://github.com/HasanAhmadov/Simple-Onion-Architecture-API.git
    cd Simple-Onion-Architecture-API
    ```

2.  **Configure the Database**
    - Open the solution file (`OnionArchitecture.sln`) in your IDE (Visual Studio, Rider, VS Code).
    - In the `OnionArchitecture.API` project, update the connection string in `appsettings.json` to point to your database server.

3.  **Create the Database using EF Migrations**
    - Open the Package Manager Console (in Visual Studio) or a terminal.
    - Ensure the default project is set to `OnionArchitecture.Infrastructure`.
    - Run the following commands:
    ```bash
    Add-Migration InitialCreate
    Update-Database
    ```
    *Alternatively, from a terminal in the `Infrastructure` project directory:*
    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```

4.  **Run the Application**
    - Set the `OnionArchitecture.API` project as the startup project.
    - Run the application (F5 in Visual Studio, or `dotnet run` from the `API` project directory).

5.  **Explore the API**
    - Navigate to the Swagger UI to see and test the available endpoints.
