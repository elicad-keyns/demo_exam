using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace demo_exam.Models.Mysql
{
    [Table("demo_exam.information_about_student")]
    public class InformationAboutStudent
    {
        [Key]
        [StringLength(30)]
        public string student_name { get; set; }

        public double gpa { get; set; }

        [StringLength(100)]
        public string major { get; set; }

        [StringLength(100)]
        public string schoolYear { get; set; }

        [StringLength(30)]
        public string course { get; set; }

        [StringLength(30)]
        public string major_course { get; set; }
    }
}