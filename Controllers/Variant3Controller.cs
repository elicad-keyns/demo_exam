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

        public JsonResult<string[]> GetStudentsName()
        {
            return Json(entities.Students.Select(x => x.student_name).ToArray());
        }

        public JsonResult<List<Course>> GetCourses(string property, string courseName)
        {
            return Json(GetListCourses(property)
                .Where(x=>x.course1.Contains(courseName))
                .ToList());
        }

        public JsonResult<List<Course>> GetCourses(string property)
        {
            return Json(GetListCourses(property));
        }

        private List<Course> GetListCourses(string property)
        {
            return entities.Students
                .First(x => x.student_name == property).StudentCourses
                .Select(x => x.Course)
                .ToList();
        }

        //// GET: ForTeachers/GetCourses
        //public JsonResult<List<Course>> GetCourses()
        //{
        //    return Json(entities.Courses.ToList());
        //}

        //// GET: ForTeachers/GetCourses
        //public JsonResult<List<Student>> GetStudent(string id)
        //{
        //    return Json(GetStudents(id));
        //}

        //public double GetAvgScore(string id)
        //{
        //    return GetStudents(id).Average(x=>(double)x.gpa);
        //}

        //private List<Student> GetStudents(string idCourses)
        //{
        //    var item = entities.StudentCourses
        //        .Where(x => x.course_id == idCourses)
        //        .Select(x => x.student_id);
        //    return entities.Students
        //        .Where(x => item
        //        .Contains(x.student_id))
        //        .ToList();
        //}
    }
}