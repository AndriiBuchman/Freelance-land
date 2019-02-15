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

    public List<Review> CustomerReviews { get; set; }
    public List<Review> ExecutorReviews { get; set; }
    public List<Task_History> CustomerHistories { get; set; }
    public List<Task_History> ExecutorHistories { get; set; }

    public int? UserStatusId { get; set; }
    public User_Status UserStatus { get; set; }

}
