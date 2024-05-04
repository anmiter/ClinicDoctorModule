using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule.Personal
{
    /// <summary>
    /// 修改密码窗体
    /// </summary>
    public partial class frm_ModifyPassword : Form
    {
        public frm_ModifyPassword()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//本窗体启动位置设为屏幕中央
        }
        /// <summary>
        /// 工号
        /// </summary>
        string DoctorNo;
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="doctorNo"></param>
        public frm_ModifyPassword(string doctorNo) : this()
        {
            this.DoctorNo = doctorNo;
        }
        /// <summary>
        /// 单击保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txb_NewPassword.Text.Trim()) || string.IsNullOrWhiteSpace(this.txb_ConfirmPassword.Text.Trim()))
            {
                MessageBox.Show("请输入密码和确认密码!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txb_NewPassword.Focus();
            }
            else
            {
                if (CheckFunction.CheckPassword(this.txb_NewPassword.Text.Trim()))
                {
                    if (this.txb_NewPassword.Text.Trim() == this.txb_ConfirmPassword.Text.Trim())
                    {
                        SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
                        sqlConnection.ConnectionString =
                            ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

                        SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText =
                            $@"UPDATE tb_Doctor
	                                    SET Password=HASHBYTES('MD5',@Password)
	                                    WHERE No={this.DoctorNo}";
                        sqlCommand.Parameters.AddWithValue("@Password", this.txb_NewPassword.Text.Trim());//向SQL命令的参数集合添加参数的名称、值；
                        sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;//将密码参数的类型设为变长字符串；
                                                                                         //SQL参数自动识别类型；若参数值为字符串，则类型自动设为NVARCHAR，且可在执行时自动转换；
                                                                                         //但对于相同密码，VARCHAR/NVARCHAR类型所获得的散列值不同，故需手动将SQL参数类型统一设为VARCHAR;
                        sqlConnection.Open();
                        int rowAffected = sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        if (rowAffected == 1)
                        {
                            MessageBox.Show("修改成功！");
                            frm_Login frm_Login = new frm_Login(this.DoctorNo);
                            frm_Login.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("修改失败，可再次尝试！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("密码和确认密码不一致！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txb_ConfirmPassword.Focus();
                        this.txb_ConfirmPassword.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("密码必须至少8个字符，至少一个大写字母，一个小写字母，一个数字和一个特殊字符！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txb_NewPassword.Focus();
                    txb_NewPassword.SelectAll();
                }
            }
        }
    }
}
