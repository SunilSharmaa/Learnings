﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    [Serializable]
    public class StudentModel
    {
        
        public string Name { get; set; }
        public string Grade { get; set; }

        public int Age { get; set; }

    }
}
