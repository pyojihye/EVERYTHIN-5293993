namespace EVERYTHIN_5293993
{
    partial class FormEmployRentalNow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployRentalNow));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cONSUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENMONEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENPREPAYMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENTALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new EVERYTHIN_5293993.DataSet1();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelNowRental = new System.Windows.Forms.Label();
            this.labelRental = new System.Windows.Forms.Label();
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rENTALTableAdapter = new EVERYTHIN_5293993.DataSet1TableAdapters.RENTALTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(202, 78);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 82;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(596, 297);
            this.dataGridView1.TabIndex = 81;
            // 
            // cONSUIDDataGridViewTextBoxColumn
            // 
            this.cONSUIDDataGridViewTextBoxColumn.DataPropertyName = "CONSU_ID";
            this.cONSUIDDataGridViewTextBoxColumn.HeaderText = "CONSU_ID";
            this.cONSUIDDataGridViewTextBoxColumn.Name = "cONSUIDDataGridViewTextBoxColumn";
            this.cONSUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cONSUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iTEMIDDataGridViewTextBoxColumn
            // 
            this.iTEMIDDataGridViewTextBoxColumn.DataPropertyName = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.HeaderText = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.Name = "iTEMIDDataGridViewTextBoxColumn";
            this.iTEMIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iTEMIDDataGridViewTextBoxColumn.Visible = false;
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
            this.eMPLOYIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOY_ID";
            this.eMPLOYIDDataGridViewTextBoxColumn.HeaderText = "EMPLOY_ID";
            this.eMPLOYIDDataGridViewTextBoxColumn.Name = "eMPLOYIDDataGridViewTextBoxColumn";
            this.eMPLOYIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPLOYIDDataGridViewTextBoxColumn.Visible = false;
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
            // rENTALBindingSource
            // 
            this.rENTALBindingSource.DataMember = "RENTAL";
            this.rENTALBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(666, 423);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 72);
            this.pictureBox3.TabIndex = 80;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // labelNowRental
            // 
            this.labelNowRental.AutoSize = true;
            this.labelNowRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelNowRental.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelNowRental.ForeColor = System.Drawing.Color.LightGreen;
            this.labelNowRental.Location = new System.Drawing.Point(659, 192);
            this.labelNowRental.Name = "labelNowRental";
            this.labelNowRental.Size = new System.Drawing.Size(91, 23);
            this.labelNowRental.TabIndex = 76;
            this.labelNowRental.Text = "대여 현황";
            // 
            // labelRental
            // 
            this.labelRental.AutoSize = true;
            this.labelRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelRental.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelRental.ForeColor = System.Drawing.Color.White;
            this.labelRental.Location = new System.Drawing.Point(659, 100);
            this.labelRental.Name = "labelRental";
            this.labelRental.Size = new System.Drawing.Size(91, 23);
            this.labelRental.TabIndex = 75;
            this.labelRental.Text = "물건 대여";
            this.labelRental.Click += new System.EventHandler(this.labelRentalClick);
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
            this.labelFindID.TabIndex = 78;
            this.labelFindID.Text = "대여>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 68);
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(616, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 516);
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            // 
            // rENTALTableAdapter
            // 
            this.rENTALTableAdapter.ClearBeforeFill = true;
            // 
            // FormEmployRentalNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelNowRental);
            this.Controls.Add(this.labelRental);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEmployRentalNow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVERYTHIN\'";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmployRentalNow_FormClosing);
            this.Load += new System.EventHandler(this.FormEmployRentalNow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelNowRental;
        private System.Windows.Forms.Label labelRental;
        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
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
    }
}