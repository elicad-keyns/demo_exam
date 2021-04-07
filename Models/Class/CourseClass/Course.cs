namespace demo_exam.Models.Class.CourseClass
{
    public class Course
    {
        public Course(DataModel.Course course)
        {
            CourseName = course.course1;
        }
        public string CourseName { get; set; }
    }
}