### Secure Data Exchange with ASP.NET Core Web API (Clean Architecture) Guide

This project follows clean architecture principles to create a robust and maintainable ASP.NET Core Web API with JWT Authentication. Below is a step-by-step guide to help you set up and understand the project.

---

### **Project Structure Overview**

1. **Application Layer**  
   - Houses interfaces, DTOs, business logic, and validation rules.
   - Acts as a mediator between the Domain and Infrastructure layers.
   
2. **Domain Layer**  
   - Contains the core entities/models of the project.
   - Central to the architecture and independent of external dependencies.

3. **Infrastructure Layer**  
   - Responsible for data access using Entity Framework Core.
   - Implements interfaces from the Application Layer.

4. **Web API Layer**  
   - Hosts the controllers to manage client requests.
   - Includes configurations for routing, Swagger documentation, and authentication.

---

### **Prerequisites**

Ensure you have installed:

- **.NET 9 SDK**
- **SQL Server** (with a valid running instance)
- **Visual Studio 2022** or another suitable IDE

---

### **Setup Guide**

#### **Step 1: Clone the Repository**
Use the following command to clone the repository:
```bash
git clone <repository-url>
cd <repository-folder>
```

#### **Step 2: Configure the Database**

1. Open `appsettings.json` in the Web API project.
2. Update the `DefaultConnection` string:
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;User ID=YOUR_USER_ID;Password=YOUR_PASSWORD;"
    }
    ```

3. Ensure your SQL Server instance is running.

#### **Step 3: Run Entity Framework Migrations**

1. Open **Package Manager Console** in Visual Studio.
2. Run the following commands:
    ```powershell
    Add-Migration InitialCreate
    Update-Database
    ```

#### **Step 4: Build and Run the Application**

1. Set the Web API project as the startup project in Visual Studio.
2. Press `F5` to run the application or execute:
    ```bash
    dotnet run
    ```

3. The Swagger documentation should now be accessible at:
    ```
    https://localhost:5001/swagger
    ```

---

