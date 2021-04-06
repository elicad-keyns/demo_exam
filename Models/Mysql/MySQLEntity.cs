namespace demo_exam.Models.Mysql
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MySQLEntity : DbContext
    {
        public MySQLEntity()
            : base("name=MySQLEntity")
        {
        }

        public virtual DbSet<InformationAboutCourse> InformationAboutCourses { get; set; }
        public virtual DbSet<InformationAboutStudent> InformationAboutStudents { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InformationAboutCourse>()
                .Property(e => e.course)
                .IsUnicode(false);

            modelBuilder.Entity<InformationAboutCourse>()
                .Property(e => e.faculty_id)
                .IsUnicode(false);

            modelBuilder.Entity<InformationAboutCourse>()
                .Property(e => e.classroom)
                .IsUnicode(false);

            modelBuilder.Entity<InformationAboutCourse>()
                .Property(e => e.schedule)
                .IsUnicode(false);

            modelBuilder.Entity<InformationAboutCourse>()
                .Property(e => e.faculty_name)
                .IsUnicode(false);




            modelBuilder.Entity<InformationAboutStudent>()
                .Property(e => e.student_name)
                .IsUnicode(false);

            modelBuilder.Entity<InformationAboutStudent>()
                .Property(e => e.course)
                .IsUnicode(false);

            modelBuilder.Entity<InformationAboutStudent>()
                .Property(e => e.major_course)
                .IsUnicode(false);
        }
    }
}
