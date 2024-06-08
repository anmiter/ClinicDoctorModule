namespace OutpatientClinicDoctorModule
{
    partial class frm_SignUp
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
            this.lbl_Telephone = new System.Windows.Forms.Label();
            this.txb_Telephone = new System.Windows.Forms.TextBox();
            this.lbl_No = new System.Windows.Forms.Label();
            this.txb_No = new System.Windows.Forms.TextBox();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Telephone
            // 
            this.lbl_Telephone.AutoSize = true;
            this.lbl_Telephone.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_Telephone.Location = new System.Drawing.Point(469, 349);
            this.lbl_Telephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Telephone.Name = "lbl_Telephone";
            this.lbl_Telephone.Size = new System.Drawing.Size(167, 39);
            this.lbl_Telephone.TabIndex = 61;
            this.lbl_Telephone.Text = "电话号码：";
            // 
            // txb_Telephone
            // 
            this.txb_Telephone.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txb_Telephone.Location = new System.Drawing.Point(640, 344);
            this.txb_Telephone.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Telephone.Name = "txb_Telephone";
            this.txb_Telephone.Size = new System.Drawing.Size(320, 47);
            this.txb_Telephone.TabIndex = 60;
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_No.Location = new System.Drawing.Point(525, 252);
            this.lbl_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(107, 39);
            this.lbl_No.TabIndex = 59;
            this.lbl_No.Text = "工号：";
            // 
            // txb_No
            // 
            this.txb_No.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txb_No.Location = new System.Drawing.Point(640, 244);
            this.txb_No.Margin = new System.Windows.Forms.Padding(4);
            this.txb_No.Name = "txb_No";
            this.txb_No.Size = new System.Drawing.Size(320, 47);
            this.txb_No.TabIndex = 58;
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SignUp.Location = new System.Drawing.Point(716, 530);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(121, 66);
            this.btn_SignUp.TabIndex = 57;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbl_Password.Location = new System.Drawing.Point(525, 445);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(107, 39);
            this.lbl_Password.TabIndex = 56;
            this.lbl_Password.Text = "密码：";
            // 
            // txb_Password
            // 
            this.txb_Password.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.txb_Password.Location = new System.Drawing.Point(640, 437);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(320, 47);
            this.txb_Password.TabIndex = 55;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // frm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.lbl_Telephone);
            this.Controls.Add(this.txb_Telephone);
            this.Controls.Add(this.lbl_No);
            this.Controls.Add(this.txb_No);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txb_Password);
            this.Name = "frm_SignUp";
            this.Text = "注册";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Telephone;
        private System.Windows.Forms.TextBox txb_Telephone;
        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.TextBox txb_No;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}