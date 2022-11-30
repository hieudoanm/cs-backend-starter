using System;
using Microsoft.EntityFrameworkCore;

namespace cs_backend_starter.Models;

public class TaskContext : DbContext
{
	public TaskContext(DbContextOptions<TaskContext> options) : base(options)
    {
	}

    public DbSet<Task> Tasks { get; set; } = null!;
}
