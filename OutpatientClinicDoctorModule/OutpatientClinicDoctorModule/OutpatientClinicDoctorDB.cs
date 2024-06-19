using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OutpatientClinicDoctorModule
{
    public partial class OutpatientClinicDoctorDB : DbContext
    {
        public OutpatientClinicDoctorDB()
            : base("name=OutpatientClinicDoctorDB")
        {
        }

        public virtual DbSet<Department> tb_Department { get; set; }
        public virtual DbSet<Hospital> tb_Hospital { get; set; }
        public virtual DbSet<TreatRecord> tb_TreatRecord { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.tb_TreatRecord)
                .WithOptional(e => e.tb_Department)
                .HasForeignKey(e => e.DepartmentNo);

            modelBuilder.Entity<Hospital>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Hospital>()
                .HasMany(e => e.tb_Department)
                .WithOptional(e => e.tb_Hospital)
                .HasForeignKey(e => e.HospitalNo);

            modelBuilder.Entity<TreatRecord>()
                .Property(e => e.No)
                .IsUnicode(false);

            modelBuilder.Entity<TreatRecord>()
                .Property(e => e.HealthCardNo)
                .IsUnicode(false);

            modelBuilder.Entity<TreatRecord>()
                .Property(e => e.DoctorNo)
                .IsUnicode(false);

            modelBuilder.Entity<TreatRecord>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TreatRecord>()
                .Property(e => e.Result)
                .IsUnicode(false);

            modelBuilder.Entity<TreatRecord>()
                .Property(e => e.TCMNo)
                .IsUnicode(false);

            modelBuilder.Entity<TreatRecord>()
                .Property(e => e.PrescriptionNo)
                .IsUnicode(false);

            modelBuilder.Entity<TreatRecord>()
                .Property(e => e.ExaminationsNo)
                .IsUnicode(false);
        }
    }
}
