﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Comment
{
    public int Id { get; set; }

    public string Content { get; set; }

    public DateTime DateAndTime { get; set; }

    public int? UserId { get; set; }
    public User User { get; set; }

    public int? TaskId { get; set; }
    public Task Task { get; set; }
}

