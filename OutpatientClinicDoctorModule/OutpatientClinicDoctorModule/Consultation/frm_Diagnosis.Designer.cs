namespace OutpatientClinicDoctorModule.Consultation
{
    partial class frm_Diagnosis
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
            this.btn_Load = new System.Windows.Forms.Button();
            this.txb_DoctorNo = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.cmb_PrescriptionNo = new System.Windows.Forms.ComboBox();
            this.lbl_PrescriptionNo = new System.Windows.Forms.Label();
            this.cmb_ExamineItemsNo = new System.Windows.Forms.ComboBox();
            this.lbl_ExamineItemsNo = new System.Windows.Forms.Label();
            this.txb_Result = new System.Windows.Forms.TextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.txb_Description = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txb_PatientIDCard = new System.Windows.Forms.TextBox();
            this.lbl_PatientIDCard = new System.Windows.Forms.Label();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.lbl_DoctorNo = new System.Windows.Forms.Label();
            this.txb_Hospital = new System.Windows.Forms.TextBox();
            this.lbl_Hospital = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_Load.Location = new System.Drawing.Point(1219, 505);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(121, 66);
            this.btn_Load.TabIndex = 195;
            this.btn_Load.Text = "载入";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // txb_DoctorNo
            // 
            this.txb_DoctorNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_DoctorNo.Location = new System.Drawing.Point(1134, 80);
            this.txb_DoctorNo.Name = "txb_DoctorNo";
            this.txb_DoctorNo.Size = new System.Drawing.Size(206, 39);
            this.txb_DoctorNo.TabIndex = 194;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_Save.Location = new System.Drawing.Point(1219, 368);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(121, 66);
            this.btn_Save.TabIndex = 193;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_Submit.Location = new System.Drawing.Point(1219, 647);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(121, 66);
            this.btn_Submit.TabIndex = 192;
            this.btn_Submit.Text = "提交";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // cmb_PrescriptionNo
            // 
            this.cmb_PrescriptionNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_PrescriptionNo.FormattingEnabled = true;
            this.cmb_PrescriptionNo.Location = new System.Drawing.Point(696, 195);
            this.cmb_PrescriptionNo.Name = "cmb_PrescriptionNo";
            this.cmb_PrescriptionNo.Size = new System.Drawing.Size(200, 39);
            this.cmb_PrescriptionNo.TabIndex = 191;
            // 
            // lbl_PrescriptionNo
            // 
            this.lbl_PrescriptionNo.AutoSize = true;
            this.lbl_PrescriptionNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_PrescriptionNo.Location = new System.Drawing.Point(556, 203);
            this.lbl_PrescriptionNo.Name = "lbl_PrescriptionNo";
            this.lbl_PrescriptionNo.Size = new System.Drawing.Size(134, 31);
            this.lbl_PrescriptionNo.TabIndex = 190;
            this.lbl_PrescriptionNo.Text = "药方编号：";
            // 
            // cmb_ExamineItemsNo
            // 
            this.cmb_ExamineItemsNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_ExamineItemsNo.FormattingEnabled = true;
            this.cmb_ExamineItemsNo.Location = new System.Drawing.Point(1140, 195);
            this.cmb_ExamineItemsNo.Name = "cmb_ExamineItemsNo";
            this.cmb_ExamineItemsNo.Size = new System.Drawing.Size(200, 39);
            this.cmb_ExamineItemsNo.TabIndex = 189;
            // 
            // lbl_ExamineItemsNo
            // 
            this.lbl_ExamineItemsNo.AutoSize = true;
            this.lbl_ExamineItemsNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_ExamineItemsNo.Location = new System.Drawing.Point(1000, 203);
            this.lbl_ExamineItemsNo.Name = "lbl_ExamineItemsNo";
            this.lbl_ExamineItemsNo.Size = new System.Drawing.Size(134, 31);
            this.lbl_ExamineItemsNo.TabIndex = 188;
            this.lbl_ExamineItemsNo.Text = "检查编号：";
            // 
            // txb_Result
            // 
            this.txb_Result.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Result.Location = new System.Drawing.Point(274, 560);
            this.txb_Result.Multiline = true;
            this.txb_Result.Name = "txb_Result";
            this.txb_Result.Size = new System.Drawing.Size(860, 201);
            this.txb_Result.TabIndex = 187;
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Result.Location = new System.Drawing.Point(134, 563);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(134, 31);
            this.lbl_Result.TabIndex = 186;
            this.lbl_Result.Text = "诊断结果：";
            // 
            // txb_Description
            // 
            this.txb_Description.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Description.Location = new System.Drawing.Point(274, 309);
            this.txb_Description.Multiline = true;
            this.txb_Description.Name = "txb_Description";
            this.txb_Description.Size = new System.Drawing.Size(860, 201);
            this.txb_Description.TabIndex = 185;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Description.Location = new System.Drawing.Point(134, 312);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(134, 31);
            this.lbl_Description.TabIndex = 184;
            this.lbl_Description.Text = "病情描述：";
            // 
            // txb_PatientIDCard
            // 
            this.txb_PatientIDCard.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_PatientIDCard.Location = new System.Drawing.Point(228, 195);
            this.txb_PatientIDCard.Name = "txb_PatientIDCard";
            this.txb_PatientIDCard.Size = new System.Drawing.Size(260, 39);
            this.txb_PatientIDCard.TabIndex = 183;
            // 
            // lbl_PatientIDCard
            // 
            this.lbl_PatientIDCard.AutoSize = true;
            this.lbl_PatientIDCard.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_PatientIDCard.Location = new System.Drawing.Point(88, 203);
            this.lbl_PatientIDCard.Name = "lbl_PatientIDCard";
            this.lbl_PatientIDCard.Size = new System.Drawing.Size(134, 31);
            this.lbl_PatientIDCard.TabIndex = 182;
            this.lbl_PatientIDCard.Text = "医保卡号：";
            // 
            // cmb_Department
            // 
            this.cmb_Department.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Location = new System.Drawing.Point(696, 88);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(200, 39);
            this.cmb_Department.TabIndex = 181;
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Department.Location = new System.Drawing.Point(604, 96);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(86, 31);
            this.lbl_Department.TabIndex = 180;
            this.lbl_Department.Text = "科室：";
            // 
            // lbl_DoctorNo
            // 
            this.lbl_DoctorNo.AutoSize = true;
            this.lbl_DoctorNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_DoctorNo.Location = new System.Drawing.Point(1042, 88);
            this.lbl_DoctorNo.Name = "lbl_DoctorNo";
            this.lbl_DoctorNo.Size = new System.Drawing.Size(86, 31);
            this.lbl_DoctorNo.TabIndex = 179;
            this.lbl_DoctorNo.Text = "工号：";
            // 
            // txb_Hospital
            // 
            this.txb_Hospital.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Hospital.Location = new System.Drawing.Point(227, 88);
            this.txb_Hospital.Name = "txb_Hospital";
            this.txb_Hospital.Size = new System.Drawing.Size(261, 39);
            this.txb_Hospital.TabIndex = 178;
            this.txb_Hospital.Text = "福建省第三人民医院";
            // 
            // lbl_Hospital
            // 
            this.lbl_Hospital.AutoSize = true;
            this.lbl_Hospital.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Hospital.Location = new System.Drawing.Point(135, 96);
            this.lbl_Hospital.Name = "lbl_Hospital";
            this.lbl_Hospital.Size = new System.Drawing.Size(86, 31);
            this.lbl_Hospital.TabIndex = 177;
            this.lbl_Hospital.Text = "医院：";
            // 
            // frm_Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.txb_DoctorNo);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.cmb_PrescriptionNo);
            this.Controls.Add(this.lbl_PrescriptionNo);
            this.Controls.Add(this.cmb_ExamineItemsNo);
            this.Controls.Add(this.lbl_ExamineItemsNo);
            this.Controls.Add(this.txb_Result);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.txb_Description);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.txb_PatientIDCard);
            this.Controls.Add(this.lbl_PatientIDCard);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.lbl_DoctorNo);
            this.Controls.Add(this.txb_Hospital);
            this.Controls.Add(this.lbl_Hospital);
            this.Name = "frm_Diagnosis";
            this.Text = "诊断";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.TextBox txb_DoctorNo;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.ComboBox cmb_PrescriptionNo;
        private System.Windows.Forms.Label lbl_PrescriptionNo;
        private System.Windows.Forms.ComboBox cmb_ExamineItemsNo;
        private System.Windows.Forms.Label lbl_ExamineItemsNo;
        private System.Windows.Forms.TextBox txb_Result;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.TextBox txb_Description;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txb_PatientIDCard;
        private System.Windows.Forms.Label lbl_PatientIDCard;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Label lbl_DoctorNo;
        private System.Windows.Forms.TextBox txb_Hospital;
        private System.Windows.Forms.Label lbl_Hospital;
    }
}