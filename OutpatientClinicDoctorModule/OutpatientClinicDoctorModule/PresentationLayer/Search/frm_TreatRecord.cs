using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        /// 构造函数
        /// </summary>
        public frm_TreatRecord()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="patient"></param>
        public frm_TreatRecord(Patient patient) : this()
        {
            Patient = patient;
            TreeNode firstNode = new TreeNode("福建省第三人民医院");
            trv_TreatRecord.Nodes.Add(firstNode);
            TreeNode secondNode = new TreeNode("福建省立医院");
            trv_TreatRecord.Nodes.Add(secondNode);
            string connectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommandDepartments = new SqlCommand("SELECT * FROM tb_Department", sqlConnection);
                using (SqlDataAdapter sqlDataAdapterDepartments = new SqlDataAdapter(sqlCommandDepartments))
                {
                    DataTable departmentTable = new DataTable();
                    sqlDataAdapterDepartments.Fill(departmentTable);
                    foreach (DataRow row in departmentTable.Rows)
                    {
                        TreeNode DepartmentNode = new TreeNode(row["Name"].ToString());
                        firstNode.Nodes.Add(DepartmentNode);
                        string departmentNo = row["No"].ToString();
                        SqlCommand sqlCommandTreatments =
                            new SqlCommand($@"SELECT T.Date,T.HealthCardNo,DE.Name,D.Name,T.Description,T.Result,T.TCMNo,T.PrescriptionNo,T.ExaminationsNo,T.TCMPrice+T.PrescriptionPrice+T.ExaminationPrice AS Price  
	                                            FROM tb_TreatRecord AS T
	                                            JOIN tb_Doctor AS D ON T.DoctorNo=D.No
	                                            JOIN tb_Department AS DE ON D.DepartmentNo=DE.NO
	                                            WHERE T.HealthCardNo=@HealthCardNo AND D.DepartmentNo=@DepartmentNo 
                                                ORDER BY T.Date", sqlConnection);
                        sqlCommandTreatments.Parameters.AddWithValue("@HealthCardNo", this.Patient.HealthCardNo);
                        sqlCommandTreatments.Parameters.AddWithValue("@DepartmentNo", departmentNo);
                        using (SqlDataAdapter sqlDataAdapterTreatments = new SqlDataAdapter(sqlCommandTreatments))
                        {
                            DataTable treatmentTable = new DataTable();
                            sqlDataAdapterTreatments.Fill(treatmentTable);
                            foreach (DataRow treatmentRow in treatmentTable.Rows)
                            {
                                TreeNode dataNode = new TreeNode(treatmentRow["Date"].ToString().Substring(0, 8));
                                DepartmentNode.Nodes.Add(dataNode);
                            }
                        }
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
            int date = (int)this.trv_TreatRecord.SelectedNode.Tag;
            this.label1.Text = date.ToString();
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand insertCommand = sqlConnection.CreateCommand();
            insertCommand.Connection = sqlConnection;
            insertCommand.CommandText = $@"SELECT T.Date,T.HealthCardNo,DE.Name,D.Name,T.Description,T.Result,T.TCMNo,T.PrescriptionNo,T.ExaminationsNo,T.TCMPrice+T.PrescriptionPrice+T.ExaminationPrice AS Price  
	                                            FROM tb_TreatRecord AS T
	                                            JOIN tb_Doctor AS D ON T.DoctorNo=D.No
	                                            JOIN tb_Department AS DE ON D.DepartmentNo=DE.NO
	                                            WHERE T.HealthCardNo=@HealthCardNo
                                                    AND T.Date=@Date";
            insertCommand.Parameters.AddWithValue("@HealthCardNo", this.Patient.HealthCardNo);
            //insertCommand.Parameters.AddWithValue("@Date", DateTime.Parse(date));
            insertCommand.Parameters.Add("@ExaminationNo", SqlDbType.Char, 4, "No");

        }
        /// <summary>
        /// 单击查看检查项目按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchExaminations_Click(object sender, System.EventArgs e)
        {

        }
        /// <summary>
        /// 单击查看药方按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchPrescription_Click(object sender, System.EventArgs e)
        {

        }
        private void frm_TreatRecord_Load(object sender, System.EventArgs e)
        {

        }
    }
}