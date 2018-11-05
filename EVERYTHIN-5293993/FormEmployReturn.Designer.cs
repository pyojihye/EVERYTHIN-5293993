namespace EVERYTHIN_5293993
{
    partial class FormEmployReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployReturn));
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearchConsu = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelNowReturn = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cONSUMERRENTALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new EVERYTHIN_5293993.DataSet1();
            this.cONSUMERRENTALTableAdapter = new EVERYTHIN_5293993.DataSet1TableAdapters.CONSUMERRENTALTableAdapter();
            this.dataSet11 = new EVERYTHIN_5293993.DataSet1();
            this.itemTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.ITEMTableAdapter();
            this.consumerTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.CONSUMERTableAdapter();
            this.returnTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.RETURNTableAdapter();
            this.cONSUNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUMILEAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENMONEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENPREPAYMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMERRENTALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("나눔스퀘어", 14.25F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.textBoxSearch.Location = new System.Drawing.Point(16, 96);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(390, 29);
            this.textBoxSearch.TabIndex = 84;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // buttonSearchConsu
            // 
            this.buttonSearchConsu.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonSearchConsu.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSearchConsu.ForeColor = System.Drawing.Color.White;
            this.buttonSearchConsu.Location = new System.Drawing.Point(487, 83);
            this.buttonSearchConsu.Name = "buttonSearchConsu";
            this.buttonSearchConsu.Size = new System.Drawing.Size(113, 50);
            this.buttonSearchConsu.TabIndex = 85;
            this.buttonSearchConsu.Text = "회원 검색";
            this.buttonSearchConsu.UseVisualStyleBackColor = false;
            this.buttonSearchConsu.Click += new System.EventHandler(this.buttonSearchConsuClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(412, 83);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(69, 50);
            this.buttonSearch.TabIndex = 86;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearchClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(676, 443);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 72);
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // labelNowReturn
            // 
            this.labelNowReturn.AutoSize = true;
            this.labelNowReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelNowReturn.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelNowReturn.ForeColor = System.Drawing.Color.White;
            this.labelNowReturn.Location = new System.Drawing.Point(659, 192);
            this.labelNowReturn.Name = "labelNowReturn";
            this.labelNowReturn.Size = new System.Drawing.Size(91, 23);
            this.labelNowReturn.TabIndex = 78;
            this.labelNowReturn.Text = "반납 현황";
            this.labelNowReturn.Click += new System.EventHandler(this.labelNowReturnClick);
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelReturn.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelReturn.ForeColor = System.Drawing.Color.LightGreen;
            this.labelReturn.Location = new System.Drawing.Point(659, 100);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(91, 23);
            this.labelReturn.TabIndex = 77;
            this.labelReturn.Text = "물건 반납";
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
            this.labelFindID.TabIndex = 80;
            this.labelFindID.Text = "반납>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 68);
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(616, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 516);
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cONSUNAMEDataGridViewTextBoxColumn,
            this.cONSUEMAILDataGridViewTextBoxColumn,
            this.cONSUMILEAGEDataGridViewTextBoxColumn,
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn,
            this.rENMONEYDataGridViewTextBoxColumn,
            this.rENDATEDataGridViewTextBoxColumn,
            this.rENPREPAYMENTDataGridViewTextBoxColumn,
            this.sTOSTOCKDataGridViewTextBoxColumn,
            this.iTEMNAMEDataGridViewTextBoxColumn,
            this.cONSUIDDataGridViewTextBoxColumn,
            this.iTEMIDDataGridViewTextBoxColumn,
            this.cATEDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cONSUMERRENTALBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(584, 399);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cONSUMERRENTALBindingSource
            // 
            this.cONSUMERRENTALBindingSource.DataMember = "CONSUMERRENTAL";
            this.cONSUMERRENTALBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONSUMERRENTALTableAdapter
            // 
            this.cONSUMERRENTALTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableAdapter1
            // 
            this.itemTableAdapter1.ClearBeforeFill = true;
            // 
            // consumerTableAdapter1
            // 
            this.consumerTableAdapter1.ClearBeforeFill = true;
            // 
            // returnTableAdapter1
            // 
            this.returnTableAdapter1.ClearBeforeFill = true;
            // 
            // cONSUNAMEDataGridViewTextBoxColumn
            // 
            this.cONSUNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cONSUNAMEDataGridViewTextBoxColumn.DataPropertyName = "CONSU_NAME";
            this.cONSUNAMEDataGridViewTextBoxColumn.HeaderText = "회원명";
            this.cONSUNAMEDataGridViewTextBoxColumn.Name = "cONSUNAMEDataGridViewTextBoxColumn";
            this.cONSUNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONSUEMAILDataGridViewTextBoxColumn
            // 
            this.cONSUEMAILDataGridViewTextBoxColumn.DataPropertyName = "CONSU_EMAIL";
            this.cONSUEMAILDataGridViewTextBoxColumn.HeaderText = "CONSU_EMAIL";
            this.cONSUEMAILDataGridViewTextBoxColumn.Name = "cONSUEMAILDataGridViewTextBoxColumn";
            this.cONSUEMAILDataGridViewTextBoxColumn.Visible = false;
            // 
            // cONSUMILEAGEDataGridViewTextBoxColumn
            // 
            this.cONSUMILEAGEDataGridViewTextBoxColumn.DataPropertyName = "CONSU_MILEAGE";
            this.cONSUMILEAGEDataGridViewTextBoxColumn.HeaderText = "CONSU_MILEAGE";
            this.cONSUMILEAGEDataGridViewTextBoxColumn.Name = "cONSUMILEAGEDataGridViewTextBoxColumn";
            this.cONSUMILEAGEDataGridViewTextBoxColumn.Visible = false;
            // 
            // cONSUBLACKCONSUMERDataGridViewTextBoxColumn
            // 
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.DataPropertyName = "CONSU_BLACKCONSUMER";
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.HeaderText = "CONSU_BLACKCONSUMER";
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.Name = "cONSUBLACKCONSUMERDataGridViewTextBoxColumn";
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.Visible = false;
            // 
            // rENMONEYDataGridViewTextBoxColumn
            // 
            this.rENMONEYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rENMONEYDataGridViewTextBoxColumn.DataPropertyName = "REN_MONEY";
            this.rENMONEYDataGridViewTextBoxColumn.HeaderText = "대여금";
            this.rENMONEYDataGridViewTextBoxColumn.Name = "rENMONEYDataGridViewTextBoxColumn";
            this.rENMONEYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rENDATEDataGridViewTextBoxColumn
            // 
            this.rENDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rENDATEDataGridViewTextBoxColumn.DataPropertyName = "REN_DATE";
            this.rENDATEDataGridViewTextBoxColumn.HeaderText = "대여일";
            this.rENDATEDataGridViewTextBoxColumn.Name = "rENDATEDataGridViewTextBoxColumn";
            this.rENDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rENPREPAYMENTDataGridViewTextBoxColumn
            // 
            this.rENPREPAYMENTDataGridViewTextBoxColumn.DataPropertyName = "REN_PREPAYMENT";
            this.rENPREPAYMENTDataGridViewTextBoxColumn.HeaderText = "REN_PREPAYMENT";
            this.rENPREPAYMENTDataGridViewTextBoxColumn.Name = "rENPREPAYMENTDataGridViewTextBoxColumn";
            this.rENPREPAYMENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTOSTOCKDataGridViewTextBoxColumn
            // 
            this.sTOSTOCKDataGridViewTextBoxColumn.DataPropertyName = "STO_STOCK";
            this.sTOSTOCKDataGridViewTextBoxColumn.HeaderText = "STO_STOCK";
            this.sTOSTOCKDataGridViewTextBoxColumn.Name = "sTOSTOCKDataGridViewTextBoxColumn";
            this.sTOSTOCKDataGridViewTextBoxColumn.Visible = false;
            // 
            // iTEMNAMEDataGridViewTextBoxColumn
            // 
            this.iTEMNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iTEMNAMEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_NAME";
            this.iTEMNAMEDataGridViewTextBoxColumn.HeaderText = "물건명";
            this.iTEMNAMEDataGridViewTextBoxColumn.Name = "iTEMNAMEDataGridViewTextBoxColumn";
            this.iTEMNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONSUIDDataGridViewTextBoxColumn
            // 
            this.cONSUIDDataGridViewTextBoxColumn.DataPropertyName = "CONSU_ID";
            this.cONSUIDDataGridViewTextBoxColumn.HeaderText = "CONSU_ID";
            this.cONSUIDDataGridViewTextBoxColumn.Name = "cONSUIDDataGridViewTextBoxColumn";
            this.cONSUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iTEMIDDataGridViewTextBoxColumn
            // 
            this.iTEMIDDataGridViewTextBoxColumn.DataPropertyName = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.HeaderText = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.Name = "iTEMIDDataGridViewTextBoxColumn";
            this.iTEMIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cATEDATEDataGridViewTextBoxColumn
            // 
            this.cATEDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cATEDATEDataGridViewTextBoxColumn.DataPropertyName = "CATE_DATE";
            this.cATEDATEDataGridViewTextBoxColumn.HeaderText = "대여기간";
            this.cATEDATEDataGridViewTextBoxColumn.Name = "cATEDATEDataGridViewTextBoxColumn";
            this.cATEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cATEDATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormEmployReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearchConsu);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelNowReturn);
            this.Controls.Add(this.labelReturn);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEmployReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVERYTHIN\'";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmployReturn_FormClosing);
            this.Load += new System.EventHandler(this.FormEmployReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMERRENTALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearchConsu;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelNowReturn;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cONSUMERRENTALBindingSource;
        private DataSet1TableAdapters.CONSUMERRENTALTableAdapter cONSUMERRENTALTableAdapter;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.ITEMTableAdapter itemTableAdapter1;
        private DataSet1TableAdapters.CONSUMERTableAdapter consumerTableAdapter1;
        private DataSet1TableAdapters.RETURNTableAdapter returnTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUMILEAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUBLACKCONSUMERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENMONEYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENPREPAYMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEDATEDataGridViewTextBoxColumn;
    }
}