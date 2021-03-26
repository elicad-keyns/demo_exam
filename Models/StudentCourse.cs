namespace demo_exam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("StudentCourse")]
    public partial class StudentCourse
    {
        [Key]
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int s_course_id { get; set; }

        [StringLength(50)]
        public string student_id { get; set; }

        [StringLength(50)]
        public string course_id { get; set; }

        public int? credit { get; set; }

        [DataMember]
        public string major { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
    }
}
