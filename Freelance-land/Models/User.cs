using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class User
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Sur_Name { get; set; }

    public DateTime Birth_Date { get; set; }

    public string Phone_Number { get; set; }

    public string Email { get; set; }

    public string Login { get; set; }

    public string Password { get; set; }

    public ICollection<Review> Customer_Reviews { get; set; }
    public ICollection<Review> Executor_Reviews { get; set; }
    public ICollection<Task_History> Customer_History { get; set; }
    public ICollection<Task_History> Executor_History { get; set; }
    public User()
    {
        Executor_Reviews = new List<Review>();
        Customer_Reviews = new List<Review>();
        Customer_History = new List<Task_History>();
        Executor_History = new List<Task_History>();
    }

    public int? User_Status_Id { get; set; }
    public User_Status User_Status { get; set; }

}
