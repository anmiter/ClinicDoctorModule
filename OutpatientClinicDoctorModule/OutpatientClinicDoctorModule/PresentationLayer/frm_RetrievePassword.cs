using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 找回密码窗体
    /// </summary>
    public partial class frm_RetrievePassword : Form
    {
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
        /// 验证码长度
        /// </summary>
        int VerificationCodeLength = 6;
        /// <summary>
        /// 医生（业务逻辑层）
        /// </summary>
        private IDoctorBll DoctorBll { get; set; }
        /// <summary>
        /// 医生
        /// </summary>
        private Doctor Doctor { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public frm_RetrievePassword()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoctorBll = new DoctorBll();
            this.btn_RetrievePassword.Enabled = false;
            this.txb_No.Validating += Txb_No_Validating;
            this.txb_QQEmail.Validating += Txb_QQEmail_Validating;
            this.ErrorProvider.BlinkRate = 500;
        }
        /// <summary>
        /// 验证QQ邮箱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Txb_QQEmail_Validating(object sender, CancelEventArgs e)
        {
            string QQEmail = this.txb_QQEmail.Text;
            this.ErrorProvider.SetError(this.txb_QQEmail, "");
            bool isEmpty = string.IsNullOrEmpty(QQEmail);
            if (isEmpty)
            {
                this.ErrorProvider.SetError(this.txb_QQEmail, "QQ邮箱不能为空");
                return;
            }
            bool isValid = this.DoctorBll.CheckQQEmail(QQEmail);
            if (!isValid)
            {
                this.ErrorProvider.SetError(this.txb_QQEmail, $"邮箱格式应为：1111111111@qq.com");
                return;
            }
            bool isExisting = this.DoctorBll.CheckExistQQEmail(QQEmail);
            if (!isExisting)
            {
                this.ErrorProvider.SetError(this.txb_QQEmail, "该QQ邮箱不存在");
                return;
            }
            this.ErrorProvider.SetError(this.txb_QQEmail, "");
        }
        /// <summary>
        /// 验证工号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Txb_No_Validating(object sender, CancelEventArgs e)
        {
            string No = this.txb_No.Text;
            this.ErrorProvider.SetError(this.txb_No, "");
            bool isEmpty = string.IsNullOrEmpty(No);
            if (isEmpty)
            {
                this.ErrorProvider.SetError(this.txb_No, "工号不能为空");
                return;
            }
            bool isLengthValid = (No.Length == this.DoctorBll.NoLength);
            if (!isLengthValid)
            {
                this.ErrorProvider.SetError
                    (this.txb_No, $"工号长度应为{this.DoctorBll.NoLength}");
                return;
            }
            bool isExisting = this.DoctorBll.CheckExist(No);
            if (!isExisting)
            {
                this.ErrorProvider.SetError(this.txb_No, "工号不存在");
                return;
            }
            this.ErrorProvider.SetError(this.txb_No, "");
        }
        /// <summary>
        /// 单击重置密码按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RetrievePassword_Click(object sender, EventArgs e)
        {
            string mailVeriCode = txb_VerificationCode.Text.Trim();
            bool isEmpty = string.IsNullOrEmpty(mailVeriCode);
            bool isLengthValid = (mailVeriCode.Length == this.VerificationCodeLength);
            if (isEmpty)
            {
                this.ErrorProvider.SetError(this.txb_VerificationCode, "验证码不能为空");
                return;
            }
            else if (!isLengthValid)
            {
                this.ErrorProvider.SetError
                    (this.txb_VerificationCode, $"验证码长度应为{this.VerificationCodeLength}");
                return;
            }
            else if (mailVeriCode != this.strMailVeriCode)
            {
                this.ErrorProvider.SetError(this.txb_VerificationCode, "您输入的验证码有误！");
                this.txb_VerificationCode.Focus();
                this.txb_VerificationCode.SelectAll();
                return;
            }
            else
            {
                frm_ModifyPassword frm_ModifyPassword = new frm_ModifyPassword(this.Doctor);
                frm_ModifyPassword.ShowDialog();
            }
        }
        /// <summary>
        /// 单击发送验证码按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            string No = this.txb_No.Text.Trim();
            string QQEmail = this.txb_QQEmail.Text.Trim();
            this.Doctor = this.DoctorBll.RetrievePassword(No, QQEmail);
            if (Doctor == null)
            {
                this.txb_QQEmail.Focus();
                this.txb_QQEmail.SelectAll();
                MessageBox.Show("该QQ邮箱和工号不匹配");
                return;
            }
            else
            {
                this.strMailVeriCode = SendEmail.CreateRandomMailCode(this.VerificationCodeLength);//生成6位数验证码
                string strBody = "验证码：" + this.strMailVeriCode + "，5分钟内有效,请勿泄漏于他人。如非本人操作，请忽略。系统邮件请勿回复。";//邮件内容            
                string strSubject = "门诊医生找回密码";//邮件标题
                string strMyEmailAddress = "3454634841@qq.com";//发件人邮箱
                string strAuthorizationCode = "lqxssyvvondycjhi";//邮箱授权码
                if (SendEmail.SendMailMessage(strMyEmailAddress, QQEmail, strSubject, strBody, strAuthorizationCode) == true)
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
                this.strMailVeriCode = SendEmail.CreateRandomMailCode(6);//旧的验证码过期,生成一个新的验证码
            }
        }
    }
}
