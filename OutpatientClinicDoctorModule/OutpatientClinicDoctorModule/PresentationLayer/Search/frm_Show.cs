using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 查看药方和检查项目窗体
    /// </summary>
    public partial class frm_Show : Form
    {
        /// <summary>
        /// Sql助手
        /// </summary>
        private SqlHelper sqlHelper {  get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public frm_Show()
        {
            InitializeComponent();
            this.sqlHelper = new SqlHelper();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.dgv_TCM.AllowUserToAddRows = false;
            this.dgv_TCM.RowHeadersVisible = false;
            this.dgv_TCM.BackgroundColor = Color.White;
            this.dgv_TCM.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Prescription.AllowUserToAddRows = false;
            this.dgv_Prescription.RowHeadersVisible = false;
            this.dgv_Prescription.BackgroundColor = Color.White;
            this.dgv_Prescription.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Examinations.AllowUserToAddRows = false;
            this.dgv_Examinations.RowHeadersVisible = false;
            this.dgv_Examinations.BackgroundColor = Color.White;
            this.dgv_Examinations.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="keyNo"></param>
        public frm_Show(string keyNo) : this()
        {
            LoadTCM(keyNo);
            LoadPrescription(keyNo);
            LoadExamination(keyNo);
        }
        /// <summary>
        /// 载入中药药方
        /// </summary>
        /// <param name="keyNo"></param>
        private void LoadTCM(string keyNo)
        {
            string commandText =
                $@"SELECT H.Name,T.Usage,C.Category,H.Efficacy,H.Price
                        FROM tb_TCM AS T
		                    JOIN tb_Herb AS H ON T.HerbNo=H.No 
		                    JOIN tb_HerbCategory AS C ON H.CategoryNo=C.No
	                    WHERE T.No=@No";
            DataTable tcmTable = this.sqlHelper.GetTable(commandText, "1" + keyNo);
            this.dgv_TCM.Columns.Clear();
            this.dgv_TCM.DataSource = tcmTable;
            this.dgv_TCM.Columns["Name"].ReadOnly = true;
            this.dgv_TCM.Columns["Usage"].ReadOnly = true;
            this.dgv_TCM.Columns["Category"].ReadOnly = true;
            this.dgv_TCM.Columns["Efficacy"].ReadOnly = true;
            this.dgv_TCM.Columns["Price"].ReadOnly = true;
            this.dgv_TCM.Columns["Name"].HeaderText = "名称";
            this.dgv_TCM.Columns["Usage"].HeaderText = "用量/g";
            this.dgv_TCM.Columns["Category"].HeaderText = "类别";
            this.dgv_TCM.Columns["Efficacy"].HeaderText = "功效";
            this.dgv_TCM.Columns["Price"].HeaderText = "价格";
        }
        /// <summary>
        /// 载入西药药方
        /// </summary>
        /// <param name="keyNo"></param>
        private void LoadPrescription(string keyNo)
        {
            string commandText =
                $@"SELECT D.ChineseName,P.Number,U.Name AS Unit,P.Usage,D.Treat,D.Price
	                    FROM tb_Prescription AS P
		                    JOIN tb_Drug AS D ON P.DrugNo=D.No
		                    JOIN tb_Unit AS U ON D.UnitNo=U.No
	                    WHERE P.No=@No";
            DataTable prescriptionTable = this.sqlHelper.GetTable(commandText, "2" + keyNo);
            this.dgv_Prescription.Columns.Clear();
            this.dgv_Prescription.DataSource = prescriptionTable;
            this.dgv_Prescription.Columns["ChineseName"].ReadOnly = true;
            this.dgv_Prescription.Columns["Number"].ReadOnly = true;
            this.dgv_Prescription.Columns["Unit"].ReadOnly = true;
            this.dgv_Prescription.Columns["Usage"].ReadOnly = true;
            this.dgv_Prescription.Columns["Treat"].ReadOnly = true;
            this.dgv_Prescription.Columns["Price"].ReadOnly = true;
            this.dgv_Prescription.Columns["ChineseName"].HeaderText = "名称";
            this.dgv_Prescription.Columns["Number"].HeaderText = "数量";
            this.dgv_Prescription.Columns["Unit"].HeaderText = "单位";
            this.dgv_Prescription.Columns["Usage"].HeaderText = "用法";
            this.dgv_Prescription.Columns["Treat"].HeaderText = "主治";
            this.dgv_Prescription.Columns["Price"].HeaderText = "价格";
        }
        /// <summary>
        /// 载入检查项目
        /// </summary>
        /// <param name="keyNo"></param>
        private void LoadExamination(string keyNo)
        {
            string commandText =
                $@"SELECT E.Name,ES.Result,T.Type,E.Introduction,E.Price
                        FROM tb_Examinations AS ES 
		                    JOIN tb_Examination AS E ON ES.ExaminationNo=E.No 
		                    JOIN tb_ExaminationType AS T ON E.TypeNo=T.No
	                    WHERE ES.No=@No";
            DataTable examinationsTable = this.sqlHelper.GetTable(commandText, "3" + keyNo);
            this.dgv_Examinations.Columns.Clear();
            this.dgv_Examinations.DataSource = examinationsTable;
            this.dgv_Examinations.Columns["Name"].ReadOnly = true;
            this.dgv_Examinations.Columns["Result"].ReadOnly = true;
            this.dgv_Examinations.Columns["Type"].ReadOnly = true;
            this.dgv_Examinations.Columns["Introduction"].ReadOnly = true;
            this.dgv_Examinations.Columns["Price"].ReadOnly = true;
            this.dgv_Examinations.Columns["Name"].HeaderText = "名称";
            this.dgv_Examinations.Columns["Result"].HeaderText = "结果";
            this.dgv_Examinations.Columns["Type"].HeaderText = "类型";
            this.dgv_Examinations.Columns["Introduction"].HeaderText = "简介";
            this.dgv_Examinations.Columns["Price"].HeaderText = "价格";
        }
        private void frm_Show_Load(object sender, EventArgs e)
        {

        }
    }
}