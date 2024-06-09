namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 医生（业务逻辑层）接口
    /// </summary>
    public interface IDoctorBll
    {
        /// <summary>
        /// 工号的长度
        /// </summary>
        int NoLength { get; }
        /// <summary>
        /// 密码最小长度
        /// </summary>
        int PasswordMinLength { get; }
        /// <summary>
		/// 密码最大长度
		/// </summary>
		int PasswordMaxLength { get; }
        /// <summary>
        /// 是否完成登录
        /// </summary>
        bool HasLoggedIn { get; }
        /// <summary>
        /// 是否完成注册
        /// </summary>
        bool HasSignedUp { get; }
        /// <summary>
        /// 消息
        /// </summary>
        string Message { get; }
        /// <summary>
        /// 数据库类型
        /// </summary>
        string DBType { get; }
        /// <summary>
        /// 检查工号是否存在
        /// </summary>
        /// <param name="no">工号</param>
        /// <returns>是否存在</returns>
        bool CheckExist(string no);
        /// <summary>
		/// 检查是否不存在
		/// </summary>
		/// <param name="userNo">工号</param>
		/// <returns>是否不存在</returns>
		bool CheckNotExist(string no);
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="no">工号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        Doctor LogIn(string no, string password);
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="no">工号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        Doctor SignUp(string no, string telephone, string password);
        /// <summary>
        /// 检查密码格式是否正确
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        bool CheckPassword(string password);
        /// <summary>
        /// 验证身份证号格式是否正确
        /// </summary>
        /// <param name="iD"></param>
        /// <returns></returns>
        bool CheckIDCardNo(string iD);
        /// <summary>
        /// 验证QQ邮箱格式是否正确
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        bool CheckQQEmail(string mail);
        /// <summary>
        /// 检查该QQ邮箱是否存在
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        bool CheckExistQQEmail(string mail);
        /// <summary>
        /// 检查电话号码格式是否正确
        /// </summary>
        /// <param name="telephone"></param>
        /// <returns></returns>
        bool CheckTelephone(string telephone);
        /// <summary>
        /// 检查电话号码是否已被绑定
        /// </summary>
        /// <param name="telephone"></param>
        /// <returns></returns>
        bool CheckExistTelephone(string telephone);
        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="no"></param>
        /// <param name="mail"></param>
        /// <returns></returns>
        Doctor RetrievePassword(string no, string mail);
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        int ModifyPassword(Doctor doctor, string password);
    }
}
