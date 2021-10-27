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

    }
}
