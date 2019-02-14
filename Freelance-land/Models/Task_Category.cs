using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Task_Category
{
    public int Id { get; set; }

    public string Type { get; set; }

    public ICollection<Task> Tasks { get; set; }
    public Task_Category()
    {
        Tasks = new List<Task>();
    }
}

