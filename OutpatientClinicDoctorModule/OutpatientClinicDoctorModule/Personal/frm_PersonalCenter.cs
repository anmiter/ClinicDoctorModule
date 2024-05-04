using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using static System.Environment;

namespace OutpatientClinicDoctorModule.Personal
{
    /// <summary>
    /// 个人中心窗体
    /// </summary>
    public partial class frm_PersonalCenter : Form
    {
        public frm_PersonalCenter()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//本窗体启动位置设为屏幕中央
        }
        /// <summary>
        /// 患者编号
        /// </summary>
        string DoctorNo;
        /// <summary>
        /// 传参载入
        /// </summary>
        /// <param name="id"></param>
        public frm_PersonalCenter(string doctorNo) : this()
        {
            this.DoctorNo = doctorNo;
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand1 = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
            SqlCommand sqlCommand3 = sqlConnection.CreateCommand();
            sqlCommand1.Connection = sqlConnection;
            sqlCommand2.Connection = sqlConnection;
            sqlCommand3.Connection = sqlConnection;
            sqlCommand1.CommandText = $@"SELECT * FROM tb_Department";
            sqlCommand2.CommandText = $@"SELECT * FROM tb_Title";
            sqlCommand3.CommandText = $@"SELECT * FROM tb_Doctor WHERE No='{this.DoctorNo}'";
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
            sqlDataAdapter1.SelectCommand = sqlCommand1;
            sqlDataAdapter2.SelectCommand = sqlCommand2;
            DataTable departmentTable = new DataTable();
            DataTable titleTable = new DataTable();
            sqlConnection.Open();//打开SQL连接；
            sqlDataAdapter1.Fill(departmentTable);
            this.cmb_Department.DataSource = departmentTable;
            this.cmb_Department.DisplayMember = "Name";
            this.cmb_Department.ValueMember = "No";
            sqlDataAdapter2.Fill(titleTable);
            this.cmb_Title.DataSource = titleTable;
            this.cmb_Title.DisplayMember = "Name";
            this.cmb_Title.ValueMember = "No";
            SqlDataReader sqlDataReader = sqlCommand3.ExecuteReader();
            if (sqlDataReader.Read())
            {
                this.lbl_DoctorNo.Text = sqlDataReader["No"].ToString();
                if (sqlDataReader["Name"] != DBNull.Value)
                {
                    this.txb_Name.Text = sqlDataReader["Name"].ToString();
                }
                if (sqlDataReader["Gender"] != DBNull.Value)
                {
                    this.rdb_Male.Checked = (bool)sqlDataReader["Gender"];
                    this.rdb_Female.Checked = !(bool)sqlDataReader["Gender"];
                }
                if (sqlDataReader["Age"] != DBNull.Value)
                {
                    this.nud_Age.Value = decimal.Parse(sqlDataReader["Age"].ToString());
                }
                if (sqlDataReader["BirthDate"] != DBNull.Value)
                {
                    this.dtp_Birthdate.Value = (DateTime)sqlDataReader["BirthDate"];
                }
                if (sqlDataReader["Identification"] != DBNull.Value)
                {
                    this.txb_Identification.Text = sqlDataReader["Identification"].ToString();
                }
                if (sqlDataReader["Telephone"] != DBNull.Value)
                {
                    this.txb_Telephone.Text = sqlDataReader["Telephone"].ToString();
                }
                if (sqlDataReader["QQEmail"] != DBNull.Value)
                {
                    this.txb_Email.Text = sqlDataReader["QQEmail"].ToString();
                }
                if (sqlDataReader["DepartmentNo"] != DBNull.Value)
                {
                    this.cmb_Department.SelectedValue = (int)sqlDataReader["DepartmentNo"];
                }
                if (sqlDataReader["TitleNo"] != DBNull.Value)
                {
                    this.cmb_Title.SelectedValue = (int)sqlDataReader["TitleNo"];
                }
                if (sqlDataReader["Introduction"] != DBNull.Value)
                {
                    this.txb_Introduction.Text = sqlDataReader["Introduction"].ToString();
                }
                if (sqlDataReader["Avatar"] != DBNull.Value)
                {
                    byte[] photoBytes = (byte[])sqlDataReader["Avatar"];
                    MemoryStream memoryStream = new MemoryStream(photoBytes);//内存流
                    this.ptb_Avatar.Image = Image.FromStream(memoryStream);
                }
            }
            sqlConnection.Close();
        }
        /// <summary>
        /// 单击更新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (this.txb_Telephone.Text.Trim() != "" && this.txb_Name.Text.Trim() != "" && this.txb_Identification.Text.Trim() != "" && this.txb_Email.Text.Trim() != "" && this.ptb_Avatar.Image != null)
            {
                if (CheckFunction.CheckID(this.txb_Identification.Text.Trim()))
                {
                    if (CheckFunction.CheckTelephone(this.txb_Telephone.Text.Trim()))
                    {
                        if (CheckFunction.CheckMail(this.txb_Email.Text.Trim()))
                        {
                            MemoryStream memoryStream = new MemoryStream();
                            this.ptb_Avatar.Image.Save(memoryStream, ImageFormat.Bmp);
                            byte[] photoBytes = new byte[memoryStream.Length];
                            memoryStream.Seek(0, SeekOrigin.Begin);
                            memoryStream.Read(photoBytes, 0, photoBytes.Length);
                            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
                            sqlConnection.ConnectionString =
                                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

                            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
                            sqlCommand.Connection = sqlConnection;
                            sqlCommand.CommandText =
                                $@"UPDATE tb_Doctor
	                                    SET Name=@Name
	                                    ,Gender=@Gender
	                                    ,Age=@Age
	                                    ,Birthdate=@BirthDate
	                                    ,Identification=@Identification
	                                    ,Telephone=@Telephone
	                                    ,QQEmail=@QQEmail
	                                    ,DepartmentNo=@DepartmentNo
	                                    ,TitleNo=@TitleNo
	                                    ,Introduction=@Introduction
	                                    ,Avatar=@Avatar
	                                    WHERE No={this.DoctorNo}";
                            sqlCommand.Parameters.AddWithValue("@Name", this.txb_Name.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@Gender", this.rdb_Male.Checked);
                            sqlCommand.Parameters.AddWithValue("@Age", this.nud_Age.Value);
                            sqlCommand.Parameters.AddWithValue("@BirthDate", this.dtp_Birthdate.Value);
                            sqlCommand.Parameters.AddWithValue("@Identification", this.txb_Identification.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@Telephone", this.txb_Telephone.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@QQEmail", this.txb_Email.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@DepartmentNo", (int)this.cmb_Department.SelectedValue);
                            sqlCommand.Parameters.AddWithValue("@TitleNo", (int)this.cmb_Title.SelectedValue);
                            sqlCommand.Parameters.AddWithValue("@Introduction", this.txb_Introduction.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@Avatar", photoBytes);
                            sqlConnection.Open();
                            int rowAffected = sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                            if (rowAffected == 1)
                            {
                                MessageBox.Show("更新成功！");
                            }
                            else
                            {
                                MessageBox.Show("更新失败，可再次尝试！");
                            }
                        }
                        else
                        {
                            MessageBox.Show("QQ邮箱格式错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txb_Email.Focus();
                            this.txb_Email.SelectAll();
                        }
                    }
                    else
                    {
                        MessageBox.Show("手机号格式错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txb_Telephone.Focus();
                        this.txb_Telephone.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("身份证号格式错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txb_Identification.Focus();
                    this.txb_Identification.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("加*为必填项！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// 单击修改密码按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ModifyPassword_Click(object sender, EventArgs e)
        {
            Personal.frm_ModifyPassword frm_ModifyPassword = new Personal.frm_ModifyPassword(this.DoctorNo);
            frm_ModifyPassword.ShowDialog();
        }
        /// <summary>
        /// 点击打开照片按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OpenPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPhotoDialog = new OpenFileDialog()
            {
                Title = "打开照片文件"
                ,
                Filter = "图像文件|*.bmp;*.jpg;*png;*gif"
                ,
                InitialDirectory = GetFolderPath(SpecialFolder.MyPictures)
            };
            if (openPhotoDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openPhotoDialog.FileName;
                this.ptb_Avatar.Image = Image.FromFile(fileName);
            }
        }
    }
}
