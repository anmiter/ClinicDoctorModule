namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 排号（数据访问层）接口
    /// </summary>
    public interface IQueueDal
    {
        /// <summary>
        /// 更新排号表
        /// </summary>
        /// <param name="queue">排号表</param>
        /// <returns>受影响行数</returns>
        int Update(int stateNo, Doctor doctor, Patient patient);
    }
}
