namespace OutpatientClinicDoctorModule
{
    partial class frm_Prescription
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
            this.tp_Drug = new System.Windows.Forms.TabPage();
            this.lbl_Tip2 = new System.Windows.Forms.Label();
            this.lbl_DrugPinyin = new System.Windows.Forms.Label();
            this.txb_DrugPinyin = new System.Windows.Forms.TextBox();
            this.txb_DrugKeyWord = new System.Windows.Forms.TextBox();
            this.txb_DrugName = new System.Windows.Forms.TextBox();
            this.txb_DrugNo = new System.Windows.Forms.TextBox();
            this.lbl_Drug = new System.Windows.Forms.Label();
            this.btn_LoadDrug = new System.Windows.Forms.Button();
            this.btn_SearchDrugByName = new System.Windows.Forms.Button();
            this.btn_SearchDrugByNo = new System.Windows.Forms.Button();
            this.dgv_Drug = new System.Windows.Forms.DataGridView();
            this.tp_Herb = new System.Windows.Forms.TabPage();
            this.lbl_Tip1 = new System.Windows.Forms.Label();
            this.lbl_HerbPinyin = new System.Windows.Forms.Label();
            this.txb_HerbPinyin = new System.Windows.Forms.TextBox();
            this.txb_HerbKeyWord = new System.Windows.Forms.TextBox();
            this.txb_HerbName = new System.Windows.Forms.TextBox();
            this.txb_HerbNo = new System.Windows.Forms.TextBox();
            this.lbl_Herb = new System.Windows.Forms.Label();
            this.btn_LoadHerb = new System.Windows.Forms.Button();
            this.btn_SearchHerbByName = new System.Windows.Forms.Button();
            this.btn_SearchHerbByNo = new System.Windows.Forms.Button();
            this.dgv_Herb = new System.Windows.Forms.DataGridView();
            this.tc_Prescription = new System.Windows.Forms.TabControl();
            this.tp_Drug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drug)).BeginInit();
            this.tp_Herb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Herb)).BeginInit();
            this.tc_Prescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // tp_Drug
            // 
            this.tp_Drug.Controls.Add(this.lbl_Tip2);
            this.tp_Drug.Controls.Add(this.lbl_DrugPinyin);
            this.tp_Drug.Controls.Add(this.txb_DrugPinyin);
            this.tp_Drug.Controls.Add(this.txb_DrugKeyWord);
            this.tp_Drug.Controls.Add(this.txb_DrugName);
            this.tp_Drug.Controls.Add(this.txb_DrugNo);
            this.tp_Drug.Controls.Add(this.lbl_Drug);
            this.tp_Drug.Controls.Add(this.btn_LoadDrug);
            this.tp_Drug.Controls.Add(this.btn_SearchDrugByName);
            this.tp_Drug.Controls.Add(this.btn_SearchDrugByNo);
            this.tp_Drug.Controls.Add(this.dgv_Drug);
            this.tp_Drug.Location = new System.Drawing.Point(4, 28);
            this.tp_Drug.Name = "tp_Drug";
            this.tp_Drug.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Drug.Size = new System.Drawing.Size(1410, 803);
            this.tp_Drug.TabIndex = 1;
            this.tp_Drug.Text = "药品";
            this.tp_Drug.UseVisualStyleBackColor = true;
            // 
            // lbl_Tip2
            // 
            this.lbl_Tip2.AutoSize = true;
            this.lbl_Tip2.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.lbl_Tip2.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tip2.Location = new System.Drawing.Point(815, 658);
            this.lbl_Tip2.Name = "lbl_Tip2";
            this.lbl_Tip2.Size = new System.Drawing.Size(234, 21);
            this.lbl_Tip2.TabIndex = 54;
            this.lbl_Tip2.Text = "名称、英文名、主治中的关键字";
            // 
            // lbl_DrugPinyin
            // 
            this.lbl_DrugPinyin.AutoSize = true;
            this.lbl_DrugPinyin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_DrugPinyin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_DrugPinyin.Location = new System.Drawing.Point(678, 700);
            this.lbl_DrugPinyin.Name = "lbl_DrugPinyin";
            this.lbl_DrugPinyin.Size = new System.Drawing.Size(134, 31);
            this.lbl_DrugPinyin.TabIndex = 52;
            this.lbl_DrugPinyin.Text = "根据拼音：";
            // 
            // txb_DrugPinyin
            // 
            this.txb_DrugPinyin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_DrugPinyin.Location = new System.Drawing.Point(819, 700);
            this.txb_DrugPinyin.Margin = new System.Windows.Forms.Padding(4);
            this.txb_DrugPinyin.Name = "txb_DrugPinyin";
            this.txb_DrugPinyin.Size = new System.Drawing.Size(272, 39);
            this.txb_DrugPinyin.TabIndex = 51;
            this.txb_DrugPinyin.TextChanged += new System.EventHandler(this.txb_DrugPinyin_TextChanged);
            // 
            // txb_DrugKeyWord
            // 
            this.txb_DrugKeyWord.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_DrugKeyWord.Location = new System.Drawing.Point(819, 615);
            this.txb_DrugKeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.txb_DrugKeyWord.Name = "txb_DrugKeyWord";
            this.txb_DrugKeyWord.Size = new System.Drawing.Size(272, 39);
            this.txb_DrugKeyWord.TabIndex = 46;
            this.txb_DrugKeyWord.TextChanged += new System.EventHandler(this.txb_DrugKeyWord_TextChanged);
            // 
            // txb_DrugName
            // 
            this.txb_DrugName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_DrugName.Location = new System.Drawing.Point(124, 700);
            this.txb_DrugName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_DrugName.Name = "txb_DrugName";
            this.txb_DrugName.Size = new System.Drawing.Size(272, 39);
            this.txb_DrugName.TabIndex = 43;
            // 
            // txb_DrugNo
            // 
            this.txb_DrugNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_DrugNo.Location = new System.Drawing.Point(124, 615);
            this.txb_DrugNo.Margin = new System.Windows.Forms.Padding(4);
            this.txb_DrugNo.Name = "txb_DrugNo";
            this.txb_DrugNo.Size = new System.Drawing.Size(272, 39);
            this.txb_DrugNo.TabIndex = 41;
            // 
            // lbl_Drug
            // 
            this.lbl_Drug.AutoSize = true;
            this.lbl_Drug.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Drug.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Drug.Location = new System.Drawing.Point(678, 615);
            this.lbl_Drug.Name = "lbl_Drug";
            this.lbl_Drug.Size = new System.Drawing.Size(134, 31);
            this.lbl_Drug.TabIndex = 48;
            this.lbl_Drug.Text = "模糊查询：";
            // 
            // btn_LoadDrug
            // 
            this.btn_LoadDrug.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_LoadDrug.Location = new System.Drawing.Point(1175, 647);
            this.btn_LoadDrug.Name = "btn_LoadDrug";
            this.btn_LoadDrug.Size = new System.Drawing.Size(137, 58);
            this.btn_LoadDrug.TabIndex = 45;
            this.btn_LoadDrug.Text = "重新载入";
            this.btn_LoadDrug.UseVisualStyleBackColor = true;
            this.btn_LoadDrug.Click += new System.EventHandler(this.btn_LoadDrug_Click);
            // 
            // btn_SearchDrugByName
            // 
            this.btn_SearchDrugByName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SearchDrugByName.Location = new System.Drawing.Point(403, 700);
            this.btn_SearchDrugByName.Name = "btn_SearchDrugByName";
            this.btn_SearchDrugByName.Size = new System.Drawing.Size(181, 43);
            this.btn_SearchDrugByName.TabIndex = 44;
            this.btn_SearchDrugByName.Text = "根据名称搜索";
            this.btn_SearchDrugByName.UseVisualStyleBackColor = true;
            this.btn_SearchDrugByName.Click += new System.EventHandler(this.btn_SearchDrugByName_Click);
            // 
            // btn_SearchDrugByNo
            // 
            this.btn_SearchDrugByNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SearchDrugByNo.Location = new System.Drawing.Point(403, 615);
            this.btn_SearchDrugByNo.Name = "btn_SearchDrugByNo";
            this.btn_SearchDrugByNo.Size = new System.Drawing.Size(181, 43);
            this.btn_SearchDrugByNo.TabIndex = 42;
            this.btn_SearchDrugByNo.Text = "根据编号搜索";
            this.btn_SearchDrugByNo.UseVisualStyleBackColor = true;
            this.btn_SearchDrugByNo.Click += new System.EventHandler(this.btn_SearchDrugByNo_Click);
            // 
            // dgv_Drug
            // 
            this.dgv_Drug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Drug.Location = new System.Drawing.Point(6, 6);
            this.dgv_Drug.Name = "dgv_Drug";
            this.dgv_Drug.RowHeadersWidth = 62;
            this.dgv_Drug.RowTemplate.Height = 30;
            this.dgv_Drug.Size = new System.Drawing.Size(1408, 570);
            this.dgv_Drug.TabIndex = 38;
            // 
            // tp_Herb
            // 
            this.tp_Herb.Controls.Add(this.lbl_Tip1);
            this.tp_Herb.Controls.Add(this.lbl_HerbPinyin);
            this.tp_Herb.Controls.Add(this.txb_HerbPinyin);
            this.tp_Herb.Controls.Add(this.txb_HerbKeyWord);
            this.tp_Herb.Controls.Add(this.txb_HerbName);
            this.tp_Herb.Controls.Add(this.txb_HerbNo);
            this.tp_Herb.Controls.Add(this.lbl_Herb);
            this.tp_Herb.Controls.Add(this.btn_LoadHerb);
            this.tp_Herb.Controls.Add(this.btn_SearchHerbByName);
            this.tp_Herb.Controls.Add(this.btn_SearchHerbByNo);
            this.tp_Herb.Controls.Add(this.dgv_Herb);
            this.tp_Herb.Location = new System.Drawing.Point(4, 28);
            this.tp_Herb.Name = "tp_Herb";
            this.tp_Herb.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Herb.Size = new System.Drawing.Size(1410, 803);
            this.tp_Herb.TabIndex = 0;
            this.tp_Herb.Text = "药材";
            this.tp_Herb.UseVisualStyleBackColor = true;
            // 
            // lbl_Tip1
            // 
            this.lbl_Tip1.AutoSize = true;
            this.lbl_Tip1.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.lbl_Tip1.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tip1.Location = new System.Drawing.Point(815, 658);
            this.lbl_Tip1.Name = "lbl_Tip1";
            this.lbl_Tip1.Size = new System.Drawing.Size(170, 21);
            this.lbl_Tip1.TabIndex = 54;
            this.lbl_Tip1.Text = "名称、类型中的关键字";
            // 
            // lbl_HerbPinyin
            // 
            this.lbl_HerbPinyin.AutoSize = true;
            this.lbl_HerbPinyin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_HerbPinyin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_HerbPinyin.Location = new System.Drawing.Point(678, 700);
            this.lbl_HerbPinyin.Name = "lbl_HerbPinyin";
            this.lbl_HerbPinyin.Size = new System.Drawing.Size(134, 31);
            this.lbl_HerbPinyin.TabIndex = 50;
            this.lbl_HerbPinyin.Text = "根据拼音：";
            // 
            // txb_HerbPinyin
            // 
            this.txb_HerbPinyin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_HerbPinyin.Location = new System.Drawing.Point(819, 700);
            this.txb_HerbPinyin.Margin = new System.Windows.Forms.Padding(4);
            this.txb_HerbPinyin.Name = "txb_HerbPinyin";
            this.txb_HerbPinyin.Size = new System.Drawing.Size(272, 39);
            this.txb_HerbPinyin.TabIndex = 49;
            this.txb_HerbPinyin.TextChanged += new System.EventHandler(this.txb_HerbPinyin_TextChanged);
            // 
            // txb_HerbKeyWord
            // 
            this.txb_HerbKeyWord.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_HerbKeyWord.Location = new System.Drawing.Point(819, 615);
            this.txb_HerbKeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.txb_HerbKeyWord.Name = "txb_HerbKeyWord";
            this.txb_HerbKeyWord.Size = new System.Drawing.Size(272, 39);
            this.txb_HerbKeyWord.TabIndex = 46;
            this.txb_HerbKeyWord.TextChanged += new System.EventHandler(this.txb_HerbKeyWord_TextChanged);
            // 
            // txb_HerbName
            // 
            this.txb_HerbName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_HerbName.Location = new System.Drawing.Point(124, 700);
            this.txb_HerbName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_HerbName.Name = "txb_HerbName";
            this.txb_HerbName.Size = new System.Drawing.Size(272, 39);
            this.txb_HerbName.TabIndex = 43;
            // 
            // txb_HerbNo
            // 
            this.txb_HerbNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_HerbNo.Location = new System.Drawing.Point(124, 615);
            this.txb_HerbNo.Margin = new System.Windows.Forms.Padding(4);
            this.txb_HerbNo.Name = "txb_HerbNo";
            this.txb_HerbNo.Size = new System.Drawing.Size(272, 39);
            this.txb_HerbNo.TabIndex = 41;
            // 
            // lbl_Herb
            // 
            this.lbl_Herb.AutoSize = true;
            this.lbl_Herb.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Herb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Herb.Location = new System.Drawing.Point(678, 615);
            this.lbl_Herb.Name = "lbl_Herb";
            this.lbl_Herb.Size = new System.Drawing.Size(134, 31);
            this.lbl_Herb.TabIndex = 48;
            this.lbl_Herb.Text = "模糊查询：";
            // 
            // btn_LoadHerb
            // 
            this.btn_LoadHerb.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_LoadHerb.Location = new System.Drawing.Point(1175, 647);
            this.btn_LoadHerb.Name = "btn_LoadHerb";
            this.btn_LoadHerb.Size = new System.Drawing.Size(137, 58);
            this.btn_LoadHerb.TabIndex = 45;
            this.btn_LoadHerb.Text = "重新载入";
            this.btn_LoadHerb.UseVisualStyleBackColor = true;
            this.btn_LoadHerb.Click += new System.EventHandler(this.btn_LoadHerb_Click);
            // 
            // btn_SearchHerbByName
            // 
            this.btn_SearchHerbByName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SearchHerbByName.Location = new System.Drawing.Point(403, 700);
            this.btn_SearchHerbByName.Name = "btn_SearchHerbByName";
            this.btn_SearchHerbByName.Size = new System.Drawing.Size(181, 43);
            this.btn_SearchHerbByName.TabIndex = 44;
            this.btn_SearchHerbByName.Text = "根据名称搜索";
            this.btn_SearchHerbByName.UseVisualStyleBackColor = true;
            this.btn_SearchHerbByName.Click += new System.EventHandler(this.btn_SearchHerbByName_Click);
            // 
            // btn_SearchHerbByNo
            // 
            this.btn_SearchHerbByNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SearchHerbByNo.Location = new System.Drawing.Point(403, 615);
            this.btn_SearchHerbByNo.Name = "btn_SearchHerbByNo";
            this.btn_SearchHerbByNo.Size = new System.Drawing.Size(181, 43);
            this.btn_SearchHerbByNo.TabIndex = 42;
            this.btn_SearchHerbByNo.Text = "根据编号搜索";
            this.btn_SearchHerbByNo.UseVisualStyleBackColor = true;
            this.btn_SearchHerbByNo.Click += new System.EventHandler(this.btn_SearchHerbByNo_Click);
            // 
            // dgv_Herb
            // 
            this.dgv_Herb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Herb.Location = new System.Drawing.Point(6, 6);
            this.dgv_Herb.Name = "dgv_Herb";
            this.dgv_Herb.RowHeadersWidth = 62;
            this.dgv_Herb.RowTemplate.Height = 30;
            this.dgv_Herb.Size = new System.Drawing.Size(1408, 570);
            this.dgv_Herb.TabIndex = 0;
            // 
            // tc_Prescription
            // 
            this.tc_Prescription.Controls.Add(this.tp_Herb);
            this.tc_Prescription.Controls.Add(this.tp_Drug);
            this.tc_Prescription.Location = new System.Drawing.Point(5, 3);
            this.tc_Prescription.Name = "tc_Prescription";
            this.tc_Prescription.SelectedIndex = 0;
            this.tc_Prescription.Size = new System.Drawing.Size(1418, 835);
            this.tc_Prescription.TabIndex = 2;
            // 
            // frm_Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.tc_Prescription);
            this.Name = "frm_Prescription";
            this.Text = "处方";
            this.tp_Drug.ResumeLayout(false);
            this.tp_Drug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drug)).EndInit();
            this.tp_Herb.ResumeLayout(false);
            this.tp_Herb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Herb)).EndInit();
            this.tc_Prescription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tp_Drug;
        private System.Windows.Forms.Label lbl_Tip2;
        private System.Windows.Forms.Label lbl_DrugPinyin;
        private System.Windows.Forms.TextBox txb_DrugPinyin;
        private System.Windows.Forms.TextBox txb_DrugKeyWord;
        private System.Windows.Forms.TextBox txb_DrugName;
        private System.Windows.Forms.TextBox txb_DrugNo;
        private System.Windows.Forms.Label lbl_Drug;
        private System.Windows.Forms.Button btn_LoadDrug;
        private System.Windows.Forms.Button btn_SearchDrugByName;
        private System.Windows.Forms.Button btn_SearchDrugByNo;
        private System.Windows.Forms.DataGridView dgv_Drug;
        private System.Windows.Forms.TabPage tp_Herb;
        private System.Windows.Forms.Label lbl_Tip1;
        private System.Windows.Forms.Label lbl_HerbPinyin;
        private System.Windows.Forms.TextBox txb_HerbPinyin;
        private System.Windows.Forms.TextBox txb_HerbKeyWord;
        private System.Windows.Forms.TextBox txb_HerbName;
        private System.Windows.Forms.TextBox txb_HerbNo;
        private System.Windows.Forms.Label lbl_Herb;
        private System.Windows.Forms.Button btn_LoadHerb;
        private System.Windows.Forms.Button btn_SearchHerbByName;
        private System.Windows.Forms.Button btn_SearchHerbByNo;
        private System.Windows.Forms.DataGridView dgv_Herb;
        private System.Windows.Forms.TabControl tc_Prescription;
    }
}