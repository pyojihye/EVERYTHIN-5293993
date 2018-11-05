namespace EVERYTHIN_5293993
{
    partial class FormConsuMile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsuMile));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelLogout = new System.Windows.Forms.Label();
            this.labelRentalReturn = new System.Windows.Forms.Label();
            this.labelMile = new System.Windows.Forms.Label();
            this.labelMyInfo = new System.Windows.Forms.Label();
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dataSet1 = new EVERYTHIN_5293993.DataSet1();
            this.mILEAGEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mILEAGETableAdapter = new EVERYTHIN_5293993.DataSet1TableAdapters.MILEAGETableAdapter();
            this.cONSUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mILMILEAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mILDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mILEAGEBindingSource)).BeginInit();
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
            this.cONSUIDDataGridViewTextBoxColumn,
            this.mILMILEAGEDataGridViewTextBoxColumn,
            this.mILDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mILEAGEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(406, 467);
            this.dataGridView1.TabIndex = 61;
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelLogout.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelLogout.ForeColor = System.Drawing.Color.White;
            this.labelLogout.Location = new System.Drawing.Point(661, 320);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(86, 23);
            this.labelLogout.TabIndex = 57;
            this.labelLogout.Text = "로그아웃";
            this.labelLogout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLogoutMouseDown);
            this.labelLogout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelLogoutMouseUp);
            // 
            // labelRentalReturn
            // 
            this.labelRentalReturn.AutoSize = true;
            this.labelRentalReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelRentalReturn.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelRentalReturn.ForeColor = System.Drawing.Color.White;
            this.labelRentalReturn.Location = new System.Drawing.Point(631, 246);
            this.labelRentalReturn.Name = "labelRentalReturn";
            this.labelRentalReturn.Size = new System.Drawing.Size(137, 23);
            this.labelRentalReturn.TabIndex = 56;
            this.labelRentalReturn.Text = "대여/반납 현황";
            this.labelRentalReturn.Click += new System.EventHandler(this.labelRentalReturnClick);
            // 
            // labelMile
            // 
            this.labelMile.AutoSize = true;
            this.labelMile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelMile.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMile.ForeColor = System.Drawing.Color.LightGreen;
            this.labelMile.Location = new System.Drawing.Point(634, 168);
            this.labelMile.Name = "labelMile";
            this.labelMile.Size = new System.Drawing.Size(129, 23);
            this.labelMile.TabIndex = 55;
            this.labelMile.Text = "마일리지 현황";
            // 
            // labelMyInfo
            // 
            this.labelMyInfo.AutoSize = true;
            this.labelMyInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelMyInfo.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMyInfo.ForeColor = System.Drawing.Color.White;
            this.labelMyInfo.Location = new System.Drawing.Point(661, 100);
            this.labelMyInfo.Name = "labelMyInfo";
            this.labelMyInfo.Size = new System.Drawing.Size(72, 23);
            this.labelMyInfo.TabIndex = 54;
            this.labelMyInfo.Text = "내 정보";
            this.labelMyInfo.Click += new System.EventHandler(this.labelMyInfoClick);
            // 
            // labelFindID
            // 
            this.labelFindID.AutoSize = true;
            this.labelFindID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(134)))), ((int)(((byte)(153)))));
            this.labelFindID.Font = new System.Drawing.Font("나눔스퀘어", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFindID.ForeColor = System.Drawing.Color.White;
            this.labelFindID.Location = new System.Drawing.Point(11, 22);
            this.labelFindID.Name = "labelFindID";
            this.labelFindID.Size = new System.Drawing.Size(164, 26);
            this.labelFindID.TabIndex = 59;
            this.labelFindID.Text = "마이 페이지>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 68);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(615, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 516);
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(666, 423);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 72);
            this.pictureBox4.TabIndex = 63;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(463, 236);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 123);
            this.pictureBox3.TabIndex = 62;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(666, 443);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(73, 72);
            this.pictureBox5.TabIndex = 64;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mILEAGEBindingSource
            // 
            this.mILEAGEBindingSource.DataMember = "MILEAGE";
            this.mILEAGEBindingSource.DataSource = this.dataSet1;
            // 
            // mILEAGETableAdapter
            // 
            this.mILEAGETableAdapter.ClearBeforeFill = true;
            // 
            // cONSUIDDataGridViewTextBoxColumn
            // 
            this.cONSUIDDataGridViewTextBoxColumn.DataPropertyName = "CONSU_ID";
            this.cONSUIDDataGridViewTextBoxColumn.HeaderText = "CONSU_ID";
            this.cONSUIDDataGridViewTextBoxColumn.Name = "cONSUIDDataGridViewTextBoxColumn";
            this.cONSUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cONSUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // mILMILEAGEDataGridViewTextBoxColumn
            // 
            this.mILMILEAGEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mILMILEAGEDataGridViewTextBoxColumn.DataPropertyName = "MIL_MILEAGE";
            this.mILMILEAGEDataGridViewTextBoxColumn.HeaderText = "적립금";
            this.mILMILEAGEDataGridViewTextBoxColumn.Name = "mILMILEAGEDataGridViewTextBoxColumn";
            this.mILMILEAGEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mILDATEDataGridViewTextBoxColumn
            // 
            this.mILDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mILDATEDataGridViewTextBoxColumn.DataPropertyName = "MIL_DATE";
            this.mILDATEDataGridViewTextBoxColumn.HeaderText = "적립일";
            this.mILDATEDataGridViewTextBoxColumn.Name = "mILDATEDataGridViewTextBoxColumn";
            this.mILDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormConsuMile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelLogout);
            this.Controls.Add(this.labelRentalReturn);
            this.Controls.Add(this.labelMile);
            this.Controls.Add(this.labelMyInfo);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormConsuMile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVERYTHIN\'";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConsuMile_FormClosing);
            this.Load += new System.EventHandler(this.FormConsuMile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mILEAGEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.Label labelRentalReturn;
        private System.Windows.Forms.Label labelMile;
        private System.Windows.Forms.Label labelMyInfo;
        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mILEAGEBindingSource;
        private DataSet1TableAdapters.MILEAGETableAdapter mILEAGETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mILMILEAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mILDATEDataGridViewTextBoxColumn;
    }
}