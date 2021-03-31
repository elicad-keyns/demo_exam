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

        // GET: api/Variant2/GetCourses
        [HttpGet]
        public JsonResult<List<Course>> AllCourses()
        {
            return Json(entities.Courses.Include(x => x.Faculty).ToList());
        }

        // GET: api/Variant2/GetCourses/{courseName}
        [HttpGet]
        public JsonResult<List<Course>> Course(string nameCourse)
        {
            return Json(entities.Courses.Include(x => x.Faculty).Where(x=>x.course1.Contains(nameCourse)).ToList());
        }

        // GET: api/Variant2/GetTitleCourses
        [HttpGet]
        public JsonResult<string[]> TitleCourses()
        {
            return Json(entities.Courses.Select(x => x.course1).ToArray());
        }

        ////GET: ForSecretary/GetClassroom
        //public List<string> GetClassroom()
        //{
        //    return entities.Courses.Select(x => x.classroom).ToList();
        //}

        //// GET: ForSecretary/GetCourses
        //public JsonResult<List<Course>> GetCourses(string id) 
        //{
        //    var item = entities.Courses.Where(x => x.classroom == id)
        //        .ToList();
        //    return Json(item);
        //}
        //// GET: ForSecretary/GetTotalCountHour
        //public int GetTotalCountHour(string id)
        //{
        //    var item = entities.Courses.Where(x => x.classroom == id)
        //        .ToList();
        //    return item.Sum(x => (int)x.enrollment);
        //}
    }
}