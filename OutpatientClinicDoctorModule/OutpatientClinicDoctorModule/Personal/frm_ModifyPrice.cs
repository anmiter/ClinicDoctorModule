using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule.Personal
{
    /// <summary>
    /// 修改价目窗体
    /// </summary>
    public partial class frm_ModifyPrice : Form
    {
        public frm_ModifyPrice()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//本窗体启动位置设为屏幕中央
            this.dgv_Herb.BackgroundColor = Color.White;
            this.dgv_Herb.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Drug.BackgroundColor = Color.White;
            this.dgv_Drug.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Examine.BackgroundColor = Color.White;
            this.dgv_Examine.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            LoadHerb();
            LoadDrug();
            LoadExamine();
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
        /// 检查项目表
        /// </summary>
        private DataTable _ExamineTable;
        /// <summary>
        /// 载入药材
        /// </summary>
        public void LoadHerb()
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_HerbType";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable typeTable = new DataTable();
            DataTable herbTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(typeTable);
            sqlCommand.CommandText = "SELECT * FROM tb_Herb";
            sqlDataAdapter.Fill(herbTable);
            sqlConnection.Close();
            this._HerbTable = herbTable;
            this.dgv_Herb.Columns.Clear();
            this.dgv_Herb.DataSource = herbTable;
            this.dgv_Herb.Columns["No"].ReadOnly = true;
            this.dgv_Herb.Columns["No"].HeaderText = "编号";
            this.dgv_Herb.Columns["Name"].HeaderText = "名称";
            this.dgv_Herb.Columns["Pinyin"].HeaderText = "拼音";
            this.dgv_Herb.Columns["Effect"].HeaderText = "功效";
            this.dgv_Herb.Columns["Price"].HeaderText = "售价/g";
            this.dgv_Herb.Columns["TypeNo"].Visible = false;
            DataGridViewComboBoxColumn typeColumn = new DataGridViewComboBoxColumn();
            this.dgv_Herb.Columns.Add(typeColumn);
            typeColumn.Name = "Type";
            typeColumn.HeaderText = "类型";
            typeColumn.DataSource = typeTable;
            typeColumn.DisplayMember = "Type";
            typeColumn.ValueMember = "No";
            typeColumn.DataPropertyName = "TypeNo";
            typeColumn.DisplayIndex = 3;
            typeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_Herb.Columns[this.dgv_Herb.Columns.Count - 2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// 载入药品
        /// </summary>
        public void LoadDrug()
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_Unit";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable unitTable = new DataTable();
            DataTable drugTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(unitTable);
            sqlCommand.CommandText = "SELECT * FROM tb_Drug";
            sqlDataAdapter.Fill(drugTable);
            sqlConnection.Close();
            this._DrugTable = drugTable;
            this.dgv_Drug.Columns.Clear();
            this.dgv_Drug.DataSource = drugTable;
            this.dgv_Drug.Columns["No"].ReadOnly = true;
            this.dgv_Drug.Columns["No"].HeaderText = "编号";
            this.dgv_Drug.Columns["ChineseName"].HeaderText = "中文名";
            this.dgv_Drug.Columns["EnglishName"].HeaderText = "英文名";
            this.dgv_Drug.Columns["Pinyin"].HeaderText = "拼音";
            this.dgv_Drug.Columns["Treat"].HeaderText = "主治";
            this.dgv_Drug.Columns["Price"].HeaderText = "售价";
            this.dgv_Drug.Columns["UnitNo"].Visible = false;
            DataGridViewComboBoxColumn unitColumn = new DataGridViewComboBoxColumn();
            this.dgv_Drug.Columns.Add(unitColumn);
            unitColumn.Name = "Unit";
            unitColumn.HeaderText = "单位";
            unitColumn.DataSource = unitTable;
            unitColumn.DisplayMember = "Name";
            unitColumn.ValueMember = "No";
            unitColumn.DataPropertyName = "No";
            unitColumn.DisplayIndex = 5;
            unitColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_Drug.Columns[this.dgv_Drug.Columns.Count - 2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// 载入检查项目
        /// </summary>
        public void LoadExamine()
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_ExamineType";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable typeTable = new DataTable();
            DataTable exmaineTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(typeTable);
            sqlCommand.CommandText = $@"SELECT * FROM tb_ExamineItem";
            sqlDataAdapter.Fill(exmaineTable);
            sqlConnection.Close();
            this._ExamineTable = exmaineTable;
            this.dgv_Examine.Columns.Clear();
            this.dgv_Examine.DataSource = exmaineTable;
            this.dgv_Examine.Columns["No"].ReadOnly = true;
            this.dgv_Examine.Columns["No"].HeaderText = "项目编号";
            this.dgv_Examine.Columns["Name"].HeaderText = "项目名称";
            this.dgv_Examine.Columns["Price"].HeaderText = "价格";
            this.dgv_Examine.Columns["Introduction"].HeaderText = "简介";
            this.dgv_Examine.Columns["TypeNo"].Visible = false;
            DataGridViewComboBoxColumn typeColumn = new DataGridViewComboBoxColumn();
            this.dgv_Examine.Columns.Add(typeColumn);
            typeColumn.Name = "Type";
            typeColumn.HeaderText = "类型";
            typeColumn.DataSource = typeTable;//数据源
            typeColumn.DisplayMember = "Name";//显示的列
            typeColumn.ValueMember = "No";//对应的值
            typeColumn.DataPropertyName = "TypeNo";//两张表绑定列
            typeColumn.DisplayIndex = 2;//定位，第几列，从0开始
            typeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_Examine.Columns[this.dgv_Examine.Columns.Count - 2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// 保存药材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveHerb_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；
            SqlCommand insertCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令
            insertCommand.Connection = sqlConnection;
            insertCommand.CommandText = $@"INSERT INTO tb_Herb
	            (Name,Pinyin,TypeNo,Effect,Price)
	            VALUES
	            (@Name,@Pinyin,@TypeNo,@Effect,@Price)";
            insertCommand.Parameters.Add("@Name", SqlDbType.VarChar, 0, "Name");
            insertCommand.Parameters.Add("@Pinyin", SqlDbType.VarChar, 0, "Pinyin");
            insertCommand.Parameters.Add("@TypeNo", SqlDbType.Int, 0, "TypeNo");
            insertCommand.Parameters.Add("@Effect", SqlDbType.VarChar, 0, "Effect");
            insertCommand.Parameters.Add("@Price", SqlDbType.Decimal, 2, "Price");
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.Connection = sqlConnection;
            updateCommand.CommandText = $@"UPDATE tb_Herb
	                                        SET
		                                        Name=@Name,
		                                        Pinyin=@Pinyin,
                                                TypeNo=@TypeNo,
		                                        Effect=@Effect,
		                                        Price=@Price
	                                        WHERE
		                                        No=@No";
            updateCommand.Parameters.Add("@Name", SqlDbType.VarChar, 0, "Name");
            updateCommand.Parameters.Add("@Pinyin", SqlDbType.VarChar, 0, "Pinyin");
            updateCommand.Parameters.Add("@TypeNo", SqlDbType.Int, 0, "TypeNo");
            updateCommand.Parameters.Add("@Effect", SqlDbType.VarChar, 0, "Effect");
            updateCommand.Parameters.Add("@Price", SqlDbType.Decimal, 2, "Price");
            updateCommand.Parameters.Add("@No", SqlDbType.Int, 0, "No");
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.Connection = sqlConnection;
            deleteCommand.CommandText =
                "DELETE tb_Herb WHERE No=@No";
            deleteCommand.Parameters.Add("@No", SqlDbType.Int, 0, "No");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = insertCommand;
            sqlDataAdapter.UpdateCommand = updateCommand;
            sqlDataAdapter.DeleteCommand = deleteCommand;
            DataTable HerbTable = (DataTable)this.dgv_Herb.DataSource;
            sqlConnection.Open();
            int rowAffected = sqlDataAdapter.Update(HerbTable);
            sqlConnection.Close();
            MessageBox.Show($"更新{rowAffected}行。");

        }
        /// <summary>
        /// 保存药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveDrug_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；
            SqlCommand insertCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令
            insertCommand.Connection = sqlConnection;
            insertCommand.CommandText = $@"INSERT INTO tb_Drug
	            (ChineseName,EnglishName,Pinyin,Treat,UnitNo,Price)
	            VALUES
	            (@ChineseName,@EnglishName,@Pinyin,@Treat,@UnitNo,@Price)";
            insertCommand.Parameters.Add("@ChineseName", SqlDbType.VarChar, 0, "ChineseName");
            insertCommand.Parameters.Add("@EnglishName", SqlDbType.VarChar, 0, "EnglishName");
            insertCommand.Parameters.Add("@Pinyin", SqlDbType.VarChar, 0, "Pinyin");
            insertCommand.Parameters.Add("@Treat", SqlDbType.VarChar, 0, "Treat");
            insertCommand.Parameters.Add("@UnitNo", SqlDbType.Int, 0, "UnitNo");
            insertCommand.Parameters.Add("@Price", SqlDbType.Decimal, 2, "Price");
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.Connection = sqlConnection;
            updateCommand.CommandText = $@"UPDATE tb_Drug
	                                        SET
		                                        ChineseName=@ChineseName,
		                                        EnglishName=@EnglishName,
		                                        Pinyin=@Pinyin,
		                                        Treat=@Treat,
		                                        UnitNo=@UnitNo,
		                                        Price=@Price
	                                        WHERE
		                                        No=@No";
            updateCommand.Parameters.Add("@ChineseName", SqlDbType.VarChar, 0, "ChineseName");
            updateCommand.Parameters.Add("@EnglishName", SqlDbType.VarChar, 0, "EnglishName");
            updateCommand.Parameters.Add("@Pinyin", SqlDbType.VarChar, 0, "Pinyin");
            updateCommand.Parameters.Add("@Treat", SqlDbType.VarChar, 0, "Treat");
            updateCommand.Parameters.Add("@UnitNo", SqlDbType.Int, 0, "UnitNo");
            updateCommand.Parameters.Add("@Price", SqlDbType.Decimal, 2, "Price");
            updateCommand.Parameters.Add("@No", SqlDbType.Int, 0, "No");
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.Connection = sqlConnection;
            deleteCommand.CommandText =
                "DELETE tb_Drug WHERE No=@No";
            deleteCommand.Parameters.Add("@No", SqlDbType.Int, 0, "No");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = insertCommand;
            sqlDataAdapter.UpdateCommand = updateCommand;
            sqlDataAdapter.DeleteCommand = deleteCommand;
            DataTable DrugTable = (DataTable)this.dgv_Drug.DataSource;
            sqlConnection.Open();
            int rowAffected = sqlDataAdapter.Update(DrugTable);
            sqlConnection.Close();
            MessageBox.Show($"更新{rowAffected}行。");
        }
        /// <summary>
        /// 保存检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveExamine_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；
            SqlCommand insertCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令
            insertCommand.Connection = sqlConnection;
            insertCommand.CommandText = $@"INSERT INTO tb_ExamineItem
	                                        (Name,TypeNo,Price,Introduction)
	                                        VALUES
	                                        (@Name,@TypeNo,@Price,@Introduction)";
            insertCommand.Parameters.Add("@Name", SqlDbType.VarChar, 0, "Name");
            insertCommand.Parameters.Add("@TypeNo", SqlDbType.Int, 0, "TypeNo");
            insertCommand.Parameters.Add("@Price", SqlDbType.Decimal, 2, "Price");
            insertCommand.Parameters.Add("@Introduction", SqlDbType.VarChar, 0, "Introduction");
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.Connection = sqlConnection;
            updateCommand.CommandText = $@"UPDATE tb_ExamineItem
	                                            SET
		                                            Name=@Name,
		                                            TypeNo=@TypeNo,
		                                            Price=@Price,
		                                            Introduction=@Introduction
	                                            WHERE
	                                                No=@No";
            updateCommand.Parameters.Add("@Name", SqlDbType.VarChar, 0, "Name");
            updateCommand.Parameters.Add("@TypeNo", SqlDbType.Int, 0, "TypeNo");
            updateCommand.Parameters.Add("@Price", SqlDbType.Decimal, 2, "Price");
            updateCommand.Parameters.Add("@Introduction", SqlDbType.VarChar, 0, "Introduction");
            updateCommand.Parameters.Add("@No", SqlDbType.Int, 0, "No");
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.Connection = sqlConnection;
            deleteCommand.CommandText =
                "DELETE tb_ExamineItem WHERE No=@No";
            deleteCommand.Parameters.Add("@No", SqlDbType.Int, 0, "No");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = insertCommand;
            sqlDataAdapter.UpdateCommand = updateCommand;
            sqlDataAdapter.DeleteCommand = deleteCommand;
            DataTable ExamineTable = (DataTable)this.dgv_Examine.DataSource;
            sqlConnection.Open();
            int rowAffected = sqlDataAdapter.Update(ExamineTable);
            sqlConnection.Close();
            MessageBox.Show($"更新{rowAffected}行。");
        }
    }
}
