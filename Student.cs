﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo
{
    public class Student
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Age => (DateTime.Now.Year - Birthday.Year);
    } 
}
