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
        /// SQL助手
        /// </summary>
        private SqlHelper SqlHelper { get; set; }
        /// <summary>
        /// 重要编码
        /// </summary>
        string KeyNo;
        /// <summary>
        /// 检查项目表
        /// </summary>
        private DataTable _ExaminationTable;
        /// <summary>
        /// 按名称排序的项目数据视图；
        /// </summary>
        private DataView _ExaminationViewByName;
        /// <summary>
        /// 检查项目清单表
        /// </summary>
        private DataTable ExaminationsTable;
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
            this.dgv_Examinations.BackgroundColor = Color.White;
        }
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
            this.SqlHelper = new SqlHelper();
            LoadExamination();
        }
        /// <summary>
        /// 单击根据编号搜索按钮搜索检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchByNo_Click(object sender, EventArgs e)
        {
            if (this.nud_No.Text.Trim() != "")
            {
                DataRow ExamineRow = this._ExaminationTable.Rows.Find(this.nud_No.Text.Trim());
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
            sqlCommand.CommandText = $@"SELECT E.No,E.Name,E.Price,T.Type,E.Introduction,E.Pinyin
	                                        FROM tb_Examination AS E JOIN tb_ExaminationType AS T ON E.TypeNo=T.No";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable ExaminationTable = new DataTable("ExaminationTable");
            this.ExaminationsTable = new DataTable();
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            sqlConnection.Open();
            sqlDataAdapter.Fill(ExaminationTable);
            sqlCommand.CommandText = $@"SELECT E.No,E.Name,E.Price,E.Introduction FROM tb_Examination AS E
	                                        JOIN tb_Examinations AS ES ON E.No=ES.ExaminationNo AND ES.No=@KeyNo";
            sqlCommand.Parameters.AddWithValue("@KeyNo", "3" + this.KeyNo);
            sqlDataAdapter.Fill(this.ExaminationsTable);
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
            this.dgv_Examinations.DataSource = this.ExaminationsTable;
            this.dgv_Examinations.Columns["No"].HeaderText = "编号";
            this.dgv_Examinations.Columns["Name"].HeaderText = "名称";
            this.dgv_Examinations.Columns["Price"].HeaderText = "价格";
            this.dgv_Examinations.Columns["Introduction"].HeaderText = "简介";
            lbl_Price.Text = "总价为：" + this.ExaminationsTable.Compute("SUM(Price)", "").ToString();
        }
        /// <summary>
        /// 单击选择按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (this.dgv_Examination.Rows.Count <= 0)
            {
                MessageBox.Show("当前已无检查项目！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRowView currentRowView = this.dgv_Examination.CurrentRow.DataBoundItem as DataRowView;
            DataRow currentExaminationRow = currentRowView.Row;
            DataRow selectedExaminationRow = this.ExaminationsTable.NewRow();
            selectedExaminationRow["No"] = currentRowView["No"];
            selectedExaminationRow["Name"] = currentRowView["Name"];
            selectedExaminationRow["Price"] = currentRowView["Price"];
            selectedExaminationRow["Introduction"] = currentRowView["Introduction"];
            currentExaminationRow.Delete();
            this.ExaminationsTable.Rows.Add(selectedExaminationRow);
            lbl_Price.Text = "总价为：" + this.ExaminationsTable.Compute("SUM(Price)", "").ToString();
        }
        /// <summary>
        /// 单击移除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            DataRowView selectedExamination = this.dgv_Examinations.CurrentRow.DataBoundItem as DataRowView;
            DataRow selectedExaminationRow = selectedExamination.Row;
            DataRow deletedExaminationRow = this._ExaminationTable.Select($"No='{selectedExaminationRow["No"]}'", "", DataViewRowState.Deleted)[0];
            deletedExaminationRow.RejectChanges();
            this.ExaminationsTable.Rows.Remove(selectedExaminationRow);
            lbl_Price.Text = "总价为：" + this.ExaminationsTable.Compute("SUM(Price)", "").ToString();
        }
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand insertCommand = sqlConnection.CreateCommand();
            insertCommand.Connection = sqlConnection;
            insertCommand.CommandText = $@"INSERT INTO tb_Examinations
	                                            (No,DoctorNo,HealthCardNo,Date,ExaminationNo)
	                                            VALUES
	                                            (@No,@DoctorNo,@HealthCardNo,@Date,@ExaminationNo)";
            insertCommand.Parameters.AddWithValue("@No", "3" + this.KeyNo);
            insertCommand.Parameters.AddWithValue("@DoctorNo", this.Doctor.No);
            insertCommand.Parameters.AddWithValue("@HealthCardNo", this.Patient.HealthCardNo);
            insertCommand.Parameters.AddWithValue("@Date", DateTime.Now);
            insertCommand.Parameters.Add("@ExaminationNo", SqlDbType.Char, 4, "No");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = insertCommand;
            sqlConnection.Open();
            int rowAffection = sqlDataAdapter.Update(this.ExaminationsTable);
            sqlConnection.Close();
            this.SqlHelper
            .NewCommand($@"UPDATE tb_TreatRecord
	                            SET ExaminationPrice=@ExaminationPrice
	                            WHERE Date=@Date
		                            AND HealthCardNo=@HealthCardNo
		                            AND DoctorNo=@DoctorNo")
            .NewParameter("@ExaminationPrice", this.ExaminationsTable.Compute("SUM(Price)", ""))
            .NewParameter("@Date", DateTime.Now)
            .NewParameter("@HealthCardNo", this.Patient.HealthCardNo)
            .NewParameter("@DoctorNo", this.Doctor.No)
            .NonQuery();
            MessageBox.Show($@"成功提交{rowAffection}个检查项目！");
        }
    }
}
