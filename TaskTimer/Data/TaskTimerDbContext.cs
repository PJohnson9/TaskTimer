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


        public DbSet<Task> Task { get; set; }
        public DbSet<TaskCategory> TaskCategory { get; set; }
        public DbSet<WorkSession> WorkSession { get; set; }
    }
}
