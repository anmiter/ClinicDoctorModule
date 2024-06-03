namespace OutpatientClinicDoctorModule
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
            this.components = new System.ComponentModel.Container();
            this.btn_Load = new System.Windows.Forms.Button();
            this.txb_No = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txb_Result = new System.Windows.Forms.TextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.txb_Description = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txb_HealthCardNo = new System.Windows.Forms.TextBox();
            this.lbl_HealthCardNo = new System.Windows.Forms.Label();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.lbl_No = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.btn_Load.Location = new System.Drawing.Point(868, 127);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(113, 60);
            this.btn_Load.TabIndex = 210;
            this.btn_Load.Text = "载入";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // txb_No
            // 
            this.txb_No.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.txb_No.Location = new System.Drawing.Point(328, 38);
            this.txb_No.Name = "txb_No";
            this.txb_No.Size = new System.Drawing.Size(299, 42);
            this.txb_No.TabIndex = 209;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.btn_Save.Location = new System.Drawing.Point(690, 127);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(113, 60);
            this.btn_Save.TabIndex = 208;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.btn_Submit.Location = new System.Drawing.Point(1042, 127);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(113, 60);
            this.btn_Submit.TabIndex = 207;
            this.btn_Submit.Text = "提交";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txb_Result
            // 
            this.txb_Result.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Result.Location = new System.Drawing.Point(251, 533);
            this.txb_Result.Multiline = true;
            this.txb_Result.Name = "txb_Result";
            this.txb_Result.Size = new System.Drawing.Size(1058, 251);
            this.txb_Result.TabIndex = 206;
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.lbl_Result.Location = new System.Drawing.Point(100, 533);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(145, 35);
            this.lbl_Result.TabIndex = 205;
            this.lbl_Result.Text = "诊断结果：";
            // 
            // txb_Description
            // 
            this.txb_Description.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Description.Location = new System.Drawing.Point(251, 235);
            this.txb_Description.Multiline = true;
            this.txb_Description.Name = "txb_Description";
            this.txb_Description.Size = new System.Drawing.Size(1058, 251);
            this.txb_Description.TabIndex = 204;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.lbl_Description.Location = new System.Drawing.Point(100, 235);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(145, 35);
            this.lbl_Description.TabIndex = 203;
            this.lbl_Description.Text = "病情描述：";
            // 
            // txb_HealthCardNo
            // 
            this.txb_HealthCardNo.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.txb_HealthCardNo.Location = new System.Drawing.Point(328, 137);
            this.txb_HealthCardNo.Name = "txb_HealthCardNo";
            this.txb_HealthCardNo.Size = new System.Drawing.Size(299, 42);
            this.txb_HealthCardNo.TabIndex = 202;
            // 
            // lbl_HealthCardNo
            // 
            this.lbl_HealthCardNo.AutoSize = true;
            this.lbl_HealthCardNo.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.lbl_HealthCardNo.Location = new System.Drawing.Point(177, 144);
            this.lbl_HealthCardNo.Name = "lbl_HealthCardNo";
            this.lbl_HealthCardNo.Size = new System.Drawing.Size(145, 35);
            this.lbl_HealthCardNo.TabIndex = 201;
            this.lbl_HealthCardNo.Text = "医保卡号：";
            // 
            // cmb_Department
            // 
            this.cmb_Department.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Location = new System.Drawing.Point(783, 38);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(307, 43);
            this.cmb_Department.TabIndex = 200;
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.lbl_Department.Location = new System.Drawing.Point(684, 41);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(93, 35);
            this.lbl_Department.TabIndex = 199;
            this.lbl_Department.Text = "科室：";
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.lbl_No.Location = new System.Drawing.Point(229, 45);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(93, 35);
            this.lbl_No.TabIndex = 198;
            this.lbl_No.Text = "工号：";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.txb_No);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txb_Result);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.txb_Description);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.txb_HealthCardNo);
            this.Controls.Add(this.lbl_HealthCardNo);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.lbl_No);
            this.Name = "frm_Diagnosis";
            this.Text = "诊断";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.TextBox txb_No;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txb_Result;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.TextBox txb_Description;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txb_HealthCardNo;
        private System.Windows.Forms.Label lbl_HealthCardNo;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}