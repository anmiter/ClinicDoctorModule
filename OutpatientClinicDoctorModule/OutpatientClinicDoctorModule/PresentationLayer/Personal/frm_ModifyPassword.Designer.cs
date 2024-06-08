namespace OutpatientClinicDoctorModule
{
    partial class frm_ModifyPassword
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
            this.lbl_ConfirmPassword = new System.Windows.Forms.Label();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.txb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.txb_NewPassword = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ConfirmPassword
            // 
            this.lbl_ConfirmPassword.AutoSize = true;
            this.lbl_ConfirmPassword.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ConfirmPassword.Location = new System.Drawing.Point(467, 382);
            this.lbl_ConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            this.lbl_ConfirmPassword.Size = new System.Drawing.Size(167, 39);
            this.lbl_ConfirmPassword.TabIndex = 160;
            this.lbl_ConfirmPassword.Text = "确认密码：";
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_NewPassword.Location = new System.Drawing.Point(497, 295);
            this.lbl_NewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(137, 39);
            this.lbl_NewPassword.TabIndex = 159;
            this.lbl_NewPassword.Text = "新密码：";
            // 
            // txb_ConfirmPassword
            // 
            this.txb_ConfirmPassword.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_ConfirmPassword.Location = new System.Drawing.Point(642, 374);
            this.txb_ConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ConfirmPassword.Name = "txb_ConfirmPassword";
            this.txb_ConfirmPassword.PasswordChar = '*';
            this.txb_ConfirmPassword.Size = new System.Drawing.Size(320, 47);
            this.txb_ConfirmPassword.TabIndex = 158;
            // 
            // txb_NewPassword
            // 
            this.txb_NewPassword.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_NewPassword.Location = new System.Drawing.Point(642, 287);
            this.txb_NewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txb_NewPassword.Name = "txb_NewPassword";
            this.txb_NewPassword.PasswordChar = '*';
            this.txb_NewPassword.Size = new System.Drawing.Size(320, 47);
            this.txb_NewPassword.TabIndex = 157;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Save.Location = new System.Drawing.Point(731, 487);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(121, 66);
            this.btn_Save.TabIndex = 156;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // frm_ModifyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.lbl_ConfirmPassword);
            this.Controls.Add(this.lbl_NewPassword);
            this.Controls.Add(this.txb_ConfirmPassword);
            this.Controls.Add(this.txb_NewPassword);
            this.Controls.Add(this.btn_Save);
            this.Name = "frm_ModifyPassword";
            this.Text = "修改密码";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ConfirmPassword;
        private System.Windows.Forms.Label lbl_NewPassword;
        private System.Windows.Forms.TextBox txb_ConfirmPassword;
        private System.Windows.Forms.TextBox txb_NewPassword;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}