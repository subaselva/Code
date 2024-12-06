Prerequisites
Ensure you have the following installed:

.NET 8.0 SDK or higher
SQL Server or an alternative database server
Visual Studio 2022 or another IDE
Node.js for running the Blazor app if you're using React or Blazor WebAssembly
Setting Up the API
1. Clone the Repository
bash
Copy code
git clone https://github.com/your-username/UnitCostManagement.git
cd UnitCostManagement
2. Configure Database Connection
Update the appsettings.json file in the API project with your SQL Server connection string.

json
Copy code
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=YourDatabaseName;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
3. Restore Dependencies
Run the following command to restore the project dependencies.

bash
Copy code
dotnet restore
4. Migrate Database (If using Entity Framework)
If you have migrations enabled, apply the migrations to your database.

bash
Copy code
dotnet ef database update
Alternatively, run the API without migrations if you have an existing database.

5. Run the API
To start the API locally:

bash
Copy code
dotnet run
The API should now be running on https://localhost:7127/ (or another port if configured differently).

