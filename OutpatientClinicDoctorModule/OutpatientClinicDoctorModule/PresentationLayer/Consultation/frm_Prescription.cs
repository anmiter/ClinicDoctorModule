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
        /// SQL助手
        /// </summary>
        private SqlHelper SqlHelper { get; set; }
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
        /// 中药药方表
        /// </summary>
        private DataTable TCMTable;
        /// <summary>
        /// 西药药方表
        /// </summary>
        private DataTable PrescriptionTable;
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
            this.dgv_TCM.BackgroundColor = Color.White;
            this.dgv_Drug.AllowUserToAddRows = false;
            this.dgv_Drug.RowHeadersVisible = false;
            this.dgv_Drug.BackgroundColor = Color.White;
            this.dgv_Drug.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Prescription.BackgroundColor = Color.White;
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
            this.SqlHelper = new SqlHelper();
            LoadHerb();
            LoadDrug();
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
            this.TCMTable = new DataTable();
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            sqlConnection.Open();
            sqlDataAdapter.Fill(HerbTable);
            sqlCommand.CommandText = $@"SELECT H.No,H.Name,T.Usage,H.Efficacy,H.Price,H.Price*T.Usage AS Total 
                                            FROM tb_TCM AS T
	                                        JOIN tb_Herb AS H ON T.HerbNo=H.No AND T.No=@KeyNo";
            sqlCommand.Parameters.AddWithValue("@KeyNo", "1" + this.KeyNo);
            sqlDataAdapter.Fill(this.TCMTable);
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
            this.dgv_TCM.DataSource = this.TCMTable;
            this.dgv_TCM.Columns["No"].HeaderText = "编号";
            this.dgv_TCM.Columns["Name"].HeaderText = "名称";
            this.dgv_TCM.Columns["Usage"].HeaderText = "用量";
            this.dgv_TCM.Columns["Price"].HeaderText = "售价/g";
            this.dgv_TCM.Columns["Efficacy"].HeaderText = "功效";
            this.dgv_TCM.Columns["Total"].HeaderText = "价格";
            lbl_HerbPrice.Text = "总价为：" + this.TCMTable.Compute("SUM(Total)", "").ToString();
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
            this.PrescriptionTable = new DataTable();
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            sqlConnection.Open();
            sqlDataAdapter.Fill(DrugTable);
            sqlCommand.CommandText = $@"SELECT D.No,D.ChineseName,P.Number,P.Usage,D.Price,D.Treat,D.Price*P.Number AS Total 
                                            FROM tb_Prescription AS P
	                                        JOIN tb_Drug AS D ON P.DrugNo=D.No AND P.No=@KeyNo";
            sqlCommand.Parameters.AddWithValue("@KeyNo", "2" + this.KeyNo);
            sqlDataAdapter.Fill(this.PrescriptionTable);
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
            this.dgv_Prescription.DataSource = this.PrescriptionTable;
            this.dgv_Prescription.Columns["No"].ReadOnly = true;
            this.dgv_Prescription.Columns["No"].HeaderText = "编号";
            this.dgv_Prescription.Columns["ChineseName"].HeaderText = "名称";
            this.dgv_Prescription.Columns["Number"].HeaderText = "数量";
            this.dgv_Prescription.Columns["Usage"].HeaderText = "用法";
            this.dgv_Prescription.Columns["Price"].HeaderText = "售价";
            this.dgv_Prescription.Columns["Treat"].HeaderText = "主治";
            this.dgv_Prescription.Columns["Total"].HeaderText = "价格";
            lbl_DrugPrice.Text = "总价为：" + this.PrescriptionTable.Compute("SUM(Total)", "").ToString();
        }
        /// <summary>
        /// 单击选择药材按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddHerb_Click(object sender, EventArgs e)
        {
            if (this.dgv_Herb.Rows.Count <= 0)
            {
                MessageBox.Show("当前已无药材！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRowView currentRowView = this.dgv_Herb.CurrentRow.DataBoundItem as DataRowView;
            DataRow currentHerbRow = currentRowView.Row;
            DataRow selectedHerbRow = this.TCMTable.NewRow();
            selectedHerbRow["No"] = currentRowView["No"];
            selectedHerbRow["Name"] = currentRowView["Name"];
            selectedHerbRow["Price"] = currentRowView["Price"];
            selectedHerbRow["Efficacy"] = currentRowView["Efficacy"];
            selectedHerbRow["Usage"] = DBNull.Value;
            currentHerbRow.Delete();
            this.TCMTable.Rows.Add(selectedHerbRow);
            lbl_HerbPrice.Text = "总价为：" + this.TCMTable.Compute("SUM(Total)", "").ToString();
        }
        /// <summary>
        /// 单击移除药材按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RemoveHerb_Click(object sender, EventArgs e)
        {
            DataRowView selectedHerb = this.dgv_TCM.CurrentRow.DataBoundItem as DataRowView;
            DataRow selectedHerbRow = selectedHerb.Row;
            DataRow deletedHerbRow = this._HerbTable.Select($"No='{selectedHerbRow["No"]}'", "", DataViewRowState.Deleted)[0];
            deletedHerbRow.RejectChanges();
            this.TCMTable.Rows.Remove(selectedHerbRow);
            lbl_HerbPrice.Text = "总价为：" + this.TCMTable.Compute("SUM(Total)", "").ToString();
        }
        /// <summary>
        /// 单击选择药品按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddDrug_Click(object sender, EventArgs e)
        {
            if (this.dgv_Drug.Rows.Count <= 0)
            {
                MessageBox.Show("当前已无药品！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRowView currentRowView = this.dgv_Drug.CurrentRow.DataBoundItem as DataRowView;
            DataRow currentDrugRow = currentRowView.Row;
            DataRow selectedDrugRow = this.PrescriptionTable.NewRow();
            selectedDrugRow["No"] = currentRowView["No"];
            selectedDrugRow["ChineseName"] = currentRowView["ChineseName"];
            selectedDrugRow["Price"] = currentRowView["Price"];
            selectedDrugRow["Number"] = DBNull.Value;
            selectedDrugRow["Usage"] = DBNull.Value;
            selectedDrugRow["Treat"] = currentRowView["Treat"];
            currentDrugRow.Delete();
            this.PrescriptionTable.Rows.Add(selectedDrugRow);
            lbl_DrugPrice.Text = "总价为：" + this.PrescriptionTable.Compute("SUM(Total)", "").ToString();
        }
        /// <summary>
        /// 单击移除药品按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RemoveDrug_Click(object sender, EventArgs e)
        {
            DataRowView selectedDrug = this.dgv_Prescription.CurrentRow.DataBoundItem as DataRowView;
            DataRow selectedDrugRow = selectedDrug.Row;
            DataRow deletedDrugRow = this._DrugTable.Select($"No='{selectedDrugRow["No"]}'", "", DataViewRowState.Deleted)[0];
            deletedDrugRow.RejectChanges();
            this.PrescriptionTable.Rows.Remove(selectedDrugRow);
            lbl_DrugPrice.Text = "总价为：" + this.PrescriptionTable.Compute("SUM(Total)", "").ToString();
        }
        /// <summary>
        /// 单击按钮提交中药药方
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
            insertCommand.CommandText = $@"INSERT INTO tb_TCM
	                                            (No,Date,HealthCardNo,DoctorNo,HerbNo,Usage)
	                                            VALUES
	                                            (@No,@Date,@HealthCardNo,@DoctorNo,@HerbNo,@Usage)";
            insertCommand.Parameters.AddWithValue("@No", "1" + this.KeyNo);
            insertCommand.Parameters.AddWithValue("@Date", DateTime.Now);
            insertCommand.Parameters.AddWithValue("@HealthCardNo", this.Patient.HealthCardNo);
            insertCommand.Parameters.AddWithValue("@DoctorNo", this.Doctor.No);
            insertCommand.Parameters.Add("@HerbNo", SqlDbType.Char, 4, "No");
            insertCommand.Parameters.Add("@Usage", SqlDbType.Char, 4, "Usage");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = insertCommand;
            sqlConnection.Open();
            int rowAffection = sqlDataAdapter.Update(this.TCMTable);
            sqlConnection.Close();
            this.SqlHelper
            .NewCommand($@"UPDATE tb_TreatRecord
	                            SET TCMPrice=@TCMPrice
	                            WHERE Date=@Date
		                            AND HealthCardNo=@HealthCardNo
		                            AND DoctorNo=@DoctorNo")
            .NewParameter("@TCMPrice", this.TCMTable.Compute("SUM(Total)", ""))
            .NewParameter("@Date", DateTime.Now)
            .NewParameter("@HealthCardNo", this.Patient.HealthCardNo)
            .NewParameter("@DoctorNo", this.Doctor.No)
            .NonQuery();
            MessageBox.Show($@"成功提交{rowAffection}个药材！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 单击按钮提交西药药方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SubmitDrug_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand insertCommand = sqlConnection.CreateCommand();
            insertCommand.Connection = sqlConnection;
            insertCommand.CommandText = $@"INSERT INTO tb_Prescription
	                                            (No,HealthCardNo,DoctorNo,Date,DrugNo,Number,Usage)
	                                            VALUES
	                                            (@No,@HealthCardNo,@DoctorNo,@Date,@DrugNo,@Number,@Usage)";
            insertCommand.Parameters.AddWithValue("@No", "2" + this.KeyNo);
            insertCommand.Parameters.AddWithValue("@HealthCardNo", this.Patient.HealthCardNo);
            insertCommand.Parameters.AddWithValue("@DoctorNo", this.Doctor.No);
            insertCommand.Parameters.AddWithValue("@Date", DateTime.Now);
            insertCommand.Parameters.Add("@DrugNo", SqlDbType.Char, 4, "No");
            insertCommand.Parameters.Add("@Number", SqlDbType.Char, 4, "Number");
            insertCommand.Parameters.Add("@Usage", SqlDbType.Char, 4, "Usage");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = insertCommand;
            sqlConnection.Open();
            int rowAffection = sqlDataAdapter.Update(this.PrescriptionTable);
            sqlConnection.Close();
            this.SqlHelper
            .NewCommand($@"UPDATE tb_TreatRecord
	                            SET PrescriptionPrice=@PrescriptionPrice
	                            WHERE Date=@Date
		                            AND HealthCardNo=@HealthCardNo
		                            AND DoctorNo=@DoctorNo")
            .NewParameter("@PrescriptionPrice", this.PrescriptionTable.Compute("SUM(Total)", ""))
            .NewParameter("@Date", DateTime.Now)
            .NewParameter("@HealthCardNo", this.Patient.HealthCardNo)
            .NewParameter("@DoctorNo", this.Doctor.No)
            .NonQuery();
            MessageBox.Show($@"成功提交{rowAffection}个药品！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
