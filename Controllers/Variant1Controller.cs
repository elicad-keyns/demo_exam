using demo_exam.Models.Mysql;
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
        MySQLEntity entities = new MySQLEntity();

        [HttpGet]
        public JsonResult<List<InformationAboutStudent>> Students()
        {
            //var studentEntities = entities.Students
            //    .Include(x => x.StudentCourses
            //.Select(y=>y.Course))
            //    .ToList();
            //          entities.Students.Include(x => x.StudentCourses.Select(c => c.Course)).ToList()
            return Json(entities.InformationAboutStudents.ToList());
        }

        [HttpGet]
        public JsonResult<List<InformationAboutStudent>> Students(string name)
        {
            return Json(entities.InformationAboutStudents.Where(x=>x.course.Contains(name))
                .Select(x=>new InformationAboutStudent
                {
                    
                }).ToList());
            //return Json(entities.Students.Include(x => x.StudentCourses.Select(c => c.Course)).Where(x=>x.student_name.Contains(name)).ToList());
        }

        [HttpGet]
        public JsonResult<string[]> TitleCourses()
        {
            return Json(entities.InformationAboutStudents.Select(x=>x.course).Distinct().ToArray());
            //return Json(entities.Courses.Select(x => x.course1).Distinct().ToArray());
        }
    }
}
