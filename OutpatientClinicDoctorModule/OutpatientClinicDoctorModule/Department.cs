namespace OutpatientClinicDoctorModule
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_Department")]
    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            tb_TreatRecord = new HashSet<TreatRecord>();
        }

        [Key]
        public int No { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? HospitalNo { get; set; }

        public virtual Hospital tb_Hospital { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TreatRecord> tb_TreatRecord { get; set; }
    }
}
