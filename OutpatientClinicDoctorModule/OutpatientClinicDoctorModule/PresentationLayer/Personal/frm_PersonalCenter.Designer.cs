﻿namespace OutpatientClinicDoctorModule
{
    partial class frm_PersonalCenter
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
            this.components = new System.ComponentModel.Container();
            this.txb_Introduction = new System.Windows.Forms.TextBox();
            this.lbl_Introduction = new System.Windows.Forms.Label();
            this.cmb_Title = new System.Windows.Forms.ComboBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.btn_ModifyPassword = new System.Windows.Forms.Button();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.btn_OpenPhoto = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.ptb_Avatar = new System.Windows.Forms.PictureBox();
            this.nud_Age = new System.Windows.Forms.NumericUpDown();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.gpb_Gender = new System.Windows.Forms.GroupBox();
            this.rdb_Female = new System.Windows.Forms.RadioButton();
            this.txb_QQEmail = new System.Windows.Forms.TextBox();
            this.lbl_QQEmail = new System.Windows.Forms.Label();
            this.dtp_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_Birthdate = new System.Windows.Forms.Label();
            this.lbl_Telephone = new System.Windows.Forms.Label();
            this.txb_IDCardNo = new System.Windows.Forms.TextBox();
            this.lbl_IDCardNo = new System.Windows.Forms.Label();
            this.txb_Telephone = new System.Windows.Forms.TextBox();
            this.lbl_No = new System.Windows.Forms.Label();
            this.lbl_No1 = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Age)).BeginInit();
            this.gpb_Gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_Introduction
            // 
            this.txb_Introduction.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.txb_Introduction.Location = new System.Drawing.Point(1000, 105);
            this.txb_Introduction.Multiline = true;
            this.txb_Introduction.Name = "txb_Introduction";
            this.txb_Introduction.Size = new System.Drawing.Size(393, 167);
            this.txb_Introduction.TabIndex = 186;
            // 
            // lbl_Introduction
            // 
            this.lbl_Introduction.AutoSize = true;
            this.lbl_Introduction.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.lbl_Introduction.Location = new System.Drawing.Point(895, 113);
            this.lbl_Introduction.Name = "lbl_Introduction";
            this.lbl_Introduction.Size = new System.Drawing.Size(99, 36);
            this.lbl_Introduction.TabIndex = 185;
            this.lbl_Introduction.Text = "简介：";
            // 
            // cmb_Title
            // 
            this.cmb_Title.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.cmb_Title.FormattingEnabled = true;
            this.cmb_Title.Location = new System.Drawing.Point(534, 217);
            this.cmb_Title.Name = "cmb_Title";
            this.cmb_Title.Size = new System.Drawing.Size(235, 44);
            this.cmb_Title.TabIndex = 184;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.lbl_Title.Location = new System.Drawing.Point(429, 225);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(99, 36);
            this.lbl_Title.TabIndex = 183;
            this.lbl_Title.Text = "职称：";
            // 
            // cmb_Department
            // 
            this.cmb_Department.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Location = new System.Drawing.Point(534, 105);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(235, 44);
            this.cmb_Department.TabIndex = 182;
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.lbl_Department.Location = new System.Drawing.Point(429, 113);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(99, 36);
            this.lbl_Department.TabIndex = 181;
            this.lbl_Department.Text = "科室：";
            // 
            // btn_ModifyPassword
            // 
            this.btn_ModifyPassword.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_ModifyPassword.Location = new System.Drawing.Point(946, 660);
            this.btn_ModifyPassword.Name = "btn_ModifyPassword";
            this.btn_ModifyPassword.Size = new System.Drawing.Size(173, 66);
            this.btn_ModifyPassword.TabIndex = 180;
            this.btn_ModifyPassword.Text = "修改密码";
            this.btn_ModifyPassword.UseVisualStyleBackColor = true;
            this.btn_ModifyPassword.Click += new System.EventHandler(this.btn_ModifyPassword_Click);
            // 
            // rdb_Male
            // 
            this.rdb_Male.AutoSize = true;
            this.rdb_Male.Location = new System.Drawing.Point(58, 52);
            this.rdb_Male.Name = "rdb_Male";
            this.rdb_Male.Size = new System.Drawing.Size(68, 40);
            this.rdb_Male.TabIndex = 0;
            this.rdb_Male.TabStop = true;
            this.rdb_Male.Text = "男";
            this.rdb_Male.UseVisualStyleBackColor = true;
            // 
            // btn_OpenPhoto
            // 
            this.btn_OpenPhoto.Font = new System.Drawing.Font("宋体", 10F);
            this.btn_OpenPhoto.Location = new System.Drawing.Point(148, 415);
            this.btn_OpenPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OpenPhoto.Name = "btn_OpenPhoto";
            this.btn_OpenPhoto.Size = new System.Drawing.Size(112, 34);
            this.btn_OpenPhoto.TabIndex = 179;
            this.btn_OpenPhoto.Text = "*打开照片";
            this.btn_OpenPhoto.UseVisualStyleBackColor = true;
            this.btn_OpenPhoto.Click += new System.EventHandler(this.btn_OpenPhoto_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_Update.Location = new System.Drawing.Point(545, 675);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(121, 66);
            this.btn_Update.TabIndex = 178;
            this.btn_Update.Text = "更新";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // ptb_Avatar
            // 
            this.ptb_Avatar.Location = new System.Drawing.Point(51, 55);
            this.ptb_Avatar.Name = "ptb_Avatar";
            this.ptb_Avatar.Size = new System.Drawing.Size(311, 332);
            this.ptb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Avatar.TabIndex = 177;
            this.ptb_Avatar.TabStop = false;
            // 
            // nud_Age
            // 
            this.nud_Age.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.nud_Age.Location = new System.Drawing.Point(162, 675);
            this.nud_Age.Name = "nud_Age";
            this.nud_Age.Size = new System.Drawing.Size(200, 44);
            this.nud_Age.TabIndex = 176;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.lbl_Age.Location = new System.Drawing.Point(57, 683);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(99, 36);
            this.lbl_Age.TabIndex = 175;
            this.lbl_Age.Text = "年龄：";
            // 
            // txb_Name
            // 
            this.txb_Name.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.txb_Name.Location = new System.Drawing.Point(162, 592);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(200, 44);
            this.txb_Name.TabIndex = 174;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.lbl_Name.Location = new System.Drawing.Point(44, 600);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(112, 36);
            this.lbl_Name.TabIndex = 173;
            this.lbl_Name.Text = "*姓名：";
            // 
            // gpb_Gender
            // 
            this.gpb_Gender.Controls.Add(this.rdb_Female);
            this.gpb_Gender.Controls.Add(this.rdb_Male);
            this.gpb_Gender.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.gpb_Gender.Location = new System.Drawing.Point(445, 309);
            this.gpb_Gender.Name = "gpb_Gender";
            this.gpb_Gender.Size = new System.Drawing.Size(324, 113);
            this.gpb_Gender.TabIndex = 172;
            this.gpb_Gender.TabStop = false;
            this.gpb_Gender.Text = "性别";
            // 
            // rdb_Female
            // 
            this.rdb_Female.AutoSize = true;
            this.rdb_Female.Location = new System.Drawing.Point(195, 52);
            this.rdb_Female.Name = "rdb_Female";
            this.rdb_Female.Size = new System.Drawing.Size(68, 40);
            this.rdb_Female.TabIndex = 1;
            this.rdb_Female.TabStop = true;
            this.rdb_Female.Text = "女";
            this.rdb_Female.UseVisualStyleBackColor = true;
            // 
            // txb_QQEmail
            // 
            this.txb_QQEmail.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.txb_QQEmail.Location = new System.Drawing.Point(1000, 522);
            this.txb_QQEmail.Name = "txb_QQEmail";
            this.txb_QQEmail.Size = new System.Drawing.Size(393, 44);
            this.txb_QQEmail.TabIndex = 171;
            // 
            // lbl_QQEmail
            // 
            this.lbl_QQEmail.AutoSize = true;
            this.lbl_QQEmail.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.lbl_QQEmail.Location = new System.Drawing.Point(836, 530);
            this.lbl_QQEmail.Name = "lbl_QQEmail";
            this.lbl_QQEmail.Size = new System.Drawing.Size(158, 36);
            this.lbl_QQEmail.TabIndex = 170;
            this.lbl_QQEmail.Text = "*QQ邮箱：";
            // 
            // dtp_Birthdate
            // 
            this.dtp_Birthdate.CalendarFont = new System.Drawing.Font("宋体", 14F);
            this.dtp_Birthdate.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.dtp_Birthdate.Location = new System.Drawing.Point(503, 541);
            this.dtp_Birthdate.Name = "dtp_Birthdate";
            this.dtp_Birthdate.Size = new System.Drawing.Size(266, 44);
            this.dtp_Birthdate.TabIndex = 169;
            // 
            // lbl_Birthdate
            // 
            this.lbl_Birthdate.AutoSize = true;
            this.lbl_Birthdate.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.lbl_Birthdate.Location = new System.Drawing.Point(429, 479);
            this.lbl_Birthdate.Name = "lbl_Birthdate";
            this.lbl_Birthdate.Size = new System.Drawing.Size(155, 36);
            this.lbl_Birthdate.TabIndex = 168;
            this.lbl_Birthdate.Text = "出生日期：";
            // 
            // lbl_Telephone
            // 
            this.lbl_Telephone.AutoSize = true;
            this.lbl_Telephone.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.lbl_Telephone.Location = new System.Drawing.Point(826, 434);
            this.lbl_Telephone.Name = "lbl_Telephone";
            this.lbl_Telephone.Size = new System.Drawing.Size(168, 36);
            this.lbl_Telephone.TabIndex = 163;
            this.lbl_Telephone.Text = "*电话号码：";
            // 
            // txb_IDCardNo
            // 
            this.txb_IDCardNo.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.txb_IDCardNo.Location = new System.Drawing.Point(1000, 328);
            this.txb_IDCardNo.Name = "txb_IDCardNo";
            this.txb_IDCardNo.Size = new System.Drawing.Size(393, 44);
            this.txb_IDCardNo.TabIndex = 167;
            // 
            // lbl_IDCardNo
            // 
            this.lbl_IDCardNo.AutoSize = true;
            this.lbl_IDCardNo.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.lbl_IDCardNo.Location = new System.Drawing.Point(826, 336);
            this.lbl_IDCardNo.Name = "lbl_IDCardNo";
            this.lbl_IDCardNo.Size = new System.Drawing.Size(168, 36);
            this.lbl_IDCardNo.TabIndex = 166;
            this.lbl_IDCardNo.Text = "*身份证号：";
            // 
            // txb_Telephone
            // 
            this.txb_Telephone.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.txb_Telephone.Location = new System.Drawing.Point(1000, 426);
            this.txb_Telephone.Name = "txb_Telephone";
            this.txb_Telephone.Size = new System.Drawing.Size(393, 44);
            this.txb_Telephone.TabIndex = 165;
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.lbl_No.Location = new System.Drawing.Point(162, 515);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(127, 36);
            this.lbl_No.TabIndex = 164;
            this.lbl_No.Text = "1111111";
            // 
            // lbl_No1
            // 
            this.lbl_No1.AutoSize = true;
            this.lbl_No1.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.lbl_No1.Location = new System.Drawing.Point(57, 515);
            this.lbl_No1.Name = "lbl_No1";
            this.lbl_No1.Size = new System.Drawing.Size(99, 36);
            this.lbl_No1.TabIndex = 162;
            this.lbl_No1.Text = "工号：";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // frm_PersonalCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.txb_Introduction);
            this.Controls.Add(this.lbl_Introduction);
            this.Controls.Add(this.cmb_Title);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.btn_ModifyPassword);
            this.Controls.Add(this.btn_OpenPhoto);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.ptb_Avatar);
            this.Controls.Add(this.nud_Age);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.gpb_Gender);
            this.Controls.Add(this.txb_QQEmail);
            this.Controls.Add(this.lbl_QQEmail);
            this.Controls.Add(this.dtp_Birthdate);
            this.Controls.Add(this.lbl_Birthdate);
            this.Controls.Add(this.lbl_Telephone);
            this.Controls.Add(this.txb_IDCardNo);
            this.Controls.Add(this.lbl_IDCardNo);
            this.Controls.Add(this.txb_Telephone);
            this.Controls.Add(this.lbl_No);
            this.Controls.Add(this.lbl_No1);
            this.Name = "frm_PersonalCenter";
            this.Text = "个人中心";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Age)).EndInit();
            this.gpb_Gender.ResumeLayout(false);
            this.gpb_Gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Introduction;
        private System.Windows.Forms.Label lbl_Introduction;
        private System.Windows.Forms.ComboBox cmb_Title;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Button btn_ModifyPassword;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.Button btn_OpenPhoto;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.PictureBox ptb_Avatar;
        private System.Windows.Forms.NumericUpDown nud_Age;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.GroupBox gpb_Gender;
        private System.Windows.Forms.RadioButton rdb_Female;
        private System.Windows.Forms.TextBox txb_QQEmail;
        private System.Windows.Forms.Label lbl_QQEmail;
        private System.Windows.Forms.DateTimePicker dtp_Birthdate;
        private System.Windows.Forms.Label lbl_Birthdate;
        private System.Windows.Forms.Label lbl_Telephone;
        private System.Windows.Forms.TextBox txb_IDCardNo;
        private System.Windows.Forms.Label lbl_IDCardNo;
        private System.Windows.Forms.TextBox txb_Telephone;
        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.Label lbl_No1;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}