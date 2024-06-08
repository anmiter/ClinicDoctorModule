using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 检查项目窗体
    /// </summary>
    public partial class frm_Examination : Form
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
        /// 重要编码
        /// </summary>
        string KeyNo;
        /// <summary>
        /// 构造函数
        /// </summary>
        public frm_Examination()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.dgv_Examination.AllowUserToAddRows = false;
            this.dgv_Examination.RowHeadersVisible = false;
            this.dgv_Examination.BackgroundColor = Color.White;
            this.dgv_Examination.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            LoadExamination();
        }
        /// <summary>
        /// 检查项目表
        /// </summary>
        private DataTable _ExaminationTable;
        /// <summary>
        /// 按名称排序的项目数据视图；
        /// </summary>
        private DataView _ExaminationViewByName;
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="doctor"></param>
        /// <param name="patient"></param>
        /// <param name="keyNo"></param>
        public frm_Examination(Doctor doctor, Patient patient, string keyNo) : this()
        {
            this.Doctor = doctor;
            this.Patient = patient;
            this.KeyNo = keyNo;
        }
        /// <summary>
        /// 单击根据编号搜索按钮搜索检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchByNo_Click(object sender, EventArgs e)
        {
            if (this.txb_No.Text.Trim() != "")
            {
                DataRow ExamineRow = this._ExaminationTable.Rows.Find(this.txb_No.Text.Trim());
                DataTable searchResultTable = this._ExaminationTable.Clone();
                searchResultTable.ImportRow(ExamineRow);
                this.dgv_Examination.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 单击根据名称搜索按钮搜索检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchByName_Click(object sender, EventArgs e)
        {
            if (this.txb_Name.Text.Trim() != "")
            {
                DataRowView[] searchResultRowViews =
                this._ExaminationViewByName.FindRows(this.txb_Name.Text.Trim());
                DataTable searchResultTable = this._ExaminationTable.Clone();
                foreach (DataRowView dataRowView in searchResultRowViews)
                {
                    searchResultTable.ImportRow(dataRowView.Row);
                }
                this.dgv_Examination.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 单击根据关键字搜索按钮搜索检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_KeyWord_TextChanged(object sender, EventArgs e)
        {
            if (this.txb_KeyWord.Text.Trim() != "")
            {
                DataRow[] searchResultRows =
                    this._ExaminationTable.Select($"Name LIKE '%{this.txb_KeyWord.Text.Trim()}%' OR Type LIKE '%{this.txb_KeyWord.Text.Trim()}%'");
                DataTable searchResultTable = this._ExaminationTable.Clone();
                foreach (DataRow row in searchResultRows)
                {
                    searchResultTable.ImportRow(row);
                }
                this.dgv_Examination.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 根据拼音搜索检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_Pinyin_TextChanged(object sender, EventArgs e)
        {
            if (this.txb_Pinyin.Text.Trim() != "")
            {
                DataRow[] searchResultRows =
                this._ExaminationTable.Select($"Pinyin LIKE '%{this.txb_Pinyin.Text.Trim()}%'");
                DataTable searchResultTable = this._ExaminationTable.Clone();
                foreach (DataRow row in searchResultRows)
                {
                    searchResultTable.ImportRow(row);
                }
                this.dgv_Examination.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 单击重新载入按钮载入检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadExamination();
            this.txb_Name.Clear();
            this.txb_No.Clear();
            this.txb_KeyWord.Clear();
            this.txb_Pinyin.Clear();
        }
        /// <summary>
        /// 载入检查项目
        /// </summary>
        public void LoadExamination()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"SELECT E.No,E.Name,E.Price,T.Type,E.Pinyin,E.Introduction
	                                        FROM tb_Examination AS E JOIN tb_ExaminationType AS T ON E.TypeNo=T.No";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable ExaminationTable = new DataTable("ExaminationTable");
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            sqlConnection.Open();
            sqlDataAdapter.Fill(ExaminationTable);
            sqlConnection.Close();
            this._ExaminationTable = ExaminationTable;
            this._ExaminationViewByName = new DataView();
            this._ExaminationViewByName.Table = ExaminationTable;
            this._ExaminationViewByName.Sort = "Name ASC";
            this.dgv_Examination.Columns.Clear();
            this.dgv_Examination.DataSource = ExaminationTable;
            this.dgv_Examination.Columns["No"].ReadOnly = true;
            this.dgv_Examination.Columns["No"].HeaderText = "编号";
            this.dgv_Examination.Columns["Name"].HeaderText = "名称";
            this.dgv_Examination.Columns["Price"].HeaderText = "价格";
            this.dgv_Examination.Columns["Type"].HeaderText = "类型";
            this.dgv_Examination.Columns["Pinyin"].HeaderText = "拼音";
            this.dgv_Examination.Columns["Introduction"].HeaderText = "简介";
        }
    }
}
