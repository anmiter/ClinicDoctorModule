using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule
{
    public partial class frm_ModifyPassword : Form
    {
        /// <summary>
        /// 医生
        /// </summary>
        private Doctor Doctor {  get; set; }
        /// <summary>
        /// 医生（业务逻辑层）
        /// </summary>
        private IDoctorBll DoctorBll { get; set; }
        /// <summary>
        /// 医生（数据访问层）
        /// </summary>
        private IDoctorDal DoctorDal { get; set; }
        /// <summary>
        /// 密码是否符号要求
        /// </summary>
        private bool PasswordGood { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public frm_ModifyPassword()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoctorBll = new DoctorBll();
            this.DoctorDal = new DoctorDal();
            this.txb_NewPassword.Validating += Txb_NewPassword_Validating;
            this.txb_ConfirmPassword.Validating += Txb_ConfirmPassword_Validating;
            this.ErrorProvider.BlinkRate = 500;
        }
        /// <summary>
        /// 验证确认密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Txb_ConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            string password = this.txb_ConfirmPassword.Text;
            this.ErrorProvider.SetError(this.txb_ConfirmPassword, "");
            bool isEmpty = string.IsNullOrEmpty(password);
            if (isEmpty)
            {
                this.ErrorProvider.SetError(this.txb_ConfirmPassword, "确认密码不能为空");
                return;
            }
        }
        /// <summary>
        /// 验证新密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Txb_NewPassword_Validating(object sender, CancelEventArgs e)
        {
            string password = this.txb_NewPassword.Text;
            this.ErrorProvider.SetError(this.txb_NewPassword, "");
            bool isEmpty = string.IsNullOrEmpty(password);
            if (isEmpty)
            {
                this.ErrorProvider.SetError(this.txb_NewPassword, "新密码不能为空");
                return;
            }
            bool IsVaild = this.DoctorBll.CheckPassword(password);
            if (!IsVaild)
            {
                this.ErrorProvider.SetError
                    (this.txb_NewPassword, $"密码必须至少{this.DoctorBll.PasswordMinLength}个字符，最多{this.DoctorBll.PasswordMaxLength}个字符，并且至少一个大写字母，一个小写字母，一个数字和一个特殊字符！");
                return;
            }
            this.ErrorProvider.SetError(this.txb_NewPassword, "");
        }

        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="doctor"></param>
        public frm_ModifyPassword(Doctor doctor) : this()
        {
            this.Doctor = doctor;
        }
        /// <summary>
        /// 单击保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string password = this.txb_NewPassword.Text.Trim();
            if (password != this.txb_ConfirmPassword.Text.Trim())
            {
                MessageBox.Show("密码和确认密码不一致！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txb_ConfirmPassword.Focus();
                this.txb_ConfirmPassword.SelectAll();
                return;
            }
            if (this.DoctorBll.CheckPassword(password))
            {
                this.Doctor.Password = EnCrypt.Md5Encrypt(this.txb_NewPassword.Text.Trim());
                this.DoctorDal.Update(this.Doctor);
            }
        }
    }
}
