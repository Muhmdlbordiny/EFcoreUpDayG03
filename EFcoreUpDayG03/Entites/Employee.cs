﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreUpDayG03.Entites
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public int Dept_Id { get; set; }
        public Department? WorkFor { get; set; }
    }
}
