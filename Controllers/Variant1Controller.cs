using demo_exam.Models.Class.CourseClass;
using demo_exam.Models.Class.StudentClass;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;

namespace demo_exam.Controllers
{
    public class Variant1Controller : ApiController
    {
        Models.DataModel.CollegeEntities entities = Models.DataModel.CollegeEntities.GetCollegeEntities();
        [HttpGet]
        public JsonResult<List<Student<Course>>> Students()
        {
            var studentCourse = entities.Students.Local.Select(x=> (Student<Course>)new StudentVariant1(x))
                .ToList();
            return Json(studentCourse);
        }

        [HttpGet]
        public JsonResult<List<Student<Course>>> Students(string name)
        {
            var studentCourse = entities.Students.Local.Select(x => (Student<Course>)new StudentVariant1(x))
                .ToList();
            return Json(studentCourse.Where(x=>x.Name.Contains(name)).ToList());
        }

        [HttpGet]
        public JsonResult<List<Student<Course>>> Students(string name, string courseName)
        {
            var studentCourse = entities.Students.Local.Select(x => (Student<Course>)new StudentVariant1(x))
                .ToList();
            return Json(studentCourse.Where(x => x.Name.Contains(name) && x.StudentCourses.Select(c=>c.Course.CourseName).Contains(courseName)).ToList());
        }

        [HttpGet]
        [Route("Variant1/Students")]
        public JsonResult<List<Student<Course>>> Student(string courseName)
        {
            var studentCourse = entities.Students.Local.Select(x => (Student<Course>)new StudentVariant1(x))
                .ToList();
            return Json(studentCourse.Where(x => x.StudentCourses.Select(c => c.Course.CourseName).Contains(courseName)).ToList());
        }

        [HttpGet]
        public JsonResult<string[]> TitleCourses()
        {
            return Json(entities.Courses.Local.Select(x => x.course1)
                .Distinct()
                .ToArray());
        }
    }
}
