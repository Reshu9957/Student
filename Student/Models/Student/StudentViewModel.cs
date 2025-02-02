﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Models.Student
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegisterNumber { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Department { get; set; }
        public string Password { get; set; }
        public SubjectViewModel Subject { get; set; }
    }
}
