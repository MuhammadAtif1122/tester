using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tester.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
