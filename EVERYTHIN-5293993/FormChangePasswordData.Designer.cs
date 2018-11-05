namespace EVERYTHIN_5293993
{
    partial class FormChangePasswordData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePasswordData));
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxChangePasswd = new System.Windows.Forms.TextBox();
            this.dataSet11 = new EVERYTHIN_5293993.DataSet1();
            this.consumerTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.CONSUMERTableAdapter();
            this.employeeTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.EMPLOYEETableAdapter();
            this.administerTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.ADMINISTERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFindID
            // 
            this.labelFindID.AutoSize = true;
            this.labelFindID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(134)))), ((int)(((byte)(153)))));
            this.labelFindID.Font = new System.Drawing.Font("나눔스퀘어", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFindID.ForeColor = System.Drawing.Color.White;
            this.labelFindID.Location = new System.Drawing.Point(12, 9);
            this.labelFindID.Name = "labelFindID";
            this.labelFindID.Size = new System.Drawing.Size(210, 26);
            this.labelFindID.TabIndex = 37;
            this.labelFindID.Text = "비밀번호 바꾸기>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 50);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonChange.Font = new System.Drawing.Font("나눔스퀘어", 15.75F);
            this.buttonChange.ForeColor = System.Drawing.Color.White;
            this.buttonChange.Location = new System.Drawing.Point(143, 151);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(114, 42);
            this.buttonChange.TabIndex = 35;
            this.buttonChange.Tag = "2";
            this.buttonChange.Text = "변경";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChangeClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "변경 될 비밀번호 :";
            // 
            // textBoxChangePasswd
            // 
            this.textBoxChangePasswd.Font = new System.Drawing.Font("나눔스퀘어", 15.75F);
            this.textBoxChangePasswd.Location = new System.Drawing.Point(183, 93);
            this.textBoxChangePasswd.Name = "textBoxChangePasswd";
            this.textBoxChangePasswd.Size = new System.Drawing.Size(205, 31);
            this.textBoxChangePasswd.TabIndex = 33;
            this.textBoxChangePasswd.Tag = "1";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consumerTableAdapter1
            // 
            this.consumerTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // administerTableAdapter1
            // 
            this.administerTableAdapter1.ClearBeforeFill = true;
            // 
            // FormChangePasswordData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(400, 206);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxChangePasswd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormChangePasswordData";
            this.Text = "EVERYTHIN\'";
            this.Load += new System.EventHandler(this.FormChangePasswordData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxChangePasswd;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.CONSUMERTableAdapter consumerTableAdapter1;
        private DataSet1TableAdapters.EMPLOYEETableAdapter employeeTableAdapter1;
        private DataSet1TableAdapters.ADMINISTERTableAdapter administerTableAdapter1;
    }
}