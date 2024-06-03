namespace OutpatientClinicDoctorModule
{
    /// <summary>
    ///  医生（数据访问层）接口
    /// </summary>
    public interface IDoctorDal
    {
        /// <summary>
		/// 插入医生
		/// </summary>
		/// <param name="doctor">医生</param>
		/// <returns>受影响行数</returns>
		int Insert(Doctor doctor);
        /// <summary>
        /// 查询医生
        /// </summary>
        /// <param name="no">工号</param>
        /// <returns>医生</returns>
        Doctor Select(string no);
        /// <summary>
        /// 查询医生计数
        /// </summary>
        /// <param name="no">工号</param>
        /// <returns>计数</returns>
        int SelectCount(string no);
        /// <summary>
		/// 更新医生
		/// </summary>
		/// <param name="doctor">医生</param>
		/// <returns>受影响行数</returns>
		int Update(Doctor doctor);
        /// <summary>
        /// 查询电话号码计数
        /// </summary>
        /// <param name="telephone"></param>
        /// <returns></returns>
        int SelectCountTelephone(string telephone);
        /// <summary>
        /// 查询QQ邮箱计数
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        int SelectCountQQEmail(string mail);

    }
}
