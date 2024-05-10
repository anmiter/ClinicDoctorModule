namespace OutpatientClinicDoctorModule.Consultation
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
            this.dgv_Queue = new System.Windows.Forms.DataGridView();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txb_PatientIDCard = new System.Windows.Forms.TextBox();
            this.lbl_PatientIDCard = new System.Windows.Forms.Label();
            this.txb_Identification = new System.Windows.Forms.TextBox();
            this.lbl_Identification = new System.Windows.Forms.Label();
            this.gpb_Gender = new System.Windows.Forms.GroupBox();
            this.rdb_Female = new System.Windows.Forms.RadioButton();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.dtp_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_Birthdate = new System.Windows.Forms.Label();
            this.nud_Age = new System.Windows.Forms.NumericUpDown();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.gb_MaritalState = new System.Windows.Forms.GroupBox();
            this.rdb_UnMarried = new System.Windows.Forms.RadioButton();
            this.rdb_Married = new System.Windows.Forms.RadioButton();
            this.lbl_ComeFrom = new System.Windows.Forms.Label();
            this.txb_AllergyHistory = new System.Windows.Forms.TextBox();
            this.lbl_AllergyHistory = new System.Windows.Forms.Label();
            this.btn_Call = new System.Windows.Forms.Button();
            this.txb_Telephone = new System.Windows.Forms.TextBox();
            this.lbl_Telephone = new System.Windows.Forms.Label();
            this.txb_ComeFrom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Queue)).BeginInit();
            this.gpb_Gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Age)).BeginInit();
            this.gb_MaritalState.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Queue
            // 
            this.dgv_Queue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Queue.Location = new System.Drawing.Point(0, 0);
            this.dgv_Queue.Name = "dgv_Queue";
            this.dgv_Queue.RowHeadersWidth = 62;
            this.dgv_Queue.RowTemplate.Height = 30;
            this.dgv_Queue.Size = new System.Drawing.Size(512, 839);
            this.dgv_Queue.TabIndex = 0;
            this.dgv_Queue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Queue_CellContentClick);
            // 
            // txb_Name
            // 
            this.txb_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Name.Location = new System.Drawing.Point(695, 120);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(260, 39);
            this.txb_Name.TabIndex = 147;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Name.Location = new System.Drawing.Point(603, 128);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(86, 31);
            this.lbl_Name.TabIndex = 146;
            this.lbl_Name.Text = "姓名：";
            // 
            // txb_PatientIDCard
            // 
            this.txb_PatientIDCard.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_PatientIDCard.Location = new System.Drawing.Point(695, 424);
            this.txb_PatientIDCard.Name = "txb_PatientIDCard";
            this.txb_PatientIDCard.Size = new System.Drawing.Size(260, 39);
            this.txb_PatientIDCard.TabIndex = 145;
            // 
            // lbl_PatientIDCard
            // 
            this.lbl_PatientIDCard.AutoSize = true;
            this.lbl_PatientIDCard.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_PatientIDCard.Location = new System.Drawing.Point(555, 432);
            this.lbl_PatientIDCard.Name = "lbl_PatientIDCard";
            this.lbl_PatientIDCard.Size = new System.Drawing.Size(134, 31);
            this.lbl_PatientIDCard.TabIndex = 144;
            this.lbl_PatientIDCard.Text = "医保卡号：";
            // 
            // txb_Identification
            // 
            this.txb_Identification.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Identification.Location = new System.Drawing.Point(695, 315);
            this.txb_Identification.Name = "txb_Identification";
            this.txb_Identification.Size = new System.Drawing.Size(260, 39);
            this.txb_Identification.TabIndex = 143;
            // 
            // lbl_Identification
            // 
            this.lbl_Identification.AutoSize = true;
            this.lbl_Identification.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Identification.Location = new System.Drawing.Point(555, 323);
            this.lbl_Identification.Name = "lbl_Identification";
            this.lbl_Identification.Size = new System.Drawing.Size(134, 31);
            this.lbl_Identification.TabIndex = 142;
            this.lbl_Identification.Text = "身份证号：";
            // 
            // gpb_Gender
            // 
            this.gpb_Gender.Controls.Add(this.rdb_Female);
            this.gpb_Gender.Controls.Add(this.rdb_Male);
            this.gpb_Gender.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.gpb_Gender.Location = new System.Drawing.Point(1060, 43);
            this.gpb_Gender.Name = "gpb_Gender";
            this.gpb_Gender.Size = new System.Drawing.Size(286, 113);
            this.gpb_Gender.TabIndex = 148;
            this.gpb_Gender.TabStop = false;
            this.gpb_Gender.Text = "性别";
            // 
            // rdb_Female
            // 
            this.rdb_Female.AutoSize = true;
            this.rdb_Female.Location = new System.Drawing.Point(177, 52);
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
            // dtp_Birthdate
            // 
            this.dtp_Birthdate.CalendarFont = new System.Drawing.Font("宋体", 14F);
            this.dtp_Birthdate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_Birthdate.Location = new System.Drawing.Point(695, 219);
            this.dtp_Birthdate.Name = "dtp_Birthdate";
            this.dtp_Birthdate.Size = new System.Drawing.Size(260, 39);
            this.dtp_Birthdate.TabIndex = 150;
            // 
            // lbl_Birthdate
            // 
            this.lbl_Birthdate.AutoSize = true;
            this.lbl_Birthdate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Birthdate.Location = new System.Drawing.Point(555, 225);
            this.lbl_Birthdate.Name = "lbl_Birthdate";
            this.lbl_Birthdate.Size = new System.Drawing.Size(134, 31);
            this.lbl_Birthdate.TabIndex = 149;
            this.lbl_Birthdate.Text = "出生日期：";
            // 
            // nud_Age
            // 
            this.nud_Age.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.nud_Age.Location = new System.Drawing.Point(1146, 214);
            this.nud_Age.Name = "nud_Age";
            this.nud_Age.Size = new System.Drawing.Size(200, 39);
            this.nud_Age.TabIndex = 152;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Age.Location = new System.Drawing.Point(1054, 222);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(86, 31);
            this.lbl_Age.TabIndex = 151;
            this.lbl_Age.Text = "年龄：";
            // 
            // gb_MaritalState
            // 
            this.gb_MaritalState.Controls.Add(this.rdb_UnMarried);
            this.gb_MaritalState.Controls.Add(this.rdb_Married);
            this.gb_MaritalState.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.gb_MaritalState.Location = new System.Drawing.Point(1036, 532);
            this.gb_MaritalState.Name = "gb_MaritalState";
            this.gb_MaritalState.Size = new System.Drawing.Size(286, 113);
            this.gb_MaritalState.TabIndex = 149;
            this.gb_MaritalState.TabStop = false;
            this.gb_MaritalState.Text = "婚姻状况";
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
            // lbl_ComeFrom
            // 
            this.lbl_ComeFrom.AutoSize = true;
            this.lbl_ComeFrom.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_ComeFrom.Location = new System.Drawing.Point(1030, 429);
            this.lbl_ComeFrom.Name = "lbl_ComeFrom";
            this.lbl_ComeFrom.Size = new System.Drawing.Size(110, 31);
            this.lbl_ComeFrom.TabIndex = 158;
            this.lbl_ComeFrom.Text = "来源地：";
            // 
            // txb_AllergyHistory
            // 
            this.txb_AllergyHistory.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_AllergyHistory.Location = new System.Drawing.Point(695, 532);
            this.txb_AllergyHistory.Multiline = true;
            this.txb_AllergyHistory.Name = "txb_AllergyHistory";
            this.txb_AllergyHistory.Size = new System.Drawing.Size(260, 267);
            this.txb_AllergyHistory.TabIndex = 163;
            // 
            // lbl_AllergyHistory
            // 
            this.lbl_AllergyHistory.AutoSize = true;
            this.lbl_AllergyHistory.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_AllergyHistory.Location = new System.Drawing.Point(579, 535);
            this.lbl_AllergyHistory.Name = "lbl_AllergyHistory";
            this.lbl_AllergyHistory.Size = new System.Drawing.Size(110, 31);
            this.lbl_AllergyHistory.TabIndex = 162;
            this.lbl_AllergyHistory.Text = "过敏史：";
            // 
            // btn_Call
            // 
            this.btn_Call.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_Call.Location = new System.Drawing.Point(1158, 686);
            this.btn_Call.Name = "btn_Call";
            this.btn_Call.Size = new System.Drawing.Size(121, 66);
            this.btn_Call.TabIndex = 164;
            this.btn_Call.Text = "叫号";
            this.btn_Call.UseVisualStyleBackColor = true;
            this.btn_Call.Click += new System.EventHandler(this.btn_Call_Click);
            // 
            // txb_Telephone
            // 
            this.txb_Telephone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Telephone.Location = new System.Drawing.Point(1146, 312);
            this.txb_Telephone.Name = "txb_Telephone";
            this.txb_Telephone.Size = new System.Drawing.Size(200, 39);
            this.txb_Telephone.TabIndex = 166;
            // 
            // lbl_Telephone
            // 
            this.lbl_Telephone.AutoSize = true;
            this.lbl_Telephone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Telephone.Location = new System.Drawing.Point(1006, 315);
            this.lbl_Telephone.Name = "lbl_Telephone";
            this.lbl_Telephone.Size = new System.Drawing.Size(134, 31);
            this.lbl_Telephone.TabIndex = 165;
            this.lbl_Telephone.Text = "电话号码：";
            // 
            // txb_ComeFrom
            // 
            this.txb_ComeFrom.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_ComeFrom.Location = new System.Drawing.Point(1158, 421);
            this.txb_ComeFrom.Name = "txb_ComeFrom";
            this.txb_ComeFrom.Size = new System.Drawing.Size(200, 39);
            this.txb_ComeFrom.TabIndex = 167;
            // 
            // frm_CallNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.txb_ComeFrom);
            this.Controls.Add(this.txb_Telephone);
            this.Controls.Add(this.lbl_Telephone);
            this.Controls.Add(this.btn_Call);
            this.Controls.Add(this.txb_AllergyHistory);
            this.Controls.Add(this.lbl_AllergyHistory);
            this.Controls.Add(this.lbl_ComeFrom);
            this.Controls.Add(this.gb_MaritalState);
            this.Controls.Add(this.nud_Age);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.dtp_Birthdate);
            this.Controls.Add(this.lbl_Birthdate);
            this.Controls.Add(this.gpb_Gender);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txb_PatientIDCard);
            this.Controls.Add(this.lbl_PatientIDCard);
            this.Controls.Add(this.txb_Identification);
            this.Controls.Add(this.lbl_Identification);
            this.Controls.Add(this.dgv_Queue);
            this.Name = "frm_CallNumber";
            this.Text = "叫号";
            this.Load += new System.EventHandler(this.frm_CallNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Queue)).EndInit();
            this.gpb_Gender.ResumeLayout(false);
            this.gpb_Gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Age)).EndInit();
            this.gb_MaritalState.ResumeLayout(false);
            this.gb_MaritalState.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Queue;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txb_PatientIDCard;
        private System.Windows.Forms.Label lbl_PatientIDCard;
        private System.Windows.Forms.TextBox txb_Identification;
        private System.Windows.Forms.Label lbl_Identification;
        private System.Windows.Forms.GroupBox gpb_Gender;
        private System.Windows.Forms.RadioButton rdb_Female;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.DateTimePicker dtp_Birthdate;
        private System.Windows.Forms.Label lbl_Birthdate;
        private System.Windows.Forms.NumericUpDown nud_Age;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.GroupBox gb_MaritalState;
        private System.Windows.Forms.RadioButton rdb_UnMarried;
        private System.Windows.Forms.RadioButton rdb_Married;
        private System.Windows.Forms.Label lbl_ComeFrom;
        private System.Windows.Forms.TextBox txb_AllergyHistory;
        private System.Windows.Forms.Label lbl_AllergyHistory;
        private System.Windows.Forms.Button btn_Call;
        private System.Windows.Forms.TextBox txb_Telephone;
        private System.Windows.Forms.Label lbl_Telephone;
        private System.Windows.Forms.TextBox txb_ComeFrom;
    }
}