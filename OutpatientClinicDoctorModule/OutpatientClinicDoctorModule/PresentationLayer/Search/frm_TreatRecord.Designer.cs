namespace OutpatientClinicDoctorModule
{
    partial class frm_TreatRecord
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
            this.trv_TreatRecord = new System.Windows.Forms.TreeView();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_Birthdate = new System.Windows.Forms.Label();
            this.dtp_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txb_HealthCardNo = new System.Windows.Forms.TextBox();
            this.lbl_HealthCardNo = new System.Windows.Forms.Label();
            this.nud_Age = new System.Windows.Forms.NumericUpDown();
            this.txt_Doctor = new System.Windows.Forms.TextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.txt_Discription = new System.Windows.Forms.TextBox();
            this.lbl_Discription = new System.Windows.Forms.Label();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.lbl_Doctor = new System.Windows.Forms.Label();
            this.btn_SearchPrescription = new System.Windows.Forms.Button();
            this.btn_SearchExaminations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Age)).BeginInit();
            this.SuspendLayout();
            // 
            // trv_TreatRecord
            // 
            this.trv_TreatRecord.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.trv_TreatRecord.Location = new System.Drawing.Point(0, 1);
            this.trv_TreatRecord.Name = "trv_TreatRecord";
            this.trv_TreatRecord.Size = new System.Drawing.Size(468, 839);
            this.trv_TreatRecord.TabIndex = 0;
            this.trv_TreatRecord.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_TreatRecord_AfterSelect);
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Age.Location = new System.Drawing.Point(553, 150);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(86, 31);
            this.lbl_Age.TabIndex = 258;
            this.lbl_Age.Text = "年龄：";
            // 
            // lbl_Birthdate
            // 
            this.lbl_Birthdate.AutoSize = true;
            this.lbl_Birthdate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Birthdate.Location = new System.Drawing.Point(923, 150);
            this.lbl_Birthdate.Name = "lbl_Birthdate";
            this.lbl_Birthdate.Size = new System.Drawing.Size(134, 31);
            this.lbl_Birthdate.TabIndex = 256;
            this.lbl_Birthdate.Text = "出生日期：";
            // 
            // dtp_Birthdate
            // 
            this.dtp_Birthdate.CalendarFont = new System.Drawing.Font("宋体", 14F);
            this.dtp_Birthdate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_Birthdate.Location = new System.Drawing.Point(1063, 150);
            this.dtp_Birthdate.Name = "dtp_Birthdate";
            this.dtp_Birthdate.Size = new System.Drawing.Size(277, 39);
            this.dtp_Birthdate.TabIndex = 257;
            // 
            // txb_Name
            // 
            this.txb_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Name.Location = new System.Drawing.Point(645, 50);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(207, 39);
            this.txb_Name.TabIndex = 253;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Name.Location = new System.Drawing.Point(553, 50);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(86, 31);
            this.lbl_Name.TabIndex = 252;
            this.lbl_Name.Text = "姓名：";
            // 
            // txb_HealthCardNo
            // 
            this.txb_HealthCardNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_HealthCardNo.Location = new System.Drawing.Point(1063, 50);
            this.txb_HealthCardNo.Name = "txb_HealthCardNo";
            this.txb_HealthCardNo.Size = new System.Drawing.Size(277, 39);
            this.txb_HealthCardNo.TabIndex = 251;
            // 
            // lbl_HealthCardNo
            // 
            this.lbl_HealthCardNo.AutoSize = true;
            this.lbl_HealthCardNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_HealthCardNo.Location = new System.Drawing.Point(923, 50);
            this.lbl_HealthCardNo.Name = "lbl_HealthCardNo";
            this.lbl_HealthCardNo.Size = new System.Drawing.Size(134, 31);
            this.lbl_HealthCardNo.TabIndex = 250;
            this.lbl_HealthCardNo.Text = "医保卡号：";
            // 
            // nud_Age
            // 
            this.nud_Age.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.nud_Age.Location = new System.Drawing.Point(645, 150);
            this.nud_Age.Name = "nud_Age";
            this.nud_Age.Size = new System.Drawing.Size(207, 39);
            this.nud_Age.TabIndex = 259;
            // 
            // txt_Doctor
            // 
            this.txt_Doctor.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_Doctor.Location = new System.Drawing.Point(645, 250);
            this.txt_Doctor.Name = "txt_Doctor";
            this.txt_Doctor.Size = new System.Drawing.Size(207, 39);
            this.txt_Doctor.TabIndex = 267;
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Result.Location = new System.Drawing.Point(505, 595);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(134, 31);
            this.lbl_Result.TabIndex = 276;
            this.lbl_Result.Text = "诊断结果：";
            // 
            // txt_Discription
            // 
            this.txt_Discription.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_Discription.Location = new System.Drawing.Point(645, 351);
            this.txt_Discription.Multiline = true;
            this.txt_Discription.Name = "txt_Discription";
            this.txt_Discription.Size = new System.Drawing.Size(745, 197);
            this.txt_Discription.TabIndex = 275;
            // 
            // lbl_Discription
            // 
            this.lbl_Discription.AutoSize = true;
            this.lbl_Discription.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Discription.Location = new System.Drawing.Point(505, 359);
            this.lbl_Discription.Name = "lbl_Discription";
            this.lbl_Discription.Size = new System.Drawing.Size(134, 31);
            this.lbl_Discription.TabIndex = 274;
            this.lbl_Discription.Text = "病情描述：";
            // 
            // txt_Result
            // 
            this.txt_Result.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_Result.Location = new System.Drawing.Point(645, 595);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(745, 197);
            this.txt_Result.TabIndex = 277;
            // 
            // lbl_Doctor
            // 
            this.lbl_Doctor.AutoSize = true;
            this.lbl_Doctor.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Doctor.Location = new System.Drawing.Point(553, 250);
            this.lbl_Doctor.Name = "lbl_Doctor";
            this.lbl_Doctor.Size = new System.Drawing.Size(86, 31);
            this.lbl_Doctor.TabIndex = 278;
            this.lbl_Doctor.Text = "医生：";
            // 
            // btn_SearchPrescription
            // 
            this.btn_SearchPrescription.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.btn_SearchPrescription.Location = new System.Drawing.Point(1203, 250);
            this.btn_SearchPrescription.Name = "btn_SearchPrescription";
            this.btn_SearchPrescription.Size = new System.Drawing.Size(137, 55);
            this.btn_SearchPrescription.TabIndex = 280;
            this.btn_SearchPrescription.Text = "查看药方";
            this.btn_SearchPrescription.UseVisualStyleBackColor = true;
            this.btn_SearchPrescription.Click += new System.EventHandler(this.btn_SearchPrescription_Click);
            // 
            // btn_SearchExaminations
            // 
            this.btn_SearchExaminations.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.btn_SearchExaminations.Location = new System.Drawing.Point(929, 250);
            this.btn_SearchExaminations.Name = "btn_SearchExaminations";
            this.btn_SearchExaminations.Size = new System.Drawing.Size(191, 55);
            this.btn_SearchExaminations.TabIndex = 281;
            this.btn_SearchExaminations.Text = "查看检查项目";
            this.btn_SearchExaminations.UseVisualStyleBackColor = true;
            this.btn_SearchExaminations.Click += new System.EventHandler(this.btn_SearchExaminations_Click);
            // 
            // frm_TreatRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.btn_SearchExaminations);
            this.Controls.Add(this.btn_SearchPrescription);
            this.Controls.Add(this.lbl_Doctor);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.txt_Discription);
            this.Controls.Add(this.lbl_Discription);
            this.Controls.Add(this.txt_Doctor);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_Birthdate);
            this.Controls.Add(this.dtp_Birthdate);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txb_HealthCardNo);
            this.Controls.Add(this.lbl_HealthCardNo);
            this.Controls.Add(this.nud_Age);
            this.Controls.Add(this.trv_TreatRecord);
            this.Name = "frm_TreatRecord";
            this.Text = "病历";
            this.Load += new System.EventHandler(this.frm_TreatRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trv_TreatRecord;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_Birthdate;
        private System.Windows.Forms.DateTimePicker dtp_Birthdate;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txb_HealthCardNo;
        private System.Windows.Forms.Label lbl_HealthCardNo;
        private System.Windows.Forms.NumericUpDown nud_Age;
        private System.Windows.Forms.TextBox txt_Doctor;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.TextBox txt_Discription;
        private System.Windows.Forms.Label lbl_Discription;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label lbl_Doctor;
        private System.Windows.Forms.Button btn_SearchPrescription;
        private System.Windows.Forms.Button btn_SearchExaminations;
    }
}