# Task Manager API

A RESTful Web API for managing tasks, built with **ASP.NET Core 8** and **Entity Framework Core**.

## Features

- Full **CRUD** operations for tasks (Create, Read, Update, Delete)
- **Filter tasks by status** via query parameter
- **Input validation** with meaningful error messages
- **Swagger UI** with auto-generated interactive documentation
- **In-memory database** — no external DB setup required

<img width="999" height="630" alt="image" src="https://github.com/user-attachments/assets/09e748c7-65ba-4911-ad2a-f90ad0b38fd2" />

<img width="976" height="518" alt="image" src="https://github.com/user-attachments/assets/5f1aee8d-cd49-41af-a1e5-1890efe9d7d8" />

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
---
 ## What i learned

 While building the Task Manager API, I developed a solid understanding of how to design and implement a RESTful web service using ASP.NET Core 8 and Entity Framework Core. I learned how to structure a clean and maintainable backend by separating concerns into controllers, models, DTOs, and data layers. Implementing full CRUD operations helped me better understand HTTP methods, routing, and handling requests and responses effectively. I also gained experience with input validation and returning meaningful error messages, which improved the overall reliability and usability of the API. Using an in-memory database allowed me to quickly prototype and test functionality without complex setup, while Swagger helped me explore and document endpoints in an interactive way. Overall, this project strengthened my backend development skills and gave me a clearer perspective on building scalable and well-structured APIs.
