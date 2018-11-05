namespace EVERYTHIN_5293993
{
    partial class FormEmployReturnNow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployReturnNow));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rETURNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new EVERYTHIN_5293993.DataSet1();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelNowReturn = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rETURNTableAdapter = new EVERYTHIN_5293993.DataSet1TableAdapters.RETURNTableAdapter();
            this.cONSUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tODAYDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rET50000DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rET10000DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rET5000DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rET1000DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rET500DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rET100DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rET50DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rET10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rETURNBindingSource)).BeginInit();
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
            this.monthCalendar1.TabIndex = 87;
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
            this.tODAYDATEDataGridViewTextBoxColumn,
            this.rET50000DataGridViewTextBoxColumn,
            this.rET10000DataGridViewTextBoxColumn,
            this.rET5000DataGridViewTextBoxColumn,
            this.rET1000DataGridViewTextBoxColumn,
            this.rET500DataGridViewTextBoxColumn,
            this.rET100DataGridViewTextBoxColumn,
            this.rET50DataGridViewTextBoxColumn,
            this.rET10DataGridViewTextBoxColumn,
            this.sTOSTOCKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rETURNBindingSource;
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
            this.dataGridView1.TabIndex = 86;
            // 
            // rETURNBindingSource
            // 
            this.rETURNBindingSource.DataMember = "RETURN";
            this.rETURNBindingSource.DataSource = this.dataSet1;
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
            this.pictureBox3.Location = new System.Drawing.Point(676, 443);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 72);
            this.pictureBox3.TabIndex = 85;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // labelNowReturn
            // 
            this.labelNowReturn.AutoSize = true;
            this.labelNowReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelNowReturn.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelNowReturn.ForeColor = System.Drawing.Color.LightGreen;
            this.labelNowReturn.Location = new System.Drawing.Point(659, 192);
            this.labelNowReturn.Name = "labelNowReturn";
            this.labelNowReturn.Size = new System.Drawing.Size(91, 23);
            this.labelNowReturn.TabIndex = 81;
            this.labelNowReturn.Text = "반납 현황";
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelReturn.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelReturn.ForeColor = System.Drawing.Color.White;
            this.labelReturn.Location = new System.Drawing.Point(659, 100);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(91, 23);
            this.labelReturn.TabIndex = 80;
            this.labelReturn.Text = "물건 반납";
            this.labelReturn.Click += new System.EventHandler(this.labelReturnClick);
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
            this.labelFindID.TabIndex = 83;
            this.labelFindID.Text = "반납>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 68);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(616, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 516);
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            // 
            // rETURNTableAdapter
            // 
            this.rETURNTableAdapter.ClearBeforeFill = true;
            // 
            // cONSUIDDataGridViewTextBoxColumn
            // 
            this.cONSUIDDataGridViewTextBoxColumn.DataPropertyName = "CONSU_ID";
            this.cONSUIDDataGridViewTextBoxColumn.HeaderText = "회원ID";
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
            this.eMPLOYIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOY_ID";
            this.eMPLOYIDDataGridViewTextBoxColumn.HeaderText = "EMPLOY_ID";
            this.eMPLOYIDDataGridViewTextBoxColumn.Name = "eMPLOYIDDataGridViewTextBoxColumn";
            this.eMPLOYIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPLOYIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tODAYDATEDataGridViewTextBoxColumn
            // 
            this.tODAYDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tODAYDATEDataGridViewTextBoxColumn.DataPropertyName = "TODAY_DATE";
            this.tODAYDATEDataGridViewTextBoxColumn.HeaderText = "반납일";
            this.tODAYDATEDataGridViewTextBoxColumn.Name = "tODAYDATEDataGridViewTextBoxColumn";
            this.tODAYDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rET50000DataGridViewTextBoxColumn
            // 
            this.rET50000DataGridViewTextBoxColumn.DataPropertyName = "RET_50000";
            this.rET50000DataGridViewTextBoxColumn.HeaderText = "RET_50000";
            this.rET50000DataGridViewTextBoxColumn.Name = "rET50000DataGridViewTextBoxColumn";
            this.rET50000DataGridViewTextBoxColumn.ReadOnly = true;
            this.rET50000DataGridViewTextBoxColumn.Visible = false;
            // 
            // rET10000DataGridViewTextBoxColumn
            // 
            this.rET10000DataGridViewTextBoxColumn.DataPropertyName = "RET_10000";
            this.rET10000DataGridViewTextBoxColumn.HeaderText = "RET_10000";
            this.rET10000DataGridViewTextBoxColumn.Name = "rET10000DataGridViewTextBoxColumn";
            this.rET10000DataGridViewTextBoxColumn.ReadOnly = true;
            this.rET10000DataGridViewTextBoxColumn.Visible = false;
            // 
            // rET5000DataGridViewTextBoxColumn
            // 
            this.rET5000DataGridViewTextBoxColumn.DataPropertyName = "RET_5000";
            this.rET5000DataGridViewTextBoxColumn.HeaderText = "RET_5000";
            this.rET5000DataGridViewTextBoxColumn.Name = "rET5000DataGridViewTextBoxColumn";
            this.rET5000DataGridViewTextBoxColumn.ReadOnly = true;
            this.rET5000DataGridViewTextBoxColumn.Visible = false;
            // 
            // rET1000DataGridViewTextBoxColumn
            // 
            this.rET1000DataGridViewTextBoxColumn.DataPropertyName = "RET_1000";
            this.rET1000DataGridViewTextBoxColumn.HeaderText = "RET_1000";
            this.rET1000DataGridViewTextBoxColumn.Name = "rET1000DataGridViewTextBoxColumn";
            this.rET1000DataGridViewTextBoxColumn.ReadOnly = true;
            this.rET1000DataGridViewTextBoxColumn.Visible = false;
            // 
            // rET500DataGridViewTextBoxColumn
            // 
            this.rET500DataGridViewTextBoxColumn.DataPropertyName = "RET_500";
            this.rET500DataGridViewTextBoxColumn.HeaderText = "RET_500";
            this.rET500DataGridViewTextBoxColumn.Name = "rET500DataGridViewTextBoxColumn";
            this.rET500DataGridViewTextBoxColumn.ReadOnly = true;
            this.rET500DataGridViewTextBoxColumn.Visible = false;
            // 
            // rET100DataGridViewTextBoxColumn
            // 
            this.rET100DataGridViewTextBoxColumn.DataPropertyName = "RET_100";
            this.rET100DataGridViewTextBoxColumn.HeaderText = "RET_100";
            this.rET100DataGridViewTextBoxColumn.Name = "rET100DataGridViewTextBoxColumn";
            this.rET100DataGridViewTextBoxColumn.ReadOnly = true;
            this.rET100DataGridViewTextBoxColumn.Visible = false;
            // 
            // rET50DataGridViewTextBoxColumn
            // 
            this.rET50DataGridViewTextBoxColumn.DataPropertyName = "RET_50";
            this.rET50DataGridViewTextBoxColumn.HeaderText = "RET_50";
            this.rET50DataGridViewTextBoxColumn.Name = "rET50DataGridViewTextBoxColumn";
            this.rET50DataGridViewTextBoxColumn.ReadOnly = true;
            this.rET50DataGridViewTextBoxColumn.Visible = false;
            // 
            // rET10DataGridViewTextBoxColumn
            // 
            this.rET10DataGridViewTextBoxColumn.DataPropertyName = "RET_10";
            this.rET10DataGridViewTextBoxColumn.HeaderText = "RET_10";
            this.rET10DataGridViewTextBoxColumn.Name = "rET10DataGridViewTextBoxColumn";
            this.rET10DataGridViewTextBoxColumn.ReadOnly = true;
            this.rET10DataGridViewTextBoxColumn.Visible = false;
            // 
            // sTOSTOCKDataGridViewTextBoxColumn
            // 
            this.sTOSTOCKDataGridViewTextBoxColumn.DataPropertyName = "STO_STOCK";
            this.sTOSTOCKDataGridViewTextBoxColumn.HeaderText = "STO_STOCK";
            this.sTOSTOCKDataGridViewTextBoxColumn.Name = "sTOSTOCKDataGridViewTextBoxColumn";
            this.sTOSTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTOSTOCKDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormEmployReturnNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelNowReturn);
            this.Controls.Add(this.labelReturn);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEmployReturnNow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVERYTHIN\'";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmployReturnNow_FormClosing);
            this.Load += new System.EventHandler(this.FormEmployReturnNow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rETURNBindingSource)).EndInit();
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
        private System.Windows.Forms.Label labelNowReturn;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rETURNBindingSource;
        private DataSet1TableAdapters.RETURNTableAdapter rETURNTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tODAYDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rET50000DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rET10000DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rET5000DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rET1000DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rET500DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rET100DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rET50DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rET10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOSTOCKDataGridViewTextBoxColumn;
    }
}