using System;
using System.Data;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 医生（PostgreSQL数据访问层）
    /// </summary>
    public class DoctorDalPgsql : IDoctorDal
    {
        /// <summary>
        /// SQL助手
        /// </summary>
        private PgsqlHelper PgsqlHelper { get; set; }
        /// <summary>
        /// 查询医生计数
        /// </summary>
        /// <param name="no">工号</param>
        /// <returns>计数</returns>
        public int SelectCount(string no)
        => this.PgsqlHelper
            .NewCommand("SELECT CAST(COUNT(1) AS INTEGER) FROM tb_doctor AS d WHERE d.no=:no")
            .NewParameter(":no", no)
            .GetScalar<int>();
        /// <summary>
        /// 查询医生
        /// </summary>
        /// <param name="no">工号</param>
        /// <returns>医生</returns>
        public Doctor Select(string no)
        {
            IDataReader dataReader =
                this.PgsqlHelper
                .NewCommand("SELECT * FROM tb_doctor AS d WHERE d.no=:no")
                .NewParameter(":no", no)
                .GetReader();
            Doctor doctor = null;
            if (dataReader.Read())
            {
                doctor = new Doctor()
                {
                    No = no,
                    Password = dataReader["password"] == DBNull.Value ? null : (byte[])dataReader["password"],
                    Name = dataReader["name"] == DBNull.Value ? null : (string)dataReader["name"],
                    Gender = dataReader["gender"] == DBNull.Value ? default(bool) : (bool)dataReader["gender"],
                    Birthdate = dataReader["birthdate"] == DBNull.Value ? DateTime.Now : (DateTime)dataReader["birthdate"],
                    IDCardNo = dataReader["id_card_no"] == DBNull.Value ? null : (string)dataReader["id_card_no"],
                    Telephone = dataReader["telephone"] == DBNull.Value ? null : (string)dataReader["telephone"],
                    QQEmail = dataReader["qq_email"] == DBNull.Value ? null : (string)dataReader["qq_email"],
                    DepartmentNo = dataReader["department_no"] == DBNull.Value ? 1 : (int)dataReader["department_no"],
                    TitleNo = dataReader["title_no"] == DBNull.Value ? 1 : (int)dataReader["title_no"],
                    Introduction = dataReader["introduction"] == DBNull.Value ? null : (string)dataReader["introduction"],
                    Avatar = dataReader["avatar"] == DBNull.Value ? null : (byte[])dataReader["avatar"],
                    ErrorNumber = dataReader["error_number"] == DBNull.Value ? 0 : (int)dataReader["error_number"],
                    IsFreeze = dataReader["is_freeze"] == DBNull.Value ? false : (bool)dataReader["is_freeze"]
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
        => this.PgsqlHelper
            .NewCommand($@"UPDATE tb_doctor
	                            SET password=:password,
		                            name=:name,
		                            gender=:gender,
		                            birthdate=:birthdate,
		                            id_card_no=:id_card_no,
		                            telephone=:telephone,
		                            qq_email=:qq_email,
		                            department_no=:department_no,
		                            title_no=:title_no,
		                            introduction=:introduction,
                                    avatar=:avatar,
		                            error_number=:error_number,
		                            is_freeze=:is_freeze
	                            WHERE no=:no")
            .NewParameter(":no", doctor.No)
            .NewParameter(":password", doctor.Password)
            .NewParameter(":name", doctor.Name)
            .NewParameter(":gender", doctor.Gender)
            .NewParameter(":birthdate", doctor.Birthdate)
            .NewParameter(":id_card_no", doctor.IDCardNo)
            .NewParameter(":telephone", doctor.Telephone)
            .NewParameter(":qq_email", doctor.QQEmail)
            .NewParameter(":department_no", doctor.DepartmentNo)
            .NewParameter(":title_no", doctor.TitleNo)
            .NewParameter(":introduction", doctor.Introduction)
            .NewParameter(":avatar", doctor.Avatar)
            .NewParameter(":error_number", doctor.ErrorNumber)
            .NewParameter(":is_freeze", doctor.IsFreeze)
            .NonQuery();
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="doctor">医生</param>
        /// <returns>受影响行数</returns>
        public int Insert(Doctor doctor)
        {
            int rowAffected = 0;
            try
            {
                rowAffected =
                    this.PgsqlHelper.NewCommand($@"INSERT INTO tb_doctor
	                                                (no,password,telephone,avatar)
	                                                VALUES
	                                                (:no,:password,:telephone,''::BYTEA)")
                    .NewParameter(":no", doctor.No)
                    .NewParameter(":password", doctor.Password)
                    .NewParameter(":telephone", doctor.Telephone)
                    .NonQuery();
            }
            catch (NotUniqueException)
            {
                throw new ApplicationException("您提交的工号已存在！");
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
        => this.PgsqlHelper
            .NewCommand($@"UPDATE tb_doctor
	                            SET password=:password,
	                            WHERE no=:no")
            .NewParameter(":no", doctor.No)
            .NewParameter(":password", doctor.Password)
            .NonQuery();
        /// <summary>
        /// 查询QQ邮箱计数
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public int SelectCountQQEmail(string mail)
            => this.PgsqlHelper
            .NewCommand("SELECT CAST(COUNT(1) AS INTEGER) FROM tb_doctor AS d WHERE d.qq_email=:qq_email")
            .NewParameter(":qq_email", mail)
            .GetScalar<int>();
        /// <summary>
        /// 查询电话号码计数
        /// </summary>
        /// <param name="telephone"></param>
        /// <returns></returns>
        public int SelectCountTelephone(string telephone)
            => this.PgsqlHelper
            .NewCommand("SELECT CAST(COUNT(1) AS INTEGER) FROM tb_doctor AS d WHERE d.telephone=:telephone")
            .NewParameter(":telephone", telephone)
            .GetScalar<int>();
        /// <summary>
        /// 构造函数；
        /// </summary>
        public DoctorDalPgsql()
        {
            this.PgsqlHelper = new PgsqlHelper();
        }
    }
}
