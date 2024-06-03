namespace OutpatientClinicDoctorModule
{
    partial class frm_CallNumber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Age = new System.Windows.Forms.Label();
            this.dtp_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_Birthdate = new System.Windows.Forms.Label();
            this.gpb_Gender = new System.Windows.Forms.GroupBox();
            this.rdb_Female = new System.Windows.Forms.RadioButton();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txb_HealthCardNo = new System.Windows.Forms.TextBox();
            this.lbl_HealthCardNo = new System.Windows.Forms.Label();
            this.txb_IDCardNo = new System.Windows.Forms.TextBox();
            this.dgv_Queue = new System.Windows.Forms.DataGridView();
            this.rdb_UnMarried = new System.Windows.Forms.RadioButton();
            this.nud_Age = new System.Windows.Forms.NumericUpDown();
            this.rdb_Married = new System.Windows.Forms.RadioButton();
            this.lbl_Telephone = new System.Windows.Forms.Label();
            this.gb_MaritalState = new System.Windows.Forms.GroupBox();
            this.txb_Telephone = new System.Windows.Forms.TextBox();
            this.btn_Call = new System.Windows.Forms.Button();
            this.txb_DrugAllergy = new System.Windows.Forms.TextBox();
            this.lbl_DrugAllergy = new System.Windows.Forms.Label();
            this.lbl_Provenance = new System.Windows.Forms.Label();
            this.lbl_IDCardNo = new System.Windows.Forms.Label();
            this.cmb_Provenance = new System.Windows.Forms.ComboBox();
            this.gpb_Gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Queue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Age)).BeginInit();
            this.gb_MaritalState.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Age.Location = new System.Drawing.Point(1074, 222);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(86, 31);
            this.lbl_Age.TabIndex = 219;
            this.lbl_Age.Text = "年龄：";
            // 
            // dtp_Birthdate
            // 
            this.dtp_Birthdate.CalendarFont = new System.Drawing.Font("宋体", 14F);
            this.dtp_Birthdate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_Birthdate.Location = new System.Drawing.Point(695, 217);
            this.dtp_Birthdate.Name = "dtp_Birthdate";
            this.dtp_Birthdate.Size = new System.Drawing.Size(277, 39);
            this.dtp_Birthdate.TabIndex = 218;
            // 
            // lbl_Birthdate
            // 
            this.lbl_Birthdate.AutoSize = true;
            this.lbl_Birthdate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Birthdate.Location = new System.Drawing.Point(555, 223);
            this.lbl_Birthdate.Name = "lbl_Birthdate";
            this.lbl_Birthdate.Size = new System.Drawing.Size(134, 31);
            this.lbl_Birthdate.TabIndex = 217;
            this.lbl_Birthdate.Text = "出生日期：";
            // 
            // gpb_Gender
            // 
            this.gpb_Gender.Controls.Add(this.rdb_Female);
            this.gpb_Gender.Controls.Add(this.rdb_Male);
            this.gpb_Gender.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.gpb_Gender.Location = new System.Drawing.Point(1056, 43);
            this.gpb_Gender.Name = "gpb_Gender";
            this.gpb_Gender.Size = new System.Drawing.Size(310, 113);
            this.gpb_Gender.TabIndex = 215;
            this.gpb_Gender.TabStop = false;
            this.gpb_Gender.Text = "性别";
            // 
            // rdb_Female
            // 
            this.rdb_Female.AutoSize = true;
            this.rdb_Female.Location = new System.Drawing.Point(201, 52);
            this.rdb_Female.Name = "rdb_Female";
            this.rdb_Female.Size = new System.Drawing.Size(63, 35);
            this.rdb_Female.TabIndex = 1;
            this.rdb_Female.TabStop = true;
            this.rdb_Female.Text = "女";
            this.rdb_Female.UseVisualStyleBackColor = true;
            // 
            // rdb_Male
            // 
            this.rdb_Male.AutoSize = true;
            this.rdb_Male.Location = new System.Drawing.Point(55, 52);
            this.rdb_Male.Name = "rdb_Male";
            this.rdb_Male.Size = new System.Drawing.Size(63, 35);
            this.rdb_Male.TabIndex = 0;
            this.rdb_Male.TabStop = true;
            this.rdb_Male.Text = "男";
            this.rdb_Male.UseVisualStyleBackColor = true;
            // 
            // txb_Name
            // 
            this.txb_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Name.Location = new System.Drawing.Point(695, 91);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(277, 39);
            this.txb_Name.TabIndex = 214;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Name.Location = new System.Drawing.Point(603, 99);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(86, 31);
            this.lbl_Name.TabIndex = 213;
            this.lbl_Name.Text = "姓名：";
            // 
            // txb_HealthCardNo
            // 
            this.txb_HealthCardNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_HealthCardNo.Location = new System.Drawing.Point(695, 421);
            this.txb_HealthCardNo.Name = "txb_HealthCardNo";
            this.txb_HealthCardNo.Size = new System.Drawing.Size(277, 39);
            this.txb_HealthCardNo.TabIndex = 212;
            // 
            // lbl_HealthCardNo
            // 
            this.lbl_HealthCardNo.AutoSize = true;
            this.lbl_HealthCardNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_HealthCardNo.Location = new System.Drawing.Point(555, 429);
            this.lbl_HealthCardNo.Name = "lbl_HealthCardNo";
            this.lbl_HealthCardNo.Size = new System.Drawing.Size(134, 31);
            this.lbl_HealthCardNo.TabIndex = 211;
            this.lbl_HealthCardNo.Text = "医保卡号：";
            // 
            // txb_IDCardNo
            // 
            this.txb_IDCardNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_IDCardNo.Location = new System.Drawing.Point(695, 315);
            this.txb_IDCardNo.Name = "txb_IDCardNo";
            this.txb_IDCardNo.Size = new System.Drawing.Size(277, 39);
            this.txb_IDCardNo.TabIndex = 210;
            // 
            // dgv_Queue
            // 
            this.dgv_Queue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Queue.Location = new System.Drawing.Point(1, 0);
            this.dgv_Queue.Name = "dgv_Queue";
            this.dgv_Queue.RowHeadersWidth = 62;
            this.dgv_Queue.RowTemplate.Height = 30;
            this.dgv_Queue.Size = new System.Drawing.Size(512, 839);
            this.dgv_Queue.TabIndex = 208;
            this.dgv_Queue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Queue_CellContentClick);
            // 
            // rdb_UnMarried
            // 
            this.rdb_UnMarried.AutoSize = true;
            this.rdb_UnMarried.Location = new System.Drawing.Point(177, 52);
            this.rdb_UnMarried.Name = "rdb_UnMarried";
            this.rdb_UnMarried.Size = new System.Drawing.Size(87, 35);
            this.rdb_UnMarried.TabIndex = 1;
            this.rdb_UnMarried.TabStop = true;
            this.rdb_UnMarried.Text = "未婚";
            this.rdb_UnMarried.UseVisualStyleBackColor = true;
            // 
            // nud_Age
            // 
            this.nud_Age.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.nud_Age.Location = new System.Drawing.Point(1166, 214);
            this.nud_Age.Name = "nud_Age";
            this.nud_Age.Size = new System.Drawing.Size(223, 39);
            this.nud_Age.TabIndex = 220;
            // 
            // rdb_Married
            // 
            this.rdb_Married.AutoSize = true;
            this.rdb_Married.Location = new System.Drawing.Point(55, 52);
            this.rdb_Married.Name = "rdb_Married";
            this.rdb_Married.Size = new System.Drawing.Size(87, 35);
            this.rdb_Married.TabIndex = 0;
            this.rdb_Married.TabStop = true;
            this.rdb_Married.Text = "已婚";
            this.rdb_Married.UseVisualStyleBackColor = true;
            // 
            // lbl_Telephone
            // 
            this.lbl_Telephone.AutoSize = true;
            this.lbl_Telephone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Telephone.Location = new System.Drawing.Point(1026, 315);
            this.lbl_Telephone.Name = "lbl_Telephone";
            this.lbl_Telephone.Size = new System.Drawing.Size(134, 31);
            this.lbl_Telephone.TabIndex = 225;
            this.lbl_Telephone.Text = "电话号码：";
            // 
            // gb_MaritalState
            // 
            this.gb_MaritalState.Controls.Add(this.rdb_UnMarried);
            this.gb_MaritalState.Controls.Add(this.rdb_Married);
            this.gb_MaritalState.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.gb_MaritalState.Location = new System.Drawing.Point(1056, 532);
            this.gb_MaritalState.Name = "gb_MaritalState";
            this.gb_MaritalState.Size = new System.Drawing.Size(310, 113);
            this.gb_MaritalState.TabIndex = 216;
            this.gb_MaritalState.TabStop = false;
            this.gb_MaritalState.Text = "婚姻状况";
            // 
            // txb_Telephone
            // 
            this.txb_Telephone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Telephone.Location = new System.Drawing.Point(1166, 312);
            this.txb_Telephone.Name = "txb_Telephone";
            this.txb_Telephone.Size = new System.Drawing.Size(223, 39);
            this.txb_Telephone.TabIndex = 226;
            // 
            // btn_Call
            // 
            this.btn_Call.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_Call.Location = new System.Drawing.Point(1178, 700);
            this.btn_Call.Name = "btn_Call";
            this.btn_Call.Size = new System.Drawing.Size(121, 66);
            this.btn_Call.TabIndex = 224;
            this.btn_Call.Text = "叫号";
            this.btn_Call.UseVisualStyleBackColor = true;
            this.btn_Call.Click += new System.EventHandler(this.btn_Call_Click);
            // 
            // txb_DrugAllergy
            // 
            this.txb_DrugAllergy.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_DrugAllergy.Location = new System.Drawing.Point(695, 532);
            this.txb_DrugAllergy.Multiline = true;
            this.txb_DrugAllergy.Name = "txb_DrugAllergy";
            this.txb_DrugAllergy.Size = new System.Drawing.Size(277, 267);
            this.txb_DrugAllergy.TabIndex = 223;
            // 
            // lbl_DrugAllergy
            // 
            this.lbl_DrugAllergy.AutoSize = true;
            this.lbl_DrugAllergy.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_DrugAllergy.Location = new System.Drawing.Point(579, 535);
            this.lbl_DrugAllergy.Name = "lbl_DrugAllergy";
            this.lbl_DrugAllergy.Size = new System.Drawing.Size(110, 31);
            this.lbl_DrugAllergy.TabIndex = 222;
            this.lbl_DrugAllergy.Text = "过敏史：";
            // 
            // lbl_Provenance
            // 
            this.lbl_Provenance.AutoSize = true;
            this.lbl_Provenance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Provenance.Location = new System.Drawing.Point(1050, 429);
            this.lbl_Provenance.Name = "lbl_Provenance";
            this.lbl_Provenance.Size = new System.Drawing.Size(110, 31);
            this.lbl_Provenance.TabIndex = 221;
            this.lbl_Provenance.Text = "来源地：";
            // 
            // lbl_IDCardNo
            // 
            this.lbl_IDCardNo.AutoSize = true;
            this.lbl_IDCardNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_IDCardNo.Location = new System.Drawing.Point(555, 323);
            this.lbl_IDCardNo.Name = "lbl_IDCardNo";
            this.lbl_IDCardNo.Size = new System.Drawing.Size(134, 31);
            this.lbl_IDCardNo.TabIndex = 209;
            this.lbl_IDCardNo.Text = "身份证号：";
            // 
            // cmb_Provenance
            // 
            this.cmb_Provenance.Font = new System.Drawing.Font("宋体", 12F);
            this.cmb_Provenance.FormattingEnabled = true;
            this.cmb_Provenance.Location = new System.Drawing.Point(1166, 428);
            this.cmb_Provenance.Name = "cmb_Provenance";
            this.cmb_Provenance.Size = new System.Drawing.Size(223, 32);
            this.cmb_Provenance.TabIndex = 227;
            // 
            // frm_CallNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.cmb_Provenance);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.dtp_Birthdate);
            this.Controls.Add(this.lbl_Birthdate);
            this.Controls.Add(this.gpb_Gender);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txb_HealthCardNo);
            this.Controls.Add(this.lbl_HealthCardNo);
            this.Controls.Add(this.txb_IDCardNo);
            this.Controls.Add(this.dgv_Queue);
            this.Controls.Add(this.nud_Age);
            this.Controls.Add(this.lbl_Telephone);
            this.Controls.Add(this.gb_MaritalState);
            this.Controls.Add(this.txb_Telephone);
            this.Controls.Add(this.btn_Call);
            this.Controls.Add(this.txb_DrugAllergy);
            this.Controls.Add(this.lbl_DrugAllergy);
            this.Controls.Add(this.lbl_Provenance);
            this.Controls.Add(this.lbl_IDCardNo);
            this.Name = "frm_CallNumber";
            this.Text = "叫号";
            this.gpb_Gender.ResumeLayout(false);
            this.gpb_Gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Queue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Age)).EndInit();
            this.gb_MaritalState.ResumeLayout(false);
            this.gb_MaritalState.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.DateTimePicker dtp_Birthdate;
        private System.Windows.Forms.Label lbl_Birthdate;
        private System.Windows.Forms.GroupBox gpb_Gender;
        private System.Windows.Forms.RadioButton rdb_Female;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txb_HealthCardNo;
        private System.Windows.Forms.Label lbl_HealthCardNo;
        private System.Windows.Forms.TextBox txb_IDCardNo;
        private System.Windows.Forms.DataGridView dgv_Queue;
        private System.Windows.Forms.RadioButton rdb_UnMarried;
        private System.Windows.Forms.NumericUpDown nud_Age;
        private System.Windows.Forms.RadioButton rdb_Married;
        private System.Windows.Forms.Label lbl_Telephone;
        private System.Windows.Forms.GroupBox gb_MaritalState;
        private System.Windows.Forms.TextBox txb_Telephone;
        private System.Windows.Forms.Button btn_Call;
        private System.Windows.Forms.TextBox txb_DrugAllergy;
        private System.Windows.Forms.Label lbl_DrugAllergy;
        private System.Windows.Forms.Label lbl_Provenance;
        private System.Windows.Forms.Label lbl_IDCardNo;
        private System.Windows.Forms.ComboBox cmb_Provenance;
    }
}