using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimer.Models;

namespace TaskTimer.Data
{
    public static class TaskTimerDbSeed
    {
        public static void Initialize(TaskTimerDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.TaskCategories.Any())
                return; // Existing data

            TaskCategory[] categories = new TaskCategory[]
            {
                new TaskCategory("Work"),
                new TaskCategory("Fun"),
                new TaskCategory("Education")
            };

            foreach (TaskCategory c in categories)
            {
                context.TaskCategories.Add(c);
            }
            context.SaveChanges();
        }
    }
}
