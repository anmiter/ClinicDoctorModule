namespace OutpatientClinicDoctorModule
{
    partial class frm_Examination
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
            this.dgv_Examination = new System.Windows.Forms.DataGridView();
            this.lbl_Tip = new System.Windows.Forms.Label();
            this.lbl_Pinyin = new System.Windows.Forms.Label();
            this.txb_Pinyin = new System.Windows.Forms.TextBox();
            this.lbl_KeyWord = new System.Windows.Forms.Label();
            this.txb_KeyWord = new System.Windows.Forms.TextBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_SearchByName = new System.Windows.Forms.Button();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.btn_SearchByNo = new System.Windows.Forms.Button();
            this.txb_No = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Examination)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Examination
            // 
            this.dgv_Examination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Examination.Location = new System.Drawing.Point(-1, 2);
            this.dgv_Examination.Name = "dgv_Examination";
            this.dgv_Examination.RowHeadersWidth = 62;
            this.dgv_Examination.RowTemplate.Height = 30;
            this.dgv_Examination.Size = new System.Drawing.Size(1428, 619);
            this.dgv_Examination.TabIndex = 39;
            // 
            // lbl_Tip
            // 
            this.lbl_Tip.AutoSize = true;
            this.lbl_Tip.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.lbl_Tip.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tip.Location = new System.Drawing.Point(808, 701);
            this.lbl_Tip.Name = "lbl_Tip";
            this.lbl_Tip.Size = new System.Drawing.Size(170, 21);
            this.lbl_Tip.TabIndex = 64;
            this.lbl_Tip.Text = "名称、类型中的关键字";
            // 
            // lbl_Pinyin
            // 
            this.lbl_Pinyin.AutoSize = true;
            this.lbl_Pinyin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Pinyin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Pinyin.Location = new System.Drawing.Point(671, 743);
            this.lbl_Pinyin.Name = "lbl_Pinyin";
            this.lbl_Pinyin.Size = new System.Drawing.Size(134, 31);
            this.lbl_Pinyin.TabIndex = 63;
            this.lbl_Pinyin.Text = "根据拼音：";
            // 
            // txb_Pinyin
            // 
            this.txb_Pinyin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Pinyin.Location = new System.Drawing.Point(812, 743);
            this.txb_Pinyin.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Pinyin.Name = "txb_Pinyin";
            this.txb_Pinyin.Size = new System.Drawing.Size(272, 39);
            this.txb_Pinyin.TabIndex = 62;
            this.txb_Pinyin.TextChanged += new System.EventHandler(this.txb_Pinyin_TextChanged);
            // 
            // lbl_KeyWord
            // 
            this.lbl_KeyWord.AutoSize = true;
            this.lbl_KeyWord.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_KeyWord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_KeyWord.Location = new System.Drawing.Point(671, 658);
            this.lbl_KeyWord.Name = "lbl_KeyWord";
            this.lbl_KeyWord.Size = new System.Drawing.Size(134, 31);
            this.lbl_KeyWord.TabIndex = 61;
            this.lbl_KeyWord.Text = "模糊查询：";
            // 
            // txb_KeyWord
            // 
            this.txb_KeyWord.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_KeyWord.Location = new System.Drawing.Point(812, 658);
            this.txb_KeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.txb_KeyWord.Name = "txb_KeyWord";
            this.txb_KeyWord.Size = new System.Drawing.Size(272, 39);
            this.txb_KeyWord.TabIndex = 60;
            this.txb_KeyWord.TextChanged += new System.EventHandler(this.txb_KeyWord_TextChanged);
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Load.Location = new System.Drawing.Point(1168, 690);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(137, 58);
            this.btn_Load.TabIndex = 59;
            this.btn_Load.Text = "重新载入";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_SearchByName
            // 
            this.btn_SearchByName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SearchByName.Location = new System.Drawing.Point(396, 743);
            this.btn_SearchByName.Name = "btn_SearchByName";
            this.btn_SearchByName.Size = new System.Drawing.Size(181, 43);
            this.btn_SearchByName.TabIndex = 58;
            this.btn_SearchByName.Text = "根据名称搜索";
            this.btn_SearchByName.UseVisualStyleBackColor = true;
            this.btn_SearchByName.Click += new System.EventHandler(this.btn_SearchByName_Click);
            // 
            // txb_Name
            // 
            this.txb_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_Name.Location = new System.Drawing.Point(117, 743);
            this.txb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(272, 39);
            this.txb_Name.TabIndex = 57;
            // 
            // btn_SearchByNo
            // 
            this.btn_SearchByNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SearchByNo.Location = new System.Drawing.Point(396, 658);
            this.btn_SearchByNo.Name = "btn_SearchByNo";
            this.btn_SearchByNo.Size = new System.Drawing.Size(181, 43);
            this.btn_SearchByNo.TabIndex = 56;
            this.btn_SearchByNo.Text = "根据编号搜索";
            this.btn_SearchByNo.UseVisualStyleBackColor = true;
            this.btn_SearchByNo.Click += new System.EventHandler(this.btn_SearchByNo_Click);
            // 
            // txb_No
            // 
            this.txb_No.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_No.Location = new System.Drawing.Point(117, 658);
            this.txb_No.Margin = new System.Windows.Forms.Padding(4);
            this.txb_No.Name = "txb_No";
            this.txb_No.Size = new System.Drawing.Size(272, 39);
            this.txb_No.TabIndex = 55;
            // 
            // frm_Examination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.lbl_Tip);
            this.Controls.Add(this.lbl_Pinyin);
            this.Controls.Add(this.txb_Pinyin);
            this.Controls.Add(this.lbl_KeyWord);
            this.Controls.Add(this.txb_KeyWord);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_SearchByName);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.btn_SearchByNo);
            this.Controls.Add(this.txb_No);
            this.Controls.Add(this.dgv_Examination);
            this.Name = "frm_Examination";
            this.Text = "检查项目";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Examination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Examination;
        private System.Windows.Forms.Label lbl_Tip;
        private System.Windows.Forms.Label lbl_Pinyin;
        private System.Windows.Forms.TextBox txb_Pinyin;
        private System.Windows.Forms.Label lbl_KeyWord;
        private System.Windows.Forms.TextBox txb_KeyWord;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_SearchByName;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Button btn_SearchByNo;
        private System.Windows.Forms.TextBox txb_No;
    }
}