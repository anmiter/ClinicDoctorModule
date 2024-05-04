using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 登录窗体
    /// </summary>
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//本窗体启动位置设为屏幕中央
        }
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="DoctorNo"></param>
        public frm_Login(string DoctorNo) : this()
        {
            this.txb_DoctorNo.Text = DoctorNo;
        }
        /// <summary>
        /// 单击登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txb_DoctorNo.Text.Trim()) || string.IsNullOrWhiteSpace(this.txb_Password.Text.Trim()))
            {
                MessageBox.Show("请输入账号密码!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txb_DoctorNo.Focus();
            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
                sqlConnection.ConnectionString =
                    ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

                SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText =
                    $@"SELECT COUNT(1) FROM tb_Doctor WHERE No=@No AND Password=HASHBYTES('MD5',@Password)";//指定SQL命令的命令文本；命令文本包含参数；
                sqlCommand.Parameters.AddWithValue("@No", this.txb_DoctorNo.Text.Trim());//向SQL命令的参数集合添加参数的名称、值；
                sqlCommand.Parameters.AddWithValue("@Password", this.txb_Password.Text.Trim());//向SQL命令的参数集合添加参数的名称、值；
                sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;//将密码参数的类型设为变长字符串；
                                                                                 //SQL参数自动识别类型；若参数值为字符串，则类型自动设为NVARCHAR，且可在执行时自动转换；
                                                                                 //但对于相同密码，VARCHAR/NVARCHAR类型所获得的散列值不同，故需手动将SQL参数类型统一设为VARCHAR;
                sqlConnection.Open();//打开SQL连接；
                int rowCount = (int)sqlCommand.ExecuteScalar();//调用SQL命令的方法ExecuteScalar来执行命令，并接受单个结果（即标量）
                sqlConnection.Close();//关闭SQL连接；
                if (rowCount == 1)
                {
                    MessageBox.Show("登录成功！");
                    frm_Home frm_Home = new frm_Home(this.txb_DoctorNo.Text.Trim());
                    frm_Home.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码有误或账号不存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txb_Password.Focus(); //密码文本框获得焦点；
                    this.txb_Password.SelectAll();//密码文本框内所有文本被选中；
                }
            }
        }
        /// <summary>
        /// 单击注册按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Register_Click(object sender, EventArgs e)
        {
            frm_Register frm_Register = new frm_Register();
            frm_Register.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// 单击找回密码按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RetrievePassword_Click(object sender, EventArgs e)
        {
            frm_RetrievePassword frm_RetrievePassword = new frm_RetrievePassword();
            frm_RetrievePassword.ShowDialog();
            this.Close();
        }
    }
}
