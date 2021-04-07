using demo_exam.Models.Class.CourseClass;

namespace demo_exam.Models.Class
{
    public class StudentCourse<T> where T : Course
    {
        public StudentCourse(DataModel.StudentCourse studentCourse)
        {
            Major = studentCourse.major;
            Course = (T)new Course(studentCourse.Course);
        }
        public string Major { get; set; }
        public T Course { get; set; }
    }
}