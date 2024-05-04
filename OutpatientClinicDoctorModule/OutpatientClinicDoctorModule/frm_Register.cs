using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 注册窗体
    /// </summary>
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//本窗体启动位置设为屏幕中央
        }
        /// <summary>
        /// 单击注册按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txb_DoctorNo.Text.Trim()) || string.IsNullOrWhiteSpace(this.txb_Telephone.Text.Trim()) || string.IsNullOrWhiteSpace(this.txb_Password.Text.Trim()))
            {
                MessageBox.Show("工号，电话号码，密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_Telephone.Focus();
            }
            else
            {
                if (!CheckFunction.IsExistDoctorNo(this.txb_DoctorNo.Text.Trim()) && !CheckFunction.IsExistTelephone(this.txb_Telephone.Text.Trim()))
                {
                    if (CheckFunction.CheckTelephone(this.txb_Telephone.Text.Trim()))
                    {
                        if (CheckFunction.CheckPassword(this.txb_Password.Text.Trim()))
                        {
                            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
                            sqlConnection.ConnectionString =
                                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

                            SqlCommand sqlCommand = sqlConnection.CreateCommand();
                            sqlCommand.Connection = sqlConnection;
                            sqlCommand.CommandText =
                                $@"INSERT tb_Doctor
	                                    (No,Telephone,Password)
	                                    VALUES
	                                    (@No,@Telephone,HASHBYTES('MD5',@Password))";

                            sqlCommand.Parameters.AddWithValue("@No", this.txb_DoctorNo.Text.Trim());//向SQL命令的参数集合添加参数的名称、值；
                            sqlCommand.Parameters.AddWithValue("@Telephone", this.txb_Telephone.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@Password", this.txb_Password.Text.Trim());
                            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;//将密码参数的类型设为变长字符串；
                                                                                             //SQL参数自动识别类型；若参数值为字符串，则类型自动设为NVARCHAR，且可在执行时自动转换；
                                                                                             //但对于相同密码，VARCHAR/NVARCHAR类型所获得的散列值不同，故需手动将SQL参数类型统一设为VARCHAR;

                            sqlConnection.Open();//打开SQL连接
                            int rowAffected = sqlCommand.ExecuteNonQuery();//调用SQL命令的方法ExecuteNonQuery来执行命令，向数据库写入数据，并返回受影响行数；
                            sqlConnection.Close();//关闭SQL连接；

                            if (rowAffected == 1)//若查得所输用户号相应的1行记录；
                            {
                                MessageBox.Show("注册成功！");
                                frm_Login frm_Login = new frm_Login(this.txb_DoctorNo.Text.Trim());
                                frm_Login.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("注册失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.txb_Password.Focus(); //密码文本框获得焦点；
                                this.txb_Password.SelectAll();//密码文本框内所有文本被选中；
                            }
                        }
                        else
                        {
                            MessageBox.Show("密码必须至少8个字符，至少一个大写字母，一个小写字母，一个数字和一个特殊字符！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txb_Password.Focus();
                            txb_Password.SelectAll();
                        }
                    }
                    else
                    {
                        MessageBox.Show("手机号码格式错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txb_Telephone.Focus();
                        this.txb_Telephone.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("该工号或手机号已注册！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
