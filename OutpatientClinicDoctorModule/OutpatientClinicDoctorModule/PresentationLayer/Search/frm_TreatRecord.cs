using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 病历窗体
    /// </summary>
    public partial class frm_TreatRecord : Form
    {
        /// <summary>
        /// 患者
        /// </summary>
        private Patient Patient;
        /// <summary>
        /// SQL助手
        /// </summary>
        private SqlHelper SqlHelper { get; set; }
        /// <summary>
        /// 重要编码
        /// </summary>
        private string KeyNo;
        /// <summary>
        /// 实体集
        /// </summary>
        private OutpatientClinicDoctorDB dbContext;
        /// <summary>
        /// 构造函数
        /// </summary>
        public frm_TreatRecord()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dbContext = new OutpatientClinicDoctorDB();
        }
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="patient"></param>
        public frm_TreatRecord(Patient patient) : this()
        {
            Patient = patient;
            this.SqlHelper = new SqlHelper();
            this.trv_TreatRecord.Nodes.Clear();
            var hospitals = dbContext.tb_Hospital.ToList();
            foreach (var hospital in hospitals)
            {
                var hospitalNode = new TreeNode(hospital.Name);
                this.trv_TreatRecord.Nodes.Add(hospitalNode);
                var departments = dbContext.tb_Department.Where(d => d.HospitalNo == hospital.No).ToList();
                foreach (var department in departments)
                {
                    var departmentNode = new TreeNode(department.Name);
                    hospitalNode.Nodes.Add(departmentNode);
                    var treatRecords = dbContext.tb_TreatRecord.Where(tr => tr.DepartmentNo == department.No)
                                                             .GroupBy(tr => tr.Date)
                                                             .Select(gr => gr.Key)
                                                             .ToList();
                    foreach (var date in treatRecords)
                    {
                        var dateNode = new TreeNode(date.ToString());
                        departmentNode.Nodes.Add(dateNode);
                    }
                }
            }
        }
        /// <summary>
        /// 选择节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trv_TreatRecord_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.txb_Name.Text = this.Patient.Name;
            this.txb_HealthCardNo.Text = this.Patient.HealthCardNo;
            this.dtp_Birthdate.Value = this.Patient.Birthdate;
            this.nud_Age.Value = DateTime.Now.Year - this.Patient.Birthdate.Year;
            if (this.trv_TreatRecord.SelectedNode.Level != 2)
                return;
            string date = (string)this.trv_TreatRecord.SelectedNode.Text;

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"";
            sqlCommand.Parameters.AddWithValue("@HealthCardNo", this.Patient.HealthCardNo);
            sqlCommand.Parameters.AddWithValue("@Date", DateTime.Parse(date));
            sqlCommand.Parameters.Add("@ExaminationNo", SqlDbType.Char, 4, "No");
            IDataReader dataReader =
                this.SqlHelper
                .NewCommand($@"SELECT T.Date,DE.Name AS Department,D.Name AS Doctor,T.Description,T.Result,T.TCMNo,T.PrescriptionNo,T.ExaminationsNo
                                FROM tb_TreatRecord AS T
                                JOIN tb_Doctor AS D ON T.DoctorNo=D.No
                                JOIN tb_Department AS DE ON D.DepartmentNo=DE.NO
                                WHERE T.HealthCardNo=@HealthCardNo
                                AND T.Date=@Date")
                .NewParameter("@HealthCardNo", this.Patient.HealthCardNo)
                .NewParameter("@Date", date)
                .GetReader();
            if (dataReader.Read())
            {
                this.txt_Doctor.Text = (string)dataReader["Doctor"];
                this.txt_Description.Text = (string)dataReader["Description"];
                this.txt_Result.Text = (string)dataReader["Result"];
                if (dataReader["TCMNo"] != DBNull.Value)
                {
                    this.KeyNo = (string)dataReader["TCMNo"].ToString().Substring(1);
                }
                if (dataReader["ExaminationsNo"] != DBNull.Value)
                {
                    this.KeyNo = (string)dataReader["TCMNo"].ToString().Substring(1);
                }
                if (dataReader["PrescriptionNo"] != DBNull.Value)
                {
                    this.KeyNo = (string)dataReader["TCMNo"].ToString().Substring(1);
                }
            }
        }
        /// <summary>
        /// 查看药方和检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Show_Click(object sender, EventArgs e)
        {
            frm_Show frm_Show = new frm_Show(this.KeyNo);
            frm_Show.ShowDialog();
        }
        private void frm_TreatRecord_Load(object sender, System.EventArgs e)
        {

        }
    }
}