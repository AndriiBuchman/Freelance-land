using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Task_History
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int? Task_Executor_Id { get; set; }
    public User Task_Executor { get; set; }

    public int? Task_Customer_Id { get; set; }
    public User Task_Customer { get; set; }

    public int? Task_Id { get; set; }
    public Task Task { get; set; }
}

