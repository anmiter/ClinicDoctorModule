using System;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 患者
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// 医保卡号
        /// </summary>
        public string HealthCardNo { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string IDCardNo { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public bool Gender { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Birthdate { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// 是否已婚
        /// </summary>
        public bool IsMarried { get; set; }
        /// <summary>
        /// 来源编号
        /// </summary>
        public int ProvenanceNo { get; set; }
        /// <summary>
        /// 过敏史
        /// </summary>
        public string DrugAllergy { get; set; }
        /// <summary>
        /// 余额
        /// </summary>
        public decimal Balance { get; set; }
    }
}
