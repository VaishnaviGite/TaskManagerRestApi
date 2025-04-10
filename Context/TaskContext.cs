using Microsoft.EntityFrameworkCore;
using TaskManagerRestApi.Models;

namespace TaskManagerRestApi.Context
{
    public class TaskContext: DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        { }

        public DbSet<Items> Tasks { get; set; }

    }
}
