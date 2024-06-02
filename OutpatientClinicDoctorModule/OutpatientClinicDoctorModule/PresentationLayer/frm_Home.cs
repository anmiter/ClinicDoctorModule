using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 首页窗体
    /// </summary>
    public partial class frm_Home : Form
    {
        /// <summary>
        /// 医生
        /// </summary>
        Doctor Doctor { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public frm_Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="doctor"></param>
        public frm_Home(Doctor doctor) : this()
        {
            this.Doctor = doctor;
            this.lbl_Name.Text = this.Doctor.Name;
            this.lbl_No.Text = this.Doctor.No;
            if (this.Doctor.Telephone == null || this.Doctor.Name == null || this.Doctor.QQEmail == null || this.Doctor.IDCardNo == null || this.Doctor.Avatar == null) 
            {
                frm_PersonalCenter frm_PersonalCenter = new frm_PersonalCenter(this.Doctor);
                MessageBox.Show("请完善个人信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_PersonalCenter.ShowDialog();
            }
            if (Doctor.Avatar.Length > 10) 
            {
                byte[] photoBytes = Doctor.Avatar;
                MemoryStream memoryStream = new MemoryStream(photoBytes);//内存流
                this.ptb_Avatar.Image = Image.FromStream(memoryStream);
            }
        }
        /// <summary>
        /// 单击个人中心按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PersonalCenter_Click(object sender, EventArgs e)
        {
            frm_PersonalCenter frm_PersonalCenter = new frm_PersonalCenter(this.Doctor);
            frm_PersonalCenter.ShowDialog();
        }
        /// <summary>
        /// 单击退出登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LogOut_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 单击叫号按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CallNumber_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 单击读卡按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ReadCard_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 单击病历按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TreatRecord_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 单击诊断按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Diagnosis_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 单击处方按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Prescription_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 单击检查项目按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Examination_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 单击修改价目按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ModifyPrice_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 单击查询价目按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchPrice_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 单击确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sure_Click(object sender, EventArgs e)
        {

        }
    }
}
