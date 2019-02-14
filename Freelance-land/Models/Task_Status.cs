using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Task_Status
{
    public int Id { get; set; }

    public string Type { get; set; }

    public ICollection<Task> Tasks { get; set; }

    public Task_Status()
    {
        Tasks = new List<Task>();
    }
}

