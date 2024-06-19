namespace OutpatientClinicDoctorModule
{
    partial class frm_Show
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
            this.tc_SearchPrescription = new System.Windows.Forms.TabControl();
            this.tp_TCM = new System.Windows.Forms.TabPage();
            this.dgv_TCM = new System.Windows.Forms.DataGridView();
            this.tp_Prescription = new System.Windows.Forms.TabPage();
            this.dgv_Prescription = new System.Windows.Forms.DataGridView();
            this.tp_Examinations = new System.Windows.Forms.TabPage();
            this.dgv_Examinations = new System.Windows.Forms.DataGridView();
            this.tc_SearchPrescription.SuspendLayout();
            this.tp_TCM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TCM)).BeginInit();
            this.tp_Prescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prescription)).BeginInit();
            this.tp_Examinations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Examinations)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_SearchPrescription
            // 
            this.tc_SearchPrescription.Controls.Add(this.tp_TCM);
            this.tc_SearchPrescription.Controls.Add(this.tp_Prescription);
            this.tc_SearchPrescription.Controls.Add(this.tp_Examinations);
            this.tc_SearchPrescription.Location = new System.Drawing.Point(1, 1);
            this.tc_SearchPrescription.Name = "tc_SearchPrescription";
            this.tc_SearchPrescription.SelectedIndex = 0;
            this.tc_SearchPrescription.Size = new System.Drawing.Size(961, 413);
            this.tc_SearchPrescription.TabIndex = 4;
            // 
            // tp_TCM
            // 
            this.tp_TCM.Controls.Add(this.dgv_TCM);
            this.tp_TCM.Location = new System.Drawing.Point(4, 28);
            this.tp_TCM.Name = "tp_TCM";
            this.tp_TCM.Padding = new System.Windows.Forms.Padding(3);
            this.tp_TCM.Size = new System.Drawing.Size(953, 381);
            this.tp_TCM.TabIndex = 0;
            this.tp_TCM.Text = "中药药方";
            this.tp_TCM.UseVisualStyleBackColor = true;
            // 
            // dgv_TCM
            // 
            this.dgv_TCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TCM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TCM.Location = new System.Drawing.Point(3, 3);
            this.dgv_TCM.Name = "dgv_TCM";
            this.dgv_TCM.RowHeadersWidth = 62;
            this.dgv_TCM.RowTemplate.Height = 30;
            this.dgv_TCM.Size = new System.Drawing.Size(947, 375);
            this.dgv_TCM.TabIndex = 0;
            // 
            // tp_Prescription
            // 
            this.tp_Prescription.Controls.Add(this.dgv_Prescription);
            this.tp_Prescription.Location = new System.Drawing.Point(4, 28);
            this.tp_Prescription.Name = "tp_Prescription";
            this.tp_Prescription.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Prescription.Size = new System.Drawing.Size(1398, 702);
            this.tp_Prescription.TabIndex = 1;
            this.tp_Prescription.Text = "西药药方";
            this.tp_Prescription.UseVisualStyleBackColor = true;
            // 
            // dgv_Prescription
            // 
            this.dgv_Prescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Prescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Prescription.Location = new System.Drawing.Point(3, 3);
            this.dgv_Prescription.Name = "dgv_Prescription";
            this.dgv_Prescription.RowHeadersWidth = 62;
            this.dgv_Prescription.RowTemplate.Height = 30;
            this.dgv_Prescription.Size = new System.Drawing.Size(1392, 696);
            this.dgv_Prescription.TabIndex = 38;
            // 
            // tp_Examinations
            // 
            this.tp_Examinations.Controls.Add(this.dgv_Examinations);
            this.tp_Examinations.Location = new System.Drawing.Point(4, 28);
            this.tp_Examinations.Name = "tp_Examinations";
            this.tp_Examinations.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Examinations.Size = new System.Drawing.Size(1398, 702);
            this.tp_Examinations.TabIndex = 2;
            this.tp_Examinations.Text = "检查项目";
            this.tp_Examinations.UseVisualStyleBackColor = true;
            // 
            // dgv_Examinations
            // 
            this.dgv_Examinations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Examinations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Examinations.Location = new System.Drawing.Point(3, 3);
            this.dgv_Examinations.Name = "dgv_Examinations";
            this.dgv_Examinations.RowHeadersWidth = 62;
            this.dgv_Examinations.RowTemplate.Height = 30;
            this.dgv_Examinations.Size = new System.Drawing.Size(1392, 696);
            this.dgv_Examinations.TabIndex = 40;
            // 
            // frm_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 412);
            this.Controls.Add(this.tc_SearchPrescription);
            this.Name = "frm_Show";
            this.Text = "查看药方和检查项目";
            this.Load += new System.EventHandler(this.frm_Show_Load);
            this.tc_SearchPrescription.ResumeLayout(false);
            this.tp_TCM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TCM)).EndInit();
            this.tp_Prescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prescription)).EndInit();
            this.tp_Examinations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Examinations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_SearchPrescription;
        private System.Windows.Forms.TabPage tp_TCM;
        private System.Windows.Forms.DataGridView dgv_TCM;
        private System.Windows.Forms.TabPage tp_Prescription;
        private System.Windows.Forms.DataGridView dgv_Prescription;
        private System.Windows.Forms.TabPage tp_Examinations;
        private System.Windows.Forms.DataGridView dgv_Examinations;
    }
}