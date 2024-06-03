using System;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 患者（业务逻辑层）
    /// </summary>
    public class PatientBll : IPatientBll
    {
        /// <summary>
        /// 医生（数据访问层）
        /// </summary>
        private IPatientDal PatientDal { get; set; }
        /// <summary>
        /// 重要编码
        /// </summary>
        /// <param name="doctor"></param>
        /// <param name="patient"></param>
        /// <returns></returns>
        public string KeyNo(Doctor doctor, Patient patient)
        {
            string keyNo = doctor.No + patient.HealthCardNo + DateTime.Now.Year.ToString();
            if (DateTime.Now.Month < 10)
            {
                keyNo = keyNo + "0" + DateTime.Now.Month.ToString();
            }
            else
            {
                keyNo = keyNo + DateTime.Now.Month.ToString();
            }
            if (DateTime.Now.Day < 10)
            {
                keyNo = keyNo + "0" + DateTime.Now.Day.ToString();
            }
            else
            {
                keyNo = keyNo + DateTime.Now.Day.ToString();
            }
            return keyNo;
        }
        /// <summary>
        /// 检查卡号是否存在
        /// </summary>
        /// <param name="cardNo">卡号</param>
        /// <returns>是否存在</returns>
        public bool CheckExist(string cardNo)
            => this.PatientDal.SelectCount(cardNo) == 1;
        /// <summary>
        /// 选择患者
        /// </summary>
        /// <param name="cardNo"></param>
        /// <returns></returns>
        public Patient Select(string cardNo)
        {
            if (this.CheckExist(cardNo) == false)
            {
                return null;
            }
            return this.PatientDal.Select(cardNo);
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public PatientBll()
        {
            this.PatientDal = new PatientDal();
        }
    }
}
