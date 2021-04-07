namespace demo_exam.Models.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            LogIns = new HashSet<LogIn>();
            StudentCourses = new HashSet<StudentCourse>();
        }

        [Key]
        [StringLength(50)]
        public string student_id { get; set; }

        [DataMember]
        [StringLength(100)]
        public string student_name { get; set; }
        
        //[DataMember] - ��� ���� � ������ (1)
        public double? gpa { get; set; }

        public int? credits { get; set; }
        //[DataMember] - ��� ���� � ������ (1)
        public string major { get; set; }

        //[DataMember] - ��� ���� � ������ (1)
        public string schoolYear { get; set; }

        public string email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogIn> LogIns { get; set; }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
