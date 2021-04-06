namespace demo_exam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("login")]
    public partial class LogIn
    {
        [Key]
        [StringLength(50)]
        public string user_name { get; set; }

        [StringLength(50)]
        public string pass_word { get; set; }

        [StringLength(50)]
        public string faculty_id { get; set; }

        [StringLength(50)]
        public string student_id { get; set; }

        public virtual Faculty Faculty { get; set; }

        public virtual Student Student { get; set; }
    }
}
