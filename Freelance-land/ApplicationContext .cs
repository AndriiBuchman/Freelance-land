﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Task> Tasks { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<UserRoles> User_Statuses { get; set; }
    public DbSet<TaskCategory> Task_Categories { get; set; }
    public DbSet<TaskHistory> Task_Histories { get; set; }
    public DbSet<TaskStatus> Task_Statuses { get; set; }

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=freelancelanddb;Trusted_Connection=True;");
    }
}

