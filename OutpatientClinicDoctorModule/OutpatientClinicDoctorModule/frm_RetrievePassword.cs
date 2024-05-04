using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 找回密码窗体
    /// </summary>
    public partial class frm_RetrievePassword : Form
    {
        public frm_RetrievePassword()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//本窗体启动位置设为屏幕中央
            this.btn_RetrievePassword.Enabled = false;
        }
        /// <summary>
        /// 验证码
        /// </summary>
        string strMailVeriCode;
        /// <summary>
        /// 倒计时60s
        /// </summary>
        int seconds1 = 60;
        /// <summary>
        /// 验证码有效时间5分钟
        /// </summary>
        int seconds2 = 60 * 5;
        /// <summary>
        /// 单击重置密码按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RetrievePassword_Click(object sender, EventArgs e)
        {
            string mailVeriCode = txb_VerificationCode.Text.Trim();//邮箱验证码  
            if (string.IsNullOrEmpty(mailVeriCode) == true)
            {
                MessageBox.Show("请输入验证码!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_VerificationCode.Focus();
            }
            else if (mailVeriCode != strMailVeriCode) //判断邮箱验证码是否输入正确
            {
                MessageBox.Show("您输入的验证码有误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txb_VerificationCode.Focus();
                txb_VerificationCode.SelectAll();
                return;
            }
            else
            {
                Personal.frm_ModifyPassword frm_ModifyPassword = new Personal.frm_ModifyPassword();
                frm_ModifyPassword.ShowDialog();
                this.Close();
            }
        }
        /// <summary>
        /// 单击发送验证码按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            string recEMailAddress = txb_QQEmail.Text.Trim();//收件人邮箱
            if (string.IsNullOrWhiteSpace(this.txb_DoctorNo.Text.Trim()) || string.IsNullOrWhiteSpace(this.txb_QQEmail.Text.Trim()))
            {
                MessageBox.Show("工号和邮箱不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txb_DoctorNo.Focus();
            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
                sqlConnection.ConnectionString =
                    ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    $@"SELECT COUNT(1) FROM tb_Doctor WHERE No=@No AND QQEmail=@QQEmail";//指定SQL命令的命令文本；命令文本包含参数；
                sqlCommand.Parameters.AddWithValue("@No", this.txb_DoctorNo.Text.Trim());//向SQL命令的参数集合添加参数的名称、值；
                sqlCommand.Parameters.AddWithValue("@QQEmail", this.txb_QQEmail.Text.Trim());//向SQL命令的参数集合添加参数的名称、值；
                sqlConnection.Open();//打开SQL连接；
                int rowCount = (int)sqlCommand.ExecuteScalar();//调用SQL命令的方法ExecuteScalar来执行命令，并接受单个结果（即标量）
                sqlConnection.Close();//关闭SQL连接；
                if (rowCount == 1)
                {
                    strMailVeriCode = SendFunction.CreateRandomMailCode(6);//生成6位数验证码
                    string strBody = "验证码：" + strMailVeriCode + "，5分钟内有效,请勿泄漏于他人。如非本人操作，请忽略。系统邮件请勿回复。";//邮件内容            
                    string strSubject = "门诊医生找回密码";//邮件标题
                    string strMyEmailAddress = "3454634841@qq.com";//发件人邮箱
                    string strAuthorizationCode = "lqxssyvvondycjhi";//邮箱授权码
                    if (SendFunction.SendMailMessage(strMyEmailAddress, recEMailAddress, strSubject, strBody, strAuthorizationCode) == true)
                    {
                        btn_SendEmail.Enabled = false;
                        btn_RetrievePassword.Enabled = true;
                        //计时器初始化              
                        timer1.Interval = 1000;
                        timer1.Start();
                        timer2.Interval = 1000;
                        timer2.Start();
                    }
                }
                else
                {
                    MessageBox.Show("该工号和邮箱不匹配！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txb_QQEmail.Focus();
                }
            }
        }
        /// <summary>
        /// 倒计时—邮箱验证码1分钟只能点击发送1次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds1 > 0)
            {
                seconds1--;
                btn_SendEmail.Text = "剩余" + seconds1.ToString() + "秒";
            }
            else
            {
                timer1.Stop();
                btn_SendEmail.Text = "获取验证码";
                btn_SendEmail.Enabled = true;
            }
        }
        /// <summary>
        /// 验证码5分钟内有效；但是如果有新的验证码出现,旧验证码就会失效
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (seconds2 == 0)
            {
                timer2.Stop();
                strMailVeriCode = SendFunction.CreateRandomMailCode(6);//旧的验证码过期,生成一个新的验证码
            }
        }
    }
}
