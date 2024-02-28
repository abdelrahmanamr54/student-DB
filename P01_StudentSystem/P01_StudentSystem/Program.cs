using P01_StudentSystem.Model;
using System.Reflection.Metadata;

namespace P01_StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentSystemContext context = new StudentSystemContext();


            Course courese = new Course();

            //context.students.Add(new() { Name = "salem", PhoneNumber = "0122456482",RegisteredOn=DateTime.Now });

            //context.students.Add(new() { Name = "akram", PhoneNumber = "0112047771", RegisteredOn = DateTime.Now });
            //context.students.Add(new() { Name = "Amgad", PhoneNumber = "0111441782", RegisteredOn = DateTime.Now   });

            //context.homeworks.Add(new() { Content = "Lec1_homework",  contentType=ContentType.Application,SubmissionTime= "2/28/2024", StudentId=3 ,CourseId=1});
            //context.homeworks.Add(new() { Content = "Lec2_homework", contentType = ContentType.Zip, SubmissionTime = "2/28/2024", StudentId = 3, CourseId = 2 });
            //context.homeworks.Add(new() { Content = "Lec_hw", contentType = ContentType.Pdf, SubmissionTime = "2/28/2024", StudentId = 4, CourseId = 3 });
            //context.courses.Add(new() { Name = "data_structure", StartDate = DateTime.Now, EndDate = DateTime.Now, Price = 2000 });
            //context.courses.Add(new() { Name = "discrete_Math", StartDate = DateTime.Now, EndDate = DateTime.Now, Price = 2200 });
            context.studentCourses.Add(new() { StudentId = 3, CourseId = 1 });
            context.studentCourses.Add(new() { StudentId = 4, CourseId = 2 });
            context.studentCourses.Add(new() { StudentId = 4, CourseId = 3 });
            context.studentCourses.Add(new() { StudentId = 5, CourseId = 1 });

            context.SaveChanges();


        }
    }
}