using demo_exam.Models.Class;
using demo_exam.Models.Class.CourseClass;
using demo_exam.Models.Class.StudentClass;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;

namespace demo_exam.Controllers
{
    public class Variant3Controller : ApiController
    {
        Models.DataModel.CollegeEntities entities = Models.DataModel.CollegeEntities.GetCollegeEntities();

        [HttpGet]
        public JsonResult<string[]> NameStudents()
        {
            return Json(entities.Students.Local.Select(x => x.student_name).ToArray());
        }

        [HttpGet]
        public JsonResult<List<StudentCourse<CourseVariant3>>> Courses(string nameStudent)
        {
            return Json(ListStudentCourse(nameStudent));
        }

        [HttpGet]
        public JsonResult<List<StudentCourse<CourseVariant3>>> Courses(string nameStudent, string nameCourse)
        {
            var courseEntities = ListStudentCourse(nameStudent).Where(x => x.Course.CourseName.Contains(nameCourse))
                .ToList();
            return Json(courseEntities);
        }

        [HttpGet]
        public JsonResult<List<StudentCourse<CourseVariant3>>> Courses(string nameStudent, string nameCourse, string speciality)
        {
            var courseEntities = ListStudentCourse(nameStudent).Where(x => x.Major.Contains(speciality) && x.Course.CourseName.Contains(nameCourse))
                .ToList();
            return Json(courseEntities);
        }

        private List<StudentCourse<CourseVariant3>> ListStudentCourse(string name)
        {
            var student = entities.Students.Local.First(x => x.student_name.Contains(name));
            var studentCourse = student.StudentCourses.Select(x => new StudentCourse<CourseVariant3>(x)).ToList();
            //var courseEntities = entities.Students.Local.Select(x => new Student(x)).Select(x => x.StudentCourses.Where(s => s.Courses.CourseName.Contains(name))).ToList();
            return studentCourse;
            //return entities.Students
            //    .First(x => x.student_name.Contains(name)).StudentCourses
            //    .Select(x => x.Course)
            //    .ToList();
        }
    }
}