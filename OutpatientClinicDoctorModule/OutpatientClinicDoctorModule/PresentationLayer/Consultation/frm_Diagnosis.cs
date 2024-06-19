using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 诊断窗体
    /// </summary>
    public partial class frm_Diagnosis : Form
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public frm_Diagnosis()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ErrorProvider.BlinkRate = 500;
        }
        /// <summary>
        /// 医生
        /// </summary>
        private Doctor Doctor { get; set; }
        /// <summary>
        /// 患者
        /// </summary>
        private Patient Patient { get; set; }
        /// <summary>
        /// 重要编码
        /// </summary>
        string KeyNo;
        /// <summary>
        /// SQL助手
        /// </summary>
        private SqlHelper SqlHelper { get; set; }
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="doctor"></param>
        /// <param name="patient"></param>
        /// <param name="keyNo"></param>
        public frm_Diagnosis(Doctor doctor, Patient patient, string keyNo) : this()
        {
            this.Doctor = doctor;
            this.Patient = patient;
            this.KeyNo = keyNo;
            this.SqlHelper = new SqlHelper();
            DataTable departmentTable = SqlHelper.GetTable("SELECT * FROM tb_Department");
            this.cmb_Department.DataSource = departmentTable;
            this.cmb_Department.DisplayMember = "Name";
            this.cmb_Department.ValueMember = "No";
            this.cmb_Department.SelectedValue = this.Doctor.DepartmentNo;
            this.txb_No.Text = this.Doctor.No;
            this.txb_HealthCardNo.Text = this.Patient.HealthCardNo;
            this.txb_Description.Validating += Txb_Description_Validating;
            this.txb_Result.Validating += Txb_Result_Validating;
            IDataReader dataReader =
                this.SqlHelper
                .NewCommand("SELECT * FROM tb_TreatRecord WHERE Date=@Date AND DoctorNo=@DoctorNo AND HealthCardNo=@HealthCardNo")
                .NewParameter("@Date", DateTime.Now.Date)
                .NewParameter("@HealthCardNo", Patient.HealthCardNo)
                .NewParameter("@DoctorNo", Doctor.No)
                .GetReader();
            if (dataReader.Read())
            {
                this.txb_Description.Text = (string)dataReader["Description"];
                this.txb_Result.Text = (string)dataReader["Result"];
            }
        }
        /// <summary>
        /// 检查诊断结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Txb_Result_Validating(object sender, CancelEventArgs e)
        {
            this.ErrorProvider.SetError(this.txb_Result, "");
            if (this.txb_Result.Text.Length > 500)
            {
                this.ErrorProvider.SetError(this.txb_Result, "字数不能大于500！");
                return;
            }
            this.ErrorProvider.SetError(this.txb_Result, "");
        }
        /// <summary>
        /// 检查病情描述
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Txb_Description_Validating(object sender, CancelEventArgs e)
        {
            this.ErrorProvider.SetError(this.txb_Description, "");
            if (this.txb_Description.Text.Length > 500)
            {
                this.ErrorProvider.SetError(this.txb_Description, "字数不能大于500！");
                return;
            }
            this.ErrorProvider.SetError(this.txb_Description, "");
        }
        /// <summary>  
        /// 保存数据到文件（使用JSON格式）  
        /// </summary>  
        /// <param name="filePath"></param>  
        /// <param name="info"></param>  
        private void SaveDataToFile(string filePath, ConsultationInfo info)
        {
            string json = JsonConvert.SerializeObject(info);
            File.WriteAllText(filePath, json);
        }
        /// <summary>  
        /// 从文件中加载数据（使用JSON格式）  
        /// </summary>  
        /// <param name="filePath"></param>  
        /// <returns></returns>  
        private ConsultationInfo LoadDataFromFile(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<ConsultationInfo>(json);
        }
        /// <summary>
        /// 单击保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\SaveInfor.txt";  
            ConsultationInfo info = new ConsultationInfo
            {
                Description = this.txb_Description.Text,
                Result = this.txb_Result.Text
            };
            try
            {
                SaveDataToFile(filePath, info);
                MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("保存出错，请重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 单击载入按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Load_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\SaveInfor.txt";  
            ConsultationInfo loadedInfo = LoadDataFromFile(filePath);
            this.txb_Description.Text = loadedInfo.Description;  
            this.txb_Result.Text = loadedInfo.Result; 
        }
        /// <summary>
        /// 单击提交按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this.SqlHelper.NewCommand($@"INSERT INTO tb_TreatRecord
	                                            (No,Date,HealthCardNo,DoctorNo,DepartmentNo,Description,Result)
	                                            VALUES
	                                            (@No,@Date,@HealthCardNo,@DoctorNo,@DepartmentNo,@Description,@Result)");
            this.SqlHelper.NewParameter("@No", this.KeyNo);
            this.SqlHelper.NewParameter("@Date", DateTime.Now.Date);
            this.SqlHelper.NewParameter("@HealthCardNo", Patient.HealthCardNo);
            this.SqlHelper.NewParameter("@DoctorNo", Doctor.No);
            this.SqlHelper.NewParameter("@DepartmentNo", this.Doctor.DepartmentNo);
            this.SqlHelper.NewParameter("@Description", this.txb_Description.Text.Trim());
            this.SqlHelper.NewParameter("@Result", this.txb_Result.Text.Trim());
            int rowAffected = this.SqlHelper.NonQuery();
            if (rowAffected == 1)
            {
                MessageBox.Show("提交成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("提交失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 单击修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modify_Click(object sender, EventArgs e)
        {
            this.SqlHelper.NewCommand($@"UPDATE tb_TreatRecord
	                                            SET Description=@Description,
		                                            Result=@Result
	                                            WHERE
		                                            Date=@Date
		                                            AND DoctorNo=@DoctorNo
		                                            AND HealthCardNo=@HealthCardNo");
            this.SqlHelper.NewParameter("@Date", DateTime.Now.Date);
            this.SqlHelper.NewParameter("@HealthCardNo", Patient.HealthCardNo);
            this.SqlHelper.NewParameter("@DoctorNo", Doctor.No);
            this.SqlHelper.NewParameter("@Description", this.txb_Description.Text.Trim());
            this.SqlHelper.NewParameter("@Result", this.txb_Result.Text.Trim());
            int rowAffected = this.SqlHelper.NonQuery();
            if (rowAffected == 1)
            {
                MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("修改失败！原因可能是病历还未提交。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
