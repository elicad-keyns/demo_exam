using demo_exam.Models.Class.CourseClass;

namespace demo_exam.Models.Class
{
    public class StudentCourse <T> where T : Course
    {
        public StudentCourse(DataModel.StudentCourse studentCourse)
        {
            Major = studentCourse.major;
            if(typeof(T).IsAssignableFrom(typeof(CourseVariant3)))
            {
                Course = new CourseVariant3(studentCourse.Course) as T;
            }
            else if (typeof(T).IsAssignableFrom(typeof(CourseVariant2)))
            {
                Course = new CourseVariant2(studentCourse.Course) as T;
            }
            else
                Course = (T)new Course(studentCourse.Course);
        }
        public string Major { get; set; }
        public T Course { get; set; }
    }
}