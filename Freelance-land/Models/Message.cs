using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


public class Message
{
    public int Id { get; set; }

    public string Content { get; set; }

    public DateTime DateAndTime { get; set; }

    public int? SenderUserId { get; set; }
    [ForeignKey("SenderUserId")]
    public User SenderUser { get; set; }

    public int? GetterUserId { get; set; }
    [ForeignKey("GetterUserId")]
    [InverseProperty("UserMessages")]
    public User GetterUser { get; set; }

}

