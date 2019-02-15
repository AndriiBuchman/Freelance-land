using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Task_History
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int? TaskExecutorId { get; set; }
    public User TaskExecutor { get; set; }

    public int? TaskCustomerId { get; set; }
    public User TaskCustomer { get; set; }

    public int? TaskId { get; set; }
    public Task Task { get; set; }
}

