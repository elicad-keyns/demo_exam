using demo_exam.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;

namespace demo_exam.Controllers
{
    public class Variant3Controller : ApiController
    {
        CollegeEntities entities = new CollegeEntities();

        [HttpGet]
        public JsonResult<string[]> NameStudents()
        {
            return Json(entities.Students.Select(x => x.student_name).ToArray());
        }

        [HttpGet]
        public JsonResult<List<Course>> Courses(string nameStudent, string nameCourse)
        {
            return Json(ListCourses(nameStudent)
                .Where(x=>x.course1.Contains(nameCourse))
                .ToList());
        }

        [HttpGet]
        public JsonResult<List<Course>> Courses(string nameCourse)
        {
            return Json(ListCourses(nameCourse));
        }

        private List<Course> ListCourses(string name)
        {
            return entities.Students
                .First(x => x.student_name.Contains(name)).StudentCourses
                .Select(x => x.Course)
                .ToList();
        }
    }
}