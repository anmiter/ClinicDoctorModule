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
        private Doctor Doctor { get; set; }
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
        public frm_ModifyPassword()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="doctor"></param>
        public frm_ModifyPassword(Doctor doctor) : this()
        {
            this.Doctor = doctor;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {

        }
    }
}
