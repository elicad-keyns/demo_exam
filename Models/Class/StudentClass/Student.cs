using System.Collections.Generic;
using System.Linq;

namespace demo_exam.Models.Class.StudentClass
{
    public class Student <S> where S : CourseClass.Course
    {
        public Student(DataModel.Student student)
        {
            Name = student.student_name;
            StudentCourses = student.StudentCourses.Select(x => new StudentCourse<S>(x)).ToList();
        }
        public string Name { get; set; }
        public List<StudentCourse<S>> StudentCourses { get; set; }
    }
}