﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinoxBeard.Models
{
    public class UsageModel
    {
        [PrimaryKey, AutoIncrement]
        public int UsageID { get; set; }
        public string Title { get; set; }
        public string Venue { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
    }
}
