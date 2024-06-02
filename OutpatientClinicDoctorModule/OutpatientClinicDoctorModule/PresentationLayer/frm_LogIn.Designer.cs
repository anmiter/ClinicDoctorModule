namespace OutpatientClinicDoctorModule
{
    partial class frm_LogIn
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
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_RetrievePassword = new System.Windows.Forms.Button();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_No = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_No = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Register.Location = new System.Drawing.Point(781, 533);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(121, 66);
            this.btn_Register.TabIndex = 152;
            this.btn_Register.Text = "注册";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_RetrievePassword
            // 
            this.btn_RetrievePassword.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_RetrievePassword.Location = new System.Drawing.Point(781, 427);
            this.btn_RetrievePassword.Name = "btn_RetrievePassword";
            this.btn_RetrievePassword.Size = new System.Drawing.Size(147, 40);
            this.btn_RetrievePassword.TabIndex = 151;
            this.btn_RetrievePassword.Text = "找回密码";
            this.btn_RetrievePassword.UseVisualStyleBackColor = true;
            this.btn_RetrievePassword.Click += new System.EventHandler(this.btn_RetrievePassword_Click);
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LogIn.Location = new System.Drawing.Point(536, 533);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(121, 66);
            this.btn_LogIn.TabIndex = 150;
            this.btn_LogIn.Text = "登录";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Password.Location = new System.Drawing.Point(501, 381);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(107, 39);
            this.lbl_Password.TabIndex = 149;
            this.lbl_Password.Text = "密码：";
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_No.Location = new System.Drawing.Point(501, 250);
            this.lbl_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(107, 39);
            this.lbl_No.TabIndex = 148;
            this.lbl_No.Text = "工号：";
            // 
            // txb_Password
            // 
            this.txb_Password.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Password.Location = new System.Drawing.Point(608, 373);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(320, 47);
            this.txb_Password.TabIndex = 147;
            // 
            // txb_No
            // 
            this.txb_No.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_No.Location = new System.Drawing.Point(608, 242);
            this.txb_No.Margin = new System.Windows.Forms.Padding(4);
            this.txb_No.Name = "txb_No";
            this.txb_No.Size = new System.Drawing.Size(320, 47);
            this.txb_No.TabIndex = 146;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // frm_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_RetrievePassword);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_No);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_No);
            this.Name = "frm_LogIn";
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_RetrievePassword;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_No;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}