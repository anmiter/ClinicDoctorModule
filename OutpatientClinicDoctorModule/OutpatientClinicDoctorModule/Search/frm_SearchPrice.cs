using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule.Search
{
    /// <summary>
    /// 价目查询窗体
    /// </summary>
    public partial class frm_SearchPrice : Form
    {
        public frm_SearchPrice()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//本窗体启动位置设为屏幕中央
            this.dgv_Herb.AllowUserToAddRows = false;//数据网格视图不允许用户添加行
            this.dgv_Herb.RowHeadersVisible = false;//数据网格视图的行标题不可见
            this.dgv_Herb.BackgroundColor = Color.White;//数据网格视图的背景色设为白色
            this.dgv_Herb.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;//数据网格视图的自动调整列宽模式设为显示所有单元格
            this.dgv_Drug.AllowUserToAddRows = false;//数据网格视图不允许用户添加行
            this.dgv_Drug.RowHeadersVisible = false;//数据网格视图的行标题不可见
            this.dgv_Drug.BackgroundColor = Color.White;//数据网格视图的背景色设为白色
            this.dgv_Drug.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;//数据网格视图的自动调整列宽模式设为显示所有单元格
            this.dgv_Examine.AllowUserToAddRows = false;//数据网格视图不允许用户添加行
            this.dgv_Examine.RowHeadersVisible = false;//数据网格视图的行标题不可见
            this.dgv_Examine.BackgroundColor = Color.White;//数据网格视图的背景色设为白色
            this.dgv_Examine.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;//数据网格视图的自动调整列宽模式设为显示所有单元格
            LoadHerb();
            LoadDrug();//载入药品
            LoadExamine();//载入检查项目

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
        /// 载入药材
        /// </summary>
        public void LoadHerb()
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接
            sqlCommand.Connection = sqlConnection;//将SQL命令的连接属性指向SQL连接
            sqlCommand.CommandText = $@"SELECT H.No,H.Name,H.Price,T.Type,H.Pinyin,H.Effect 
                                            FROM tb_Herb AS H JOIN tb_HerbType AS T ON H.TypeNo=T.No";//指定SQL命令的命令文本；该命令查询所有药材，以用作数据网格视图数据源
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//声明并实例化SQL数据适配器
            sqlDataAdapter.SelectCommand = sqlCommand;//将SQL数据适配器的查询命令属性指向SQL命令
            DataTable HerbTable = new DataTable("HerbTable"); // 设置DataTable的名称  
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;//设置SQL数据适配器在缺少架构时的动作为追加主键，从而获取数据库中定义的主键，否则无法根据编号搜索药材
            sqlConnection.Open();//打开SQL连接
            sqlDataAdapter.Fill(HerbTable);//SQL数据适配器读取数据，并填充药材数据表
            sqlConnection.Close();//关闭SQL连接
            this._HerbTable = HerbTable;
            this._HerbViewByName = new DataView();//实例化本窗体的药材数据视图，用于按照名称进行快速查询
            this._HerbViewByName.Table = HerbTable;//设置药材数据视图对应的数据表
            this._HerbViewByName.Sort = "Name ASC";//设置药材数据视图的排序条件，即查询所覆盖的列
            this.dgv_Herb.Columns.Clear();//数据网格视图的列集合清空
            this.dgv_Herb.DataSource = HerbTable;//将数据网格视图的数据源设为药材数据表
            this.dgv_Herb.Columns["No"].ReadOnly = true;
            this.dgv_Herb.Columns["No"].HeaderText = "编号";//将数据网格视图的指定列的表头文本设为中文
            this.dgv_Herb.Columns["Name"].HeaderText = "名称";
            this.dgv_Herb.Columns["Price"].HeaderText = "售价/g";
            this.dgv_Herb.Columns["Type"].HeaderText = "类别";
            this.dgv_Herb.Columns["Pinyin"].HeaderText = "拼音";
            this.dgv_Herb.Columns["Effect"].HeaderText = "功效";
        }
        /// <summary>
        /// 载入药品
        /// </summary>
        public void LoadDrug()
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接
            sqlCommand.Connection = sqlConnection;//将SQL命令的连接属性指向SQL连接
            sqlCommand.CommandText = $@"SELECT D.No,D.ChineseName,D.Price,U.Name,D.Treat,D.Pinyin,D.EnglishName
	                                        FROM tb_Drug AS D JOIN tb_Unit AS U ON D.UnitNo=U.No";//指定SQL命令的命令文本；该命令查询所有药品，以用作数据网格视图数据源
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//声明并实例化SQL数据适配器
            sqlDataAdapter.SelectCommand = sqlCommand;//将SQL数据适配器的查询命令属性指向SQL命令
            DataTable DrugTable = new DataTable("DrugTable"); // 设置DataTable的名称  
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;//设置SQL数据适配器在缺少架构时的动作为追加主键，从而获取数据库中定义的主键，否则无法根据编号搜索药品
            sqlConnection.Open();//打开SQL连接
            sqlDataAdapter.Fill(DrugTable);//SQL数据适配器读取数据，并填充药品数据表
            sqlConnection.Close();//关闭SQL连接
            this._DrugTable = DrugTable;
            this._DrugViewByName = new DataView();//实例化本窗体的药品数据视图，用于按照名称进行快速查询
            this._DrugViewByName.Table = DrugTable;//设置药品数据视图对应的数据表
            this._DrugViewByName.Sort = "ChineseName ASC";//设置药品数据视图的排序条件，即查询所覆盖的列
            this.dgv_Drug.Columns.Clear();//数据网格视图的列集合清空
            this.dgv_Drug.DataSource = DrugTable;//将数据网格视图的数据源设为药品数据表
            this.dgv_Drug.Columns["No"].ReadOnly = true;
            this.dgv_Drug.Columns["No"].HeaderText = "编号";//将数据网格视图的指定列的表头文本设为中文
            this.dgv_Drug.Columns["ChineseName"].HeaderText = "名称";
            this.dgv_Drug.Columns["Price"].HeaderText = "售价";
            this.dgv_Drug.Columns["Name"].HeaderText = "单位";
            this.dgv_Drug.Columns["Treat"].HeaderText = "主治";
            this.dgv_Drug.Columns["Pinyin"].HeaderText = "拼音";
            this.dgv_Drug.Columns["EnglishName"].HeaderText = "英文名";
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
            sqlCommand.Connection = sqlConnection;//将SQL命令的连接属性指向SQL连接
            sqlCommand.CommandText = $@"SELECT E.No,E.Name,E.Price,T.Name AS Type,E.Introduction
	                                        FROM tb_ExamineItem AS E JOIN tb_ExamineType AS T ON E.TypeNo=T.No";//指定SQL命令的命令文本；该命令查询所有检查项目，以用作数据网格视图数据源
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//声明并实例化SQL数据适配器
            sqlDataAdapter.SelectCommand = sqlCommand;//将SQL数据适配器的查询命令属性指向SQL命令
            DataTable ExamineTable = new DataTable("ExamineTable");
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;//设置SQL数据适配器在缺少架构时的动作为追加主键，从而获取数据库中定义的主键，否则无法根据编号搜索检查项目
            sqlConnection.Open();//打开SQL连接
            sqlDataAdapter.Fill(ExamineTable);//SQL数据适配器读取数据，并填充检查项目数据表
            sqlConnection.Close();//关闭SQL连接
            this._ExamineTable = ExamineTable;
            this._ExamineViewByName = new DataView();//实例化本窗体的检查项目数据视图，用于按照名称进行快速查询
            this._ExamineViewByName.Table = ExamineTable;//设置检查项目数据视图对应的数据表
            this._ExamineViewByName.Sort = "Name ASC";//设置检查项目数据视图的排序条件，即查询所覆盖的列
            this.dgv_Examine.Columns.Clear();//数据网格视图的列集合清空
            this.dgv_Examine.DataSource = ExamineTable;//将数据网格视图的数据源设为检查项目数据表
            this.dgv_Examine.Columns["No"].ReadOnly = true;
            this.dgv_Examine.Columns["No"].HeaderText = "编号";//将数据网格视图的指定列的表头文本设为中文
            this.dgv_Examine.Columns["Name"].HeaderText = "名称";
            this.dgv_Examine.Columns["Price"].HeaderText = "价格";
            this.dgv_Examine.Columns["Type"].HeaderText = "类型";
            this.dgv_Examine.Columns["Introduction"].HeaderText = "简介";
        }
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
                DataTable searchResultTable = this._HerbTable.Clone();//借助本窗体的药材数据表的方法Clone，创建相同架构的空表，用于保存搜索结果所在数据行；
                searchResultTable.ImportRow(herbRow);//将（复制后的）数据行导入数据表；
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
                DataTable searchResultTable = this._DrugTable.Clone();//借助本窗体的药品数据表的方法Clone，创建相同架构的空表，用于保存搜索结果所在数据行；
                searchResultTable.ImportRow(drugRow);//将（复制后的）数据行导入数据表；
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
            if (this.txb_ExamineNo.Text.Trim() != "")
            {
                DataRow ExamineRow = this._ExamineTable.Rows.Find(this.txb_ExamineNo.Text.Trim());
                DataTable searchResultTable = this._ExamineTable.Clone();//借助本窗体的检查项目数据表的方法Clone，创建相同架构的空表，用于保存搜索结果所在数据行；
                searchResultTable.ImportRow(ExamineRow);//将（复制后的）数据行导入数据表；
                this.dgv_Examine.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 单击根据名称搜索按钮搜索药材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchHerbByName_Click(object sender, EventArgs e)
        {
            DataRowView[] searchResultRowViews =
                this._HerbViewByName.FindRows(this.txb_HerbName.Text.Trim());//借助本窗体的按名称排序的药材数据视图的方法FindRows，根据排序列（即药材名称）快速查找相应药材；由于该列并非主键，可能返回多行查询结果，故返回数据行视图数组；数据行视图数组不能直接作为数据源，需转为列表后方可作为数据源；
            DataTable searchResultTable = this._HerbTable.Clone();//借助本窗体的药材数据表的方法Clone，创建相同架构的空表，用于保存搜索结果所在数据行；
            foreach (DataRowView dataRowView in searchResultRowViews)//遍历搜索结果所在数据行视图数组；
            {
                searchResultTable.ImportRow(dataRowView.Row);//通过每条数据行视图的属性Row获取相应的数据行，并导入数据表；
            }
            this.dgv_Herb.DataSource = searchResultTable;//将数据网格视图的数据源设为搜索结果数据表；
        }
        /// <summary>
        /// 单击根据名称搜索按钮搜索药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchDrugByName_Click(object sender, EventArgs e)
        {
            DataRowView[] searchResultRowViews =
                this._DrugViewByName.FindRows(this.txb_DrugName.Text.Trim());//借助本窗体的按名称排序的药品数据视图的方法FindRows，根据排序列（即药品名称）快速查找相应药品；由于该列并非主键，可能返回多行查询结果，故返回数据行视图数组；数据行视图数组不能直接作为数据源，需转为列表后方可作为数据源；
            DataTable searchResultTable = this._DrugTable.Clone();//借助本窗体的药品数据表的方法Clone，创建相同架构的空表，用于保存搜索结果所在数据行；
            foreach (DataRowView dataRowView in searchResultRowViews)//遍历搜索结果所在数据行视图数组；
            {
                searchResultTable.ImportRow(dataRowView.Row);//通过每条数据行视图的属性Row获取相应的数据行，并导入数据表；
            }
            this.dgv_Drug.DataSource = searchResultTable;//将数据网格视图的数据源设为搜索结果数据表；
        }
        /// <summary>
        /// 单击根据名称搜索按钮搜索检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchExamineByName_Click(object sender, EventArgs e)
        {
            DataRowView[] searchResultRowViews =
                this._ExamineViewByName.FindRows(this.txb_ExamineName.Text.Trim());//借助本窗体的按名称排序的检查项目数据视图的方法FindRows，根据排序列（即项目名称）快速查找相应检查项目；由于该列并非主键，可能返回多行查询结果，故返回数据行视图数组；数据行视图数组不能直接作为数据源，需转为列表后方可作为数据源；
            DataTable searchResultTable = this._ExamineTable.Clone();//借助本窗体的检查项目数据表的方法Clone，创建相同架构的空表，用于保存搜索结果所在数据行；
            foreach (DataRowView dataRowView in searchResultRowViews)//遍历搜索结果所在数据行视图数组；
            {
                searchResultTable.ImportRow(dataRowView.Row);//通过每条数据行视图的属性Row获取相应的数据行，并导入数据表；
            }
            this.dgv_Examine.DataSource = searchResultTable;//将数据网格视图的数据源设为搜索结果数据表；
        }
        /// <summary>
        /// 单击根据关键字搜索按钮搜索药材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_HerbKeyWord_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接
            sqlCommand.Connection = sqlConnection;//将SQL命令的连接属性指向SQL连接

            sqlCommand.CommandText = @"SELECT H.No,H.Name,H.Price,T.Type,H.Pinyin,H.Effect 
	                                    FROM tb_Herb AS H JOIN tb_HerbType AS T ON H.TypeNo=T.No
	                                    WHERE H.Name LIKE '%' + @KeyWord + '%' OR T.Type LIKE '%' + @KeyWord + '%'";//指定SQL命令的命令文本；该命令查询所有药品，以用作数据网格视图数据源
            sqlCommand.Parameters.Add("@KeyWord", SqlDbType.VarChar).Value = this.txb_HerbKeyWord.Text.Trim();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//声明并实例化SQL数据适配器
            sqlDataAdapter.SelectCommand = sqlCommand;//将SQL数据适配器的查询命令属性指向SQL命令
            DataTable HerbTable = new DataTable("HerbTable"); // 设置DataTable的名称  
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;//设置SQL数据适配器在缺少架构时的动作为追加主键，从而获取数据库中定义的主键，否则无法根据编号搜索药品
            sqlConnection.Open();//打开SQL连接
            sqlDataAdapter.Fill(HerbTable);//SQL数据适配器读取数据，并填充药品数据表
            sqlConnection.Close();//关闭SQL连接
            this._HerbTable = HerbTable;
            this._HerbViewByName = new DataView();//实例化本窗体的药品数据视图，用于按照名称进行快速查询
            this._HerbViewByName.Table = HerbTable;//设置药品数据视图对应的数据表
            this._HerbViewByName.Sort = "Name ASC";//设置药品数据视图的排序条件，即查询所覆盖的列
            this.dgv_Herb.Columns.Clear();//数据网格视图的列集合清空
            this.dgv_Herb.DataSource = HerbTable;//将数据网格视图的数据源设为药材数据表
            this.dgv_Herb.Columns["No"].ReadOnly = true;
            this.dgv_Herb.Columns["No"].HeaderText = "编号";//将数据网格视图的指定列的表头文本设为中文
            this.dgv_Herb.Columns["Name"].HeaderText = "名称";
            this.dgv_Herb.Columns["Price"].HeaderText = "售价/g";
            this.dgv_Herb.Columns["Type"].HeaderText = "类别";
            this.dgv_Herb.Columns["Pinyin"].HeaderText = "拼音";
            this.dgv_Herb.Columns["Effect"].HeaderText = "功效";
        }
        /// <summary>
        /// 单击根据关键字搜索按钮搜索药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_DrugKeyWord_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接
            sqlCommand.Connection = sqlConnection;//将SQL命令的连接属性指向SQL连接

            sqlCommand.CommandText = @"SELECT D.No,D.ChineseName,D.Price,U.Name,D.Treat,D.Pinyin,D.EnglishName
	                                    FROM tb_Drug AS D JOIN tb_Unit AS U ON D.UnitNo=U.No
	                                    WHERE D.ChineseName LIKE '%' + @KeyWord + '%' OR D.Treat LIKE '%' + @KeyWord + '%'";//指定SQL命令的命令文本；该命令查询所有药品，以用作数据网格视图数据源
            sqlCommand.Parameters.Add("@KeyWord", SqlDbType.VarChar).Value = this.txb_DrugKeyWord.Text.Trim();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//声明并实例化SQL数据适配器
            sqlDataAdapter.SelectCommand = sqlCommand;//将SQL数据适配器的查询命令属性指向SQL命令
            DataTable DrugTable = new DataTable("DrugTable"); // 设置DataTable的名称  
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;//设置SQL数据适配器在缺少架构时的动作为追加主键，从而获取数据库中定义的主键，否则无法根据编号搜索药品
            sqlConnection.Open();//打开SQL连接
            sqlDataAdapter.Fill(DrugTable);//SQL数据适配器读取数据，并填充药品数据表
            sqlConnection.Close();//关闭SQL连接
            this._DrugTable = DrugTable;
            this._DrugViewByName = new DataView();//实例化本窗体的药品数据视图，用于按照名称进行快速查询
            this._DrugViewByName.Table = DrugTable;//设置药品数据视图对应的数据表
            this._DrugViewByName.Sort = "ChineseName ASC";//设置药品数据视图的排序条件，即查询所覆盖的列
            this.dgv_Drug.Columns.Clear();//数据网格视图的列集合清空
            this.dgv_Drug.DataSource = DrugTable;//将数据网格视图的数据源设为药品数据表
            this.dgv_Drug.Columns["No"].ReadOnly = true;
            this.dgv_Drug.Columns["No"].HeaderText = "编号";//将数据网格视图的指定列的表头文本设为中文
            this.dgv_Drug.Columns["ChineseName"].HeaderText = "名称";
            this.dgv_Drug.Columns["Price"].HeaderText = "售价";
            this.dgv_Drug.Columns["Name"].HeaderText = "单位";
            this.dgv_Drug.Columns["Treat"].HeaderText = "主治";
            this.dgv_Drug.Columns["Pinyin"].HeaderText = "拼音";
            this.dgv_Drug.Columns["EnglishName"].HeaderText = "英文名";
        }
        /// <summary>
        /// 单击根据关键字搜索按钮搜索检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_ExamineKeyWord_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.Connection = sqlConnection;//将SQL命令的连接属性指向SQL连接
            sqlCommand.CommandText = @"SELECT E.No,E.Name,E.Price,T.Name AS Type,E.Introduction
	                                    FROM tb_ExamineItem AS E JOIN tb_ExamineType AS T ON E.TypeNo=T.No
                                        WHERE E.Name LIKE '%' + @KeyWord + '%' OR T.Name LIKE '%' + @KeyWord + '%'";//指定SQL命令的命令文本；该命令查询所有检查项目，以用作数据网格视图数据源
            sqlCommand.Parameters.Add("@KeyWord", SqlDbType.VarChar).Value = this.txb_ExamineKeyWord.Text.Trim();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//声明并实例化SQL数据适配器
            sqlDataAdapter.SelectCommand = sqlCommand;//将SQL数据适配器的查询命令属性指向SQL命令
            DataTable ExamineTable = new DataTable("ExamineTable");
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;//设置SQL数据适配器在缺少架构时的动作为追加主键，从而获取数据库中定义的主键，否则无法根据编号搜索检查项目
            sqlConnection.Open();//打开SQL连接
            sqlDataAdapter.Fill(ExamineTable);//SQL数据适配器读取数据，并填充检查项目数据表
            sqlConnection.Close();//关闭SQL连接
            this._ExamineTable = ExamineTable;
            this._ExamineViewByName = new DataView();//实例化本窗体的检查项目数据视图，用于按照名称进行快速查询
            this._ExamineViewByName.Table = ExamineTable;//设置检查项目数据视图对应的数据表
            this._ExamineViewByName.Sort = "Name ASC";//设置检查项目数据视图的排序条件，即查询所覆盖的列
            this.dgv_Examine.Columns.Clear();//数据网格视图的列集合清空
            this.dgv_Examine.DataSource = ExamineTable;//将数据网格视图的数据源设为检查项目数据表
            this.dgv_Examine.Columns["No"].ReadOnly = true;
            this.dgv_Examine.Columns["No"].HeaderText = "编号";//将数据网格视图的指定列的表头文本设为中文
            this.dgv_Examine.Columns["Name"].HeaderText = "名称";
            this.dgv_Examine.Columns["Price"].HeaderText = "价格";
            this.dgv_Examine.Columns["Type"].HeaderText = "类型";
            this.dgv_Examine.Columns["Introduction"].HeaderText = "简介";
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
        }
        /// <summary>
        /// 单击重新载入按钮载入检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LoadExamine_Click(object sender, EventArgs e)
        {
            LoadExamine();
            this.txb_ExamineName.Clear();
            this.txb_ExamineNo.Clear();
            this.txb_ExamineKeyWord.Clear();
        }
        /// <summary>
        /// 根据拼音搜索药材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_HerbPinyin_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 根据拼音搜索药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_DrugPinyin_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 根据拼音搜索检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_ExaminePinyin_TextChanged(object sender, EventArgs e)
        {

        }
        private void tp_Drug_Click(object sender, EventArgs e)
        {

        }
    }
}
