using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule
{
    public partial class frm_CallNumber : Form
    {
        /// <summary>
        /// 医生
        /// </summary>
        Doctor Doctor { get; set; }
        /// <summary>
        /// 患者
        /// </summary>
        Patient Patient { get; set; }
        /// <summary>
        /// 患者（业务逻辑层）
        /// </summary>
        private IPatientBll PatientBll { get; set; }
        /// <summary>
        /// 排号（数据访问层）
        /// </summary>
        private IQueueDal QueueDal { get; set; }
        /// <summary>
		/// SQL助手
		/// </summary>
		private SqlHelper SqlHelper { get; set; }
        /// <summary>
        /// 排号表
        /// </summary>
        private DataTable QueueTable { get; set; }
        /// <summary>
        /// 重要编码
        /// </summary>
        public string KeyNo { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public frm_CallNumber()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.dgv_Queue.AllowUserToAddRows = false;
            this.dgv_Queue.BackgroundColor = Color.White;
            this.dgv_Queue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="doctor"></param>
        public frm_CallNumber(Doctor doctor) : this()
        {
            this.Doctor = doctor;
            this.PatientBll = new PatientBll();
            this.QueueDal = new QueueDal();
            this.SqlHelper = new SqlHelper();
            this.QueueTable = new DataTable();
            this.QueueTable = SqlHelper.GetTable($@"SELECT Q.DoctorNo,Q.HealthCardNo,Q.Date,Q.Number,QS.State AS State,P.Name
	                                                    FROM tb_Queue AS Q
	                                                    JOIN tb_Patient AS P ON Q.HealthCardNo=P.HealthCardNo
	                                                    JOIN tb_QueueState AS QS ON Q.StateNo=QS.No
	                                                    WHERE Q.DoctorNo='1989001'
	                                                    AND CAST(Q.Date AS DATE) = CAST(GETDATE() AS DATE)
                                                        AND Q.StateNo=1");
            this.dgv_Queue.Columns.Clear();
            this.dgv_Queue.DataSource = this.QueueTable;
            this.dgv_Queue.Columns["DoctorNo"].Visible = false;
            this.dgv_Queue.Columns["HealthCardNo"].HeaderText = "医保卡号";
            this.dgv_Queue.Columns["Date"].Visible = false;
            this.dgv_Queue.Columns["Number"].HeaderText = "号码";
            this.dgv_Queue.Columns["State"].HeaderText = "状态";
            this.dgv_Queue.Columns["Name"].HeaderText = "姓名";
            this.dgv_Queue.Columns["Number"].ReadOnly = true;
            this.dgv_Queue.Columns["State"].ReadOnly = true;
            this.dgv_Queue.Columns["Name"].ReadOnly = true;
        }
        /// <summary>
        /// 单击叫号按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Call_Click(object sender, EventArgs e)
        {
            if (this.Patient == null) 
            {
                MessageBox.Show("请选择病人！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.KeyNo = this.PatientBll.KeyNo(this.Doctor, this.Patient);
                this.QueueDal.Update(2, this.Doctor, this.Patient);
                frm_Home frm_Home = new frm_Home(this.Doctor, this.Patient, this.KeyNo);
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
            DataTable provenanceTable = SqlHelper.GetTable("SELECT * FROM tb_Provenance");
            this.cmb_Provenance.DataSource = provenanceTable;
            this.cmb_Provenance.DisplayMember = "Name";
            this.cmb_Provenance.ValueMember = "No";
            DataRowView currentPatientRowView = this.dgv_Queue.CurrentRow.DataBoundItem as DataRowView;
            DataRow currentPatientRow = currentPatientRowView.Row;
            string HealthCardNo = currentPatientRow["HealthCardNo"].ToString();
            this.Patient = this.PatientBll.Select(HealthCardNo);
            if (this.Patient != null) 
            {
                this.txb_Name.Text = this.Patient.Name;
                this.dtp_Birthdate.Value = this.Patient.Birthdate;
                this.txb_IDCardNo.Text = this.Patient.IDCardNo;
                this.txb_HealthCardNo.Text = HealthCardNo;
                this.txb_DrugAllergy.Text = this.Patient.DrugAllergy;
                this.rdb_Female.Checked = !this.Patient.Gender;
                this.rdb_Male.Checked = this.Patient.Gender;
                this.nud_Age.Value = DateTime.Now.Year - this.Patient.Birthdate.Year;
                this.txb_Telephone.Text = this.Patient.Telephone;
                this.cmb_Provenance.SelectedValue = this.Patient.ProvenanceNo;
                this.rdb_Married.Checked = this.Patient.IsMarried;
                this.rdb_UnMarried.Checked = !this.Patient.IsMarried;
            }
            else
            {
                MessageBox.Show("该病人不存在，请联系管理员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
