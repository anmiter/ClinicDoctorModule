using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule.Consultation
{
    /// <summary>
    /// 诊断窗体
    /// </summary>
    public partial class frm_Diagnosis : Form
    {
        public frm_Diagnosis()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//本窗体启动位置设为屏幕中央
            this.txb_Description.Focus();
        }
        /// <summary>
        /// 工号
        /// </summary>
        string _DoctorNo;
        /// <summary>
        /// 医保卡号
        /// </summary>
        string _PatientIDCard;
        /// <summary>
        /// 传参，并载入信息
        /// </summary>
        /// <param name="doctorNo"></param>
        /// <param name="patientIDCatd"></param>
        public frm_Diagnosis(string doctorNo, string patientIDCatd) : this()
        {
            this._DoctorNo = doctorNo;
            this._PatientIDCard = patientIDCatd;
            this.txb_PatientIDCard.Text = this._PatientIDCard;

            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"SELECT * FROM tb_Department";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable departmentTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(departmentTable);
            this.cmb_Department.DataSource = departmentTable;
            this.cmb_Department.DisplayMember = "Name";
            this.cmb_Department.ValueMember = "No";
            sqlCommand.CommandText = $@"SELECT * FROM tb_Doctor WHERE No='{this._DoctorNo}'";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                this.txb_DoctorNo.Text = sqlDataReader["No"].ToString();
                this.cmb_Department.SelectedValue = (int)sqlDataReader["DepartmentNo"];
            }
            sqlDataReader.Close();
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
            string filePath = "D:\\SaveInfor.txt"; // 使用相同的文件路径  
            ConsultationInfo loadedInfo = LoadDataFromFile(filePath);
            this.txb_Description.Text = loadedInfo.Description; // 设置Description文本框  
            this.txb_Result.Text = loadedInfo.Result; // 设置Result文本框 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                $@"INSERT tb_MedicalRecord
	                (PatientIDCard,Hospital,DepartmentNo,DoctorNo,Date,Description,Result,PrescriptionNo,ExamineItemsNo)
	                VALUES
	                (@PatientIDCard,@Hospital,@DepartmentNo,@DoctorNo,@Date,@Description,@Result,@PrescriptionNo,@ExamineItemsNo)";

            sqlCommand.Parameters.AddWithValue("@PatientIDCard", this.txb_PatientIDCard.Text.Trim());//向SQL命令的参数集合添加参数的名称、值；
            sqlCommand.Parameters.AddWithValue("@Hospital", this.txb_Hospital.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@DepartmentNo", (int)this.cmb_Department.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@DoctorNo", this.txb_DoctorNo.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Date", DateTime.Now.Date);
            sqlCommand.Parameters.AddWithValue("@Description", this.txb_Description.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Result", this.txb_Result.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@PrescriptionNo", (int)this.cmb_PrescriptionNo.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@ExamineItemsNo", (int)this.cmb_ExamineItemsNo.SelectedValue);

            sqlConnection.Open();//打开SQL连接
            int rowAffected = sqlCommand.ExecuteNonQuery();//调用SQL命令的方法ExecuteNonQuery来执行命令，向数据库写入数据，并返回受影响行数；
            sqlConnection.Close();//关闭SQL连接；

            if (rowAffected == 1)//若查得所输用户号相应的1行记录；
            {
                MessageBox.Show("提交成功！");
            }
            else
            {
                MessageBox.Show("提交失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
