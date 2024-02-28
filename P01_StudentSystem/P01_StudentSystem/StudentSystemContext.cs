using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem
{
    internal class StudentSystemContext : DbContext
    {


        public DbSet<Student> students { get; set; }
        public DbSet<Homework> homeworks { get; set; }
        public DbSet<Resource> resources{ get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<StudentCourse> studentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source =.\\SQLEXPRESS; Initial Catalog = StudentSystem; Integrated Security = True; TrustServerCertificate = True");
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(b => b.Name)
                .HasMaxLength(100);
            modelBuilder.Entity<Course>()
               .Property(b => b.Name)
               .HasMaxLength(80);
            modelBuilder.Entity<Resource>()
              .Property(b => b.Name)
              .HasMaxLength(50);
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });


            modelBuilder.Entity<Student>()
                    .HasMany(e => e.courses)
                    .WithMany(e => e.students);


            modelBuilder.Entity<Student>()
       .HasMany(e => e.homeworks)
       .WithOne(e => e.student)
       .HasForeignKey(e => e.StudentId)
       .IsRequired();


            modelBuilder.Entity<Course>()
   .HasMany(e => e.homeworks)
   .WithOne(e => e.course)
   .HasForeignKey(e => e.CourseId)
   .IsRequired();

            modelBuilder.Entity<Course>()
.HasMany(e => e.resources)
.WithOne(e => e.course)
.HasForeignKey(e => e.CourseId)
.IsRequired();



        }
    }
}
