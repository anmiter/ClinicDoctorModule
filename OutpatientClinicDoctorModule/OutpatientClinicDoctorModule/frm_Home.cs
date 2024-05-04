using System;
using System.Configuration;
using System.Data.SqlClient;
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
        public frm_Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//本窗体启动位置设为屏幕中央
        }
        /// <summary>
        /// 医生编号
        /// </summary>
        string DoctorNo;
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="doctorNo"></param>
        public frm_Home(string doctorNo) : this()
        {
            this.DoctorNo = doctorNo;
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"SELECT * FROM tb_Doctor WHERE No='{this.DoctorNo}'";

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                this.lbl_DoctorNo.Text = this.DoctorNo;
                this.lbl_Name.Text = sqlDataReader["Name"].ToString();
                if (sqlDataReader["Telephone"] == DBNull.Value || sqlDataReader["Name"] == DBNull.Value || sqlDataReader["QQEmail"] == DBNull.Value || sqlDataReader["Identification"] == DBNull.Value || sqlDataReader["Avatar"] == DBNull.Value)
                {
                    Personal.frm_PersonalCenter frm_PersonalCenter = new Personal.frm_PersonalCenter(this.DoctorNo);
                    MessageBox.Show("请完善个人信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_PersonalCenter.ShowDialog();
                }
                if (sqlDataReader["Avatar"] != DBNull.Value)
                {
                    byte[] photoBytes = (byte[])sqlDataReader["Avatar"];
                    MemoryStream memoryStream = new MemoryStream(photoBytes);//内存流
                    this.ptb_Avatar.Image = Image.FromStream(memoryStream);
                }
            }
            sqlDataReader.Close();
        }
        /// <summary>
        /// 单击个人中心按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PersonalCenter_Click(object sender, EventArgs e)
        {
            Personal.frm_PersonalCenter frm_PersonalCenter = new Personal.frm_PersonalCenter(this.DoctorNo);
            frm_PersonalCenter.ShowDialog();
        }
        /// <summary>
        /// 单击叫号按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CallNumber_Click(object sender, EventArgs e)
        {
            Consultation.frm_CallNumber frm_CallNumber = new Consultation.frm_CallNumber();
            frm_CallNumber.ShowDialog();
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
        private void btn_MedicalRecord_Click(object sender, EventArgs e)
        {
            Consultation.frm_MedicalRecord frm_MedicalRecord = new Consultation.frm_MedicalRecord();
            frm_MedicalRecord.ShowDialog();
        }
        /// <summary>
        /// 单击病情登记按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Condition_Click(object sender, EventArgs e)
        {
            Consultation.frm_Condition frm_Condition = new Consultation.frm_Condition();
            frm_Condition.ShowDialog();
        }
        /// <summary>
        /// 单击按钮诊断
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Diagnosis_Click(object sender, EventArgs e)
        {
            Consultation.frm_Diagnosis frm_Diagnosis = new Consultation.frm_Diagnosis();
            frm_Diagnosis.ShowDialog();
        }
        /// <summary>
        /// 处方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Prescription_Click(object sender, EventArgs e)
        {
            Consultation.frm_Prescription frm_Prescription = new Consultation.frm_Prescription();
            frm_Prescription.ShowDialog();
        }
        /// <summary>
        /// 检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Examination_Click(object sender, EventArgs e)
        {
            Consultation.frm_Examination frm_Examination = new Consultation.frm_Examination();
            frm_Examination.ShowDialog();
        }
        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sure_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 单击修改价目按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ModifyPrice_Click(object sender, EventArgs e)
        {
            Personal.frm_ModifyPrice frm_ModifyPrice = new Personal.frm_ModifyPrice();
            frm_ModifyPrice.ShowDialog();
        }
        /// <summary>
        /// 单击退出登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Login frm_Login = new frm_Login();
            frm_Login.ShowDialog();
        }
        /// <summary>
        /// 单击查询价目按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchPrice_Click(object sender, EventArgs e)
        {
            Search.frm_SearchPrice frm_SearchPrice = new Search.frm_SearchPrice();
            frm_SearchPrice.ShowDialog();
        }
        private void frm_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
