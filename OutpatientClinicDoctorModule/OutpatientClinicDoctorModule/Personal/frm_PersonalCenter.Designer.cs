namespace OutpatientClinicDoctorModule.Personal
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
            this.btn_OpenPhoto = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.ptb_Avatar = new System.Windows.Forms.PictureBox();
            this.nud_Age = new System.Windows.Forms.NumericUpDown();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.gpb_Gender = new System.Windows.Forms.GroupBox();
            this.rdb_Female = new System.Windows.Forms.RadioButton();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.dtp_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_Birthdate = new System.Windows.Forms.Label();
            this.txb_Identification = new System.Windows.Forms.TextBox();
            this.lbl_Identification = new System.Windows.Forms.Label();
            this.txb_Telephone = new System.Windows.Forms.TextBox();
            this.lbl_DoctorNo = new System.Windows.Forms.Label();
            this.lbl_Telephone = new System.Windows.Forms.Label();
            this.lbl_DoctorNo1 = new System.Windows.Forms.Label();
            this.btn_ModifyPassword = new System.Windows.Forms.Button();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.cmb_Title = new System.Windows.Forms.ComboBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Introduction = new System.Windows.Forms.Label();
            this.txb_Introduction = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Age)).BeginInit();
            this.gpb_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OpenPhoto
            // 
            this.btn_OpenPhoto.Location = new System.Drawing.Point(146, 441);
            this.btn_OpenPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OpenPhoto.Name = "btn_OpenPhoto";
            this.btn_OpenPhoto.Size = new System.Drawing.Size(112, 34);
            this.btn_OpenPhoto.TabIndex = 153;
            this.btn_OpenPhoto.Text = "*打开照片";
            this.btn_OpenPhoto.UseVisualStyleBackColor = true;
            this.btn_OpenPhoto.Click += new System.EventHandler(this.btn_OpenPhoto_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_Update.Location = new System.Drawing.Point(585, 672);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(121, 66);
            this.btn_Update.TabIndex = 152;
            this.btn_Update.Text = "更新";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // ptb_Avatar
            // 
            this.ptb_Avatar.Location = new System.Drawing.Point(68, 97);
            this.ptb_Avatar.Name = "ptb_Avatar";
            this.ptb_Avatar.Size = new System.Drawing.Size(291, 323);
            this.ptb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Avatar.TabIndex = 151;
            this.ptb_Avatar.TabStop = false;
            // 
            // nud_Age
            // 
            this.nud_Age.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.nud_Age.Location = new System.Drawing.Point(146, 669);
            this.nud_Age.Name = "nud_Age";
            this.nud_Age.Size = new System.Drawing.Size(200, 39);
            this.nud_Age.TabIndex = 149;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Age.Location = new System.Drawing.Point(54, 671);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(86, 31);
            this.lbl_Age.TabIndex = 147;
            this.lbl_Age.Text = "年龄：";
            // 
            // txb_Name
            // 
            this.txb_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Name.Location = new System.Drawing.Point(146, 586);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(200, 39);
            this.txb_Name.TabIndex = 146;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Name.Location = new System.Drawing.Point(43, 594);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(97, 31);
            this.lbl_Name.TabIndex = 145;
            this.lbl_Name.Text = "*姓名：";
            // 
            // gpb_Gender
            // 
            this.gpb_Gender.Controls.Add(this.rdb_Female);
            this.gpb_Gender.Controls.Add(this.rdb_Male);
            this.gpb_Gender.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.gpb_Gender.Location = new System.Drawing.Point(432, 333);
            this.gpb_Gender.Name = "gpb_Gender";
            this.gpb_Gender.Size = new System.Drawing.Size(286, 113);
            this.gpb_Gender.TabIndex = 144;
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
            // txb_Email
            // 
            this.txb_Email.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Email.Location = new System.Drawing.Point(984, 519);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(370, 39);
            this.txb_Email.TabIndex = 141;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Email.Location = new System.Drawing.Point(841, 527);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(137, 31);
            this.lbl_Email.TabIndex = 140;
            this.lbl_Email.Text = "*QQ邮箱：";
            // 
            // dtp_Birthdate
            // 
            this.dtp_Birthdate.CalendarFont = new System.Drawing.Font("宋体", 14F);
            this.dtp_Birthdate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dtp_Birthdate.Location = new System.Drawing.Point(487, 554);
            this.dtp_Birthdate.Name = "dtp_Birthdate";
            this.dtp_Birthdate.Size = new System.Drawing.Size(240, 39);
            this.dtp_Birthdate.TabIndex = 139;
            // 
            // lbl_Birthdate
            // 
            this.lbl_Birthdate.AutoSize = true;
            this.lbl_Birthdate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Birthdate.Location = new System.Drawing.Point(435, 509);
            this.lbl_Birthdate.Name = "lbl_Birthdate";
            this.lbl_Birthdate.Size = new System.Drawing.Size(134, 31);
            this.lbl_Birthdate.TabIndex = 138;
            this.lbl_Birthdate.Text = "出生日期：";
            // 
            // txb_Identification
            // 
            this.txb_Identification.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Identification.Location = new System.Drawing.Point(984, 325);
            this.txb_Identification.Name = "txb_Identification";
            this.txb_Identification.Size = new System.Drawing.Size(370, 39);
            this.txb_Identification.TabIndex = 137;
            // 
            // lbl_Identification
            // 
            this.lbl_Identification.AutoSize = true;
            this.lbl_Identification.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Identification.Location = new System.Drawing.Point(829, 333);
            this.lbl_Identification.Name = "lbl_Identification";
            this.lbl_Identification.Size = new System.Drawing.Size(145, 31);
            this.lbl_Identification.TabIndex = 136;
            this.lbl_Identification.Text = "*身份证号：";
            // 
            // txb_Telephone
            // 
            this.txb_Telephone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Telephone.Location = new System.Drawing.Point(984, 423);
            this.txb_Telephone.Name = "txb_Telephone";
            this.txb_Telephone.Size = new System.Drawing.Size(370, 39);
            this.txb_Telephone.TabIndex = 135;
            // 
            // lbl_DoctorNo
            // 
            this.lbl_DoctorNo.AutoSize = true;
            this.lbl_DoctorNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_DoctorNo.Location = new System.Drawing.Point(177, 516);
            this.lbl_DoctorNo.Name = "lbl_DoctorNo";
            this.lbl_DoctorNo.Size = new System.Drawing.Size(0, 31);
            this.lbl_DoctorNo.TabIndex = 134;
            // 
            // lbl_Telephone
            // 
            this.lbl_Telephone.AutoSize = true;
            this.lbl_Telephone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Telephone.Location = new System.Drawing.Point(833, 431);
            this.lbl_Telephone.Name = "lbl_Telephone";
            this.lbl_Telephone.Size = new System.Drawing.Size(145, 31);
            this.lbl_Telephone.TabIndex = 133;
            this.lbl_Telephone.Text = "*电话号码：";
            // 
            // lbl_DoctorNo1
            // 
            this.lbl_DoctorNo1.AutoSize = true;
            this.lbl_DoctorNo1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_DoctorNo1.Location = new System.Drawing.Point(85, 516);
            this.lbl_DoctorNo1.Name = "lbl_DoctorNo1";
            this.lbl_DoctorNo1.Size = new System.Drawing.Size(86, 31);
            this.lbl_DoctorNo1.TabIndex = 132;
            this.lbl_DoctorNo1.Text = "工号：";
            // 
            // btn_ModifyPassword
            // 
            this.btn_ModifyPassword.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_ModifyPassword.Location = new System.Drawing.Point(916, 672);
            this.btn_ModifyPassword.Name = "btn_ModifyPassword";
            this.btn_ModifyPassword.Size = new System.Drawing.Size(173, 66);
            this.btn_ModifyPassword.TabIndex = 155;
            this.btn_ModifyPassword.Text = "修改密码";
            this.btn_ModifyPassword.UseVisualStyleBackColor = true;
            this.btn_ModifyPassword.Click += new System.EventHandler(this.btn_ModifyPassword_Click);
            // 
            // cmb_Department
            // 
            this.cmb_Department.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Location = new System.Drawing.Point(518, 102);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(200, 39);
            this.cmb_Department.TabIndex = 157;
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Department.Location = new System.Drawing.Point(426, 110);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(86, 31);
            this.lbl_Department.TabIndex = 156;
            this.lbl_Department.Text = "科室：";
            // 
            // cmb_Title
            // 
            this.cmb_Title.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_Title.FormattingEnabled = true;
            this.cmb_Title.Location = new System.Drawing.Point(518, 214);
            this.cmb_Title.Name = "cmb_Title";
            this.cmb_Title.Size = new System.Drawing.Size(200, 39);
            this.cmb_Title.TabIndex = 159;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Title.Location = new System.Drawing.Point(426, 222);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(86, 31);
            this.lbl_Title.TabIndex = 158;
            this.lbl_Title.Text = "职称：";
            // 
            // lbl_Introduction
            // 
            this.lbl_Introduction.AutoSize = true;
            this.lbl_Introduction.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Introduction.Location = new System.Drawing.Point(888, 105);
            this.lbl_Introduction.Name = "lbl_Introduction";
            this.lbl_Introduction.Size = new System.Drawing.Size(86, 31);
            this.lbl_Introduction.TabIndex = 160;
            this.lbl_Introduction.Text = "简介：";
            // 
            // txb_Introduction
            // 
            this.txb_Introduction.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Introduction.Location = new System.Drawing.Point(984, 102);
            this.txb_Introduction.Multiline = true;
            this.txb_Introduction.Name = "txb_Introduction";
            this.txb_Introduction.Size = new System.Drawing.Size(370, 167);
            this.txb_Introduction.TabIndex = 161;
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
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.dtp_Birthdate);
            this.Controls.Add(this.lbl_Birthdate);
            this.Controls.Add(this.txb_Identification);
            this.Controls.Add(this.lbl_Identification);
            this.Controls.Add(this.txb_Telephone);
            this.Controls.Add(this.lbl_DoctorNo);
            this.Controls.Add(this.lbl_Telephone);
            this.Controls.Add(this.lbl_DoctorNo1);
            this.Name = "frm_PersonalCenter";
            this.Text = "个人中心";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Age)).EndInit();
            this.gpb_Gender.ResumeLayout(false);
            this.gpb_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenPhoto;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.PictureBox ptb_Avatar;
        private System.Windows.Forms.NumericUpDown nud_Age;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.GroupBox gpb_Gender;
        private System.Windows.Forms.RadioButton rdb_Female;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.DateTimePicker dtp_Birthdate;
        private System.Windows.Forms.Label lbl_Birthdate;
        private System.Windows.Forms.TextBox txb_Identification;
        private System.Windows.Forms.Label lbl_Identification;
        private System.Windows.Forms.TextBox txb_Telephone;
        private System.Windows.Forms.Label lbl_DoctorNo;
        private System.Windows.Forms.Label lbl_Telephone;
        private System.Windows.Forms.Label lbl_DoctorNo1;
        private System.Windows.Forms.Button btn_ModifyPassword;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.ComboBox cmb_Title;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Introduction;
        private System.Windows.Forms.TextBox txb_Introduction;
    }
}