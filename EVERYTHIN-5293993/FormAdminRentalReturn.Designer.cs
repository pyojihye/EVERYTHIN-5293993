namespace EVERYTHIN_5293993
{
    partial class FormAdminRentalReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminRentalReturn));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelCateSearch = new System.Windows.Forms.Label();
            this.labelTotalSearch = new System.Windows.Forms.Label();
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new EVERYTHIN_5293993.DataSet1();
            this.rENTALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rENTALTableAdapter = new EVERYTHIN_5293993.DataSet1TableAdapters.RENTALTableAdapter();
            this.cONSUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENMONEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENPREPAYMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(672, 443);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 72);
            this.pictureBox3.TabIndex = 111;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // labelCateSearch
            // 
            this.labelCateSearch.AutoSize = true;
            this.labelCateSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelCateSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCateSearch.ForeColor = System.Drawing.Color.White;
            this.labelCateSearch.Location = new System.Drawing.Point(654, 172);
            this.labelCateSearch.Name = "labelCateSearch";
            this.labelCateSearch.Size = new System.Drawing.Size(91, 23);
            this.labelCateSearch.TabIndex = 108;
            this.labelCateSearch.Text = "반납 현황";
            this.labelCateSearch.Click += new System.EventHandler(this.labelCateSearch_Click);
            // 
            // labelTotalSearch
            // 
            this.labelTotalSearch.AutoSize = true;
            this.labelTotalSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelTotalSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTotalSearch.ForeColor = System.Drawing.Color.LightGreen;
            this.labelTotalSearch.Location = new System.Drawing.Point(654, 100);
            this.labelTotalSearch.Name = "labelTotalSearch";
            this.labelTotalSearch.Size = new System.Drawing.Size(91, 23);
            this.labelTotalSearch.TabIndex = 107;
            this.labelTotalSearch.Text = "대여 현황";
            // 
            // labelFindID
            // 
            this.labelFindID.AutoSize = true;
            this.labelFindID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(134)))), ((int)(((byte)(153)))));
            this.labelFindID.Font = new System.Drawing.Font("나눔스퀘어", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFindID.ForeColor = System.Drawing.Color.White;
            this.labelFindID.Location = new System.Drawing.Point(11, 22);
            this.labelFindID.Name = "labelFindID";
            this.labelFindID.Size = new System.Drawing.Size(158, 26);
            this.labelFindID.TabIndex = 109;
            this.labelFindID.Text = "대여 / 반납>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 68);
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(615, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 516);
            this.pictureBox2.TabIndex = 110;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.label1.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(654, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 108;
            this.label1.Text = "예약 현황";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cONSUIDDataGridViewTextBoxColumn,
            this.iTEMIDDataGridViewTextBoxColumn,
            this.cATEIDDataGridViewTextBoxColumn,
            this.eMPLOYIDDataGridViewTextBoxColumn,
            this.rENMONEYDataGridViewTextBoxColumn,
            this.rENDATEDataGridViewTextBoxColumn,
            this.rENPREPAYMENTDataGridViewTextBoxColumn,
            this.rENCOUNTDataGridViewTextBoxColumn,
            this.sTOSTOCKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rENTALBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(580, 272);
            this.dataGridView1.TabIndex = 112;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rENTALBindingSource
            // 
            this.rENTALBindingSource.DataMember = "RENTAL";
            this.rENTALBindingSource.DataSource = this.dataSet1;
            // 
            // rENTALTableAdapter
            // 
            this.rENTALTableAdapter.ClearBeforeFill = true;
            // 
            // cONSUIDDataGridViewTextBoxColumn
            // 
            this.cONSUIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cONSUIDDataGridViewTextBoxColumn.DataPropertyName = "CONSU_ID";
            this.cONSUIDDataGridViewTextBoxColumn.HeaderText = "고객ID";
            this.cONSUIDDataGridViewTextBoxColumn.Name = "cONSUIDDataGridViewTextBoxColumn";
            this.cONSUIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTEMIDDataGridViewTextBoxColumn
            // 
            this.iTEMIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iTEMIDDataGridViewTextBoxColumn.DataPropertyName = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.HeaderText = "물건ID";
            this.iTEMIDDataGridViewTextBoxColumn.Name = "iTEMIDDataGridViewTextBoxColumn";
            this.iTEMIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cATEIDDataGridViewTextBoxColumn
            // 
            this.cATEIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cATEIDDataGridViewTextBoxColumn.DataPropertyName = "CATE_ID";
            this.cATEIDDataGridViewTextBoxColumn.HeaderText = "분류명";
            this.cATEIDDataGridViewTextBoxColumn.Name = "cATEIDDataGridViewTextBoxColumn";
            this.cATEIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMPLOYIDDataGridViewTextBoxColumn
            // 
            this.eMPLOYIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eMPLOYIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOY_ID";
            this.eMPLOYIDDataGridViewTextBoxColumn.HeaderText = "직원ID";
            this.eMPLOYIDDataGridViewTextBoxColumn.Name = "eMPLOYIDDataGridViewTextBoxColumn";
            this.eMPLOYIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rENMONEYDataGridViewTextBoxColumn
            // 
            this.rENMONEYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rENMONEYDataGridViewTextBoxColumn.DataPropertyName = "REN_MONEY";
            this.rENMONEYDataGridViewTextBoxColumn.HeaderText = "금액";
            this.rENMONEYDataGridViewTextBoxColumn.Name = "rENMONEYDataGridViewTextBoxColumn";
            this.rENMONEYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rENDATEDataGridViewTextBoxColumn
            // 
            this.rENDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rENDATEDataGridViewTextBoxColumn.DataPropertyName = "REN_DATE";
            this.rENDATEDataGridViewTextBoxColumn.HeaderText = "날짜";
            this.rENDATEDataGridViewTextBoxColumn.Name = "rENDATEDataGridViewTextBoxColumn";
            this.rENDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rENPREPAYMENTDataGridViewTextBoxColumn
            // 
            this.rENPREPAYMENTDataGridViewTextBoxColumn.DataPropertyName = "REN_PREPAYMENT";
            this.rENPREPAYMENTDataGridViewTextBoxColumn.HeaderText = "REN_PREPAYMENT";
            this.rENPREPAYMENTDataGridViewTextBoxColumn.Name = "rENPREPAYMENTDataGridViewTextBoxColumn";
            this.rENPREPAYMENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.rENPREPAYMENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // rENCOUNTDataGridViewTextBoxColumn
            // 
            this.rENCOUNTDataGridViewTextBoxColumn.DataPropertyName = "REN_COUNT";
            this.rENCOUNTDataGridViewTextBoxColumn.HeaderText = "REN_COUNT";
            this.rENCOUNTDataGridViewTextBoxColumn.Name = "rENCOUNTDataGridViewTextBoxColumn";
            this.rENCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.rENCOUNTDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTOSTOCKDataGridViewTextBoxColumn
            // 
            this.sTOSTOCKDataGridViewTextBoxColumn.DataPropertyName = "STO_STOCK";
            this.sTOSTOCKDataGridViewTextBoxColumn.HeaderText = "STO_STOCK";
            this.sTOSTOCKDataGridViewTextBoxColumn.Name = "sTOSTOCKDataGridViewTextBoxColumn";
            this.sTOSTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTOSTOCKDataGridViewTextBoxColumn.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(214, 100);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 113;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // FormAdminRentalReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCateSearch);
            this.Controls.Add(this.labelTotalSearch);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAdminRentalReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVERYTHIN\'";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminRentalReturn_FormClosing);
            this.Load += new System.EventHandler(this.FormAdminRentalReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rENTALBindingSource;
        private DataSet1TableAdapters.RENTALTableAdapter rENTALTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENMONEYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENPREPAYMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}