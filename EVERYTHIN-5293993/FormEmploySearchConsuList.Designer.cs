namespace EVERYTHIN_5293993
{
    partial class FormEmploySearchConsuList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmploySearchConsuList));
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new EVERYTHIN_5293993.DataSet1();
            this.cONSUMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONSUMERTableAdapter = new EVERYTHIN_5293993.DataSet1TableAdapters.CONSUMERTableAdapter();
            this.cONSUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUBIRTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cONSUMILEAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxSearch.Location = new System.Drawing.Point(12, 74);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(275, 31);
            this.textBoxSearch.TabIndex = 51;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonConfirm.Enabled = false;
            this.buttonConfirm.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.Location = new System.Drawing.Point(160, 282);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(98, 51);
            this.buttonConfirm.TabIndex = 49;
            this.buttonConfirm.Text = "선 택";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirmClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(293, 63);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(98, 51);
            this.buttonSearch.TabIndex = 50;
            this.buttonSearch.Text = "검 색";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearchClick);
            // 
            // labelFindID
            // 
            this.labelFindID.AutoSize = true;
            this.labelFindID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(134)))), ((int)(((byte)(153)))));
            this.labelFindID.Font = new System.Drawing.Font("나눔스퀘어", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFindID.ForeColor = System.Drawing.Color.White;
            this.labelFindID.Location = new System.Drawing.Point(12, 13);
            this.labelFindID.Name = "labelFindID";
            this.labelFindID.Size = new System.Drawing.Size(164, 26);
            this.labelFindID.TabIndex = 48;
            this.labelFindID.Text = "회원 리스트>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 50);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(379, 150);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONSUMERBindingSource
            // 
            this.cONSUMERBindingSource.DataMember = "CONSUMER";
            this.cONSUMERBindingSource.DataSource = this.dataSet1;
            // 
            // cONSUMERTableAdapter
            // 
            this.cONSUMERTableAdapter.ClearBeforeFill = true;
            // 
            // cONSUIDDataGridViewTextBoxColumn
            // 
            this.cONSUIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cONSUIDDataGridViewTextBoxColumn.DataPropertyName = "CONSU_ID";
            this.cONSUIDDataGridViewTextBoxColumn.HeaderText = "회원ID";
            this.cONSUIDDataGridViewTextBoxColumn.Name = "cONSUIDDataGridViewTextBoxColumn";
            // 
            // cONSUPASSWORDDataGridViewTextBoxColumn
            // 
            this.cONSUPASSWORDDataGridViewTextBoxColumn.DataPropertyName = "CONSU_PASSWORD";
            this.cONSUPASSWORDDataGridViewTextBoxColumn.HeaderText = "CONSU_PASSWORD";
            this.cONSUPASSWORDDataGridViewTextBoxColumn.Name = "cONSUPASSWORDDataGridViewTextBoxColumn";
            this.cONSUPASSWORDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cONSUNAMEDataGridViewTextBoxColumn
            // 
            this.cONSUNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cONSUNAMEDataGridViewTextBoxColumn.DataPropertyName = "CONSU_NAME";
            this.cONSUNAMEDataGridViewTextBoxColumn.HeaderText = "회원명";
            this.cONSUNAMEDataGridViewTextBoxColumn.Name = "cONSUNAMEDataGridViewTextBoxColumn";
            // 
            // cONSUEMAILDataGridViewTextBoxColumn
            // 
            this.cONSUEMAILDataGridViewTextBoxColumn.DataPropertyName = "CONSU_EMAIL";
            this.cONSUEMAILDataGridViewTextBoxColumn.HeaderText = "CONSU_EMAIL";
            this.cONSUEMAILDataGridViewTextBoxColumn.Name = "cONSUEMAILDataGridViewTextBoxColumn";
            this.cONSUEMAILDataGridViewTextBoxColumn.Visible = false;
            // 
            // cONSUBIRTHDataGridViewTextBoxColumn
            // 
            this.cONSUBIRTHDataGridViewTextBoxColumn.DataPropertyName = "CONSU_BIRTH";
            this.cONSUBIRTHDataGridViewTextBoxColumn.HeaderText = "CONSU_BIRTH";
            this.cONSUBIRTHDataGridViewTextBoxColumn.Name = "cONSUBIRTHDataGridViewTextBoxColumn";
            this.cONSUBIRTHDataGridViewTextBoxColumn.Visible = false;
            // 
            // cONSUBLACKCONSUMERDataGridViewTextBoxColumn
            // 
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.DataPropertyName = "CONSU_BLACKCONSUMER";
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.FalseValue = "F";
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.HeaderText = "블랙리스트";
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.Name = "cONSUBLACKCONSUMERDataGridViewTextBoxColumn";
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cONSUBLACKCONSUMERDataGridViewTextBoxColumn.TrueValue = "T";
            // 
            // cONSUMILEAGEDataGridViewTextBoxColumn
            // 
            this.cONSUMILEAGEDataGridViewTextBoxColumn.DataPropertyName = "CONSU_MILEAGE";
            this.cONSUMILEAGEDataGridViewTextBoxColumn.HeaderText = "CONSU_MILEAGE";
            this.cONSUMILEAGEDataGridViewTextBoxColumn.Name = "cONSUMILEAGEDataGridViewTextBoxColumn";
            this.cONSUMILEAGEDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormEmploySearchConsuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(403, 342);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEmploySearchConsuList";
            this.Text = "EVERYTHIN\'";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmploySearchConsuList_FormClosing);
            this.Load += new System.EventHandler(this.FormEmploySearchConsuList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}