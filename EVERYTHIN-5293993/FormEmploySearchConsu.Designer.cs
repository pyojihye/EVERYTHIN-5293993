namespace EVERYTHIN_5293993
{
    partial class FormEmploySearchConsu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmploySearchConsu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cONSUMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new EVERYTHIN_5293993.DataSet1();
            this.labelConsuSearch = new System.Windows.Forms.Label();
            this.labelItemSearch = new System.Windows.Forms.Label();
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cONSUMERTableAdapter = new EVERYTHIN_5293993.DataSet1TableAdapters.CONSUMERTableAdapter();
            this.cONSUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUBIRTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cONSUMILEAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumerTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.CONSUMERTableAdapter();
            this.dataSet11 = new EVERYTHIN_5293993.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(673, 448);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 72);
            this.pictureBox3.TabIndex = 88;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("나눔스퀘어", 14.25F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.textBoxSearch.Location = new System.Drawing.Point(16, 91);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(492, 29);
            this.textBoxSearch.TabIndex = 86;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonSearch.Font = new System.Drawing.Font("나눔스퀘어", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(514, 83);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(83, 50);
            this.buttonSearch.TabIndex = 87;
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
            this.cONSUIDDataGridViewTextBoxColumn,
            this.cONSUPASSWORDDataGridViewTextBoxColumn,
            this.cONSUNAMEDataGridViewTextBoxColumn,
            this.cONSUEMAILDataGridViewTextBoxColumn,
            this.cONSUBIRTHDataGridViewTextBoxColumn,
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn,
            this.cONSUMILEAGEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cONSUMERBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(16, 137);
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
            this.dataGridView1.Size = new System.Drawing.Size(581, 412);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cONSUMERBindingSource
            // 
            this.cONSUMERBindingSource.DataMember = "CONSUMER";
            this.cONSUMERBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelConsuSearch
            // 
            this.labelConsuSearch.AutoSize = true;
            this.labelConsuSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelConsuSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelConsuSearch.ForeColor = System.Drawing.Color.LightGreen;
            this.labelConsuSearch.Location = new System.Drawing.Point(657, 169);
            this.labelConsuSearch.Name = "labelConsuSearch";
            this.labelConsuSearch.Size = new System.Drawing.Size(91, 23);
            this.labelConsuSearch.TabIndex = 82;
            this.labelConsuSearch.Text = "고객 검색";
            // 
            // labelItemSearch
            // 
            this.labelItemSearch.AutoSize = true;
            this.labelItemSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelItemSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelItemSearch.ForeColor = System.Drawing.Color.White;
            this.labelItemSearch.Location = new System.Drawing.Point(657, 97);
            this.labelItemSearch.Name = "labelItemSearch";
            this.labelItemSearch.Size = new System.Drawing.Size(91, 23);
            this.labelItemSearch.TabIndex = 81;
            this.labelItemSearch.Text = "물건 검색";
            this.labelItemSearch.Click += new System.EventHandler(this.labelItemSearchClick);
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
            this.labelFindID.Text = "검색>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 68);
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(615, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 516);
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            // 
            // cONSUMERTableAdapter
            // 
            this.cONSUMERTableAdapter.ClearBeforeFill = true;
            // 
            // cONSUIDDataGridViewTextBoxColumn
            // 
            this.cONSUIDDataGridViewTextBoxColumn.DataPropertyName = "CONSU_ID";
            this.cONSUIDDataGridViewTextBoxColumn.HeaderText = "CONSU_ID";
            this.cONSUIDDataGridViewTextBoxColumn.Name = "cONSUIDDataGridViewTextBoxColumn";
            this.cONSUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cONSUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cONSUPASSWORDDataGridViewTextBoxColumn
            // 
            this.cONSUPASSWORDDataGridViewTextBoxColumn.DataPropertyName = "CONSU_PASSWORD";
            this.cONSUPASSWORDDataGridViewTextBoxColumn.HeaderText = "CONSU_PASSWORD";
            this.cONSUPASSWORDDataGridViewTextBoxColumn.Name = "cONSUPASSWORDDataGridViewTextBoxColumn";
            this.cONSUPASSWORDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cONSUPASSWORDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cONSUNAMEDataGridViewTextBoxColumn
            // 
            this.cONSUNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cONSUNAMEDataGridViewTextBoxColumn.DataPropertyName = "CONSU_NAME";
            this.cONSUNAMEDataGridViewTextBoxColumn.HeaderText = "고객이름";
            this.cONSUNAMEDataGridViewTextBoxColumn.Name = "cONSUNAMEDataGridViewTextBoxColumn";
            this.cONSUNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONSUEMAILDataGridViewTextBoxColumn
            // 
            this.cONSUEMAILDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cONSUEMAILDataGridViewTextBoxColumn.DataPropertyName = "CONSU_EMAIL";
            this.cONSUEMAILDataGridViewTextBoxColumn.HeaderText = "이메일";
            this.cONSUEMAILDataGridViewTextBoxColumn.Name = "cONSUEMAILDataGridViewTextBoxColumn";
            this.cONSUEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONSUBIRTHDataGridViewTextBoxColumn
            // 
            this.cONSUBIRTHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cONSUBIRTHDataGridViewTextBoxColumn.DataPropertyName = "CONSU_BIRTH";
            this.cONSUBIRTHDataGridViewTextBoxColumn.HeaderText = "생일";
            this.cONSUBIRTHDataGridViewTextBoxColumn.Name = "cONSUBIRTHDataGridViewTextBoxColumn";
            this.cONSUBIRTHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONSUBLACKCONSUMERDataGridViewTextBoxColumn
            // 
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.DataPropertyName = "CONSU_BLACKCONSUMER";
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.FalseValue = "F";
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.HeaderText = "블랙리스트";
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.Name = "cONSUBLACKCONSUMERDataGridViewTextBoxColumn";
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.ReadOnly = true;
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.TrueValue = "T";
            // 
            // cONSUMILEAGEDataGridViewTextBoxColumn
            // 
            this.cONSUMILEAGEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cONSUMILEAGEDataGridViewTextBoxColumn.DataPropertyName = "CONSU_MILEAGE";
            this.cONSUMILEAGEDataGridViewTextBoxColumn.HeaderText = "적립금";
            this.cONSUMILEAGEDataGridViewTextBoxColumn.Name = "cONSUMILEAGEDataGridViewTextBoxColumn";
            this.cONSUMILEAGEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consumerTableAdapter1
            // 
            this.consumerTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormEmploySearchConsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelConsuSearch);
            this.Controls.Add(this.labelItemSearch);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEmploySearchConsu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVERYTHIN\'";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmploySearchConsu_FormClosing);
            this.Load += new System.EventHandler(this.FormEmploySearchConsu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelConsuSearch;
        private System.Windows.Forms.Label labelItemSearch;
        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cONSUMERBindingSource;
        private DataSet1TableAdapters.CONSUMERTableAdapter cONSUMERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUPASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUBIRTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cONSUBLACKCONSUMERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUMILEAGEDataGridViewTextBoxColumn;
        private DataSet1TableAdapters.CONSUMERTableAdapter consumerTableAdapter1;
        private DataSet1 dataSet11;
    }
}