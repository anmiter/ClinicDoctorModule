using System;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 排号（数据访问层）
    /// </summary>
    public class QueueDal : IQueueDal
    {
        /// <summary>
		/// SQL助手
		/// </summary>
		private SqlHelper SqlHelper { get; set; }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="queue">排号表</param>
        /// <returns>受影响行数</returns>
        public int Update(int stateNo, Doctor doctor, Patient patient)
        => this.SqlHelper
            .NewCommand($@"UPDATE tb_Queue
	                            SET StateNo=@StateNo
	                            WHERE DoctorNo=@DoctorNo
	                            AND	HealthCardNo=@HealthCardNo
                                AND Date=@Date")
            .NewParameter("@StateNo", stateNo)
            .NewParameter("@DoctorNo", doctor.No)
            .NewParameter("@HealthCardNo", patient.HealthCardNo)
            .NewParameter("@Date", DateTime.Now.ToShortDateString())
            .NonQuery();
        /// <summary>
		/// 构造函数；
		/// </summary>
		public QueueDal()
        {
            this.SqlHelper = new SqlHelper();
        }
    }
}
