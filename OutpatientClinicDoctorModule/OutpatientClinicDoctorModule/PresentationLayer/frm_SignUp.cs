using System;
using System.Data;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 注册窗体
    /// </summary>
    public partial class frm_SignUp : Form
    {
        /// <summary>
        /// 医生
        /// </summary>
        private Doctor Doctor { get; set; }
        /// <summary>
        /// 医生（业务逻辑层）
        /// </summary>
        private IDoctorBll DoctorBll { get; set; }
        private string DBType;
        /// <summary>
        /// 构造函数
        /// </summary>
        public frm_SignUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Doctor = new Doctor();
            this.DoctorBll = new DoctorBll(this.DBType);
            this.txb_No.Validating += Txb_No_Validating;
            this.txb_Password.Validating += Txb_Password_Validating;
            this.txb_Telephone.Validating += Txb_Telephone_Validating;
            this.ErrorProvider.BlinkRate = 500;
            this.AcceptButton = this.btn_SignUp;
        }
        /// <summary>
        /// 验证电话号码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Txb_Telephone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string Telephone = this.txb_Telephone.Text;
            this.ErrorProvider.SetError(this.txb_Telephone, "");
            bool isEmpty = string.IsNullOrEmpty(Telephone);
            if (isEmpty)
            {
                this.ErrorProvider.SetError(this.txb_Telephone, "电话号码不能为空");
                return;
            }
            this.ErrorProvider.SetError(this.txb_Telephone, "");
        }
        /// <summary>
        /// 验证密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Txb_Password_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string password = this.txb_Password.Text;
            this.ErrorProvider.SetError(this.txb_Password, "");
            bool isEmpty = string.IsNullOrEmpty(password);
            if (isEmpty)
            {
                this.ErrorProvider.SetError(this.txb_Password, "密码不能为空");
                return;
            }
            bool IsVaild = this.DoctorBll.CheckPassword(password);
            if (!IsVaild)
            {
                this.ErrorProvider.SetError
                    (this.txb_Password, $"密码必须至少{this.DoctorBll.PasswordMinLength}个字符，最多{this.DoctorBll.PasswordMaxLength}个字符，并且至少一个大写字母，一个小写字母，一个数字和一个特殊字符！");
                return;
            }
            this.ErrorProvider.SetError(this.txb_Password, "");
        }
        /// <summary>
        /// 验证工号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Txb_No_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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
                    (this.txb_No, $"工号长度应为{this.DoctorBll.NoLength}!");
                return;
            }
            bool isExisting = this.DoctorBll.CheckExist(No);
            if (isExisting)
            {
                this.ErrorProvider.SetError(this.txb_No, "工号已存在");
                return;
            }
        }

        /// <summary>
        /// 点击注册按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string No = this.txb_No.Text.Trim();
            string Telephone = this.txb_Telephone.Text.Trim();
            string Password = this.txb_Password.Text.Trim();
            this.Doctor = this.DoctorBll.SignUp(No, Telephone, Password);
            MessageBox.Show(this.DoctorBll.Message);
            frm_LogIn frm_LogIn = new frm_LogIn(No);
            frm_LogIn.ShowDialog();
            this.Close();
        }
    }
}
