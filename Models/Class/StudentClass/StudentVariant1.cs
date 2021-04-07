namespace demo_exam.Models.Class.StudentClass
{
    public class StudentVariant1 : Student<CourseClass.Course>
    {
        public StudentVariant1(DataModel.Student student) : base(student)
        {
            Gpa = student.gpa;
            Major = student.major;
            SchoolYear = student.schoolYear;
        }

        public double? Gpa { get; set; }
        public string Major { get; set; }
        public string SchoolYear { get; set; }
    }
}