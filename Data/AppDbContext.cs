using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TaskItem>().HasData(
                new TaskItem
                {
                    Id = 1,
                    Title = "Set up project",
                    Description = "Initialize the ASP.NET Core Web API project",
                    Status = WorkStatus.Completed,
                    DueDate = DateTime.UtcNow.AddDays(-1),
                    CreatedAt = DateTime.UtcNow.AddDays(-2)
                },
                new TaskItem
                {
                    Id = 2,
                    Title = "Build task endpoints",
                    Description = "Implement CRUD operations for task management",
                    Status = WorkStatus.InProgress,
                    DueDate = DateTime.UtcNow.AddDays(1),
                    CreatedAt = DateTime.UtcNow.AddDays(-1)
                },
                new TaskItem
                {
                    Id = 3,
                    Title = "Write unit tests",
                    Description = "Add test coverage for the controller layer",
                    Status = WorkStatus.Pending,
                    DueDate = DateTime.UtcNow.AddDays(3),
                    CreatedAt = DateTime.UtcNow
                }
            );
        }
    }
}