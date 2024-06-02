using System;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 医生
    /// </summary>
    public class Doctor
    {
        /// <summary>
        /// 工号
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// 密码（加密）
        /// </summary>
        public byte[] Password { get; set; }
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
        /// 身份证号
        /// </summary>
        public string IDCardNo { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// QQ号
        /// </summary>
        public string QQEmail { get; set; }
        /// <summary>
        /// 科室编号
        /// </summary>
        public int DepartmentNo { get; set; }
        /// <summary>
        /// 职称编号
        /// </summary>
        public int TitleNo { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        public string Introduction { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public byte[] Avatar { get; set; }
        /// <summary>
        /// 错误次数
        /// </summary>
        public int ErrorNumber { get; set; }
        /// <summary>
        /// 是否冻结
        /// </summary>
        public bool IsFreeze { get; set; }
    }
}
