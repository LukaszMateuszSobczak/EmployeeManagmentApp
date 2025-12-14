# EmployeeApp

Simple ASP.NET Core Web API for managing employees.

## Contents

- `API/` - ASP.NET Core project
  - `API/Data/Migrations` - EF Core migrations
  - `API/Entities/Employee.cs` - entity model
  - `Program.cs` - app startup and DI registration

## Prerequisites

- .NET 10 SDK (or matching SDK for the project target)
- `dotnet-ef` tool (optional for creating migrations locally)

Install `dotnet-ef` globally if you want to manage migrations locally:

```powershell
dotnet tool install --global dotnet-ef
```

## Setup (after cloning)

1. Clone the repo:

```powershell
git clone <your-repo-url>
cd EmployeeApp/API
```

2. Restore packages:

```powershell
dotnet restore
```

3. Configure the database connection

This project uses SQLite by default. The repository ignores local secrets and development settings, so you may need to add a development configuration with a connection string.

- Option A (recommended locally): create `appsettings.Development.json` next to `appsettings.json` and add:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=app.db"
  }
}
```

- Option B: set environment variable (Windows PowerShell):

```powershell
$Env:ConnectionStrings__DefaultConnection = "Data Source=app.db"
```

Notes:
- The repository `.gitignore` excludes `*.db` files and `appsettings.Development.json` to avoid committing local databases and secrets.

## Database / Migrations

Migrations are stored under `API/Data/Migrations` and are tracked in source control.

To apply existing migrations and create the database file:

```powershell
dotnet ef database update
```

To add a new migration after you change entity classes (run from `API/` folder):

```powershell
dotnet ef migrations add <MigrationName> -o Data/Migrations
```

Then apply it:

```powershell
dotnet ef database update
```

If you are in early development and the database is empty, you can remove migrations and recreate them, but DO NOT remove migrations for a database that already contains data unless you also reset that database file.

## Run

Run the API:

```powershell
dotnet run
# or for live reload during development
dotnet watch
```

The API will expose controllers under `/api/*`, e.g. `GET /api/employees` (see `API/Controllers`).

## Notes for contributors

- Keep migrations in `API/Data/Migrations` so other developers can apply the same schema changes.
- Local config (development connection strings, secrets) should stay out of source control; use `appsettings.Development.json` or environment variables.
- The project uses DI to provide `AppDbContext` (configured in `Program.cs`). When running locally, ensure the connection string points to a writable file location for the SQLite DB.

## Troubleshooting

- If `dotnet ef database update` fails, check that `dotnet-ef` is installed and you are running the command from the `API/` project folder.
- If you see missing connection string errors, verify `appsettings.Development.json` or environment variable is set.

## Useful commands summary

```powershell
# from EmployeeApp/API
dotnet restore
dotnet ef database update
dotnet run
# or
dotnet watch
```

---

If you want, I can also:
- add a sample `appsettings.Development.json` template (ignored by git),
- commit the README and .gitignore for you, or
- add a short CONTRIBUTING.md with development workflow.
