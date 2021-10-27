using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

using TaskTimer.Models;

namespace TaskTimer.Data
{
    public class TaskTimerDbContext : IdentityDbContext
    {
        public TaskTimerDbContext (DbContextOptions<TaskTimerDbContext> options) : base(options) { }


        public DbSet<WorkTask> Tasks { get; set; }
        public DbSet<TaskCategory> Categories { get; set; }
        public DbSet<WorkSession> Sessions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            String identity_schema = "Identity", 
                   data_schema = "TaskTimer";

            base.OnModelCreating(builder);

            builder.HasDefaultSchema(identity_schema);

            builder.Entity<WorkTask>().ToTable("Task", data_schema);
            builder.Entity<TaskCategory>().ToTable("Category", data_schema);
            builder.Entity<WorkSession>().ToTable("Session", data_schema);
        }
    }
}
