using demo_exam.Models;
using demo_exam.Models.Class.CourseClass;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;

namespace demo_exam.Controllers
{
    public class Variant2Controller : ApiController
    {
        Models.DataModel.CollegeEntities entities = Models.DataModel.CollegeEntities.GetCollegeEntities();

        [HttpGet]
        public JsonResult<List<Course>> Courses()
        {
            var courseEntities = entities.Courses.Local.Select(x => (Course)new CourseVariant2(x))
                .ToList();
            return Json(courseEntities);
        }

        [HttpGet]
        public JsonResult<List<Course>> Courses(string nameCourses)
        {
            var courseEntities = entities.Courses.Local.Select(x => (Course)new CourseVariant2(x))
                .ToList();
            return Json(courseEntities.Where(x => x.CourseName.Contains(nameCourses))
                .ToList());
        }

        [HttpGet]
        public JsonResult<List<Course>> Courses(string nameCourses, string classroom)
        {
            var courseEntities = entities.Courses.Local.Select(x => new CourseVariant2(x))
                .ToList();
            return Json(courseEntities.Where(x => x.CourseName.Contains(nameCourses) && x.Classroom == classroom)
                .Select(x=> (Course)x)
                .ToList());
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