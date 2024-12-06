**Exchange Data in Secure Manner - ASP.NET Core Web API with Clean Architecture**

This project demonstrates an ASP.NET Core Web API with clean architecture principles, using JWT Authentication for secure data exchange. It includes features like user registration, login, and managing employee details.

**Project Structure**

The project is organized using clean architecture:

Application Layer: Contains interfaces and DTOs (Data Transfer Objects).
Domain Layer: Holds the core entities/models of the project.
Infrastructure Layer: Handles database interactions using Entity Framework Core.
Web API Layer: Manages the REST API controllers for handling client requests.
Prerequisites

**Make sure you have the following installed:**

.NET 9 SDK
SQL Server
Visual Studio 2022
Setup Guide

**Clone the Repository**
Database Configuration
Open appsettings.json and update the connection string with your SQL Server details:
"ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;User ID=YOUR_USER_ID;Password=YOUR_PASSWORD;"
}
**Ensure your SQL Server is running.**
Run Migrations
Open the Package Manager Console in Visual Studio.
Run the following command to create the database:
Update-Database
Build and Run the Application
Open the solution in Visual Studio.
Set the Web API project as the startup project.
Press F5 or run the application using:
dotnet run
The API and Swagger documentation should now be accessible at https://localhost:5001/swagger

