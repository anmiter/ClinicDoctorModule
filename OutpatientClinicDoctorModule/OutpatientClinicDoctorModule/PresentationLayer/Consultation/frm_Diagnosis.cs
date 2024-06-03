using Newtonsoft.Json;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;


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
        /// 病历
        /// </summary>
        private TreatRecord TreatRecord { get; set; }
        /// <summary>
        /// 病历（数据访问层）
        /// </summary>
        private ITreatRecordDal TreatRecordDal { get; set; }
        /// <summary>
        /// 输入是否符合要求
        /// </summary>
        private bool IsValid;
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
        public frm_Diagnosis(Doctor doctor, Patient patient) : this()
        {
            this.Doctor = doctor;
            this.Patient = patient;
            this.SqlHelper = new SqlHelper();
            this.TreatRecord = new TreatRecord();
            this.TreatRecordDal = new TreatRecordDal();
            DataTable departmentTable = SqlHelper.GetTable("SELECT * FROM tb_Department");
            this.cmb_Department.DataSource = departmentTable;
            this.cmb_Department.DisplayMember = "Name";
            this.cmb_Department.ValueMember = "No";
            this.txb_No.Text = this.Doctor.No;
            this.txb_HealthCardNo.Text = this.Patient.HealthCardNo;
            this.cmb_Department.SelectedItem = this.Doctor.DepartmentNo;
            this.txb_Description.Validating += Txb_Description_Validating;
            this.txb_Result.Validating += Txb_Result_Validating;
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
            string filePath = "D:\\SaveInfor.txt"; // 使用合适的文件路径  
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
        /// 检查诊断结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txb_Result_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.ErrorProvider.SetError(this.txb_Result, "");
            if (this.txb_Result.Text.Length > 80)
            {
                this.ErrorProvider.SetError(this.txb_Result, "字数不能大于80！");
                this.IsValid = false;
                return;
            }
            this.ErrorProvider.SetError(this.txb_Result, "");
            this.IsValid = true;
        }
        /// <summary>
        /// 检查病情描述
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Txb_Description_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.ErrorProvider.SetError(this.txb_Description, "");
            if (this.txb_Description.Text.Length > 80)
            {
                this.ErrorProvider.SetError(this.txb_Description, "字数不能大于80！");
                this.IsValid = false;
                return;
            }
            this.ErrorProvider.SetError(this.txb_Description, "");
            this.IsValid = true;
        }
        /// <summary>
        /// 单击载入按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Load_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\SaveInfor.txt"; // 使用相同的文件路径  
            ConsultationInfo loadedInfo = LoadDataFromFile(filePath);
            this.txb_Description.Text = loadedInfo.Description; // 设置Description文本框  
            this.txb_Result.Text = loadedInfo.Result; // 设置Result文本框 
        }
        /// <summary>
        /// 单击提交按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this.TreatRecord.HealthCardNo = this.Patient.HealthCardNo;
            this.TreatRecord.DoctorNo = this.Doctor.No;
            this.TreatRecord.Date = DateTime.Now;
            this.TreatRecord.Description = this.txb_Description.Text.Trim();
            this.TreatRecord.Result = this.txb_Result.Text.Trim();
            if (this.TreatRecord.HealthCardNo == null)
            {
                MessageBox.Show("先保存才能提交！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int rowAffected = this.TreatRecordDal.Insert(this.TreatRecord);
            if (rowAffected == 1)
            {
                MessageBox.Show("提交成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("提交失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
