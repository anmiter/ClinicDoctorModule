namespace OutpatientClinicDoctorModule
{
    partial class frm_Register
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
            this.lbl_DoctorNo = new System.Windows.Forms.Label();
            this.txb_DoctorNo = new System.Windows.Forms.TextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Telephone = new System.Windows.Forms.Label();
            this.txb_Telephone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_DoctorNo
            // 
            this.lbl_DoctorNo.AutoSize = true;
            this.lbl_DoctorNo.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_DoctorNo.Location = new System.Drawing.Point(421, 219);
            this.lbl_DoctorNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DoctorNo.Name = "lbl_DoctorNo";
            this.lbl_DoctorNo.Size = new System.Drawing.Size(107, 39);
            this.lbl_DoctorNo.TabIndex = 34;
            this.lbl_DoctorNo.Text = "工号：";
            // 
            // txb_DoctorNo
            // 
            this.txb_DoctorNo.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txb_DoctorNo.Location = new System.Drawing.Point(536, 211);
            this.txb_DoctorNo.Margin = new System.Windows.Forms.Padding(4);
            this.txb_DoctorNo.Name = "txb_DoctorNo";
            this.txb_DoctorNo.Size = new System.Drawing.Size(320, 47);
            this.txb_DoctorNo.TabIndex = 33;
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Register.Location = new System.Drawing.Point(612, 497);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(121, 66);
            this.btn_Register.TabIndex = 32;
            this.btn_Register.Text = "注册";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_Password.Location = new System.Drawing.Point(421, 412);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(107, 39);
            this.lbl_Password.TabIndex = 31;
            this.lbl_Password.Text = "密码：";
            // 
            // txb_Password
            // 
            this.txb_Password.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txb_Password.Location = new System.Drawing.Point(536, 404);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(320, 47);
            this.txb_Password.TabIndex = 29;
            // 
            // lbl_Telephone
            // 
            this.lbl_Telephone.AutoSize = true;
            this.lbl_Telephone.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_Telephone.Location = new System.Drawing.Point(365, 316);
            this.lbl_Telephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Telephone.Name = "lbl_Telephone";
            this.lbl_Telephone.Size = new System.Drawing.Size(167, 39);
            this.lbl_Telephone.TabIndex = 47;
            this.lbl_Telephone.Text = "电话号码：";
            // 
            // txb_Telephone
            // 
            this.txb_Telephone.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txb_Telephone.Location = new System.Drawing.Point(536, 311);
            this.txb_Telephone.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Telephone.Name = "txb_Telephone";
            this.txb_Telephone.Size = new System.Drawing.Size(320, 47);
            this.txb_Telephone.TabIndex = 46;
            // 
            // frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.lbl_Telephone);
            this.Controls.Add(this.txb_Telephone);
            this.Controls.Add(this.lbl_DoctorNo);
            this.Controls.Add(this.txb_DoctorNo);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txb_Password);
            this.Name = "frm_Register";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DoctorNo;
        private System.Windows.Forms.TextBox txb_DoctorNo;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label lbl_Telephone;
        private System.Windows.Forms.TextBox txb_Telephone;
    }
}