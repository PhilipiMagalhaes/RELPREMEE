﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RELPREMEE.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime? PostDate { get; set; }

    }
}
