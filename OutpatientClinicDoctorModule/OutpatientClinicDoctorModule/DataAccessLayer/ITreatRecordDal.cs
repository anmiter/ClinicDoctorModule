namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 病历（数据访问层）接口
    /// </summary>
    public interface ITreatRecordDal
    {
        /// <summary>
        /// 插入病历
        /// </summary>
        /// <param name="record">病历</param>
        /// <returns>受影响行数</returns>
        int Insert(TreatRecord record);
        /// <summary>
        /// 查询病历
        /// </summary>
        /// <param name="cardNo">医保卡号</param>
        /// <returns>医生</returns>
        TreatRecord Select(string cardNo);
        /// <summary>
        /// 查询病历计数
        /// </summary>
        /// <param name="cardNo">病历</param>
        /// <returns>计数</returns>
        int SelectCount(string cardNo);
        /// <summary>
		/// 更新病历
		/// </summary>
		/// <param name="record">病历</param>
		/// <returns>受影响行数</returns>
		int Update(TreatRecord record);
    }
}
