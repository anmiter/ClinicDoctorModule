using System;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 排号表
    /// </summary>
    public class Queue
    {
        /// <summary>
        /// 工号
        /// </summary>
        public string DoctorNo { get; set; }
        /// <summary>
        /// 医保卡号
        /// </summary>
        public string HealthCardNo { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 排号
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 状态编号
        /// </summary>
        public int StateNo { get; set; }
    }
}
