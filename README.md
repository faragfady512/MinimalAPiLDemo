# MinimalApiDemo with CRUD Operations

## Overview

MinimalApiDemo is a .NET 6 project that demonstrates the implementation of CRUD (Create, Read, Update, Delete) operations using Dapper and SQL Server in a .NET Core Web API. Additionally, it includes a Blazor client-side application for user interaction.

## Technologies Used

- .NET 6
- Dapper (Object-Relational Mapping)
- SQL Server (Database)
- .NET Core Web API
- Blazor (Client-side Application)

## Prerequisites

Before you begin, ensure you have the following installed:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) (optional)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) with a database created for this project.

## Getting Started

1. Clone this repository:

   ```bash
   git clone https://github.com/yourusername/MinimalApiDemo.git
2. Update the database connection string in appsettings.json under the API project to point to your SQL Server instance.
3. Run the  commands to apply the database migrations:
4. Run the API:
5. Open another terminal and navigate to the Blazor client directory:
6. Run the Blazor application:
7. Open your web browser and navigate to https://localhost:5001 to access the Blazor client application.

-API Endpoints
-GET /api/users: Get all users.
-GET /api/users/{id}: Get a user by ID.
-POST /api/users: Create a new user.
-PUT /api/users/{id}: Update an existing user.
-DELETE /api/users/{id}: Delete a user.
-Contributing
-Contributions are welcome! Please fork this repository and submit a pull request with your changes.




   

