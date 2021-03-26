using demo_exam.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace demo_exam.Controllers
{
    public class Variant1Controller : ApiController
    {
        CollegeEntities entities = new CollegeEntities();

        // GET: api/Variant1/GetStudents
        public JsonResult<List<Student>> GetStudents()
        {
            return Json(entities.Students.Include(x => x.StudentCourses.Select(c => c.Course)).ToList());
        }

        // GET: api/Variant1/GetStudents/{studentName}
        public JsonResult<List<Student>> GetStudents(string property)
        {
            return Json(entities.Students.Include(x => x.StudentCourses.Select(c => c.Course)).Where(x=>x.student_name.Contains(property)).ToList());
        }

        // GET: api/Variant1/GetTitleCourses
        public JsonResult<string[]> GetTitleCourses()
        {
            return Json(entities.Courses.Select(x => x.course1).ToArray());
        }

        // GET api/ForStudent/GetStudents
        //public JsonResult<List<Student>> GetStudents()
        //{
        //    return Json(entities.Students.ToList());
        //}
        //// Get api/Student/GetStudent
        //public JsonResult<List<Course>> GetStudent(string id)
        //{
        //    return Json(GetCourses(id));
        //}
        ////Get api/Student/GetTotalTime
        //public int GetTotalTime(string id)
        //{
        //    int totalTime = GetCourses(id).Sum(x=>(int)x.enrollment);
        //    return totalTime;
        //}

        ////А это получить нельзя)
        //private List<Course> GetCourses(string id)
        //{
        //    var item = entities.StudentCourses
        //        .Where(x => x.student_id == id)
        //        .Select(x=>x.course_id.ToString());
        //    return entities.Courses.Where(x => item.Contains(x.course_id)).ToList();
        //}
    }
}
