using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule.Consultation
{
    public partial class frm_CallNumber : Form
    {
        public frm_CallNumber()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.dgv_Queue.AllowUserToAddRows = false;
            this.dgv_Queue.BackgroundColor = Color.White;
            this.dgv_Queue.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }
        /// <summary>
        /// 医生编号
        /// </summary>
        string DoctorNo;
        /// <summary>
        /// 排号表
        /// </summary>
        private DataTable _QueueTable;
        /// <summary>
        /// 患者编号
        /// </summary>
        string _PatientIDCard;
        /// <summary>
        /// 传参,载入排号表
        /// </summary>
        /// <param name="DoctorNo"></param>
        public frm_CallNumber(string doctorNo):this()
        {
            this.DoctorNo = doctorNo;
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接
            sqlCommand.Connection = sqlConnection;//将SQL命令的连接属性指向SQL连接
            sqlCommand.CommandText = $@"SELECT Q.DoctorNo,P.PatientIDCard,P.Name,Q.Date,Q.Number,QS.State
	                                        FROM tb_Queue AS Q JOIN tb_QueueState AS QS ON Q.StateNo=QS.No 
                                                JOIN tb_Patient AS P ON Q.PaitentIDCard=P.PatientIDCard
	                                        WHERE Q.DoctorNo='{this.DoctorNo}' 
                                                AND 
                                                CAST(Q.Date AS DATE) = CAST(GETDATE() AS DATE)";//指定SQL命令的命令文本；该命令查询所有药材，以用作数据网格视图数据源
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//声明并实例化SQL数据适配器
            sqlDataAdapter.SelectCommand = sqlCommand;//将SQL数据适配器的查询命令属性指向SQL命令
            DataTable QueueTable = new DataTable(); // 设置DataTable的名称
            this._QueueTable = new DataTable();
            sqlConnection.Open();//打开SQL连接
            sqlDataAdapter.Fill(this._QueueTable);//SQL数据适配器读取数据，并填充药材数据表
            sqlConnection.Close();//关闭SQL连接
            this.dgv_Queue.Columns.Clear();//数据网格视图的列集合清空
            this.dgv_Queue.DataSource = this._QueueTable;//将数据网格视图的数据源设为药材数据表
            this.dgv_Queue.Columns["PatientIDCard"].ReadOnly = true;
            this.dgv_Queue.Columns["Name"].ReadOnly = true;
            this.dgv_Queue.Columns["Number"].ReadOnly = true;
            this.dgv_Queue.Columns["State"].ReadOnly = true;
            this.dgv_Queue.Columns["PatientIDCard"].HeaderText = "医保卡号";//将数据网格视图的指定列的表头文本设为中文
            this.dgv_Queue.Columns["Name"].HeaderText = "姓名";
            this.dgv_Queue.Columns["Number"].HeaderText = "号码";
            this.dgv_Queue.Columns["State"].HeaderText = "状态";
            this.dgv_Queue.Columns["DoctorNo"].Visible = false;
            this.dgv_Queue.Columns["Date"].Visible = false;
        }
        /// <summary>
        /// 单击叫号按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Call_Click(object sender, EventArgs e)
        {
            if (this._PatientIDCard == null)
            {
                MessageBox.Show("请选择病人！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frm_Home frm_Home = new frm_Home(this.DoctorNo, this._PatientIDCard);
                frm_Home.ShowDialog();  
            }
        }
        /// <summary>
        /// 单击排号表中的某一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Queue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView currentPatientRowView =
                this.dgv_Queue.CurrentRow.DataBoundItem as DataRowView;//将课程数据网格视图的当前行的数据绑定项，转换为数据行视图；
            DataRow//声明数据行；
                currentPatientRow = currentPatientRowView.Row;//通过当前的数据行视图，获取其相应的数据行；
            this._PatientIDCard = currentPatientRow["PatientIDCard"].ToString();//逐一将当前课程数据行的各列值，赋予已选课程数据行的相应列；
            this.txb_PatientIDCard.Text = this._PatientIDCard;

            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"SELECT P.PatientIDCard,P.Identification,P.Name,P.Age,P.Gender,P.Birthday,P.Telephone,P.MaritalState,C.Name AS ComeFrom,P.DrugAllergyHistory
	                                        FROM tb_Patient AS P JOIN tb_ComeFrom AS C ON P.ComeFromNo=C.No
                                            WHERE P.PatientIDCard={this._PatientIDCard}";
            sqlConnection.Open();//打开SQL连接；
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                if (sqlDataReader["PatientIDCard"] != DBNull.Value)
                {
                    this.txb_PatientIDCard.Text = sqlDataReader["PatientIDCard"].ToString();
                }
                if (sqlDataReader["Identification"] != DBNull.Value)
                {
                    this.txb_Identification.Text = sqlDataReader["Identification"].ToString();
                }
                if (sqlDataReader["Name"] != DBNull.Value)
                {
                    this.txb_Name.Text = sqlDataReader["Name"].ToString();
                }
                if (sqlDataReader["Age"] != DBNull.Value)
                {
                    this.nud_Age.Value = decimal.Parse(sqlDataReader["Age"].ToString());
                }
                if (sqlDataReader["Gender"] != DBNull.Value)
                {
                    this.rdb_Male.Checked = (bool)sqlDataReader["Gender"];
                    this.rdb_Female.Checked = !(bool)sqlDataReader["Gender"];
                }
                if (sqlDataReader["BirthDay"] != DBNull.Value)
                {
                    this.dtp_Birthdate.Value = (DateTime)sqlDataReader["BirthDay"];
                }
                if (sqlDataReader["Telephone"] != DBNull.Value)
                {
                    this.txb_Telephone.Text = sqlDataReader["Telephone"].ToString();
                }
                if (sqlDataReader["MaritalState"] != DBNull.Value)
                {
                    this.rdb_Married.Checked = (bool)sqlDataReader["MaritalState"];
                    this.rdb_UnMarried.Checked = !(bool)sqlDataReader["MaritalState"];
                }
                if (sqlDataReader["ComeFrom"] != DBNull.Value)
                {
                    this.txb_ComeFrom.Text = sqlDataReader["ComeFrom"].ToString();
                }
                if (sqlDataReader["DrugAllergyHistory"] != DBNull.Value)
                {
                    this.txb_AllergyHistory.Text = sqlDataReader["DrugAllergyHistory"].ToString();
                }
            }
            sqlConnection.Close();
        }
        private void frm_CallNumber_Load(object sender, EventArgs e)
        {

        }
    }
}
