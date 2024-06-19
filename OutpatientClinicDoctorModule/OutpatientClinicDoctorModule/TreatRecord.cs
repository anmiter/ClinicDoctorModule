namespace OutpatientClinicDoctorModule
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tb_TreatRecord")]
    public partial class TreatRecord
    {
        [Key]
        [StringLength(50)]
        public string No { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string HealthCardNo { get; set; }

        [StringLength(50)]
        public string DoctorNo { get; set; }

        public int? DepartmentNo { get; set; }

        [StringLength(1500)]
        public string Description { get; set; }

        [StringLength(1500)]
        public string Result { get; set; }

        [StringLength(50)]
        public string TCMNo { get; set; }

        [StringLength(50)]
        public string PrescriptionNo { get; set; }

        [StringLength(50)]
        public string ExaminationsNo { get; set; }

        public decimal? TCMPrice { get; set; }

        public decimal? PrescriptionPrice { get; set; }

        public decimal? ExaminationPrice { get; set; }

        public bool? IsPaid { get; set; }

        public virtual Department tb_Department { get; set; }
    }
}
