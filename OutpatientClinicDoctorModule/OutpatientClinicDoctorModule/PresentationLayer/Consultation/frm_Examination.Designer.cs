﻿namespace OutpatientClinicDoctorModule
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
            this.dgv_Examinations = new System.Windows.Forms.DataGridView();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.nud_No = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Examination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Examinations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_No)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Examination
            // 
            this.dgv_Examination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Examination.Location = new System.Drawing.Point(-1, 2);
            this.dgv_Examination.Name = "dgv_Examination";
            this.dgv_Examination.RowHeadersWidth = 62;
            this.dgv_Examination.RowTemplate.Height = 30;
            this.dgv_Examination.Size = new System.Drawing.Size(630, 570);
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
            this.btn_Load.Location = new System.Drawing.Point(1168, 639);
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
            // dgv_Examinations
            // 
            this.dgv_Examinations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Examinations.Location = new System.Drawing.Point(780, 0);
            this.dgv_Examinations.Name = "dgv_Examinations";
            this.dgv_Examinations.RowHeadersWidth = 62;
            this.dgv_Examinations.RowTemplate.Height = 30;
            this.dgv_Examinations.Size = new System.Drawing.Size(630, 570);
            this.dgv_Examinations.TabIndex = 65;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Remove.Location = new System.Drawing.Point(646, 377);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(118, 49);
            this.btn_Remove.TabIndex = 67;
            this.btn_Remove.Text = "<<";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Add.Location = new System.Drawing.Point(646, 157);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(118, 49);
            this.btn_Add.TabIndex = 66;
            this.btn_Add.Text = ">>";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Submit.Location = new System.Drawing.Point(1168, 724);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(137, 58);
            this.btn_Submit.TabIndex = 68;
            this.btn_Submit.Text = "确定";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Price.ForeColor = System.Drawing.Color.Red;
            this.lbl_Price.Location = new System.Drawing.Point(784, 573);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(0, 31);
            this.lbl_Price.TabIndex = 69;
            // 
            // nud_No
            // 
            this.nud_No.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.nud_No.Location = new System.Drawing.Point(117, 659);
            this.nud_No.Name = "nud_No";
            this.nud_No.Size = new System.Drawing.Size(272, 39);
            this.nud_No.TabIndex = 70;
            // 
            // frm_Examination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.nud_No);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_Examinations);
            this.Controls.Add(this.lbl_Tip);
            this.Controls.Add(this.lbl_Pinyin);
            this.Controls.Add(this.txb_Pinyin);
            this.Controls.Add(this.lbl_KeyWord);
            this.Controls.Add(this.txb_KeyWord);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_SearchByName);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.btn_SearchByNo);
            this.Controls.Add(this.dgv_Examination);
            this.Name = "frm_Examination";
            this.Text = "检查项目";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Examination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Examinations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_No)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_Examinations;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.NumericUpDown nud_No;
    }
}