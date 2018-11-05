namespace EVERYTHIN_5293993
{
    partial class FormAdminEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminEmail));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelCateSearch = new System.Windows.Forms.Label();
            this.labelTotalSearch = new System.Windows.Forms.Label();
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cONSUMERRENTALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new EVERYTHIN_5293993.DataSet1();
            this.cONSUMERRENTALTableAdapter = new EVERYTHIN_5293993.DataSet1TableAdapters.CONSUMERRENTALTableAdapter();
            this.returnTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.RETURNTableAdapter();
            this.dataSet11 = new EVERYTHIN_5293993.DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMERRENTALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(672, 443);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 72);
            this.pictureBox3.TabIndex = 99;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // labelCateSearch
            // 
            this.labelCateSearch.AutoSize = true;
            this.labelCateSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelCateSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCateSearch.ForeColor = System.Drawing.Color.LightGreen;
            this.labelCateSearch.Location = new System.Drawing.Point(654, 171);
            this.labelCateSearch.Name = "labelCateSearch";
            this.labelCateSearch.Size = new System.Drawing.Size(91, 23);
            this.labelCateSearch.TabIndex = 96;
            this.labelCateSearch.Text = "반납 메일";
            // 
            // labelTotalSearch
            // 
            this.labelTotalSearch.AutoSize = true;
            this.labelTotalSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelTotalSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTotalSearch.ForeColor = System.Drawing.Color.White;
            this.labelTotalSearch.Location = new System.Drawing.Point(677, 102);
            this.labelTotalSearch.Name = "labelTotalSearch";
            this.labelTotalSearch.Size = new System.Drawing.Size(48, 23);
            this.labelTotalSearch.TabIndex = 95;
            this.labelTotalSearch.Text = "고객";
            this.labelTotalSearch.Click += new System.EventHandler(this.labelTotalSearch_Click);
            // 
            // labelFindID
            // 
            this.labelFindID.AutoSize = true;
            this.labelFindID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(134)))), ((int)(((byte)(153)))));
            this.labelFindID.Font = new System.Drawing.Font("나눔스퀘어", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFindID.ForeColor = System.Drawing.Color.White;
            this.labelFindID.Location = new System.Drawing.Point(11, 22);
            this.labelFindID.Name = "labelFindID";
            this.labelFindID.Size = new System.Drawing.Size(141, 26);
            this.labelFindID.TabIndex = 97;
            this.labelFindID.Text = "고객 관리>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 68);
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(615, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 516);
            this.pictureBox2.TabIndex = 98;
            this.pictureBox2.TabStop = false;
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
            // returnTableAdapter1
            // 
            this.returnTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dataGridView1.Location = new System.Drawing.Point(16, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(584, 451);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // 
            // FormAdminEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelCateSearch);
            this.Controls.Add(this.labelTotalSearch);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAdminEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVERYTHIN\'";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminEmail_FormClosing);
            this.Load += new System.EventHandler(this.FormAdminEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMERRENTALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelCateSearch;
        private System.Windows.Forms.Label labelTotalSearch;
        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cONSUMERRENTALBindingSource;
        private DataSet1TableAdapters.CONSUMERRENTALTableAdapter cONSUMERRENTALTableAdapter;
        private DataSet1TableAdapters.RETURNTableAdapter returnTableAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridView dataGridView1;
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