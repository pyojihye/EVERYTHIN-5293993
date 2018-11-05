namespace EVERYTHIN_5293993
{
    partial class FormChangePasswordAnother
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePasswordAnother));
            this.buttonPasswdConfirm = new System.Windows.Forms.Button();
            this.labelPasswdID = new System.Windows.Forms.Label();
            this.textBoxPasswdName = new System.Windows.Forms.TextBox();
            this.textBoxPasswdID = new System.Windows.Forms.TextBox();
            this.labelPasswdName = new System.Windows.Forms.Label();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.oracleCommand1 = new Oracle.DataAccess.Client.OracleCommand();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFindID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPasswdConfirm
            // 
            this.buttonPasswdConfirm.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonPasswdConfirm.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonPasswdConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonPasswdConfirm.Location = new System.Drawing.Point(108, 180);
            this.buttonPasswdConfirm.Name = "buttonPasswdConfirm";
            this.buttonPasswdConfirm.Size = new System.Drawing.Size(113, 51);
            this.buttonPasswdConfirm.TabIndex = 46;
            this.buttonPasswdConfirm.Tag = "3";
            this.buttonPasswdConfirm.Text = "확인";
            this.buttonPasswdConfirm.UseVisualStyleBackColor = false;
            this.buttonPasswdConfirm.Click += new System.EventHandler(this.buttonConfirmClick);
            // 
            // labelPasswdID
            // 
            this.labelPasswdID.AutoSize = true;
            this.labelPasswdID.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPasswdID.ForeColor = System.Drawing.Color.White;
            this.labelPasswdID.Location = new System.Drawing.Point(23, 77);
            this.labelPasswdID.Name = "labelPasswdID";
            this.labelPasswdID.Size = new System.Drawing.Size(88, 23);
            this.labelPasswdID.TabIndex = 45;
            this.labelPasswdID.Text = "아 이 디 :";
            // 
            // textBoxPasswdName
            // 
            this.textBoxPasswdName.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxPasswdName.Location = new System.Drawing.Point(125, 121);
            this.textBoxPasswdName.Name = "textBoxPasswdName";
            this.textBoxPasswdName.Size = new System.Drawing.Size(169, 31);
            this.textBoxPasswdName.TabIndex = 44;
            this.textBoxPasswdName.Tag = "2";
            // 
            // textBoxPasswdID
            // 
            this.textBoxPasswdID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPasswdID.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxPasswdID.Location = new System.Drawing.Point(125, 74);
            this.textBoxPasswdID.Name = "textBoxPasswdID";
            this.textBoxPasswdID.Size = new System.Drawing.Size(169, 31);
            this.textBoxPasswdID.TabIndex = 43;
            this.textBoxPasswdID.Tag = "1";
            // 
            // labelPasswdName
            // 
            this.labelPasswdName.AutoSize = true;
            this.labelPasswdName.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPasswdName.ForeColor = System.Drawing.Color.White;
            this.labelPasswdName.Location = new System.Drawing.Point(23, 124);
            this.labelPasswdName.Name = "labelPasswdName";
            this.labelPasswdName.Size = new System.Drawing.Size(94, 23);
            this.labelPasswdName.TabIndex = 42;
            this.labelPasswdName.Text = "이      름 : ";
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=ORAORA;PERSIST SECURITY INFO=True;USER ID=B5293993;PASSWORD=B5293993;" +
    "";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            this.oracleCommand1.Transaction = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 50);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // labelFindID
            // 
            this.labelFindID.AutoSize = true;
            this.labelFindID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(134)))), ((int)(((byte)(153)))));
            this.labelFindID.Font = new System.Drawing.Font("나눔스퀘어", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFindID.ForeColor = System.Drawing.Color.White;
            this.labelFindID.Location = new System.Drawing.Point(11, 13);
            this.labelFindID.Name = "labelFindID";
            this.labelFindID.Size = new System.Drawing.Size(210, 26);
            this.labelFindID.TabIndex = 48;
            this.labelFindID.Text = "비밀번호 바꾸기>>";
            // 
            // FormChangePasswordAnother
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(325, 247);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPasswdConfirm);
            this.Controls.Add(this.labelPasswdID);
            this.Controls.Add(this.textBoxPasswdName);
            this.Controls.Add(this.textBoxPasswdID);
            this.Controls.Add(this.labelPasswdName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormChangePasswordAnother";
            this.Text = "EVERYTHIN\'";
            this.Load += new System.EventHandler(this.FormChangePasswordAnother_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPasswdConfirm;
        private System.Windows.Forms.Label labelPasswdID;
        private System.Windows.Forms.TextBox textBoxPasswdName;
        private System.Windows.Forms.TextBox textBoxPasswdID;
        private System.Windows.Forms.Label labelPasswdName;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFindID;
    }
}