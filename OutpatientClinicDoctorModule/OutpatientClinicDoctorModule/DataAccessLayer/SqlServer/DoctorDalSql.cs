using System;
using System.Data;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 医生（SQL Server数据访问层）
    /// </summary>
    public class DoctorDalSql : IDoctorDal
    {
        /// <summary>
        /// SQL助手
        /// </summary>
        private SqlHelper SqlHelper { get; set; }
        /// <summary>
        /// 查询医生计数
        /// </summary>
        /// <param name="no">工号</param>
        /// <returns>计数</returns>
        public int SelectCount(string no)
        => this.SqlHelper
            .NewCommand("SELECT COUNT(*) FROM tb_Doctor WHERE No=@No")
            .NewParameter("@No", no)
            .GetScalar<int>();
        /// <summary>
        /// 查询医生
        /// </summary>
        /// <param name="no">工号</param>
        /// <returns>医生</returns>
        public Doctor Select(string no)
        {
            IDataReader dataReader =
                this.SqlHelper
                .NewCommand("SELECT * FROM tb_Doctor WHERE No=@No")
                .NewParameter("@No", no)
                .GetReader();
            Doctor doctor = null;
            if (dataReader.Read())
            {
                doctor = new Doctor()
                {
                    No = no,
                    Password = dataReader["Password"] == DBNull.Value ? null : (byte[])dataReader["Password"],
                    Name = dataReader["Name"] == DBNull.Value ? null : (string)dataReader["Name"],
                    Gender = dataReader["Gender"] == DBNull.Value ? default(bool) : (bool)dataReader["Gender"],
                    Birthdate = dataReader["BirthDate"] == DBNull.Value ? DateTime.Now : (DateTime)dataReader["BirthDate"],
                    IDCardNo = dataReader["IDCardNo"] == DBNull.Value ? null : (string)dataReader["IDCardNo"],
                    Telephone = dataReader["Telephone"] == DBNull.Value ? null : (string)dataReader["Telephone"],
                    QQEmail = dataReader["QQEmail"] == DBNull.Value ? null : (string)dataReader["QQEmail"],
                    DepartmentNo = dataReader["DepartmentNo"] == DBNull.Value ? 1 : (int)dataReader["DepartmentNo"],
                    TitleNo = dataReader["TitleNo"] == DBNull.Value ? 1 : (int)dataReader["TitleNo"],
                    Introduction = dataReader["Introduction"] == DBNull.Value ? null : (string)dataReader["Introduction"],
                    Avatar = dataReader["Avatar"] == DBNull.Value ? null : (byte[])dataReader["Avatar"],
                    ErrorNumber = dataReader["ErrorNumber"] == DBNull.Value ? 0 : (int)dataReader["ErrorNumber"],
                    IsFreeze = dataReader["IsFreeze"] == DBNull.Value ? false : (bool)dataReader["IsFreeze"]
                };
            }
            return doctor;
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="doctor">医生</param>
        /// <returns>受影响行数</returns>
        public int Update(Doctor doctor)
        => this.SqlHelper
            .NewCommand($@"UPDATE tb_Doctor
	                            SET Password=@Password,
		                            Name=@Name,
		                            Gender=@Gender,
		                            BirthDate=@BirthDate,
		                            IDCardNo=@IDCardNo,
		                            Telephone=@Telephone,
		                            QQEmail=@QQEmail,
		                            DepartmentNo=@DepartmentNo,
		                            TitleNo=@TitleNo,
		                            Introduction=@Introduction,
		                            Avatar=@Avatar,
		                            ErrorNumber=@ErrorNumber,
		                            IsFreeze=@IsFreeze
	                            WHERE No=@No")
            .NewParameter("@No", doctor.No)
            .NewParameter("@Password", doctor.Password)
            .NewParameter("@Name", doctor.Name)
            .NewParameter("@Gender", doctor.Gender)
            .NewParameter("@BirthDate", doctor.Birthdate)
            .NewParameter("@IDCardNo", doctor.IDCardNo)
            .NewParameter("@Telephone", doctor.Telephone)
            .NewParameter("@QQEmail", doctor.QQEmail)
            .NewParameter("@DepartmentNo", doctor.DepartmentNo)
            .NewParameter("@TitleNo", doctor.TitleNo)
            .NewParameter("@Introduction", doctor.Introduction)
            .NewParameter("@Avatar", doctor.Avatar)
            .NewParameter("@ErrorNumber", doctor.ErrorNumber)
            .NewParameter("@IsFreeze", doctor.IsFreeze)
            .NonQuery();
        /// <summary>
        /// 插入用户；
        /// </summary>
        /// <param name="doctor">医生</param>
        /// <returns>受影响行数</returns>
        public int Insert(Doctor doctor)
        {
            int rowAffected = 0;
            try
            {
                rowAffected =
                    this.SqlHelper
                    .NewCommand($@"INSERT INTO tb_Doctor
	                                    (No,Password,Telephone,IsFreeze)
	                                    VALUES
	                                    (@No,@Password,@Telephone,@IsFreeze)")
                    .NewParameter("@No", doctor.No)
                    .NewParameter("@Password", doctor.Password)
                    .NewParameter("@Telephone", doctor.Telephone)
                    .NewParameter("@IsFreeze", doctor.IsFreeze)
                    .NonQuery();
            }
            catch (NotUniqueException)
            {
                throw new ApplicationException("您提交的工号已存在");
            }
            catch (Exception)
            {
                throw;
            }
            return rowAffected;
        }
        /// <summary>
        /// 更新密码
        /// </summary>
        /// <param name="doctor"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int UpdatePassword(Doctor doctor, byte[] password)
            =>this.SqlHelper
                .NewCommand($@"UPDATE tb_Doctor
                                SET Password=@Password
                                WHERE No=@No")
                .NewParameter("@No", doctor.No)
                .NewParameter("@Password", password)
                .NonQuery();
        /// <summary>
        /// 查询QQ邮箱计数
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public int SelectCountQQEmail(string mail)
            => this.SqlHelper
            .NewCommand("SELECT COUNT(*) FROM tb_Doctor WHERE QQEmail=@QQEmail")
            .NewParameter("@QQEmail", mail)
            .GetScalar<int>();
        /// <summary>
        /// 查询电话号码计数
        /// </summary>
        /// <param name="telephone"></param>
        /// <returns></returns>
        public int SelectCountTelephone(string telephone)
            => this.SqlHelper
            .NewCommand("SELECT COUNT(*) FROM tb_Doctor WHERE Telephone=@Telephone")
            .NewParameter("@Telephone", telephone)
            .GetScalar<int>();
        /// <summary>
        /// 构造函数；
        /// </summary>
        public DoctorDalSql()
        {
            this.SqlHelper = new SqlHelper();
        }
    }
}
