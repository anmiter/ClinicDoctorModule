using System;
using System.Data;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 病历（数据访问层）
    /// </summary>
    public class TreatRecordDal : ITreatRecordDal
    {
        /// <summary>
		/// SQL助手
		/// </summary>
		private SqlHelper SqlHelper { get; set; }
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="record">病历</param>
        /// <returns>受影响行数</returns>
        public int Insert(TreatRecord record)
        {
            int rowAffected = 0;
            try
            {
                rowAffected =
                    this.SqlHelper
                    .NewCommand($@"INSERT INTO tb_TreatRecord
	                                (Date,HealthCardNo,DoctorNo,Description,Result)
	                                VALUES
	                                (@Date,@HealthCardNo,@DoctorNo,@Description,@Result)")
                    .NewParameter("@Date", record.Date)
                    .NewParameter("@HealthCardNo", record.HealthCardNo)
                    .NewParameter("@DoctorNo", record.DoctorNo)
                    .NewParameter("@Description", record.Description)
                    .NewParameter("@Result", record.Result)
                    .NonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            return rowAffected;
        }
        /// <summary>
        /// 查询病历
        /// </summary>
        /// <param name="cardNo">医保卡号</param>
        /// <returns></returns>
        public TreatRecord Select(string cardNo)
        {
            IDataReader dataReader =
                this.SqlHelper
                .NewCommand("SELECT * FROM tb_TreatRecord WHERE HealthCardNo=@HealthCardNo")
                .NewParameter("@HealthCardNo", cardNo)
                .GetReader();
            TreatRecord record = null;
            if (dataReader.Read())
            {
                record = new TreatRecord()
                {
                    Date = (DateTime)dataReader["Date"],
                    HealthCardNo = (string)dataReader["HealthCardNo"],
                    DoctorNo = (string)dataReader["DoctorNo"],
                    Description = (string)dataReader["Description"],
                    Result = (string)dataReader["Result"],
                    TCMNo = (int)dataReader["TCMNo"],
                    PrescriptionNo = (int)dataReader["PrescriptionNo"],
                    ExaminationsNo = (int)dataReader["ExaminationsNo"],
                    Price = (decimal)dataReader["Price"],
                    IsPaid = (bool)dataReader["IsPaid"],
                };
            }
            return record;
        }
        /// <summary>
        /// 查询病历计数
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public int SelectCount(string record)
            => this.SqlHelper
            .NewCommand("SELECT COUNT(*) FROM tb_TreatRecord WHERE HealthCardNo=@record")
            .NewParameter("@record", record)
            .GetScalar<int>();
        /// <summary>
		/// 更新病历
		/// </summary>
		/// <param name="record">病历</param>
		/// <returns>受影响行数</returns>
		public int Update(TreatRecord record)
        => this.SqlHelper
            .NewCommand($@"UPDATE tb_TreatRecord
	                        SET Description=@Description,
		                        Result=@Result,
		                        TCMNo=@TCMNo,
		                        PrescriptionNo=@PrescriptionNo,
		                        ExaminationsNo=@ExaminationsNo,
		                        Price=@Price,
		                        IsPaid=@IsPaid
	                        WHERE HealthCardNo=HealthCardNo
	                        AND DoctorNo=@DoctorNo
	                        AND Date=@Date")
            .NewParameter("@HealthCardNo", record.HealthCardNo)
            .NewParameter("@DoctorNo", record.DoctorNo)
            .NewParameter("@Date", record.Date)
            .NewParameter("@Description", record.Description)
            .NewParameter("@Result", record.Result)
            .NewParameter("@TCMNo", record.TCMNo)
            .NewParameter("@PrescriptionNo", record.PrescriptionNo)
            .NewParameter("@ExaminationsNo", record.ExaminationsNo)
            .NewParameter("@Price", record.Price)
            .NewParameter("@IsPaid", record.IsPaid)
            .NonQuery();
        /// <summary>
        /// 构造函数
        /// </summary>
        public TreatRecordDal()
        {
            this.SqlHelper = new SqlHelper();
        }
    }
}
