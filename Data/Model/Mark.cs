﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Marks
    {
        public int Id { get; set; } 
        public string Stud { get; set; }    
        public int Mark { get; set; }
        public string Subject { get; set; } 
        public string Teacher { get; set; } 
        public string Date { get; set; }
    }
}