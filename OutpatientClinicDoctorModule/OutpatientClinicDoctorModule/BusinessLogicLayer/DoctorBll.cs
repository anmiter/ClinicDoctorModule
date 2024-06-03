using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 医生（业务逻辑层）
    /// </summary>
    public class DoctorBll : IDoctorBll
    {
        /// <summary>
        /// 医生（数据访问层）
        /// </summary>
        private IDoctorDal DoctorDal { get; set; }
        /// <summary>
        /// 失败次数上限
        /// </summary>
        private int MaxErrorNumber => 3;
        /// <summary>
        /// 工号的长度
        /// </summary>
        public int NoLength => 7;
        /// <summary>
		/// 密码最小长度
		/// </summary>
		public int PasswordMinLength => 8;
        /// <summary>
        /// 密码最大长度
        /// </summary>
        public int PasswordMaxLength => 20;
        /// <summary>
        /// 是否已成功登录
        /// </summary>
        public bool HasLoggedIn { get; private set; }
        /// <summary>
        /// 是否已注册
        /// </summary>
        public bool HasSignedUp { get; private set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Message { get; private set; }
        /// <summary>
		/// MD5值是否相等；
		/// </summary>
		/// <param name="md5">MD5值</param>
		/// <param name="otherPlainText">另一明文</param>
		/// <returns>是否相等</returns>
		private bool Md5Equal(byte[] md5, string otherPlainText)
        => md5.SequenceEqual(EnCrypt.Md5Encrypt(otherPlainText));
        /// <summary>
        /// 处理工号不存在
        /// </summary>
        /// <param name="doctor">医生</param>
        private void HandleNotExist(Doctor doctor)
        {
            if (doctor == null)
            {
                string errorMessage = "工号不存在！";
                throw new ApplicationException(errorMessage);
            }
        }
        /// <summary>
        /// 处理账号被冻结
        /// </summary>
        /// <param name="doctor">医生</param>
        private void HandleFreeze(Doctor doctor)
        {
            if (doctor.IsFreeze)
            {
                string errorMessage = "工号已被冻结，需要邮箱验证！";
                throw new ApplicationException(errorMessage);
            }
        }
        /// <summary>
        /// 处理登录失败次数过多
        /// </summary>
        /// <param name="doctor">医生</param>
        private void HandleLogInFailTooManyTimes(Doctor doctor)
        {
            if (doctor.ErrorNumber >= this.MaxErrorNumber)
            {
                doctor.IsFreeze = true;
                this.DoctorDal.Update(doctor);
            }
        }
        /// <summary>
        /// 处理登录失败
        /// </summary>
        /// <param name="doctor">医生</param>
        private void HandleLogInFail(Doctor doctor)
        {
            doctor.ErrorNumber++;
            this.DoctorDal.Update(doctor);
        }
        /// <summary>
        /// 处理密码错误
        /// </summary>
        /// <param name="doctor">医生</param>
        /// <param name="password">密码</param>
        private void HandlePasswordNotMatch(Doctor doctor, string password)
        {
            bool isPasswordMatch = this.Md5Equal(doctor.Password, password);
            if (!isPasswordMatch)
            {
                this.HandleLogInFail(doctor);
                this.HandleLogInFailTooManyTimes(doctor);
                string errorMessage =
                    !doctor.IsFreeze ?
                    $"密码错误，请重新输入！\n您还有{this.MaxErrorNumber - doctor.ErrorNumber}次机会！"
                    : $"密码错误已达{this.MaxErrorNumber}次上限！";
                throw new ApplicationException(errorMessage);
            }
        }
        /// <summary>
        /// 处理登录成功；
        /// </summary>
        /// <param name="doctor">医生</param>
        private void HandleLogInOk(Doctor doctor)
        {
            if (doctor.ErrorNumber != 0)
            {
                doctor.ErrorNumber = 0;
                this.DoctorDal.Update(doctor);
            }
            this.HasLoggedIn = true;
            this.Message = "登录成功。";
        }
        /// <summary>
        /// 检查工号是否存在
        /// </summary>
        /// <param name="no">工号</param>
        /// <returns>是否存在</returns>
        public bool CheckExist(string no)
            => this.DoctorDal.SelectCount(no) == 1;
        /// <summary>
        /// 检查工号是否不存在；
        /// </summary>
        /// <param name="no">工号</param>
        /// <returns>是否不存在</returns>
        public bool CheckNotExist(string no)
        => !this.CheckExist(no);
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="no">工号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public Doctor LogIn(string no, string password)
        {
            this.HasLoggedIn = false;
            Doctor doctor = this.DoctorDal.Select(no);
            try
            {
                this.HandleNotExist(doctor);
                this.HandleFreeze(doctor);
                this.HandlePasswordNotMatch(doctor, password);
                this.HandleLogInOk(doctor);
            }
            catch (ApplicationException ex)
            {
                this.Message = ex.Message;
            }
            catch (Exception)
            {
                this.Message = "登录失败！";
            }
            return doctor;
        }
        /// <summary>
		/// 注册
		/// </summary>
		/// <param name="no">工号</param>
		/// <param name="password">密码</param>
		/// <returns>用户</returns>
		public Doctor SignUp(string no, string telephone, string password)
        {
            this.HasSignedUp = false;
            Doctor doctor = new Doctor()
            {
                No = no,
                Telephone = telephone,
                Password = EnCrypt.Md5Encrypt(password),
                IsFreeze = false
            };
            try
            {
                this.DoctorDal.Insert(doctor);
                this.HasSignedUp = true;
                this.Message = "注册成功。";
            }
            catch (ApplicationException ex)
            {
                this.Message = $"{ex.Message}\n注册失败！";
            }
            catch (Exception)
            {
                this.Message = "注册失败！";
            }
            return doctor;
        }
        /// <summary>
        /// 检查电话号码格式是否正确
        /// </summary>
        /// <param name="telephone"></param>
        /// <returns></returns>
        public bool CheckTelephone(string telephone)
        {
            string pattern = "^1[34578]\\d{9}$"; // 正则表达式模式  
            bool isValid = Regex.IsMatch(telephone, pattern);
            return isValid;
        }
        /// <summary>
        /// 检查电话号码是否已被绑定
        /// </summary>
        /// <param name="telephone"></param>
        /// <returns></returns>
        public bool CheckExistTelephone(string telephone)
             => this.DoctorDal.SelectCountTelephone(telephone) == 1;
        /// <summary>
        /// 检查密码格式是否正确
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckPassword(string password)
        {
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*]).{8,20}$"; // 正则表达式模式  
            bool isValid = Regex.IsMatch(password, pattern);
            return isValid;
        }
        /// <summary>
        /// 验证QQ邮箱格式是否正确
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public bool CheckQQEmail(string mail)
        {
            string str = @"^[1-9][0-9]{4,}@qq.com$";
            Regex mReg = new Regex(str);
            if (mReg.IsMatch(mail))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 检查QQ邮箱是否存在
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public bool CheckExistQQEmail(string mail)
            => this.DoctorDal.SelectCountQQEmail(mail) == 1;
        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="no"></param>
        /// <param name="mail"></param>
        public Doctor RetrievePassword(string no, string mail)
        {
            Doctor doctor = this.DoctorDal.Select(no);
            if (doctor.QQEmail == mail)
                return doctor;
            else
                return null;
        }
        /// <summary>
        /// 验证身份证号格式是否正确
        /// </summary>
        /// <param name="iD"></param>
        /// <returns></returns>
        public bool CheckIDCardNo(string iD)
        {
            string pattern = "^\\d{18}$";  
            bool isValid = Regex.IsMatch(iD, pattern);
            return isValid;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public DoctorBll()
        {
            this.DoctorDal = new DoctorDal();
        }
    }
}
