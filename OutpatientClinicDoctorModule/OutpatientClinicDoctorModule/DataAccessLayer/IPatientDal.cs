namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 患者（数据访问层）接口
    /// </summary>
    public interface IPatientDal
    {
        /// <summary>
        /// 查询患者
        /// </summary>
        /// <param name="cardNo">工号</param>
        /// <returns>医生</returns>
        Patient Select(string cardNo);
        /// <summary>
        /// 查询患者计数
        /// </summary>
        /// <param name="cardNo">工号</param>
        /// <returns>计数</returns>
        int SelectCount(string cardNo);
        /// <summary>
		/// 更新患者
		/// </summary>
		/// <param name="patient">患者</param>
		/// <returns>受影响行数</returns>
		int Update(Patient patient);
    }
}
