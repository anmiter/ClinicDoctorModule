using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using static System.Environment;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 个人中心窗体
    /// </summary>
    public partial class frm_PersonalCenter : Form
    {
        /// <summary>
        /// 医生
        /// </summary>
        Doctor Doctor { get; set; }
        /// <summary>
        /// 医生（业务逻辑层）
        /// </summary>
        private IDoctorBll DoctorBll { get; set; }
        /// <summary>
        /// 医生（数据访问层）
        /// </summary>
        private IDoctorDal DoctorDal { get; set; }
        /// <summary>
		/// SQL助手
		/// </summary>
		private SqlHelper SqlHelper { get; set; }
        /// <summary>
        /// 数据库类型
        /// </summary>
        private string DBType { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public frm_PersonalCenter()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="doctor"></param>
        public frm_PersonalCenter(Doctor doctor,string dbType) : this()
        {
            this.Doctor = doctor;
            this.lbl_No.Text = this.Doctor.No;
            this.txb_Telephone.Text = this.Doctor.Telephone;
            this.DoctorBll = new DoctorBll(this.DBType);
            this.DoctorDal = new DoctorDalSql();
            this.SqlHelper = new SqlHelper();
            DataTable departmentTable = SqlHelper.GetTable("SELECT * FROM tb_Department");
            this.cmb_Department.DataSource = departmentTable;
            this.cmb_Department.DisplayMember = "Name";
            this.cmb_Department.ValueMember = "No";
            DataTable titleTable = SqlHelper.GetTable("SELECT * FROM tb_Title");
            this.cmb_Title.DataSource = titleTable;
            this.cmb_Title.DisplayMember = "Name";
            this.cmb_Title.ValueMember = "No";
            if (this.Doctor.Name != null)
            {
                this.txb_Name.Text = this.Doctor.Name;
            }
            this.rdb_Male.Checked = this.Doctor.Gender;
            this.rdb_Female.Checked = !this.Doctor.Gender;
            if (this.Doctor.Birthdate != null)
            {
                this.dtp_Birthdate.Value = this.Doctor.Birthdate;
                this.nud_Age.Value = DateTime.Now.Year - this.Doctor.Birthdate.Year;
            }
            if (this.Doctor.IDCardNo != null)
            {
                this.txb_IDCardNo.Text = this.Doctor.IDCardNo;
            }
            if (this.Doctor.QQEmail != null)
            {
                this.txb_QQEmail.Text = this.Doctor.QQEmail;
            }
            this.cmb_Department.SelectedValue = this.Doctor.DepartmentNo;
            this.cmb_Title.SelectedValue = this.Doctor.TitleNo;
            if (this.Doctor.Introduction != null)
            {
                this.txb_Introduction.Text = this.Doctor.Introduction;
            }
            if (this.Doctor.Avatar.Length != 0) 
            {
                byte[] photoBytes = this.Doctor.Avatar;
                MemoryStream memoryStream = new MemoryStream(photoBytes);
                this.ptb_Avatar.Image = Image.FromStream(memoryStream);
            }
            this.txb_Name.Validating += Txb_Name_Validating;
            this.dtp_Birthdate.Validating += Dtp_Birthdate_Validating;
            this.txb_Introduction.Validating += Txb_Introduction_Validating;
            this.txb_IDCardNo.Validating += Txb_IDCardNo_Validating;
        }
        /// <summary>
        /// 验证身份证号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Txb_IDCardNo_Validating(object sender, CancelEventArgs e)
        {
            string ID = this.txb_IDCardNo.Text;
            this.ErrorProvider.SetError(this.txb_IDCardNo, "");
            bool isEmpty = string.IsNullOrEmpty(ID);
            if (isEmpty)
            {
                this.ErrorProvider.SetError(this.txb_IDCardNo, "身份证号不能为空");
                return;
            }
            bool isValid = this.DoctorBll.CheckIDCardNo(ID);
            if (!isValid)
            {
                this.ErrorProvider.SetError(this.txb_IDCardNo, $"身份证号格式不正确!");
                return;
            }
            this.ErrorProvider.SetError(this.txb_IDCardNo, "");
        }
        /// <summary>
        /// 验证简介
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Txb_Introduction_Validating(object sender, CancelEventArgs e)
        {
            string Introduction = this.txb_Introduction.Text;
            if (Introduction.Length > 80)
            {
                this.ErrorProvider.SetError(this.txb_Introduction, $"简介不能超过80个汉字!");
                return;
            }
            this.ErrorProvider.SetError(this.txb_Introduction, "");
        }
        /// <summary>
        /// 验证出生日期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Dtp_Birthdate_Validating(object sender, CancelEventArgs e)
        {
            if (this.dtp_Birthdate.Value > DateTime.Now)
            {
                this.ErrorProvider.SetError(this.dtp_Birthdate, $"出生日期不能大于当前日期!");
                return;
            }
            this.ErrorProvider.SetError(this.dtp_Birthdate, "");
        }
        /// <summary>
        /// 验证姓名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Txb_Name_Validating(object sender, CancelEventArgs e)
        {
            string Name = this.txb_Name.Text;
            if (Name.Length > 15)
            {
                this.ErrorProvider.SetError(this.txb_Name, $"姓名不能超过15个汉字!");
                return;
            }
            this.ErrorProvider.SetError(this.txb_Name, "");
        }
        /// <summary>
        /// 单击更新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (this.txb_Telephone.Text.Trim() != "" && this.txb_Name.Text.Trim() != "" && this.txb_IDCardNo.Text.Trim() != "" && this.txb_QQEmail.Text.Trim() != "" && this.ptb_Avatar.Image != null)
            {
                MemoryStream memoryStream = new MemoryStream();
                this.ptb_Avatar.Image.Save(memoryStream, ImageFormat.Bmp);
                byte[] photoBytes = new byte[memoryStream.Length];
                memoryStream.Seek(0, SeekOrigin.Begin);
                memoryStream.Read(photoBytes, 0, photoBytes.Length);
                this.Doctor.Name = txb_Name.Text.Trim();
                this.Doctor.Gender = this.rdb_Male.Checked;
                this.Doctor.Birthdate = this.dtp_Birthdate.Value;
                this.Doctor.IDCardNo = this.txb_IDCardNo.Text.Trim();
                this.Doctor.Telephone = this.txb_Telephone.Text.Trim();
                this.Doctor.QQEmail = this.txb_QQEmail.Text.Trim();
                this.Doctor.DepartmentNo = (int)this.cmb_Department.SelectedValue;
                this.Doctor.TitleNo = (int)this.cmb_Title.SelectedValue;
                this.Doctor.Introduction = this.txb_Introduction.Text.Trim();
                this.Doctor.Avatar = photoBytes;
                this.DoctorDal.Update(this.Doctor);
                MessageBox.Show("更新成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                MessageBox.Show("加*为必填项！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        /// <summary>
        /// 单击修改密码按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ModifyPassword_Click(object sender, EventArgs e)
        {
            frm_ModifyPassword frm_ModifyPassword = new frm_ModifyPassword(this.Doctor);
            frm_ModifyPassword.ShowDialog();
        }
        /// <summary>
        /// 单击打开照片按钮
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
        /// <summary>
        /// 电话号码更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_Telephone_TextChanged(object sender, EventArgs e)
        {
            this.txb_QQEmail.Validating += Txb_QQEmail_Validating;
        }
        /// <summary>
        /// 验证QQ邮箱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Txb_QQEmail_Validating(object sender, CancelEventArgs e)
        {
            string QQEmail = this.txb_QQEmail.Text;
            this.ErrorProvider.SetError(this.txb_QQEmail, "");
            bool isEmpty = string.IsNullOrEmpty(QQEmail);
            if (isEmpty)
            {
                this.ErrorProvider.SetError(this.txb_QQEmail, "QQ邮箱不能为空");
                return;
            }
            bool isValid = this.DoctorBll.CheckQQEmail(QQEmail);
            if (!isValid)
            {
                this.ErrorProvider.SetError(this.txb_QQEmail, $"邮箱格式应为：1111111111@qq.com");
                return;
            }
            bool isExisting = this.DoctorBll.CheckExistQQEmail(QQEmail);
            if (isExisting)
            {
                this.ErrorProvider.SetError(this.txb_QQEmail, "该QQ邮箱已被绑定");
                return;
            }
            this.ErrorProvider.SetError(this.txb_QQEmail, "");
        }

        /// <summary>
        /// QQ邮箱更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_QQEmail_TextChanged(object sender, EventArgs e)
        {
            this.txb_Telephone.Validating += Txb_Telephone_Validating;
        }
        /// <summary>
        /// 验证电话号码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Txb_Telephone_Validating(object sender, CancelEventArgs e)
        {
            string Telephone = this.txb_Telephone.Text;
            this.ErrorProvider.SetError(this.txb_Telephone, "");
            bool isEmpty = string.IsNullOrEmpty(Telephone);
            if (isEmpty)
            {
                this.ErrorProvider.SetError(this.txb_Telephone, "电话号码不能为空");
                return;
            }
            bool isValid = this.DoctorBll.CheckTelephone(Telephone);
            if (!isValid)
            {
                this.ErrorProvider.SetError(this.txb_Telephone, $"电话号码格式不正确!");
                return;
            }
            bool isExisting = this.DoctorBll.CheckExistTelephone(Telephone);
            if (isExisting)
            {
                this.ErrorProvider.SetError(this.txb_Telephone, "该电话号码已被绑定");
                return;
            }
            this.ErrorProvider.SetError(this.txb_Telephone, "");
        }
        /// <summary>
        /// 进入窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_PersonalCenter_Load(object sender, EventArgs e)
        {
            this.txb_Name.Focus();
        }
    }
}
