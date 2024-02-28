using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Model
{
    internal class StudentCourse
    {
        public int StudentId { get; set; }
        public Student student { get; set; }
        public int CourseId { get; set; }
        public Course course { get; set; }
    }
}
