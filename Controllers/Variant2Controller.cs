using demo_exam.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;

namespace demo_exam.Controllers
{
    public class Variant2Controller : ApiController
    {
        CollegeEntities entities = new CollegeEntities();

        [HttpGet]
        public JsonResult<List<Course>> Courses()
        {
            return Json(entities.Courses.Include(x => x.Faculty).ToList());
        }

        [HttpGet]
        public JsonResult<List<Course>> Courses(string nameCourses)
        {
            return Json(entities.Courses.Include(x => x.Faculty).Where(x=>x.course1.Contains(nameCourses)).ToList());
        }

        [HttpGet]
        public JsonResult<string[]> TitleCourses()
        {
            return Json(entities.Courses.Select(x => x.course1).Distinct().ToArray());
        }
    }
}