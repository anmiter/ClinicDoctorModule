using System;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 病历
    /// </summary>
    public class TreatRecord
    {
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 医保卡号
        /// </summary>
        public string HealthCardNo { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string DoctorNo { get; set; }
        /// <summary>
        /// 病情描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 病历报告
        /// </summary>
        public string Result { get; set; }
        /// <summary>
        /// 中药药方编号
        /// </summary>
        public int TCMNo { get; set; }
        /// <summary>
        /// 西药药方编号
        /// </summary>
        public int PrescriptionNo { get; set; }
        /// <summary>
        /// 检查项目清单编号
        /// </summary>
        public int ExaminationsNo { get; set; }
        /// <summary>
        /// 费用
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 是否支付
        /// </summary>
        public bool IsPaid { get; set; }
    }
}
