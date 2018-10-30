using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiTap1.Models
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string RollNumber { get; set; }
        public bool IsComplete { get; internal set; }
    }
}
