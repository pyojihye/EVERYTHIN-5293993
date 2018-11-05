namespace EVERYTHIN_5293993
{
    partial class FormConsuSearchCate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsuSearchCate));
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelNewItemSearch = new System.Windows.Forms.Label();
            this.labelAgeSearch = new System.Windows.Forms.Label();
            this.labelBestSeller = new System.Windows.Forms.Label();
            this.labelCateSearch = new System.Windows.Forms.Label();
            this.labelTotalSearch = new System.Windows.Forms.Label();
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBoxDescription = new System.Windows.Forms.ComboBox();
            this.dataSet1 = new EVERYTHIN_5293993.DataSet1();
            this.iTEMSTOCKDESCRIPTIONBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iTEMSTOCKDESCRIPTIONTableAdapter = new EVERYTHIN_5293993.DataSet1TableAdapters.ITEMSTOCKDESCRIPTIONTableAdapter();
            this.cATEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMMILEAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOBUYDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOLOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOSTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTONUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.CATEGORYTableAdapter();
            this.descriptionTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.DESCRIPTIONTableAdapter();
            this.dataSet11 = new EVERYTHIN_5293993.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSTOCKDESCRIPTIONBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.Font = new System.Drawing.Font("나눔스퀘어", 14.25F);
            this.comboBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(12, 91);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(132, 29);
            this.comboBoxSearch.TabIndex = 74;
            this.comboBoxSearch.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSelectionChangeCommitted);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonSearch.Font = new System.Drawing.Font("나눔스퀘어", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(493, 78);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(116, 50);
            this.buttonSearch.TabIndex = 76;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearchClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cATEIDDataGridViewTextBoxColumn,
            this.iTEMNAMEDataGridViewTextBoxColumn,
            this.iTEMPRICEDataGridViewTextBoxColumn,
            this.iTEMMILEAGEDataGridViewTextBoxColumn,
            this.sTOSTOCKDataGridViewTextBoxColumn,
            this.sTOBUYDATEDataGridViewTextBoxColumn,
            this.sTOLOCDataGridViewTextBoxColumn,
            this.sTOSTATEDataGridViewTextBoxColumn,
            this.dESDESCRIPTIONDataGridViewTextBoxColumn,
            this.sTONUMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iTEMSTOCKDESCRIPTIONBindingSource1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(597, 412);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(669, 449);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 72);
            this.pictureBox3.TabIndex = 72;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // labelNewItemSearch
            // 
            this.labelNewItemSearch.AutoSize = true;
            this.labelNewItemSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelNewItemSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelNewItemSearch.ForeColor = System.Drawing.Color.White;
            this.labelNewItemSearch.Location = new System.Drawing.Point(657, 389);
            this.labelNewItemSearch.Name = "labelNewItemSearch";
            this.labelNewItemSearch.Size = new System.Drawing.Size(91, 23);
            this.labelNewItemSearch.TabIndex = 68;
            this.labelNewItemSearch.Text = "신규 물건";
            this.labelNewItemSearch.Click += new System.EventHandler(this.labelNewItemSearchClick);
            // 
            // labelAgeSearch
            // 
            this.labelAgeSearch.AutoSize = true;
            this.labelAgeSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelAgeSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelAgeSearch.ForeColor = System.Drawing.Color.White;
            this.labelAgeSearch.Location = new System.Drawing.Point(647, 315);
            this.labelAgeSearch.Name = "labelAgeSearch";
            this.labelAgeSearch.Size = new System.Drawing.Size(110, 23);
            this.labelAgeSearch.TabIndex = 69;
            this.labelAgeSearch.Text = "연령별 검색";
            this.labelAgeSearch.Click += new System.EventHandler(this.labelAgeSearchClick);
            // 
            // labelBestSeller
            // 
            this.labelBestSeller.AutoSize = true;
            this.labelBestSeller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelBestSeller.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelBestSeller.ForeColor = System.Drawing.Color.White;
            this.labelBestSeller.Location = new System.Drawing.Point(647, 241);
            this.labelBestSeller.Name = "labelBestSeller";
            this.labelBestSeller.Size = new System.Drawing.Size(110, 23);
            this.labelBestSeller.TabIndex = 67;
            this.labelBestSeller.Text = "베스트 셀러";
            this.labelBestSeller.Click += new System.EventHandler(this.labelBestSellerClick);
            // 
            // labelCateSearch
            // 
            this.labelCateSearch.AutoSize = true;
            this.labelCateSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelCateSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCateSearch.ForeColor = System.Drawing.Color.LightGreen;
            this.labelCateSearch.Location = new System.Drawing.Point(647, 167);
            this.labelCateSearch.Name = "labelCateSearch";
            this.labelCateSearch.Size = new System.Drawing.Size(110, 23);
            this.labelCateSearch.TabIndex = 66;
            this.labelCateSearch.Text = "분야별 검색";
            // 
            // labelTotalSearch
            // 
            this.labelTotalSearch.AutoSize = true;
            this.labelTotalSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelTotalSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTotalSearch.ForeColor = System.Drawing.Color.White;
            this.labelTotalSearch.Location = new System.Drawing.Point(657, 97);
            this.labelTotalSearch.Name = "labelTotalSearch";
            this.labelTotalSearch.Size = new System.Drawing.Size(91, 23);
            this.labelTotalSearch.TabIndex = 65;
            this.labelTotalSearch.Text = "통합 검색";
            this.labelTotalSearch.Click += new System.EventHandler(this.labelTotalSearchClick);
            // 
            // labelFindID
            // 
            this.labelFindID.AutoSize = true;
            this.labelFindID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(134)))), ((int)(((byte)(153)))));
            this.labelFindID.Font = new System.Drawing.Font("나눔스퀘어", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFindID.ForeColor = System.Drawing.Color.White;
            this.labelFindID.Location = new System.Drawing.Point(11, 22);
            this.labelFindID.Name = "labelFindID";
            this.labelFindID.Size = new System.Drawing.Size(88, 26);
            this.labelFindID.TabIndex = 70;
            this.labelFindID.Text = "검색>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 68);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(615, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 516);
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // comboBoxDescription
            // 
            this.comboBoxDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDescription.Font = new System.Drawing.Font("나눔스퀘어", 14.25F);
            this.comboBoxDescription.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDescription.FormattingEnabled = true;
            this.comboBoxDescription.Location = new System.Drawing.Point(150, 91);
            this.comboBoxDescription.Name = "comboBoxDescription";
            this.comboBoxDescription.Size = new System.Drawing.Size(174, 29);
            this.comboBoxDescription.TabIndex = 75;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTEMSTOCKDESCRIPTIONBindingSource1
            // 
            this.iTEMSTOCKDESCRIPTIONBindingSource1.DataMember = "ITEMSTOCKDESCRIPTION";
            this.iTEMSTOCKDESCRIPTIONBindingSource1.DataSource = this.dataSet1;
            // 
            // iTEMSTOCKDESCRIPTIONTableAdapter
            // 
            this.iTEMSTOCKDESCRIPTIONTableAdapter.ClearBeforeFill = true;
            // 
            // cATEIDDataGridViewTextBoxColumn
            // 
            this.cATEIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cATEIDDataGridViewTextBoxColumn.DataPropertyName = "CATE_ID";
            this.cATEIDDataGridViewTextBoxColumn.HeaderText = "분류명";
            this.cATEIDDataGridViewTextBoxColumn.Name = "cATEIDDataGridViewTextBoxColumn";
            this.cATEIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTEMNAMEDataGridViewTextBoxColumn
            // 
            this.iTEMNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iTEMNAMEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_NAME";
            this.iTEMNAMEDataGridViewTextBoxColumn.HeaderText = "물건명";
            this.iTEMNAMEDataGridViewTextBoxColumn.Name = "iTEMNAMEDataGridViewTextBoxColumn";
            this.iTEMNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTEMPRICEDataGridViewTextBoxColumn
            // 
            this.iTEMPRICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iTEMPRICEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_PRICE";
            this.iTEMPRICEDataGridViewTextBoxColumn.HeaderText = "가격";
            this.iTEMPRICEDataGridViewTextBoxColumn.Name = "iTEMPRICEDataGridViewTextBoxColumn";
            this.iTEMPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTEMMILEAGEDataGridViewTextBoxColumn
            // 
            this.iTEMMILEAGEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_MILEAGE";
            this.iTEMMILEAGEDataGridViewTextBoxColumn.HeaderText = "ITEM_MILEAGE";
            this.iTEMMILEAGEDataGridViewTextBoxColumn.Name = "iTEMMILEAGEDataGridViewTextBoxColumn";
            this.iTEMMILEAGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iTEMMILEAGEDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTOSTOCKDataGridViewTextBoxColumn
            // 
            this.sTOSTOCKDataGridViewTextBoxColumn.DataPropertyName = "STO_STOCK";
            this.sTOSTOCKDataGridViewTextBoxColumn.HeaderText = "STO_STOCK";
            this.sTOSTOCKDataGridViewTextBoxColumn.Name = "sTOSTOCKDataGridViewTextBoxColumn";
            this.sTOSTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTOSTOCKDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTOBUYDATEDataGridViewTextBoxColumn
            // 
            this.sTOBUYDATEDataGridViewTextBoxColumn.DataPropertyName = "STO_BUYDATE";
            this.sTOBUYDATEDataGridViewTextBoxColumn.HeaderText = "STO_BUYDATE";
            this.sTOBUYDATEDataGridViewTextBoxColumn.Name = "sTOBUYDATEDataGridViewTextBoxColumn";
            this.sTOBUYDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTOBUYDATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTOLOCDataGridViewTextBoxColumn
            // 
            this.sTOLOCDataGridViewTextBoxColumn.DataPropertyName = "STO_LOC";
            this.sTOLOCDataGridViewTextBoxColumn.HeaderText = "STO_LOC";
            this.sTOLOCDataGridViewTextBoxColumn.Name = "sTOLOCDataGridViewTextBoxColumn";
            this.sTOLOCDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTOLOCDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTOSTATEDataGridViewTextBoxColumn
            // 
            this.sTOSTATEDataGridViewTextBoxColumn.DataPropertyName = "STO_STATE";
            this.sTOSTATEDataGridViewTextBoxColumn.HeaderText = "STO_STATE";
            this.sTOSTATEDataGridViewTextBoxColumn.Name = "sTOSTATEDataGridViewTextBoxColumn";
            this.sTOSTATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTOSTATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // dESDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DES_DESCRIPTION";
            this.dESDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DES_DESCRIPTION";
            this.dESDESCRIPTIONDataGridViewTextBoxColumn.Name = "dESDESCRIPTIONDataGridViewTextBoxColumn";
            this.dESDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESDESCRIPTIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTONUMDataGridViewTextBoxColumn
            // 
            this.sTONUMDataGridViewTextBoxColumn.DataPropertyName = "STO_NUM";
            this.sTONUMDataGridViewTextBoxColumn.HeaderText = "STO_NUM";
            this.sTONUMDataGridViewTextBoxColumn.Name = "sTONUMDataGridViewTextBoxColumn";
            this.sTONUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTONUMDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // descriptionTableAdapter1
            // 
            this.descriptionTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormConsuSearchCate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelNewItemSearch);
            this.Controls.Add(this.labelAgeSearch);
            this.Controls.Add(this.labelBestSeller);
            this.Controls.Add(this.labelCateSearch);
            this.Controls.Add(this.labelTotalSearch);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBoxDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormConsuSearchCate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVERYTHIN\'";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConsuSearchCate_FormClosing);
            this.Load += new System.EventHandler(this.FormConsuSearchCate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSTOCKDESCRIPTIONBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelNewItemSearch;
        private System.Windows.Forms.Label labelAgeSearch;
        private System.Windows.Forms.Label labelBestSeller;
        private System.Windows.Forms.Label labelCateSearch;
        private System.Windows.Forms.Label labelTotalSearch;
        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBoxDescription;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource iTEMSTOCKDESCRIPTIONBindingSource1;
        private DataSet1TableAdapters.ITEMSTOCKDESCRIPTIONTableAdapter iTEMSTOCKDESCRIPTIONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMMILEAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOBUYDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOLOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOSTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTONUMDataGridViewTextBoxColumn;
        private DataSet1TableAdapters.CATEGORYTableAdapter categoryTableAdapter1;
        private DataSet1TableAdapters.DESCRIPTIONTableAdapter descriptionTableAdapter1;
        private DataSet1 dataSet11;
    }
}