namespace demo_exam.Models.Mysql
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("demo_exam.information_about_course")]
    public partial class InformationAboutCourse
    {
        [StringLength(30)]
        public string course { get; set; }

        [Key]
        [StringLength(6)]
        public string faculty_id { get; set; }

        [StringLength(100)]
        public string classroom { get; set; }

        [StringLength(30)]
        public string schedule { get; set; }

        [StringLength(30)]
        public string faculty_name { get; set; }
    }
}
