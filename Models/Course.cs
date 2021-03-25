namespace demo_exam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Course")]
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
        
        [DataMember]
        public double? credit { get; set; }
        
        [DataMember]
        public string classroom { get; set; }
        
        [DataMember]
        public string schedule { get; set; }
        
        [DataMember]
        public int? enrollment { get; set; }

        [StringLength(50)]
        public string faculty_id { get; set; }

        public virtual Faculty Faculty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
