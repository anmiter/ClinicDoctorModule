namespace OutpatientClinicDoctorModule
{
    partial class frm_RetrievePassword
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
            this.btn_SendEmail = new System.Windows.Forms.Button();
            this.lbl_QQEmail = new System.Windows.Forms.Label();
            this.txb_QQEmail = new System.Windows.Forms.TextBox();
            this.lbl_DoctorNo = new System.Windows.Forms.Label();
            this.txb_DoctorNo = new System.Windows.Forms.TextBox();
            this.btn_RetrievePassword = new System.Windows.Forms.Button();
            this.lbl_VerificationCode = new System.Windows.Forms.Label();
            this.txb_VerificationCode = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_SendEmail
            // 
            this.btn_SendEmail.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btn_SendEmail.Location = new System.Drawing.Point(793, 460);
            this.btn_SendEmail.Name = "btn_SendEmail";
            this.btn_SendEmail.Size = new System.Drawing.Size(124, 43);
            this.btn_SendEmail.TabIndex = 48;
            this.btn_SendEmail.Text = "发送验证码";
            this.btn_SendEmail.UseVisualStyleBackColor = true;
            this.btn_SendEmail.Click += new System.EventHandler(this.btn_SendEmail_Click);
            // 
            // lbl_QQEmail
            // 
            this.lbl_QQEmail.AutoSize = true;
            this.lbl_QQEmail.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_QQEmail.Location = new System.Drawing.Point(442, 316);
            this.lbl_QQEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_QQEmail.Name = "lbl_QQEmail";
            this.lbl_QQEmail.Size = new System.Drawing.Size(155, 39);
            this.lbl_QQEmail.TabIndex = 47;
            this.lbl_QQEmail.Text = "QQ邮箱：";
            // 
            // txb_QQEmail
            // 
            this.txb_QQEmail.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txb_QQEmail.Location = new System.Drawing.Point(597, 308);
            this.txb_QQEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txb_QQEmail.Name = "txb_QQEmail";
            this.txb_QQEmail.Size = new System.Drawing.Size(320, 47);
            this.txb_QQEmail.TabIndex = 46;
            // 
            // lbl_DoctorNo
            // 
            this.lbl_DoctorNo.AutoSize = true;
            this.lbl_DoctorNo.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_DoctorNo.Location = new System.Drawing.Point(490, 213);
            this.lbl_DoctorNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DoctorNo.Name = "lbl_DoctorNo";
            this.lbl_DoctorNo.Size = new System.Drawing.Size(107, 39);
            this.lbl_DoctorNo.TabIndex = 45;
            this.lbl_DoctorNo.Text = "工号：";
            // 
            // txb_DoctorNo
            // 
            this.txb_DoctorNo.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txb_DoctorNo.Location = new System.Drawing.Point(597, 205);
            this.txb_DoctorNo.Margin = new System.Windows.Forms.Padding(4);
            this.txb_DoctorNo.Name = "txb_DoctorNo";
            this.txb_DoctorNo.Size = new System.Drawing.Size(320, 47);
            this.txb_DoctorNo.TabIndex = 44;
            // 
            // btn_RetrievePassword
            // 
            this.btn_RetrievePassword.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_RetrievePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_RetrievePassword.Location = new System.Drawing.Point(668, 562);
            this.btn_RetrievePassword.Name = "btn_RetrievePassword";
            this.btn_RetrievePassword.Size = new System.Drawing.Size(181, 66);
            this.btn_RetrievePassword.TabIndex = 43;
            this.btn_RetrievePassword.Text = "重置密码";
            this.btn_RetrievePassword.UseVisualStyleBackColor = true;
            this.btn_RetrievePassword.Click += new System.EventHandler(this.btn_RetrievePassword_Click);
            // 
            // lbl_VerificationCode
            // 
            this.lbl_VerificationCode.AutoSize = true;
            this.lbl_VerificationCode.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_VerificationCode.Location = new System.Drawing.Point(460, 414);
            this.lbl_VerificationCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_VerificationCode.Name = "lbl_VerificationCode";
            this.lbl_VerificationCode.Size = new System.Drawing.Size(137, 39);
            this.lbl_VerificationCode.TabIndex = 41;
            this.lbl_VerificationCode.Text = "验证码：";
            // 
            // txb_VerificationCode
            // 
            this.txb_VerificationCode.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_VerificationCode.Location = new System.Drawing.Point(597, 406);
            this.txb_VerificationCode.Margin = new System.Windows.Forms.Padding(4);
            this.txb_VerificationCode.Name = "txb_VerificationCode";
            this.txb_VerificationCode.PasswordChar = '*';
            this.txb_VerificationCode.Size = new System.Drawing.Size(320, 47);
            this.txb_VerificationCode.TabIndex = 40;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frm_RetrievePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.btn_SendEmail);
            this.Controls.Add(this.lbl_QQEmail);
            this.Controls.Add(this.txb_QQEmail);
            this.Controls.Add(this.lbl_DoctorNo);
            this.Controls.Add(this.txb_DoctorNo);
            this.Controls.Add(this.btn_RetrievePassword);
            this.Controls.Add(this.lbl_VerificationCode);
            this.Controls.Add(this.txb_VerificationCode);
            this.Name = "frm_RetrievePassword";
            this.Text = "找回密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SendEmail;
        private System.Windows.Forms.Label lbl_QQEmail;
        private System.Windows.Forms.TextBox txb_QQEmail;
        private System.Windows.Forms.Label lbl_DoctorNo;
        private System.Windows.Forms.TextBox txb_DoctorNo;
        private System.Windows.Forms.Button btn_RetrievePassword;
        private System.Windows.Forms.Label lbl_VerificationCode;
        private System.Windows.Forms.TextBox txb_VerificationCode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}