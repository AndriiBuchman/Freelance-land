﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Task
{
    public int Id { get; set; }

    public int Price { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public DateTime Date { get; set; }

    public DateTime Deadline { get; set; }

    public int? TaskStatusId { get; set; } 
    public Task_Status TaskStatus { get; set; }

    public int? TaskCategoryId { get; set; }
    public Task_Category TaskCategory { get; set; }

    public List<Task_History> TaskHistories { get; set; }
}

