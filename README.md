# CrudwithDataAnnotation

This project is an ASP.NET MVC application that demonstrates CRUD (Create, Read, Update, Delete) operations with data annotations.

## Prerequisites

- Visual Studio 2017 or later
- .NET Framework 4.7.2 or later
- SQL Server Express LocalDB

## Installation

1. Clone the repository.
2. Open the solution file (`CrudwithDataAnnotation.sln`) in Visual Studio.
3. Build the solution to restore NuGet packages.
4. Update the database connection string in the `Web.config` file if necessary.
5. Run the database migrations to create the database schema. Open the Package Manager Console and run the command `Update-Database`.

## Usage

1. Run the application from Visual Studio.
2. Navigate to the `/Employees` URL to access the employee management page.
3. You can create, read, update, and delete employee records.

## Updating NuGet Packages

This project uses NuGet packages that should be managed in a Windows environment using Visual Studio.

### Using Visual Studio NuGet Package Manager:

1.  **Open the solution** in Visual Studio.
2.  **Right-click** on the solution or the project in the Solution Explorer.
3.  Select "**Manage NuGet Packages...**".
4.  Go to the **"Updates"** tab to see a list of packages with available updates.
5.  You can update packages individually or select multiple packages to update.
6.  Click the **"Update"** button and review the changes before accepting.

### Using Package Manager Console:

1.  **Open the solution** in Visual Studio.
2.  Go to **Tools > NuGet Package Manager > Package Manager Console**.
3.  To update a specific package, use the command:
    ```powershell
    Update-Package PackageName
    ```
4.  To update all packages in the project, use the command (use with caution, review changes):
    ```powershell
    Update-Package
    ```
5.  After updating, **rebuild the solution** and test thoroughly to ensure no breaking changes were introduced.

**Note:** Direct updates of `packages.config` in a non-Windows environment are not recommended as they might lead to inconsistencies in the project file or missing binding redirects.
