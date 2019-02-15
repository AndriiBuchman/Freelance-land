using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Review
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public string Description { get; set; }

    public int? ExecutorId { get; set; }
    public User Executor { get; set; }

    public int? CustomerId { get; set; }
    public User Customer { get; set; }
}

