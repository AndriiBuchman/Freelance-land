using System;
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

    public int? Status_Id { get; set; } 
    public Task_Status Task_Status { get; set; }

    public int? Task_Category_Id { get; set; }
    public Task_Category Task_Category { get; set; }

    public ICollection<Task_History> Task_Histories { get; set; }
    public Task()
    {
        Task_Histories = new List<Task_History>();
    }
}

