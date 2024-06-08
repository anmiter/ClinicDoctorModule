namespace OutpatientClinicDoctorModule
{
    partial class frm_Home
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
            this.btn_Sure = new System.Windows.Forms.Button();
            this.gpb_State = new System.Windows.Forms.GroupBox();
            this.rdb_ExaminationWait = new System.Windows.Forms.RadioButton();
            this.rdb_End = new System.Windows.Forms.RadioButton();
            this.rdb_NotReaction = new System.Windows.Forms.RadioButton();
            this.btn_SearchPrice = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_ReadCard = new System.Windows.Forms.Button();
            this.btn_CallNumber = new System.Windows.Forms.Button();
            this.ptb_Avatar = new System.Windows.Forms.PictureBox();
            this.btn_ModifyPrice = new System.Windows.Forms.Button();
            this.btn_TreatRecord = new System.Windows.Forms.Button();
            this.btn_Examination = new System.Windows.Forms.Button();
            this.btn_Prescription = new System.Windows.Forms.Button();
            this.btn_Diagnosis = new System.Windows.Forms.Button();
            this.lbl_HealthCardNo = new System.Windows.Forms.Label();
            this.lbl_HealthCardNo1 = new System.Windows.Forms.Label();
            this.btn_PersonalCenter = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_DoctorNo1 = new System.Windows.Forms.Label();
            this.lbl_Name1 = new System.Windows.Forms.Label();
            this.lbl_No = new System.Windows.Forms.Label();
            this.gpb_State.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sure
            // 
            this.btn_Sure.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btn_Sure.Location = new System.Drawing.Point(1192, 532);
            this.btn_Sure.Name = "btn_Sure";
            this.btn_Sure.Size = new System.Drawing.Size(86, 42);
            this.btn_Sure.TabIndex = 203;
            this.btn_Sure.Text = "确认";
            this.btn_Sure.UseVisualStyleBackColor = true;
            this.btn_Sure.Click += new System.EventHandler(this.btn_Sure_Click);
            // 
            // gpb_State
            // 
            this.gpb_State.Controls.Add(this.rdb_ExaminationWait);
            this.gpb_State.Controls.Add(this.rdb_End);
            this.gpb_State.Controls.Add(this.rdb_NotReaction);
            this.gpb_State.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.gpb_State.Location = new System.Drawing.Point(644, 482);
            this.gpb_State.Name = "gpb_State";
            this.gpb_State.Size = new System.Drawing.Size(511, 113);
            this.gpb_State.TabIndex = 202;
            this.gpb_State.TabStop = false;
            this.gpb_State.Text = "状态";
            // 
            // rdb_ExaminationWait
            // 
            this.rdb_ExaminationWait.AutoSize = true;
            this.rdb_ExaminationWait.Location = new System.Drawing.Point(24, 57);
            this.rdb_ExaminationWait.Name = "rdb_ExaminationWait";
            this.rdb_ExaminationWait.Size = new System.Drawing.Size(135, 35);
            this.rdb_ExaminationWait.TabIndex = 4;
            this.rdb_ExaminationWait.TabStop = true;
            this.rdb_ExaminationWait.Text = "体查等候";
            this.rdb_ExaminationWait.UseVisualStyleBackColor = true;
            // 
            // rdb_End
            // 
            this.rdb_End.AutoSize = true;
            this.rdb_End.Location = new System.Drawing.Point(198, 57);
            this.rdb_End.Name = "rdb_End";
            this.rdb_End.Size = new System.Drawing.Size(135, 35);
            this.rdb_End.TabIndex = 3;
            this.rdb_End.TabStop = true;
            this.rdb_End.Text = "就诊结束";
            this.rdb_End.UseVisualStyleBackColor = true;
            // 
            // rdb_NotReaction
            // 
            this.rdb_NotReaction.AutoSize = true;
            this.rdb_NotReaction.Location = new System.Drawing.Point(379, 57);
            this.rdb_NotReaction.Name = "rdb_NotReaction";
            this.rdb_NotReaction.Size = new System.Drawing.Size(111, 35);
            this.rdb_NotReaction.TabIndex = 2;
            this.rdb_NotReaction.TabStop = true;
            this.rdb_NotReaction.Text = "无应诊";
            this.rdb_NotReaction.UseVisualStyleBackColor = true;
            // 
            // btn_SearchPrice
            // 
            this.btn_SearchPrice.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_SearchPrice.Location = new System.Drawing.Point(872, 631);
            this.btn_SearchPrice.Name = "btn_SearchPrice";
            this.btn_SearchPrice.Size = new System.Drawing.Size(169, 66);
            this.btn_SearchPrice.TabIndex = 201;
            this.btn_SearchPrice.Text = "查询价目";
            this.btn_SearchPrice.UseVisualStyleBackColor = true;
            this.btn_SearchPrice.Click += new System.EventHandler(this.btn_SearchPrice_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.btn_LogOut.Location = new System.Drawing.Point(346, 631);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(150, 53);
            this.btn_LogOut.TabIndex = 200;
            this.btn_LogOut.Text = "退出账号";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_ReadCard
            // 
            this.btn_ReadCard.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_ReadCard.Location = new System.Drawing.Point(872, 233);
            this.btn_ReadCard.Name = "btn_ReadCard";
            this.btn_ReadCard.Size = new System.Drawing.Size(169, 66);
            this.btn_ReadCard.TabIndex = 199;
            this.btn_ReadCard.Text = "读卡";
            this.btn_ReadCard.UseVisualStyleBackColor = true;
            this.btn_ReadCard.Click += new System.EventHandler(this.btn_ReadCard_Click);
            // 
            // btn_CallNumber
            // 
            this.btn_CallNumber.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_CallNumber.Location = new System.Drawing.Point(634, 233);
            this.btn_CallNumber.Name = "btn_CallNumber";
            this.btn_CallNumber.Size = new System.Drawing.Size(169, 66);
            this.btn_CallNumber.TabIndex = 198;
            this.btn_CallNumber.Text = "叫号";
            this.btn_CallNumber.UseVisualStyleBackColor = true;
            this.btn_CallNumber.Click += new System.EventHandler(this.btn_CallNumber_Click);
            // 
            // ptb_Avatar
            // 
            this.ptb_Avatar.Location = new System.Drawing.Point(182, 143);
            this.ptb_Avatar.Name = "ptb_Avatar";
            this.ptb_Avatar.Size = new System.Drawing.Size(262, 289);
            this.ptb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Avatar.TabIndex = 197;
            this.ptb_Avatar.TabStop = false;
            // 
            // btn_ModifyPrice
            // 
            this.btn_ModifyPrice.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_ModifyPrice.Location = new System.Drawing.Point(634, 631);
            this.btn_ModifyPrice.Name = "btn_ModifyPrice";
            this.btn_ModifyPrice.Size = new System.Drawing.Size(169, 66);
            this.btn_ModifyPrice.TabIndex = 196;
            this.btn_ModifyPrice.Text = "修改价目";
            this.btn_ModifyPrice.UseVisualStyleBackColor = true;
            this.btn_ModifyPrice.Click += new System.EventHandler(this.btn_ModifyPrice_Click);
            // 
            // btn_TreatRecord
            // 
            this.btn_TreatRecord.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_TreatRecord.Location = new System.Drawing.Point(1109, 233);
            this.btn_TreatRecord.Name = "btn_TreatRecord";
            this.btn_TreatRecord.Size = new System.Drawing.Size(169, 66);
            this.btn_TreatRecord.TabIndex = 195;
            this.btn_TreatRecord.Text = "病历";
            this.btn_TreatRecord.UseVisualStyleBackColor = true;
            this.btn_TreatRecord.Click += new System.EventHandler(this.btn_TreatRecord_Click);
            // 
            // btn_Examination
            // 
            this.btn_Examination.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_Examination.Location = new System.Drawing.Point(1109, 380);
            this.btn_Examination.Name = "btn_Examination";
            this.btn_Examination.Size = new System.Drawing.Size(169, 66);
            this.btn_Examination.TabIndex = 194;
            this.btn_Examination.Text = "检查项目";
            this.btn_Examination.UseVisualStyleBackColor = true;
            this.btn_Examination.Click += new System.EventHandler(this.btn_Examination_Click);
            // 
            // btn_Prescription
            // 
            this.btn_Prescription.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_Prescription.Location = new System.Drawing.Point(872, 380);
            this.btn_Prescription.Name = "btn_Prescription";
            this.btn_Prescription.Size = new System.Drawing.Size(169, 66);
            this.btn_Prescription.TabIndex = 193;
            this.btn_Prescription.Text = "处方";
            this.btn_Prescription.UseVisualStyleBackColor = true;
            this.btn_Prescription.Click += new System.EventHandler(this.btn_Prescription_Click);
            // 
            // btn_Diagnosis
            // 
            this.btn_Diagnosis.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_Diagnosis.Location = new System.Drawing.Point(634, 380);
            this.btn_Diagnosis.Name = "btn_Diagnosis";
            this.btn_Diagnosis.Size = new System.Drawing.Size(169, 66);
            this.btn_Diagnosis.TabIndex = 192;
            this.btn_Diagnosis.Text = "诊断";
            this.btn_Diagnosis.UseVisualStyleBackColor = true;
            this.btn_Diagnosis.Click += new System.EventHandler(this.btn_Diagnosis_Click);
            // 
            // lbl_HealthCardNo
            // 
            this.lbl_HealthCardNo.AutoSize = true;
            this.lbl_HealthCardNo.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_HealthCardNo.Location = new System.Drawing.Point(907, 143);
            this.lbl_HealthCardNo.Name = "lbl_HealthCardNo";
            this.lbl_HealthCardNo.Size = new System.Drawing.Size(0, 39);
            this.lbl_HealthCardNo.TabIndex = 191;
            // 
            // lbl_HealthCardNo1
            // 
            this.lbl_HealthCardNo1.AutoSize = true;
            this.lbl_HealthCardNo1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_HealthCardNo1.Location = new System.Drawing.Point(637, 143);
            this.lbl_HealthCardNo1.Name = "lbl_HealthCardNo1";
            this.lbl_HealthCardNo1.Size = new System.Drawing.Size(264, 39);
            this.lbl_HealthCardNo1.TabIndex = 190;
            this.lbl_HealthCardNo1.Text = "现就诊的病人编号:";
            // 
            // btn_PersonalCenter
            // 
            this.btn_PersonalCenter.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.btn_PersonalCenter.Location = new System.Drawing.Point(151, 631);
            this.btn_PersonalCenter.Name = "btn_PersonalCenter";
            this.btn_PersonalCenter.Size = new System.Drawing.Size(150, 53);
            this.btn_PersonalCenter.TabIndex = 189;
            this.btn_PersonalCenter.Text = "个人中心";
            this.btn_PersonalCenter.UseVisualStyleBackColor = true;
            this.btn_PersonalCenter.Click += new System.EventHandler(this.btn_PersonalCenter_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_Name.Location = new System.Drawing.Point(282, 468);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(0, 39);
            this.lbl_Name.TabIndex = 187;
            // 
            // lbl_DoctorNo1
            // 
            this.lbl_DoctorNo1.AutoSize = true;
            this.lbl_DoctorNo1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_DoctorNo1.Location = new System.Drawing.Point(192, 544);
            this.lbl_DoctorNo1.Name = "lbl_DoctorNo1";
            this.lbl_DoctorNo1.Size = new System.Drawing.Size(84, 39);
            this.lbl_DoctorNo1.TabIndex = 186;
            this.lbl_DoctorNo1.Text = "工号:";
            // 
            // lbl_Name1
            // 
            this.lbl_Name1.AutoSize = true;
            this.lbl_Name1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_Name1.Location = new System.Drawing.Point(192, 468);
            this.lbl_Name1.Name = "lbl_Name1";
            this.lbl_Name1.Size = new System.Drawing.Size(84, 39);
            this.lbl_Name1.TabIndex = 185;
            this.lbl_Name1.Text = "姓名:";
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_No.Location = new System.Drawing.Point(282, 544);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(0, 39);
            this.lbl_No.TabIndex = 188;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.btn_Sure);
            this.Controls.Add(this.gpb_State);
            this.Controls.Add(this.btn_SearchPrice);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_ReadCard);
            this.Controls.Add(this.btn_CallNumber);
            this.Controls.Add(this.ptb_Avatar);
            this.Controls.Add(this.btn_ModifyPrice);
            this.Controls.Add(this.btn_TreatRecord);
            this.Controls.Add(this.btn_Examination);
            this.Controls.Add(this.btn_Prescription);
            this.Controls.Add(this.btn_Diagnosis);
            this.Controls.Add(this.lbl_HealthCardNo);
            this.Controls.Add(this.lbl_HealthCardNo1);
            this.Controls.Add(this.btn_PersonalCenter);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_DoctorNo1);
            this.Controls.Add(this.lbl_Name1);
            this.Controls.Add(this.lbl_No);
            this.Name = "frm_Home";
            this.Text = "首页";
            this.gpb_State.ResumeLayout(false);
            this.gpb_State.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sure;
        private System.Windows.Forms.GroupBox gpb_State;
        private System.Windows.Forms.RadioButton rdb_ExaminationWait;
        private System.Windows.Forms.RadioButton rdb_End;
        private System.Windows.Forms.RadioButton rdb_NotReaction;
        private System.Windows.Forms.Button btn_SearchPrice;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_ReadCard;
        private System.Windows.Forms.Button btn_CallNumber;
        private System.Windows.Forms.PictureBox ptb_Avatar;
        private System.Windows.Forms.Button btn_ModifyPrice;
        private System.Windows.Forms.Button btn_TreatRecord;
        private System.Windows.Forms.Button btn_Examination;
        private System.Windows.Forms.Button btn_Prescription;
        private System.Windows.Forms.Button btn_Diagnosis;
        private System.Windows.Forms.Label lbl_HealthCardNo;
        private System.Windows.Forms.Label lbl_HealthCardNo1;
        private System.Windows.Forms.Button btn_PersonalCenter;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_DoctorNo1;
        private System.Windows.Forms.Label lbl_Name1;
        private System.Windows.Forms.Label lbl_No;
    }
}