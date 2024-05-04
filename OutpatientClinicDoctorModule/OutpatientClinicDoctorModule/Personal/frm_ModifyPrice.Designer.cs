namespace OutpatientClinicDoctorModule.Personal
{
    partial class frm_ModifyPrice
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
            this.tc_ModifyPrice = new System.Windows.Forms.TabControl();
            this.tp_Herb = new System.Windows.Forms.TabPage();
            this.tp_Drug = new System.Windows.Forms.TabPage();
            this.tp_Examine = new System.Windows.Forms.TabPage();
            this.dgv_Herb = new System.Windows.Forms.DataGridView();
            this.btn_SaveHerb = new System.Windows.Forms.Button();
            this.btn_SaveDrug = new System.Windows.Forms.Button();
            this.dgv_Drug = new System.Windows.Forms.DataGridView();
            this.btn_SaveExamine = new System.Windows.Forms.Button();
            this.dgv_Examine = new System.Windows.Forms.DataGridView();
            this.tc_ModifyPrice.SuspendLayout();
            this.tp_Herb.SuspendLayout();
            this.tp_Drug.SuspendLayout();
            this.tp_Examine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Herb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Examine)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_ModifyPrice
            // 
            this.tc_ModifyPrice.Controls.Add(this.tp_Herb);
            this.tc_ModifyPrice.Controls.Add(this.tp_Drug);
            this.tc_ModifyPrice.Controls.Add(this.tp_Examine);
            this.tc_ModifyPrice.Location = new System.Drawing.Point(0, 0);
            this.tc_ModifyPrice.Name = "tc_ModifyPrice";
            this.tc_ModifyPrice.SelectedIndex = 0;
            this.tc_ModifyPrice.Size = new System.Drawing.Size(1429, 835);
            this.tc_ModifyPrice.TabIndex = 0;
            // 
            // tp_Herb
            // 
            this.tp_Herb.Controls.Add(this.btn_SaveHerb);
            this.tp_Herb.Controls.Add(this.dgv_Herb);
            this.tp_Herb.Location = new System.Drawing.Point(4, 28);
            this.tp_Herb.Name = "tp_Herb";
            this.tp_Herb.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Herb.Size = new System.Drawing.Size(1421, 803);
            this.tp_Herb.TabIndex = 0;
            this.tp_Herb.Text = "药材";
            this.tp_Herb.UseVisualStyleBackColor = true;
            // 
            // tp_Drug
            // 
            this.tp_Drug.Controls.Add(this.btn_SaveDrug);
            this.tp_Drug.Controls.Add(this.dgv_Drug);
            this.tp_Drug.Location = new System.Drawing.Point(4, 28);
            this.tp_Drug.Name = "tp_Drug";
            this.tp_Drug.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Drug.Size = new System.Drawing.Size(1421, 803);
            this.tp_Drug.TabIndex = 1;
            this.tp_Drug.Text = "药品";
            this.tp_Drug.UseVisualStyleBackColor = true;
            // 
            // tp_Examine
            // 
            this.tp_Examine.Controls.Add(this.btn_SaveExamine);
            this.tp_Examine.Controls.Add(this.dgv_Examine);
            this.tp_Examine.Location = new System.Drawing.Point(4, 28);
            this.tp_Examine.Name = "tp_Examine";
            this.tp_Examine.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Examine.Size = new System.Drawing.Size(1421, 803);
            this.tp_Examine.TabIndex = 2;
            this.tp_Examine.Text = "检查项目";
            this.tp_Examine.UseVisualStyleBackColor = true;
            // 
            // dgv_Herb
            // 
            this.dgv_Herb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Herb.Location = new System.Drawing.Point(6, 6);
            this.dgv_Herb.Name = "dgv_Herb";
            this.dgv_Herb.RowHeadersWidth = 62;
            this.dgv_Herb.RowTemplate.Height = 30;
            this.dgv_Herb.Size = new System.Drawing.Size(1412, 698);
            this.dgv_Herb.TabIndex = 0;
            // 
            // btn_SaveHerb
            // 
            this.btn_SaveHerb.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SaveHerb.Location = new System.Drawing.Point(638, 723);
            this.btn_SaveHerb.Name = "btn_SaveHerb";
            this.btn_SaveHerb.Size = new System.Drawing.Size(126, 60);
            this.btn_SaveHerb.TabIndex = 37;
            this.btn_SaveHerb.Text = "保存";
            this.btn_SaveHerb.UseVisualStyleBackColor = true;
            this.btn_SaveHerb.Click += new System.EventHandler(this.btn_SaveHerb_Click);
            // 
            // btn_SaveDrug
            // 
            this.btn_SaveDrug.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SaveDrug.Location = new System.Drawing.Point(636, 730);
            this.btn_SaveDrug.Name = "btn_SaveDrug";
            this.btn_SaveDrug.Size = new System.Drawing.Size(126, 60);
            this.btn_SaveDrug.TabIndex = 39;
            this.btn_SaveDrug.Text = "保存";
            this.btn_SaveDrug.UseVisualStyleBackColor = true;
            this.btn_SaveDrug.Click += new System.EventHandler(this.btn_SaveDrug_Click);
            // 
            // dgv_Drug
            // 
            this.dgv_Drug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Drug.Location = new System.Drawing.Point(4, 13);
            this.dgv_Drug.Name = "dgv_Drug";
            this.dgv_Drug.RowHeadersWidth = 62;
            this.dgv_Drug.RowTemplate.Height = 30;
            this.dgv_Drug.Size = new System.Drawing.Size(1412, 698);
            this.dgv_Drug.TabIndex = 38;
            // 
            // btn_SaveExamine
            // 
            this.btn_SaveExamine.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SaveExamine.Location = new System.Drawing.Point(636, 730);
            this.btn_SaveExamine.Name = "btn_SaveExamine";
            this.btn_SaveExamine.Size = new System.Drawing.Size(126, 60);
            this.btn_SaveExamine.TabIndex = 39;
            this.btn_SaveExamine.Text = "保存";
            this.btn_SaveExamine.UseVisualStyleBackColor = true;
            this.btn_SaveExamine.Click += new System.EventHandler(this.btn_SaveExamine_Click);
            // 
            // dgv_Examine
            // 
            this.dgv_Examine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Examine.Location = new System.Drawing.Point(4, 13);
            this.dgv_Examine.Name = "dgv_Examine";
            this.dgv_Examine.RowHeadersWidth = 62;
            this.dgv_Examine.RowTemplate.Height = 30;
            this.dgv_Examine.Size = new System.Drawing.Size(1412, 698);
            this.dgv_Examine.TabIndex = 38;
            // 
            // frm_ModifyPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.tc_ModifyPrice);
            this.Name = "frm_ModifyPrice";
            this.Text = "修改价目";
            this.tc_ModifyPrice.ResumeLayout(false);
            this.tp_Herb.ResumeLayout(false);
            this.tp_Drug.ResumeLayout(false);
            this.tp_Examine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Herb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Examine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_ModifyPrice;
        private System.Windows.Forms.TabPage tp_Herb;
        private System.Windows.Forms.TabPage tp_Drug;
        private System.Windows.Forms.TabPage tp_Examine;
        private System.Windows.Forms.DataGridView dgv_Herb;
        private System.Windows.Forms.Button btn_SaveHerb;
        private System.Windows.Forms.Button btn_SaveDrug;
        private System.Windows.Forms.DataGridView dgv_Drug;
        private System.Windows.Forms.Button btn_SaveExamine;
        private System.Windows.Forms.DataGridView dgv_Examine;
    }
}