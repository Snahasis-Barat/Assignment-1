using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMnagementSystem.Models
{
   public class Student
    {
        public int id { get; set; }
         public string name { get; set; }
        public string address { get; set; }
        public string standard { get; set; }
        public List<Subject> subjects { get; set; }

    }
}
