using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Model
{
    public enum ContentType
    {
        Application,
        Pdf,
        Zip
    }
    internal class Homework
    {
        public int HomeworkId { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Content { get; set; }

        public ContentType contentType { get; set; }
        public string SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Student student { get; set; }
        public Course course { get; set; }


        //        HomeworkId
        //o Content(string, linking to a file, not unicode)
        //o ContentType(enum – can be Application, Pdf or Zip)
        //o SubmissionTime
        //o StudentId
        //o CourseId
    }
}
