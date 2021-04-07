using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace demo_exam.Models.DataModel
{
    public partial class CollegeEntities : DbContext
    {
        private CollegeEntities()
            : base("name=MySqlCollegeDB")
        {
        }

        private static CollegeEntities GetEntities;
        public static CollegeEntities GetCollegeEntities()
        {
            if(GetEntities == null)
            {
                GetEntities = new CollegeEntities();
                GetEntities.Students.Include(s => s.StudentCourses)
                    .Include(sc => sc.StudentCourses.Select(c => c.Course))
                    .Include(x => x.StudentCourses.Select(f => f.Course.Faculty)).Load();
            }
            return GetEntities;
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<LogIn> LogIns { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasMany(e => e.StudentCourses)
                .WithOptional(e => e.Course)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Courses)
                .WithOptional(e => e.Faculty)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.LogIns)
                .WithOptional(e => e.Faculty)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Student>()
                .HasMany(e => e.LogIns)
                .WithOptional(e => e.Student)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Student>()
                .HasMany(e => e.StudentCourses)
                .WithOptional(e => e.Student)
                .WillCascadeOnDelete();
        }
    }
}
