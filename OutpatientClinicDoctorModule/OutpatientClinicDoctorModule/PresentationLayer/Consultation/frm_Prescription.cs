using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 处方窗体
    /// </summary>
    public partial class frm_Prescription : Form
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
        public frm_Prescription()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.dgv_Herb.AllowUserToAddRows = false;
            this.dgv_Herb.RowHeadersVisible = false;
            this.dgv_Herb.BackgroundColor = Color.White;
            this.dgv_Herb.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Drug.AllowUserToAddRows = false;
            this.dgv_Drug.RowHeadersVisible = false;
            this.dgv_Drug.BackgroundColor = Color.White;
            this.dgv_Drug.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            LoadHerb();
            LoadDrug();
        }
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="doctor"></param>
        /// <param name="patient"></param>
        /// <param name="keyNo"></param>
        public frm_Prescription(Doctor doctor, Patient patient, string keyNo) : this()
        {
            this.Doctor = doctor;
            this.Patient = patient;
            this.KeyNo = keyNo;
        }
        /// <summary>
        /// 药材表
        /// </summary>
        private DataTable _HerbTable;
        /// <summary>
        /// 药品表
        /// </summary>
        private DataTable _DrugTable;
        /// <summary>
        /// 按名称排序的药材数据视图
        /// </summary>
        private DataView _HerbViewByName;
        /// <summary>
        /// 按名称排序的药品数据视图；
        /// </summary>
        private DataView _DrugViewByName;
        /// <summary>
        /// 按名称排序的项目数据视图；
        /// </summary>
        private DataView _ExamineViewByName;
        /// <summary>
        /// 单击根据编号搜索按钮搜索药材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchHerbByNo_Click(object sender, EventArgs e)
        {
            if (this.txb_HerbNo.Text.Trim() != "")
            {
                DataRow herbRow = this._HerbTable.Rows.Find(this.txb_HerbNo.Text.Trim());
                DataTable searchResultTable = this._HerbTable.Clone();
                searchResultTable.ImportRow(herbRow);
                this.dgv_Herb.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 单击根据编号搜索按钮搜索药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchDrugByNo_Click(object sender, EventArgs e)
        {
            if (this.txb_DrugNo.Text.Trim() != "")
            {
                DataRow drugRow = this._DrugTable.Rows.Find(this.txb_DrugNo.Text.Trim());
                DataTable searchResultTable = this._DrugTable.Clone();
                searchResultTable.ImportRow(drugRow);
                this.dgv_Drug.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 根据名称搜索按钮搜索药材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchHerbByName_Click(object sender, EventArgs e)
        {
            if (this.txb_HerbName.Text.Trim() != "")
            {
                DataRowView[] searchResultRowViews = this._HerbViewByName.FindRows(this.txb_HerbName.Text.Trim());
                DataTable searchResultTable = this._HerbTable.Clone();
                foreach (DataRowView dataRowView in searchResultRowViews)
                {
                    searchResultTable.ImportRow(dataRowView.Row);
                }
                this.dgv_Herb.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 根据名称搜索按钮搜索药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchDrugByName_Click(object sender, EventArgs e)
        {
            if (this.txb_DrugName.Text.Trim() != "")
            {
                DataRowView[] searchResultRowViews = this._DrugViewByName.FindRows(this.txb_DrugName.Text.Trim());
                DataTable searchResultTable = this._DrugTable.Clone();
                foreach (DataRowView dataRowView in searchResultRowViews)
                {
                    searchResultTable.ImportRow(dataRowView.Row);
                }
                this.dgv_Drug.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 根据关键字搜索按钮搜索药材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_HerbKeyWord_TextChanged(object sender, EventArgs e)
        {
            if (this.txb_HerbKeyWord.Text.Trim() != "")
            {
                DataRow[] searchResultRows =
               this._HerbTable.Select($"Name LIKE '%{this.txb_HerbKeyWord.Text.Trim()}%' OR Category LIKE '%{this.txb_HerbKeyWord.Text.Trim()}%'");
                                                                                                                                               
                DataTable searchResultTable = this._HerbTable.Clone();
                foreach (DataRow row in searchResultRows)
                {
                    searchResultTable.ImportRow(row);
                }
                this.dgv_Herb.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 根据关键字搜索按钮搜索药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_DrugKeyWord_TextChanged(object sender, EventArgs e)
        {
            if (this.txb_DrugKeyWord.Text.Trim() != "")
            {
                DataRow[] searchResultRows =
               this._DrugTable.Select($"ChineseName LIKE '%{this.txb_DrugKeyWord.Text.Trim()}%' OR EnglishName LIKE '%{this.txb_DrugKeyWord.Text.Trim()}%' OR Treat LIKE '%{this.txb_DrugKeyWord.Text.Trim()}%'");
                DataTable searchResultTable = this._DrugTable.Clone();
                foreach (DataRow row in searchResultRows)
                {
                    searchResultTable.ImportRow(row);
                }
                this.dgv_Drug.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 根据拼音搜索药材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_HerbPinyin_TextChanged(object sender, EventArgs e)
        {
            if (this.txb_HerbPinyin.Text.Trim() != "")
            {
                DataRow[] searchResultRows = this._HerbTable.Select($"Pinyin LIKE '%{this.txb_HerbPinyin.Text.Trim()}%'");
                DataTable searchResultTable = this._HerbTable.Clone();
                foreach (DataRow row in searchResultRows)
                {
                    searchResultTable.ImportRow(row);
                }
                this.dgv_Herb.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 根据拼音搜索药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_DrugPinyin_TextChanged(object sender, EventArgs e)
        {
            if (this.txb_DrugPinyin.Text.Trim() != "")
            {
                DataRow[] searchResultRows =
                this._DrugTable.Select($"Pinyin LIKE '%{this.txb_DrugPinyin.Text.Trim()}%'");
                DataTable searchResultTable = this._DrugTable.Clone();
                foreach (DataRow row in searchResultRows)
                {
                    searchResultTable.ImportRow(row);
                }
                this.dgv_Drug.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 单击重新载入按钮载入药材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LoadHerb_Click(object sender, EventArgs e)
        {
            LoadHerb();
            this.txb_HerbNo.Clear();
            this.txb_HerbName.Clear();
            this.txb_HerbKeyWord.Clear();
            this.txb_HerbPinyin.Clear();
        }
        /// <summary>
        /// 单击重新载入按钮载入药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LoadDrug_Click(object sender, EventArgs e)
        {
            LoadDrug();
            this.txb_DrugName.Clear();
            this.txb_DrugNo.Clear();
            this.txb_DrugKeyWord.Clear();
            this.txb_DrugPinyin.Clear();
        }
        /// <summary>
        /// 载入药材
        /// </summary>
        public void LoadHerb()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"SELECT H.No,H.Name,H.Price,T.Category,H.Pinyin,H.Efficacy 
                                            FROM tb_Herb AS H JOIN tb_HerbCategory AS T ON H.CategoryNo=T.No";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable HerbTable = new DataTable("HerbTable");
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            sqlConnection.Open();
            sqlDataAdapter.Fill(HerbTable);
            sqlConnection.Close();
            this._HerbTable = HerbTable;
            this._HerbViewByName = new DataView();
            this._HerbViewByName.Table = HerbTable;
            this._HerbViewByName.Sort = "Name ASC";
            this.dgv_Herb.Columns.Clear();
            this.dgv_Herb.DataSource = HerbTable;
            this.dgv_Herb.Columns["No"].ReadOnly = true;
            this.dgv_Herb.Columns["No"].HeaderText = "编号";
            this.dgv_Herb.Columns["Name"].HeaderText = "名称";
            this.dgv_Herb.Columns["Price"].HeaderText = "售价/g";
            this.dgv_Herb.Columns["Category"].HeaderText = "类别";
            this.dgv_Herb.Columns["Pinyin"].HeaderText = "拼音";
            this.dgv_Herb.Columns["Efficacy"].HeaderText = "功效";
        }
        /// <summary>
        /// 载入药品
        /// </summary>
        public void LoadDrug()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"SELECT D.No,D.ChineseName,D.Price,U.Name,D.Treat,D.Pinyin,D.EnglishName
	                                        FROM tb_Drug AS D JOIN tb_Unit AS U ON D.UnitNo=U.No";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable DrugTable = new DataTable("DrugTable");
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            sqlConnection.Open();
            sqlDataAdapter.Fill(DrugTable);
            sqlConnection.Close();
            this._DrugTable = DrugTable;
            this._DrugViewByName = new DataView();
            this._DrugViewByName.Table = DrugTable;
            this._DrugViewByName.Sort = "ChineseName ASC";
            this.dgv_Drug.Columns.Clear();
            this.dgv_Drug.DataSource = DrugTable;
            this.dgv_Drug.Columns["No"].ReadOnly = true;
            this.dgv_Drug.Columns["No"].HeaderText = "编号";
            this.dgv_Drug.Columns["ChineseName"].HeaderText = "名称";
            this.dgv_Drug.Columns["Price"].HeaderText = "售价";
            this.dgv_Drug.Columns["Name"].HeaderText = "单位";
            this.dgv_Drug.Columns["Treat"].HeaderText = "主治";
            this.dgv_Drug.Columns["Pinyin"].HeaderText = "拼音";
            this.dgv_Drug.Columns["EnglishName"].HeaderText = "英文名";
        }
    }
}
