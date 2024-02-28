using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Model
{
    internal class Course
    {


        public int CourseId { get; set; }

        [Column(TypeName = "NVARCHAR(80)")]

        public string Name { get; set; }
        public string? Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public ICollection<Student>students { get; set; }
        public ICollection<Resource> resources { get; set; }
        public ICollection<Homework> homeworks{ get; set; }


        //        o CourseId
        //o Name(up to 80 characters, unicode)
        //o Description(unicode, not required)
        //o StartDate
        //o EndDate
        //o Price
    }
}
