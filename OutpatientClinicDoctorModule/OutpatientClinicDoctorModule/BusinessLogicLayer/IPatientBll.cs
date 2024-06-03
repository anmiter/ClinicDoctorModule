namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 患者(业务逻辑层)接口
    /// </summary>
    public interface IPatientBll
    {
        /// <summary>
        /// 生成重要编码
        /// </summary>
        string KeyNo(Doctor doctor, Patient patient);
        /// <summary>
        /// 检查卡号是否存在
        /// </summary>
        /// <param name="cardNo">卡号</param>
        /// <returns>是否存在</returns>
        bool CheckExist(string cardNo);
        /// <summary>
        /// 选择患者
        /// </summary>
        /// <param name="cardNo"></param>
        /// <returns></returns>
        Patient Select(string cardNo);
    }
}
