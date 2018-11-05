namespace EVERYTHIN_5293993
{
    partial class FormConsuSearchBestSeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsuSearchBestSeller));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelNewItemSearch = new System.Windows.Forms.Label();
            this.labelAgeSearch = new System.Windows.Forms.Label();
            this.labelBestSeller = new System.Windows.Forms.Label();
            this.labelCateSearch = new System.Windows.Forms.Label();
            this.labelTotalSearch = new System.Windows.Forms.Label();
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new EVERYTHIN_5293993.DataSet1();
            this.iTEMRENTALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTEMRENTALTableAdapter = new EVERYTHIN_5293993.DataSet1TableAdapters.ITEMRENTALTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENTALNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMMILEAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOBUYDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOLOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOSTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMRENTALBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(669, 449);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 72);
            this.pictureBox3.TabIndex = 70;
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
            this.labelNewItemSearch.TabIndex = 66;
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
            this.labelAgeSearch.TabIndex = 67;
            this.labelAgeSearch.Text = "연령별 검색";
            this.labelAgeSearch.Click += new System.EventHandler(this.labelAgeSearchClick);
            // 
            // labelBestSeller
            // 
            this.labelBestSeller.AutoSize = true;
            this.labelBestSeller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelBestSeller.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelBestSeller.ForeColor = System.Drawing.Color.LightGreen;
            this.labelBestSeller.Location = new System.Drawing.Point(647, 241);
            this.labelBestSeller.Name = "labelBestSeller";
            this.labelBestSeller.Size = new System.Drawing.Size(110, 23);
            this.labelBestSeller.TabIndex = 65;
            this.labelBestSeller.Text = "베스트 셀러";
            // 
            // labelCateSearch
            // 
            this.labelCateSearch.AutoSize = true;
            this.labelCateSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelCateSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCateSearch.ForeColor = System.Drawing.Color.White;
            this.labelCateSearch.Location = new System.Drawing.Point(647, 167);
            this.labelCateSearch.Name = "labelCateSearch";
            this.labelCateSearch.Size = new System.Drawing.Size(110, 23);
            this.labelCateSearch.TabIndex = 64;
            this.labelCateSearch.Text = "분야별 검색";
            this.labelCateSearch.Click += new System.EventHandler(this.labelCateSearchClick);
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
            this.labelTotalSearch.TabIndex = 63;
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
            this.labelFindID.TabIndex = 68;
            this.labelFindID.Text = "검색>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 68);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(615, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 516);
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.iTEMIDDataGridViewTextBoxColumn,
            this.rENTALNUMDataGridViewTextBoxColumn,
            this.cATEIDDataGridViewTextBoxColumn,
            this.iTEMNAMEDataGridViewTextBoxColumn,
            this.iTEMPRICEDataGridViewTextBoxColumn,
            this.iTEMMILEAGEDataGridViewTextBoxColumn,
            this.sTOSTOCKDataGridViewTextBoxColumn,
            this.sTOBUYDATEDataGridViewTextBoxColumn,
            this.sTOLOCDataGridViewTextBoxColumn,
            this.sTOSTATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iTEMRENTALBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(588, 464);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTEMRENTALBindingSource
            // 
            this.iTEMRENTALBindingSource.DataMember = "ITEMRENTAL";
            this.iTEMRENTALBindingSource.DataSource = this.dataSet1;
            // 
            // iTEMRENTALTableAdapter
            // 
            this.iTEMRENTALTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "순위";
            this.Column1.Name = "Column1";
            // 
            // iTEMIDDataGridViewTextBoxColumn
            // 
            this.iTEMIDDataGridViewTextBoxColumn.DataPropertyName = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.HeaderText = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.Name = "iTEMIDDataGridViewTextBoxColumn";
            this.iTEMIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // rENTALNUMDataGridViewTextBoxColumn
            // 
            this.rENTALNUMDataGridViewTextBoxColumn.DataPropertyName = "RENTALNUM";
            this.rENTALNUMDataGridViewTextBoxColumn.HeaderText = "RENTALNUM";
            this.rENTALNUMDataGridViewTextBoxColumn.Name = "rENTALNUMDataGridViewTextBoxColumn";
            this.rENTALNUMDataGridViewTextBoxColumn.Visible = false;
            // 
            // cATEIDDataGridViewTextBoxColumn
            // 
            this.cATEIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cATEIDDataGridViewTextBoxColumn.DataPropertyName = "CATE_ID";
            this.cATEIDDataGridViewTextBoxColumn.HeaderText = "분류명";
            this.cATEIDDataGridViewTextBoxColumn.Name = "cATEIDDataGridViewTextBoxColumn";
            // 
            // iTEMNAMEDataGridViewTextBoxColumn
            // 
            this.iTEMNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iTEMNAMEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_NAME";
            this.iTEMNAMEDataGridViewTextBoxColumn.HeaderText = "물건명";
            this.iTEMNAMEDataGridViewTextBoxColumn.Name = "iTEMNAMEDataGridViewTextBoxColumn";
            // 
            // iTEMPRICEDataGridViewTextBoxColumn
            // 
            this.iTEMPRICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iTEMPRICEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_PRICE";
            this.iTEMPRICEDataGridViewTextBoxColumn.HeaderText = "가격";
            this.iTEMPRICEDataGridViewTextBoxColumn.Name = "iTEMPRICEDataGridViewTextBoxColumn";
            // 
            // iTEMMILEAGEDataGridViewTextBoxColumn
            // 
            this.iTEMMILEAGEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iTEMMILEAGEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_MILEAGE";
            this.iTEMMILEAGEDataGridViewTextBoxColumn.HeaderText = "적립금";
            this.iTEMMILEAGEDataGridViewTextBoxColumn.Name = "iTEMMILEAGEDataGridViewTextBoxColumn";
            // 
            // sTOSTOCKDataGridViewTextBoxColumn
            // 
            this.sTOSTOCKDataGridViewTextBoxColumn.DataPropertyName = "STO_STOCK";
            this.sTOSTOCKDataGridViewTextBoxColumn.HeaderText = "STO_STOCK";
            this.sTOSTOCKDataGridViewTextBoxColumn.Name = "sTOSTOCKDataGridViewTextBoxColumn";
            this.sTOSTOCKDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTOBUYDATEDataGridViewTextBoxColumn
            // 
            this.sTOBUYDATEDataGridViewTextBoxColumn.DataPropertyName = "STO_BUYDATE";
            this.sTOBUYDATEDataGridViewTextBoxColumn.HeaderText = "STO_BUYDATE";
            this.sTOBUYDATEDataGridViewTextBoxColumn.Name = "sTOBUYDATEDataGridViewTextBoxColumn";
            this.sTOBUYDATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTOLOCDataGridViewTextBoxColumn
            // 
            this.sTOLOCDataGridViewTextBoxColumn.DataPropertyName = "STO_LOC";
            this.sTOLOCDataGridViewTextBoxColumn.HeaderText = "STO_LOC";
            this.sTOLOCDataGridViewTextBoxColumn.Name = "sTOLOCDataGridViewTextBoxColumn";
            this.sTOLOCDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTOSTATEDataGridViewTextBoxColumn
            // 
            this.sTOSTATEDataGridViewTextBoxColumn.DataPropertyName = "STO_STATE";
            this.sTOSTATEDataGridViewTextBoxColumn.HeaderText = "STO_STATE";
            this.sTOSTATEDataGridViewTextBoxColumn.Name = "sTOSTATEDataGridViewTextBoxColumn";
            this.sTOSTATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormConsuSearchBestSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormConsuSearchBestSeller";
            this.Text = "EVERYTHIN\'";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConsuSearchBestSeller_FormClosing);
            this.Load += new System.EventHandler(this.FormConsuSearchBestSeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMRENTALBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelNewItemSearch;
        private System.Windows.Forms.Label labelAgeSearch;
        private System.Windows.Forms.Label labelBestSeller;
        private System.Windows.Forms.Label labelCateSearch;
        private System.Windows.Forms.Label labelTotalSearch;
        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource iTEMRENTALBindingSource;
        private DataSet1TableAdapters.ITEMRENTALTableAdapter iTEMRENTALTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENTALNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMMILEAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOBUYDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOLOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOSTATEDataGridViewTextBoxColumn;
    }
}