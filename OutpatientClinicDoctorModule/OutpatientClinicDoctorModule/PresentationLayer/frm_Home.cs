using System;
using System.Data;
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
        private Doctor Doctor { get; set; }
        /// <summary>
        /// 患者
        /// </summary>
        private Patient Patient { get; set; }
        /// <summary>
        /// 数据库类型
        /// </summary>
        private string DBType;
        /// <summary>
        /// 重要编码
        /// </summary>
        private string KeyNo;
        /// <summary>
        /// 是否已读卡
        /// </summary>
        private bool IsReadCard;
        /// <summary>
        /// SQL助手
        /// </summary>
        private SqlHelper SqlHelper { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public frm_Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsReadCard = false;
        }
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="doctor"></param>
        public frm_Home(Doctor doctor, string dbType) : this()
        {
            this.Doctor = doctor;
            this.DBType = dbType;
            this.SqlHelper = new SqlHelper();
            this.lbl_Name.Text = this.Doctor.Name;
            this.lbl_No.Text = this.Doctor.No;
            if (this.Doctor.Telephone == null || this.Doctor.Name == null || this.Doctor.QQEmail == null || this.Doctor.IDCardNo == null || this.Doctor.Avatar.Length == 0)
            {
                frm_PersonalCenter frm_PersonalCenter = new frm_PersonalCenter(this.Doctor, this.DBType);
                MessageBox.Show("请完善个人信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_PersonalCenter.ShowDialog();
            }
            if (Doctor.Avatar.Length != 0)
            {
                byte[] photoBytes = Doctor.Avatar;
                MemoryStream memoryStream = new MemoryStream(photoBytes);
                this.ptb_Avatar.Image = Image.FromStream(memoryStream);
            }
        }
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="patient"></param>
        /// <param name="keyNo"></param>
        public frm_Home(Doctor doctor, Patient patient, string keyNo) : this()
        {
            this.Doctor = doctor;
            this.SqlHelper = new SqlHelper();
            this.lbl_Name.Text = this.Doctor.Name;
            this.lbl_No.Text = this.Doctor.No;
            byte[] photoBytes = Doctor.Avatar;
            MemoryStream memoryStream = new MemoryStream(photoBytes);
            this.ptb_Avatar.Image = Image.FromStream(memoryStream);
            this.Patient = patient;
            this.KeyNo = keyNo;
            this.lbl_HealthCardNo.Text = patient.HealthCardNo;
        }
        /// <summary>
        /// 单击个人中心按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PersonalCenter_Click(object sender, EventArgs e)
        {
            frm_PersonalCenter frm_PersonalCenter = new frm_PersonalCenter(this.Doctor, this.DBType);
            frm_PersonalCenter.ShowDialog();
        }
        /// <summary>
        /// 单击叫号按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CallNumber_Click(object sender, EventArgs e)
        {
            frm_CallNumber frm_CallNumber = new frm_CallNumber(this.Doctor);
            frm_CallNumber.ShowDialog();
        }
        /// <summary>
        /// 单击读卡按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ReadCard_Click(object sender, EventArgs e)
        {
            if (this.Patient != null)
            {
                this.IsReadCard = true;
                MessageBox.Show("读卡成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("请叫号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 单击诊断按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Diagnosis_Click(object sender, EventArgs e)
        {
            if (!this.IsReadCard)
            {
                MessageBox.Show("请先读卡！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frm_Diagnosis frm_Diagnosis = new frm_Diagnosis(this.Doctor, this.Patient, this.KeyNo);
                frm_Diagnosis.ShowDialog();              
            }
        }
        /// <summary>
        /// 单击处方按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Prescription_Click(object sender, EventArgs e)
        {
            if (!this.IsReadCard)
            {
                MessageBox.Show("请先读卡！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frm_Prescription frm_Prescription = new frm_Prescription(this.Doctor, this.Patient, this.KeyNo);
                frm_Prescription.ShowDialog();
            }
        }
        /// <summary>
        /// 单击检查项目按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Examination_Click(object sender, EventArgs e)
        {
            if (!this.IsReadCard)
            {
                MessageBox.Show("请先读卡！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frm_Examination frm_Examination = new frm_Examination(this.Doctor, this.Patient, this.KeyNo);
                frm_Examination.ShowDialog();
            }
        }
        /// <summary>
        /// 单击病历按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TreatRecord_Click(object sender, EventArgs e)
        {
            if (!this.IsReadCard)
            {
                MessageBox.Show("请先读卡！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frm_TreatRecord frm_TreatRecord = new frm_TreatRecord(this.Patient);
                frm_TreatRecord.ShowDialog();
            }
        }
        /// <summary>
        /// 单击确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sure_Click(object sender, EventArgs e)
        {
            int rowAffected = 0;
            int state = 0;
            if (rdb_End.Checked)
            {
                state = 4;
            }
            else if (rdb_ExaminationWait.Checked)
            {
                state = 3;
            }
            else if (rdb_NotReaction.Checked)
            {
                state = 5;
            }
            else
            {
                MessageBox.Show("请选择就诊状态！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.SqlHelper.NewCommand($@"UPDATE tb_Queue SET StateNo=@StateNo
                                                    WHERE DoctorNo=@DoctorNo
                                                    AND HealthCardNo=@HealthCardNo
                                                    AND Date=@Date");
            this.SqlHelper.NewParameter("@StateNo", state);
            this.SqlHelper.NewParameter("@DoctorNo", this.Doctor.No);
            this.SqlHelper.NewParameter("@HealthCardNo", this.Patient.HealthCardNo);
            this.SqlHelper.NewParameter("@Date", DateTime.Now.Date);
            rowAffected = this.SqlHelper.NonQuery();
            if (rowAffected == 1)
            {
                lbl_Tip.Text = "修改成功！";
            }
            else
            {
                lbl_Tip.Text = "修改失败！";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchPrice_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 单击退出登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_LogIn frm_LogIn = new frm_LogIn();
            frm_LogIn.ShowDialog();
        }
    }
}
