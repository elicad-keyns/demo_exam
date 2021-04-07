namespace demo_exam.Models.Class.CourseClass
{
    public class CourseVariant2 : Course
    {
        public CourseVariant2(DataModel.Course course) : base(course)
        {
            Classroom = course.classroom;
            Schedule = course.schedule;
            FacultyName = course.Faculty.faculty_name;
        }

        public string Classroom { get; set; }
        public string Schedule { get; set; }
        public string FacultyName { get; set; }
    }
}