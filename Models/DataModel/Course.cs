namespace demo_exam.Models.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("course")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            StudentCourses = new HashSet<StudentCourse>();
        }

        [Key]
        [StringLength(50)]
        public string course_id { get; set; }

        [DataMember]
        [Column("course")]
        public string course1 { get; set; }
        
        public double? credit { get; set; }
        
        //[DataMember] - это надо в другом (2)
        public string classroom { get; set; }

        //[DataMember] - это надо в другом (2)
        public string schedule { get; set; }

        //[DataMember] - это надо в другом (3)
        public int? enrollment { get; set; }

        [StringLength(50)]
        public string faculty_id { get; set; }

        //[DataMember] - это надо в другом (2)
        public virtual Faculty Faculty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
