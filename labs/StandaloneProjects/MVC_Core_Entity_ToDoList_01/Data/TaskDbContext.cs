using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Core_Entity_ToDoList_01.Models;

namespace MVC_Core_Entity_ToDoList_01.Models
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext (DbContextOptions<TaskDbContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Task> Task { get; set; }

        public DbSet<Category> Category { get; set; }

        // FLUENT API RELATIONSHIPS GO RIGHT HERE

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // RELATIONSHIPS
            // CATEGORY NAME REQUIRED
            builder.Entity<Category>().Property(c => c.CategoryName)
                .IsRequired().HasMaxLength(15);

            // EVERY TASK HAS ONE CATEGORY
            builder.Entity<Category>().HasMany(c => c.Tasks)
                .WithOne(task => task.Category);

            // ONE CATEGORY CAN HAVE MANY TASKS
            builder.Entity<Task>().HasOne(task => task.Category)
                .WithMany(category => category.Tasks);
        }
    }
}
