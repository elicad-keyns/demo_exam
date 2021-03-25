using demo_exam.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;

namespace demo_exam.Controllers
{
    public class ForSecretaryController : ApiController
    {
        CollegeEntities entities = new CollegeEntities();

        //GET: ForSecretary/GetClassroom
        public List<string> GetClassroom()
        {
            return entities.Courses.Select(x => x.classroom).ToList();
        }

        // GET: ForSecretary/GetCourses
        public JsonResult<List<Course>> GetCourses(string id) 
        {
            var item = entities.Courses.Where(x => x.classroom == id)
                .ToList();
            return Json(item);
        }
        // GET: ForSecretary/GetTotalCountHour
        public int GetTotalCountHour(string id)
        {
            var item = entities.Courses.Where(x => x.classroom == id)
                .ToList();
            return item.Sum(x => (int)x.enrollment);
        }
    }
}