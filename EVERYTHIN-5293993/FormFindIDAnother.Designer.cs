namespace EVERYTHIN_5293993
{
    partial class FormFindIDAnother
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindIDAnother));
            this.labelFindID = new System.Windows.Forms.Label();
            this.buttonIDConfirm = new System.Windows.Forms.Button();
            this.labelIDBirth = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxFindIdName = new System.Windows.Forms.TextBox();
            this.labelIdName = new System.Windows.Forms.Label();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.oracleCommand1 = new Oracle.DataAccess.Client.OracleCommand();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFindID
            // 
            this.labelFindID.AutoSize = true;
            this.labelFindID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(134)))), ((int)(((byte)(153)))));
            this.labelFindID.Font = new System.Drawing.Font("나눔스퀘어", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFindID.ForeColor = System.Drawing.Color.White;
            this.labelFindID.Location = new System.Drawing.Point(10, 13);
            this.labelFindID.Name = "labelFindID";
            this.labelFindID.Size = new System.Drawing.Size(164, 26);
            this.labelFindID.TabIndex = 41;
            this.labelFindID.Text = "아이디 찾기>>";
            // 
            // buttonIDConfirm
            // 
            this.buttonIDConfirm.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonIDConfirm.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonIDConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonIDConfirm.Location = new System.Drawing.Point(160, 183);
            this.buttonIDConfirm.Name = "buttonIDConfirm";
            this.buttonIDConfirm.Size = new System.Drawing.Size(137, 52);
            this.buttonIDConfirm.TabIndex = 37;
            this.buttonIDConfirm.Tag = "3";
            this.buttonIDConfirm.Text = "확인";
            this.buttonIDConfirm.UseVisualStyleBackColor = false;
            this.buttonIDConfirm.Click += new System.EventHandler(this.buttonConfirmClick);
            // 
            // labelIDBirth
            // 
            this.labelIDBirth.AutoSize = true;
            this.labelIDBirth.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelIDBirth.ForeColor = System.Drawing.Color.White;
            this.labelIDBirth.Location = new System.Drawing.Point(20, 126);
            this.labelIDBirth.Name = "labelIDBirth";
            this.labelIDBirth.Size = new System.Drawing.Size(88, 23);
            this.labelIDBirth.TabIndex = 39;
            this.labelIDBirth.Text = "이 메 일 :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmail.Location = new System.Drawing.Point(124, 123);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(285, 31);
            this.textBoxEmail.TabIndex = 36;
            this.textBoxEmail.Tag = "2";
            // 
            // textBoxFindIdName
            // 
            this.textBoxFindIdName.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxFindIdName.ForeColor = System.Drawing.Color.Black;
            this.textBoxFindIdName.Location = new System.Drawing.Point(123, 76);
            this.textBoxFindIdName.Name = "textBoxFindIdName";
            this.textBoxFindIdName.Size = new System.Drawing.Size(285, 31);
            this.textBoxFindIdName.TabIndex = 35;
            this.textBoxFindIdName.Tag = "1";
            // 
            // labelIdName
            // 
            this.labelIdName.AutoSize = true;
            this.labelIdName.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelIdName.ForeColor = System.Drawing.Color.White;
            this.labelIdName.Location = new System.Drawing.Point(20, 79);
            this.labelIdName.Name = "labelIdName";
            this.labelIdName.Size = new System.Drawing.Size(94, 23);
            this.labelIdName.TabIndex = 38;
            this.labelIdName.Text = "이      름 : ";
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=ORAORA;USER ID=B5293993;PASSWORD=B5293993;";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            this.oracleCommand1.Transaction = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 50);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // FormFindIDAnother
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(423, 268);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.buttonIDConfirm);
            this.Controls.Add(this.labelIDBirth);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxFindIdName);
            this.Controls.Add(this.labelIdName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormFindIDAnother";
            this.Text = "EVERYTHIN\'";
            this.Load += new System.EventHandler(this.FormFindIDAnother_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.Button buttonIDConfirm;
        private System.Windows.Forms.Label labelIDBirth;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxFindIdName;
        private System.Windows.Forms.Label labelIdName;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}