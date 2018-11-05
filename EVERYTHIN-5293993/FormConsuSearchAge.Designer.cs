namespace EVERYTHIN_5293993
{
    partial class FormConsuSearchAge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsuSearchAge));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelNewItemSearch = new System.Windows.Forms.Label();
            this.labelAgeSearch = new System.Windows.Forms.Label();
            this.labelBestSeller = new System.Windows.Forms.Label();
            this.labelCateSearch = new System.Windows.Forms.Label();
            this.labelTotalSearch = new System.Windows.Forms.Label();
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataSet1 = new EVERYTHIN_5293993.DataSet1();
            this.iTEMAGERENTALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTEMAGERENTALTableAdapter = new EVERYTHIN_5293993.DataSet1TableAdapters.ITEMAGERENTALTableAdapter();
            this.aGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENTALNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMMILEAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemagerentalTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.ITEMAGERENTALTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMAGERENTALBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aGEDataGridViewTextBoxColumn,
            this.iTEMIDDataGridViewTextBoxColumn,
            this.rENTALNUMDataGridViewTextBoxColumn,
            this.cATEIDDataGridViewTextBoxColumn,
            this.iTEMNAMEDataGridViewTextBoxColumn,
            this.iTEMPRICEDataGridViewTextBoxColumn,
            this.iTEMMILEAGEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iTEMAGERENTALBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(588, 412);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(172)))), ((int)(((byte)(185)))));
            this.label20.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(147, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 23);
            this.label20.TabIndex = 83;
            this.label20.Text = "20대";
            this.label20.Click += new System.EventHandler(this.labelAgeClick);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(172)))), ((int)(((byte)(185)))));
            this.label50.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(527, 79);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(73, 23);
            this.label50.TabIndex = 84;
            this.label50.Text = "50대 ~";
            this.label50.Click += new System.EventHandler(this.labelAgeClick);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(172)))), ((int)(((byte)(185)))));
            this.label40.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(411, 79);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(55, 23);
            this.label40.TabIndex = 85;
            this.label40.Text = "40대";
            this.label40.Click += new System.EventHandler(this.labelAgeClick);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(172)))), ((int)(((byte)(185)))));
            this.label30.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(277, 79);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(55, 23);
            this.label30.TabIndex = 86;
            this.label30.Text = "30대";
            this.label30.Click += new System.EventHandler(this.labelAgeClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(172)))), ((int)(((byte)(185)))));
            this.label10.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 23);
            this.label10.TabIndex = 87;
            this.label10.Text = "10대";
            this.label10.Click += new System.EventHandler(this.labelAgeClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-1, 66);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(618, 54);
            this.pictureBox4.TabIndex = 82;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(669, 449);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 72);
            this.pictureBox3.TabIndex = 81;
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
            this.labelNewItemSearch.TabIndex = 77;
            this.labelNewItemSearch.Text = "신규 물건";
            this.labelNewItemSearch.Click += new System.EventHandler(this.labelNewItemSearchClick);
            // 
            // labelAgeSearch
            // 
            this.labelAgeSearch.AutoSize = true;
            this.labelAgeSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelAgeSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelAgeSearch.ForeColor = System.Drawing.Color.LightGreen;
            this.labelAgeSearch.Location = new System.Drawing.Point(647, 315);
            this.labelAgeSearch.Name = "labelAgeSearch";
            this.labelAgeSearch.Size = new System.Drawing.Size(110, 23);
            this.labelAgeSearch.TabIndex = 78;
            this.labelAgeSearch.Text = "연령별 검색";
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
            this.labelBestSeller.TabIndex = 76;
            this.labelBestSeller.Text = "베스트 셀러";
            this.labelBestSeller.Click += new System.EventHandler(this.labelBestSellerClick);
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
            this.labelCateSearch.TabIndex = 75;
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
            this.labelTotalSearch.TabIndex = 74;
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
            this.labelFindID.TabIndex = 79;
            this.labelFindID.Text = "검색>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 68);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(615, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 516);
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTEMAGERENTALBindingSource
            // 
            this.iTEMAGERENTALBindingSource.DataMember = "ITEMAGERENTAL";
            this.iTEMAGERENTALBindingSource.DataSource = this.dataSet1;
            // 
            // iTEMAGERENTALTableAdapter
            // 
            this.iTEMAGERENTALTableAdapter.ClearBeforeFill = true;
            // 
            // aGEDataGridViewTextBoxColumn
            // 
            this.aGEDataGridViewTextBoxColumn.DataPropertyName = "AGE";
            this.aGEDataGridViewTextBoxColumn.HeaderText = "AGE";
            this.aGEDataGridViewTextBoxColumn.Name = "aGEDataGridViewTextBoxColumn";
            this.aGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aGEDataGridViewTextBoxColumn.Visible = false;
            // 
            // iTEMIDDataGridViewTextBoxColumn
            // 
            this.iTEMIDDataGridViewTextBoxColumn.DataPropertyName = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.HeaderText = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.Name = "iTEMIDDataGridViewTextBoxColumn";
            this.iTEMIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iTEMIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // rENTALNUMDataGridViewTextBoxColumn
            // 
            this.rENTALNUMDataGridViewTextBoxColumn.DataPropertyName = "RENTALNUM";
            this.rENTALNUMDataGridViewTextBoxColumn.HeaderText = "RENTALNUM";
            this.rENTALNUMDataGridViewTextBoxColumn.Name = "rENTALNUMDataGridViewTextBoxColumn";
            this.rENTALNUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.rENTALNUMDataGridViewTextBoxColumn.Visible = false;
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
            this.iTEMMILEAGEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iTEMMILEAGEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_MILEAGE";
            this.iTEMMILEAGEDataGridViewTextBoxColumn.HeaderText = "적립금";
            this.iTEMMILEAGEDataGridViewTextBoxColumn.Name = "iTEMMILEAGEDataGridViewTextBoxColumn";
            this.iTEMMILEAGEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemagerentalTableAdapter1
            // 
            this.itemagerentalTableAdapter1.ClearBeforeFill = true;
            // 
            // FormConsuSearchAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox4);
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
            this.Name = "FormConsuSearchAge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVERYTHIN\'";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConsuSearchAge_FormClosing);
            this.Load += new System.EventHandler(this.FormConsuSearchAge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMAGERENTALBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelNewItemSearch;
        private System.Windows.Forms.Label labelAgeSearch;
        private System.Windows.Forms.Label labelBestSeller;
        private System.Windows.Forms.Label labelCateSearch;
        private System.Windows.Forms.Label labelTotalSearch;
        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource iTEMAGERENTALBindingSource;
        private DataSet1TableAdapters.ITEMAGERENTALTableAdapter iTEMAGERENTALTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENTALNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMMILEAGEDataGridViewTextBoxColumn;
        private DataSet1TableAdapters.ITEMAGERENTALTableAdapter itemagerentalTableAdapter1;
    }
}