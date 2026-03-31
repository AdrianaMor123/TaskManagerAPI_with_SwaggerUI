# Task Manager API

A RESTful Web API for managing tasks, built with **ASP.NET Core 8** and **Entity Framework Core**.

## Features

- Full **CRUD** operations for tasks (Create, Read, Update, Delete)
- **Filter tasks by status** via query parameter
- **Input validation** with meaningful error messages
- **Swagger UI** with auto-generated interactive documentation
- **In-memory database** — no external DB setup required

## Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core 8 Web API |
| ORM | Entity Framework Core 8 |
| Database | In-Memory (EF Core) |
| Docs | Swagger / OpenAPI (Swashbuckle) |

## Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Run the API

```bash
git clone https://github.com/YOUR_USERNAME/TaskManagerAPI.git
cd TaskManagerAPI
dotnet restore
dotnet run
```

Then open your browser at `https://localhost:{port}` to see the **Swagger UI**.

## API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| `GET` | `/api/tasks` | Get all tasks (optional `?status=Pending/InProgress/Completed`) |
| `GET` | `/api/tasks/{id}` | Get a task by ID |
| `POST` | `/api/tasks` | Create a new task |
| `PUT` | `/api/tasks/{id}` | Update an existing task |
| `DELETE` | `/api/tasks/{id}` | Delete a task |

### Example Request — Create a Task

```json
POST /api/tasks
{
  "title": "Review pull requests",
  "description": "Review and merge open PRs before EOD",
  "status": "Pending",
  "dueDate": "2024-12-01T17:00:00Z"
}
```

### Filter by Status

```
GET /api/tasks?status=InProgress
```

## Project Structure

```
TaskManagerAPI/
├── Controllers/
│   └── TasksController.cs     # API endpoints
├── Data/
│   └── AppDbContext.cs        # EF Core DB context + seed data
├── DTOs/
│   └── TaskDtos.cs            # Request/response data transfer objects
├── Models/
│   └── TaskItem.cs            # Task entity + Status enum
└── Program.cs                 # App configuration + startup
```

## Possible Enhancements

- Add JWT authentication
- Switch to SQL Server or PostgreSQL
- Add pagination to the GET all endpoint
- Add unit tests with xUnit
