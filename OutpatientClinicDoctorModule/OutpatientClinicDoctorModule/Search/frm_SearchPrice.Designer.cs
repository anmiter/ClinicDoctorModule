namespace OutpatientClinicDoctorModule.Search
{
    partial class frm_SearchPrice
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
            this.dgv_Herb = new System.Windows.Forms.DataGridView();
            this.tp_Drug = new System.Windows.Forms.TabPage();
            this.dgv_Drug = new System.Windows.Forms.DataGridView();
            this.tp_Examine = new System.Windows.Forms.TabPage();
            this.dgv_Examine = new System.Windows.Forms.DataGridView();
            this.txb_HerbKeyWord = new System.Windows.Forms.TextBox();
            this.btn_LoadHerb = new System.Windows.Forms.Button();
            this.btn_SearchHerbByName = new System.Windows.Forms.Button();
            this.txb_HerbName = new System.Windows.Forms.TextBox();
            this.btn_SearchHerbByNo = new System.Windows.Forms.Button();
            this.txb_HerbNo = new System.Windows.Forms.TextBox();
            this.txb_DrugKeyWord = new System.Windows.Forms.TextBox();
            this.btn_LoadDrug = new System.Windows.Forms.Button();
            this.btn_SearchDrugByName = new System.Windows.Forms.Button();
            this.txb_DrugName = new System.Windows.Forms.TextBox();
            this.btn_SearchDrugByNo = new System.Windows.Forms.Button();
            this.txb_DrugNo = new System.Windows.Forms.TextBox();
            this.txb_ExamineKeyWord = new System.Windows.Forms.TextBox();
            this.btn_LoadExamine = new System.Windows.Forms.Button();
            this.btn_SearchExamineByName = new System.Windows.Forms.Button();
            this.txb_ExamineName = new System.Windows.Forms.TextBox();
            this.btn_SearchExamineByNo = new System.Windows.Forms.Button();
            this.txb_ExamineNo = new System.Windows.Forms.TextBox();
            this.lbl_Examine = new System.Windows.Forms.Label();
            this.lbl_Drug = new System.Windows.Forms.Label();
            this.lbl_Herb = new System.Windows.Forms.Label();
            this.txb_HerbPinyin = new System.Windows.Forms.TextBox();
            this.txb_DrugPinyin = new System.Windows.Forms.TextBox();
            this.txb_ExaminePinyin = new System.Windows.Forms.TextBox();
            this.lbl_HerbPinyin = new System.Windows.Forms.Label();
            this.lbl_DrugPinyin = new System.Windows.Forms.Label();
            this.lbl_ExaminePinyin = new System.Windows.Forms.Label();
            this.tc_ModifyPrice.SuspendLayout();
            this.tp_Herb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Herb)).BeginInit();
            this.tp_Drug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drug)).BeginInit();
            this.tp_Examine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Examine)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_ModifyPrice
            // 
            this.tc_ModifyPrice.Controls.Add(this.tp_Herb);
            this.tc_ModifyPrice.Controls.Add(this.tp_Drug);
            this.tc_ModifyPrice.Controls.Add(this.tp_Examine);
            this.tc_ModifyPrice.Location = new System.Drawing.Point(1, 1);
            this.tc_ModifyPrice.Name = "tc_ModifyPrice";
            this.tc_ModifyPrice.SelectedIndex = 0;
            this.tc_ModifyPrice.Size = new System.Drawing.Size(1418, 835);
            this.tc_ModifyPrice.TabIndex = 1;
            // 
            // tp_Herb
            // 
            this.tp_Herb.Controls.Add(this.lbl_HerbPinyin);
            this.tp_Herb.Controls.Add(this.txb_HerbPinyin);
            this.tp_Herb.Controls.Add(this.lbl_Herb);
            this.tp_Herb.Controls.Add(this.txb_HerbKeyWord);
            this.tp_Herb.Controls.Add(this.btn_LoadHerb);
            this.tp_Herb.Controls.Add(this.btn_SearchHerbByName);
            this.tp_Herb.Controls.Add(this.txb_HerbName);
            this.tp_Herb.Controls.Add(this.btn_SearchHerbByNo);
            this.tp_Herb.Controls.Add(this.txb_HerbNo);
            this.tp_Herb.Controls.Add(this.dgv_Herb);
            this.tp_Herb.Location = new System.Drawing.Point(4, 28);
            this.tp_Herb.Name = "tp_Herb";
            this.tp_Herb.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Herb.Size = new System.Drawing.Size(1410, 803);
            this.tp_Herb.TabIndex = 0;
            this.tp_Herb.Text = "药材";
            this.tp_Herb.UseVisualStyleBackColor = true;
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
            // tp_Drug
            // 
            this.tp_Drug.Controls.Add(this.lbl_DrugPinyin);
            this.tp_Drug.Controls.Add(this.txb_DrugPinyin);
            this.tp_Drug.Controls.Add(this.lbl_Drug);
            this.tp_Drug.Controls.Add(this.txb_DrugKeyWord);
            this.tp_Drug.Controls.Add(this.btn_LoadDrug);
            this.tp_Drug.Controls.Add(this.btn_SearchDrugByName);
            this.tp_Drug.Controls.Add(this.txb_DrugName);
            this.tp_Drug.Controls.Add(this.btn_SearchDrugByNo);
            this.tp_Drug.Controls.Add(this.txb_DrugNo);
            this.tp_Drug.Controls.Add(this.dgv_Drug);
            this.tp_Drug.Location = new System.Drawing.Point(4, 28);
            this.tp_Drug.Name = "tp_Drug";
            this.tp_Drug.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Drug.Size = new System.Drawing.Size(1410, 803);
            this.tp_Drug.TabIndex = 1;
            this.tp_Drug.Text = "药品";
            this.tp_Drug.UseVisualStyleBackColor = true;
            this.tp_Drug.Click += new System.EventHandler(this.tp_Drug_Click);
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
            // tp_Examine
            // 
            this.tp_Examine.Controls.Add(this.lbl_ExaminePinyin);
            this.tp_Examine.Controls.Add(this.txb_ExaminePinyin);
            this.tp_Examine.Controls.Add(this.lbl_Examine);
            this.tp_Examine.Controls.Add(this.txb_ExamineKeyWord);
            this.tp_Examine.Controls.Add(this.btn_LoadExamine);
            this.tp_Examine.Controls.Add(this.btn_SearchExamineByName);
            this.tp_Examine.Controls.Add(this.txb_ExamineName);
            this.tp_Examine.Controls.Add(this.btn_SearchExamineByNo);
            this.tp_Examine.Controls.Add(this.txb_ExamineNo);
            this.tp_Examine.Controls.Add(this.dgv_Examine);
            this.tp_Examine.Location = new System.Drawing.Point(4, 28);
            this.tp_Examine.Name = "tp_Examine";
            this.tp_Examine.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Examine.Size = new System.Drawing.Size(1410, 803);
            this.tp_Examine.TabIndex = 2;
            this.tp_Examine.Text = "检查项目";
            this.tp_Examine.UseVisualStyleBackColor = true;
            // 
            // dgv_Examine
            // 
            this.dgv_Examine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Examine.Location = new System.Drawing.Point(6, 6);
            this.dgv_Examine.Name = "dgv_Examine";
            this.dgv_Examine.RowHeadersWidth = 62;
            this.dgv_Examine.RowTemplate.Height = 30;
            this.dgv_Examine.Size = new System.Drawing.Size(1408, 570);
            this.dgv_Examine.TabIndex = 38;
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
            // txb_HerbName
            // 
            this.txb_HerbName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_HerbName.Location = new System.Drawing.Point(124, 700);
            this.txb_HerbName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_HerbName.Name = "txb_HerbName";
            this.txb_HerbName.Size = new System.Drawing.Size(272, 39);
            this.txb_HerbName.TabIndex = 43;
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
            // txb_HerbNo
            // 
            this.txb_HerbNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_HerbNo.Location = new System.Drawing.Point(124, 615);
            this.txb_HerbNo.Margin = new System.Windows.Forms.Padding(4);
            this.txb_HerbNo.Name = "txb_HerbNo";
            this.txb_HerbNo.Size = new System.Drawing.Size(272, 39);
            this.txb_HerbNo.TabIndex = 41;
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
            // txb_DrugName
            // 
            this.txb_DrugName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_DrugName.Location = new System.Drawing.Point(124, 700);
            this.txb_DrugName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_DrugName.Name = "txb_DrugName";
            this.txb_DrugName.Size = new System.Drawing.Size(272, 39);
            this.txb_DrugName.TabIndex = 43;
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
            // txb_DrugNo
            // 
            this.txb_DrugNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_DrugNo.Location = new System.Drawing.Point(124, 615);
            this.txb_DrugNo.Margin = new System.Windows.Forms.Padding(4);
            this.txb_DrugNo.Name = "txb_DrugNo";
            this.txb_DrugNo.Size = new System.Drawing.Size(272, 39);
            this.txb_DrugNo.TabIndex = 41;
            // 
            // txb_ExamineKeyWord
            // 
            this.txb_ExamineKeyWord.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_ExamineKeyWord.Location = new System.Drawing.Point(819, 615);
            this.txb_ExamineKeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ExamineKeyWord.Name = "txb_ExamineKeyWord";
            this.txb_ExamineKeyWord.Size = new System.Drawing.Size(272, 39);
            this.txb_ExamineKeyWord.TabIndex = 46;
            this.txb_ExamineKeyWord.TextChanged += new System.EventHandler(this.txb_ExamineKeyWord_TextChanged);
            // 
            // btn_LoadExamine
            // 
            this.btn_LoadExamine.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_LoadExamine.Location = new System.Drawing.Point(1175, 647);
            this.btn_LoadExamine.Name = "btn_LoadExamine";
            this.btn_LoadExamine.Size = new System.Drawing.Size(137, 58);
            this.btn_LoadExamine.TabIndex = 45;
            this.btn_LoadExamine.Text = "重新载入";
            this.btn_LoadExamine.UseVisualStyleBackColor = true;
            this.btn_LoadExamine.Click += new System.EventHandler(this.btn_LoadExamine_Click);
            // 
            // btn_SearchExamineByName
            // 
            this.btn_SearchExamineByName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SearchExamineByName.Location = new System.Drawing.Point(403, 700);
            this.btn_SearchExamineByName.Name = "btn_SearchExamineByName";
            this.btn_SearchExamineByName.Size = new System.Drawing.Size(181, 43);
            this.btn_SearchExamineByName.TabIndex = 44;
            this.btn_SearchExamineByName.Text = "根据名称搜索";
            this.btn_SearchExamineByName.UseVisualStyleBackColor = true;
            this.btn_SearchExamineByName.Click += new System.EventHandler(this.btn_SearchExamineByName_Click);
            // 
            // txb_ExamineName
            // 
            this.txb_ExamineName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_ExamineName.Location = new System.Drawing.Point(124, 700);
            this.txb_ExamineName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ExamineName.Name = "txb_ExamineName";
            this.txb_ExamineName.Size = new System.Drawing.Size(272, 39);
            this.txb_ExamineName.TabIndex = 43;
            // 
            // btn_SearchExamineByNo
            // 
            this.btn_SearchExamineByNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SearchExamineByNo.Location = new System.Drawing.Point(403, 615);
            this.btn_SearchExamineByNo.Name = "btn_SearchExamineByNo";
            this.btn_SearchExamineByNo.Size = new System.Drawing.Size(181, 43);
            this.btn_SearchExamineByNo.TabIndex = 42;
            this.btn_SearchExamineByNo.Text = "根据编号搜索";
            this.btn_SearchExamineByNo.UseVisualStyleBackColor = true;
            this.btn_SearchExamineByNo.Click += new System.EventHandler(this.btn_SearchExamineByNo_Click);
            // 
            // txb_ExamineNo
            // 
            this.txb_ExamineNo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_ExamineNo.Location = new System.Drawing.Point(124, 615);
            this.txb_ExamineNo.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ExamineNo.Name = "txb_ExamineNo";
            this.txb_ExamineNo.Size = new System.Drawing.Size(272, 39);
            this.txb_ExamineNo.TabIndex = 41;
            // 
            // lbl_Examine
            // 
            this.lbl_Examine.AutoSize = true;
            this.lbl_Examine.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Examine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Examine.Location = new System.Drawing.Point(678, 615);
            this.lbl_Examine.Name = "lbl_Examine";
            this.lbl_Examine.Size = new System.Drawing.Size(134, 31);
            this.lbl_Examine.TabIndex = 47;
            this.lbl_Examine.Text = "模糊查询：";
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
            // txb_ExaminePinyin
            // 
            this.txb_ExaminePinyin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txb_ExaminePinyin.Location = new System.Drawing.Point(819, 700);
            this.txb_ExaminePinyin.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ExaminePinyin.Name = "txb_ExaminePinyin";
            this.txb_ExaminePinyin.Size = new System.Drawing.Size(272, 39);
            this.txb_ExaminePinyin.TabIndex = 51;
            this.txb_ExaminePinyin.TextChanged += new System.EventHandler(this.txb_ExaminePinyin_TextChanged);
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
            // lbl_ExaminePinyin
            // 
            this.lbl_ExaminePinyin.AutoSize = true;
            this.lbl_ExaminePinyin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_ExaminePinyin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_ExaminePinyin.Location = new System.Drawing.Point(678, 700);
            this.lbl_ExaminePinyin.Name = "lbl_ExaminePinyin";
            this.lbl_ExaminePinyin.Size = new System.Drawing.Size(134, 31);
            this.lbl_ExaminePinyin.TabIndex = 52;
            this.lbl_ExaminePinyin.Text = "根据拼音：";
            // 
            // frm_SearchPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 840);
            this.Controls.Add(this.tc_ModifyPrice);
            this.Name = "frm_SearchPrice";
            this.Text = "查询价目";
            this.tc_ModifyPrice.ResumeLayout(false);
            this.tp_Herb.ResumeLayout(false);
            this.tp_Herb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Herb)).EndInit();
            this.tp_Drug.ResumeLayout(false);
            this.tp_Drug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drug)).EndInit();
            this.tp_Examine.ResumeLayout(false);
            this.tp_Examine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Examine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_ModifyPrice;
        private System.Windows.Forms.TabPage tp_Herb;
        private System.Windows.Forms.TextBox txb_HerbKeyWord;
        private System.Windows.Forms.Button btn_LoadHerb;
        private System.Windows.Forms.Button btn_SearchHerbByName;
        private System.Windows.Forms.TextBox txb_HerbName;
        private System.Windows.Forms.Button btn_SearchHerbByNo;
        private System.Windows.Forms.TextBox txb_HerbNo;
        private System.Windows.Forms.DataGridView dgv_Herb;
        private System.Windows.Forms.TabPage tp_Drug;
        private System.Windows.Forms.TextBox txb_DrugKeyWord;
        private System.Windows.Forms.Button btn_LoadDrug;
        private System.Windows.Forms.Button btn_SearchDrugByName;
        private System.Windows.Forms.TextBox txb_DrugName;
        private System.Windows.Forms.Button btn_SearchDrugByNo;
        private System.Windows.Forms.TextBox txb_DrugNo;
        private System.Windows.Forms.DataGridView dgv_Drug;
        private System.Windows.Forms.TabPage tp_Examine;
        private System.Windows.Forms.TextBox txb_ExamineKeyWord;
        private System.Windows.Forms.Button btn_LoadExamine;
        private System.Windows.Forms.Button btn_SearchExamineByName;
        private System.Windows.Forms.TextBox txb_ExamineName;
        private System.Windows.Forms.Button btn_SearchExamineByNo;
        private System.Windows.Forms.TextBox txb_ExamineNo;
        private System.Windows.Forms.DataGridView dgv_Examine;
        private System.Windows.Forms.Label lbl_Examine;
        private System.Windows.Forms.Label lbl_Herb;
        private System.Windows.Forms.Label lbl_Drug;
        private System.Windows.Forms.Label lbl_HerbPinyin;
        private System.Windows.Forms.TextBox txb_HerbPinyin;
        private System.Windows.Forms.Label lbl_DrugPinyin;
        private System.Windows.Forms.TextBox txb_DrugPinyin;
        private System.Windows.Forms.Label lbl_ExaminePinyin;
        private System.Windows.Forms.TextBox txb_ExaminePinyin;
    }
}