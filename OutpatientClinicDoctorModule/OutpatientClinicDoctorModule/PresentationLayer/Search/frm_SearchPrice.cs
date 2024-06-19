using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 价目查询窗体
    /// </summary>
    public partial class frm_SearchPrice : Form
    {
        /// <summary>
        /// 药材表
        /// </summary>
        private DataTable _HerbTable;
        /// <summary>
        /// 药品表
        /// </summary>
        private DataTable _DrugTable;
        /// <summary>
        /// 检查项目表
        /// </summary>
        private DataTable _ExaminationTable;
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
        private DataView _ExaminationViewByName;
        /// <summary>
        /// 每页大小
        /// </summary>
        private int PageSize;
        /// <summary>
        /// 当前页号
        /// </summary>
        private int CurrentPageNo;
        /// <summary>
        /// 药材最大页号
        /// </summary>
        private int MaxPageNo;
        /// <summary>
        /// 药材当前页的数据视图
        /// </summary>
        private DataView CurrentPageView;
        /// <summary>
        /// 构造函数
        /// </summary>
        public frm_SearchPrice()
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
            this.dgv_Examination.AllowUserToAddRows = false;
            this.dgv_Examination.RowHeadersVisible = false;
            this.dgv_Examination.BackgroundColor = Color.White;
            this.dgv_Examination.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            LoadHerb();
            LoadDrug();
            LoadExamine();
        }
        /// <summary>
        /// 单击根据编号搜索按钮搜索药材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchHerbByNo_Click(object sender, EventArgs e)
        {
            if (this.nud_HerbNo.Text.Trim() != "")
            {
                DataRow herbRow = this._HerbTable.Rows.Find(this.nud_HerbNo.Text.Trim());
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
            if (this.nud_DrugNo.Text.Trim() != "")
            {
                DataRow drugRow = this._DrugTable.Rows.Find(this.nud_DrugNo.Text.Trim());
                DataTable searchResultTable = this._DrugTable.Clone();
                searchResultTable.ImportRow(drugRow);
                this.dgv_Drug.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 单击根据编号搜索按钮搜索检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchExamineByNo_Click(object sender, EventArgs e)
        {
            if (this.nud_ExaminationNo.Text.Trim() != "")
            {
                DataRow ExamineRow = this._ExaminationTable.Rows.Find(this.nud_ExaminationNo.Text.Trim());
                DataTable searchResultTable = this._ExaminationTable.Clone();
                searchResultTable.ImportRow(ExamineRow);
                this.dgv_Examination.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 单击根据名称搜索按钮搜索药材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchHerbByName_Click(object sender, EventArgs e)
        {
            if (this.txb_HerbName.Text.Trim() != "")
            {
                DataRowView[] searchResultRowViews =
                    this._HerbViewByName.FindRows(this.txb_HerbName.Text.Trim());
                DataTable searchResultTable = this._HerbTable.Clone();
                foreach (DataRowView dataRowView in searchResultRowViews)
                {
                    searchResultTable.ImportRow(dataRowView.Row);
                }
                this.dgv_Herb.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 单击根据名称搜索按钮搜索药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchDrugByName_Click(object sender, EventArgs e)
        {
            if (this.txb_DrugName.Text.Trim() != "")
            {
                DataRowView[] searchResultRowViews =
                    this._DrugViewByName.FindRows(this.txb_DrugName.Text.Trim());
                DataTable searchResultTable = this._DrugTable.Clone();
                foreach (DataRowView dataRowView in searchResultRowViews)
                {
                    searchResultTable.ImportRow(dataRowView.Row);
                }
                this.dgv_Drug.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 单击根据名称搜索按钮搜索检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchExamineByName_Click(object sender, EventArgs e)
        {
            if (this.txb_ExaminationName.Text.Trim() != "")
            {
                DataRowView[] searchResultRowViews =
                this._ExaminationViewByName.FindRows(this.txb_ExaminationName.Text.Trim());
                DataTable searchResultTable = this._ExaminationTable.Clone();
                foreach (DataRowView dataRowView in searchResultRowViews)
                {
                    searchResultTable.ImportRow(dataRowView.Row);
                }
                this.dgv_Examination.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 单击根据关键字搜索按钮搜索药材
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
        /// 单击根据关键字搜索按钮搜索药品
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
        /// 单击根据关键字搜索按钮搜索检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_ExamineKeyWord_TextChanged(object sender, EventArgs e)
        {
            if (this.txb_ExaminationKeyWord.Text.Trim() != "")
            {
                DataRow[] searchResultRows =
               this._ExaminationTable.Select($"Name LIKE '%{this.txb_ExaminationKeyWord.Text.Trim()}%' OR Type LIKE '%{this.txb_ExaminationKeyWord.Text.Trim()}%'");

                DataTable searchResultTable = this._ExaminationTable.Clone();
                foreach (DataRow row in searchResultRows)
                {
                    searchResultTable.ImportRow(row);
                }
                this.dgv_Examination.DataSource = searchResultTable;
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
                DataRow[] searchResultRows =
                this._HerbTable.Select($"Pinyin LIKE '%{this.txb_HerbPinyin.Text.Trim()}%'");
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_ExaminePinyin_TextChanged(object sender, EventArgs e)
        {
            if (this.txb_ExaminationPinyin.Text.Trim() != "")
            {
                DataRow[] searchResultRows =
                this._ExaminationTable.Select($"Pinyin LIKE '%{this.txb_ExaminationPinyin.Text.Trim()}%'");
                DataTable searchResultTable = this._ExaminationTable.Clone();
                foreach (DataRow row in searchResultRows)
                {
                    searchResultTable.ImportRow(row);
                }
                this.dgv_Examination.DataSource = searchResultTable;
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
            this.txb_DrugKeyWord.Clear();
            this.txb_DrugPinyin.Clear();
        }
        /// <summary>
        /// 单击重新载入按钮载入检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LoadExamine_Click(object sender, EventArgs e)
        {
            LoadExamine();
            this.txb_ExaminationName.Clear();
            this.txb_ExaminationKeyWord.Clear();
            this.txb_ExaminationPinyin.Clear();
        }
        /// <summary>
		/// 刷新行筛选条件
		/// </summary>
		private void RefreshRowFilter()
        => this.CurrentPageView.RowFilter =
                $"RowID >{(this.CurrentPageNo - 1) * this.PageSize} " +
                $"AND RowID <={this.CurrentPageNo * this.PageSize}";
        /// <summary>
        /// 载入药材
        /// </summary>
        public void LoadHerb()
        {
            this.PageSize = 10;
            this.CurrentPageNo = 1;

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                $@"SELECT H.No,H.Name,H.Price,HC.Category,H.Efficacy,H.Pinyin FROM tb_Herb AS H JOIN tb_HerbCategory AS HC ON H.CategoryNo=HC.No";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable HerbTable = new DataTable("HerbTable");
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataColumn rowIdColumn = new DataColumn();
            rowIdColumn.ColumnName = "RowID";
            rowIdColumn.DataType = typeof(int);
            rowIdColumn.AutoIncrement = true;
            rowIdColumn.AutoIncrementSeed = 1;
            rowIdColumn.AutoIncrementStep = 1;
            HerbTable.Columns.Add(rowIdColumn);

            sqlConnection.Open();
            sqlDataAdapter.Fill(HerbTable);
            sqlConnection.Close();
            this._HerbTable = HerbTable;
            this._HerbViewByName = new DataView();
            this._HerbViewByName.Table = HerbTable;
            this._HerbViewByName.Sort = "Name ASC";
            this.dgv_Herb.Columns.Clear();

            this.MaxPageNo = (int)Math.Ceiling((double)this._HerbTable.Rows.Count / (double)this.PageSize);
            this.CurrentPageView = new DataView(this._HerbTable);
            this.CurrentPageView.Sort = "RowID ASC";
            this.RefreshRowFilter();

            this.dgv_Herb.DataSource = this.CurrentPageView;
            this.dgv_Herb.Columns["No"].ReadOnly = true;
            this.dgv_Herb.Columns["Name"].ReadOnly = true;
            this.dgv_Herb.Columns["Price"].ReadOnly = true;
            this.dgv_Herb.Columns["Category"].ReadOnly = true;
            this.dgv_Herb.Columns["Efficacy"].ReadOnly = true;
            this.dgv_Herb.Columns["Pinyin"].ReadOnly = true;
            this.dgv_Herb.Columns["No"].HeaderText = "编号";
            this.dgv_Herb.Columns["Name"].HeaderText = "名称";
            this.dgv_Herb.Columns["Price"].HeaderText = "售价/g";
            this.dgv_Herb.Columns["Category"].HeaderText = "类别";
            this.dgv_Herb.Columns["Efficacy"].HeaderText = "功效";
            this.dgv_Herb.Columns["Pinyin"].HeaderText = "拼音";
        }
        /// <summary>
        /// 载入药品
        /// </summary>
        public void LoadDrug()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                $@"SELECT D.No,D.ChineseName,D.Price,U.Name AS Unit,D.Treat,D.EnglishName,D.Pinyin FROM tb_Drug AS D JOIN tb_Unit AS U ON D.UnitNo=U.No";
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
            this.dgv_Drug.Columns["ChineseName"].ReadOnly = true;
            this.dgv_Drug.Columns["Price"].ReadOnly = true;
            this.dgv_Drug.Columns["Unit"].ReadOnly = true;
            this.dgv_Drug.Columns["Treat"].ReadOnly = true;
            this.dgv_Drug.Columns["EnglishName"].ReadOnly = true;
            this.dgv_Drug.Columns["Pinyin"].ReadOnly = true;
            this.dgv_Drug.Columns["No"].HeaderText = "编号";
            this.dgv_Drug.Columns["ChineseName"].HeaderText = "名称";
            this.dgv_Drug.Columns["Price"].HeaderText = "售价";
            this.dgv_Drug.Columns["Unit"].HeaderText = "单位";
            this.dgv_Drug.Columns["Treat"].HeaderText = "主治";
            this.dgv_Drug.Columns["EnglishName"].HeaderText = "英文名";
            this.dgv_Drug.Columns["Pinyin"].HeaderText = "拼音";
        }
        /// <summary>
        /// 载入检查项目
        /// </summary>
        public void LoadExamine()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                $@"SELECT E.No,E.Name,E.Price,T.Type,E.Introduction,E.Pinyin FROM tb_Examination AS E JOIN tb_ExaminationType AS T ON E.TypeNo=T.No";
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
            this.dgv_Examination.Columns["Name"].ReadOnly = true;
            this.dgv_Examination.Columns["Price"].ReadOnly = true;
            this.dgv_Examination.Columns["Type"].ReadOnly = true;
            this.dgv_Examination.Columns["Introduction"].ReadOnly = true;
            this.dgv_Examination.Columns["Pinyin"].ReadOnly = true;
            this.dgv_Examination.Columns["No"].HeaderText = "编号";
            this.dgv_Examination.Columns["Name"].HeaderText = "名称";
            this.dgv_Examination.Columns["Price"].HeaderText = "价格";
            this.dgv_Examination.Columns["Type"].HeaderText = "类型";
            this.dgv_Examination.Columns["Introduction"].HeaderText = "简介";
            this.dgv_Examination.Columns["Pinyin"].HeaderText = "拼音";
        }
        /// <summary>
        /// 单击上一页按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PreviousPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageNo > 1) 
                this.CurrentPageNo--;
            this.RefreshRowFilter();
        }
        /// <summary>
        /// 单击下一页按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NextPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageNo < this.MaxPageNo)
                this.CurrentPageNo++;
            this.RefreshRowFilter();
        }
        private void tp_Examine_Click(object sender, EventArgs e)
        {

        }
    }
}
