using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace demo_exam.Models
{
    public partial class CollegeEntities : DbContext
    {
        public CollegeEntities()
            : base("name=CollegeEntities")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CollegeEntities>());
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
