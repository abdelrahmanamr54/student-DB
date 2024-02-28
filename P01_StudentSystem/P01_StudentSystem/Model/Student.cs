using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Model
{
    internal class Student
    {



        public int StudentId { get; set; }


        [Column(TypeName = "NVARCHAR(100)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }

        public DateTime? Birthday { get; set; }
        public ICollection<Course> courses { get; set; }
        public ICollection<Homework> homeworks { get; set; }

        //        StudentId
        //o Name(up to 100 characters, unicode)
        //o PhoneNumber(exactly 10 characters, not unicode, not required)
        //o RegisteredOn(DateTime)
        //o Birthday(not required
    }
}
