using demo_exam.Models.Class.CourseClass;
using System;
using System.Collections.Generic;
using System.Linq;

namespace demo_exam.Models.Class.StudentClass
{
    public class Student <SC> where SC : Course
    {
        public Student(DataModel.Student student)
        {
            Name = student.student_name;
            StudentCourses = student.StudentCourses.Select(x => new StudentCourse<SC>(x)).ToList();
        }
        public string Name { get; set; }
        public List<StudentCourse<SC>> StudentCourses { get; set; }

        public static explicit operator Student<SC>(StudentVariant1 v)
        {
            return (Student<SC>)v;
        }
    }
}