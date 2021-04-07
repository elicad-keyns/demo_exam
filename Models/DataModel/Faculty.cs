namespace demo_exam.Models.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("faculty")]
    public partial class Faculty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Faculty()
        {
            Courses = new HashSet<Course>();
            LogIns = new HashSet<LogIn>();
        }

        [Key]
        [StringLength(50)]
        public string faculty_id { get; set; }

        [DataMember]
        [StringLength(50)]
        public string faculty_name { get; set; }

        public string office { get; set; }

        public string phone { get; set; }

        public string college { get; set; }

        public string title { get; set; }

        public string email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogIn> LogIns { get; set; }
    }
}
