using System;
using System.Data;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 患者（数据访问层）
    /// </summary>
    public class PatientDal : IPatientDal
    {
        /// <summary>
		/// SQL助手
		/// </summary>
		private SqlHelper SqlHelper { get; set; }
        /// <summary>
        /// 查询患者
        /// </summary>
        /// <param name="cardNo">工号</param>
        /// <returns>患者</returns>
        public Patient Select(string cardNo)
        {
            IDataReader dataReader =
                this.SqlHelper
                .NewCommand("SELECT * FROM tb_Patient WHERE HealthCardNo=@No")
                .NewParameter("@No", cardNo)
                .GetReader();
            Patient patient = null;
            if (dataReader.Read())
            {
                patient = new Patient()
                {
                    HealthCardNo = cardNo,
                    IDCardNo = (string)dataReader["IDCardNo"],
                    Name = (string)dataReader["Name"],
                    Gender = (bool)dataReader["Gender"],
                    Birthdate = (DateTime)dataReader["BirthDate"],
                    Telephone = (string)dataReader["Telephone"],
                    IsMarried = (bool)dataReader["IsMarried"],
                    ProvenanceNo = (int)dataReader["ProvenanceNo"],
                    DrugAllergy = (string)dataReader["DrugAllergy"],
                    Balance = (decimal)dataReader["Balance"]
                };
            }
            return patient;
        }
        /// <summary>
        /// 查询患者计数
        /// </summary>
        /// <param name="cardNo">工号</param>
        /// <returns>计数</returns>
        public int SelectCount(string cardNo)
            => this.SqlHelper
            .NewCommand("SELECT COUNT(*) FROM tb_Patient WHERE HealthCardNo=@No")
            .NewParameter("@No", cardNo)
            .GetScalar<int>();
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="patient">患者</param>
        /// <returns>受影响行数</returns>
        public int Update(Patient patient)
        => this.SqlHelper
            .NewCommand($@"UPDATE tb_Patient
	                            SET IDCardNo=@IDCardNo,
		                            Name=@Name,
		                            Gender=@Gender,
		                            BirthDate=@BirthDate,
		                            Telephone=@Telephone,
									IsMarried=@IsMarried,
									ProvenanceNo=@ProvenanceNo,
									DrugAllergy=@DrugAllergy,
									Balance=@Balance
	                            WHERE HealthCardNo=HealthCardNo")
            .NewParameter("@HealthCardNo", patient.HealthCardNo)
            .NewParameter("@IDCardNo", patient.IDCardNo)
            .NewParameter("@Name", patient.Name)
            .NewParameter("@Gender", patient.Gender)
            .NewParameter("@BirthDate", patient.Birthdate)
            .NewParameter("@Telephone", patient.Telephone)
            .NewParameter("@IsMarried", patient.IsMarried)
            .NewParameter("@ProvenanceNo", patient.ProvenanceNo)
            .NewParameter("@DrugAllergy", patient.DrugAllergy)
            .NewParameter("@Balance", patient.Balance)
            .NonQuery();
        /// <summary>
		/// 构造函数；
		/// </summary>
		public PatientDal()
        {
            this.SqlHelper = new SqlHelper();
        }
    }
}
