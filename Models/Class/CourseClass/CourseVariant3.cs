namespace demo_exam.Models.Class.CourseClass
{
    public class CourseVariant3 : Course
    {
        public CourseVariant3(DataModel.Course course) : base(course)
        {
            Enrollment = course.enrollment;
        }

        public int? Enrollment { get; set; }
    }
}