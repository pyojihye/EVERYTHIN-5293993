namespace EVERYTHIN_5293993
{
    partial class FormSignUpAnother
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUpAnother));
            Oracle.DataAccess.Client.OracleParameter oracleParameter1 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter2 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter3 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter4 = new Oracle.DataAccess.Client.OracleParameter();
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonDoubleCheck = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.oracleCommand1 = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelPasswd = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.dataSet11 = new EVERYTHIN_5293993.DataSet1();
            this.administerTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.ADMINISTERTableAdapter();
            this.employeeTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.EMPLOYEETableAdapter();
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
            this.labelFindID.Location = new System.Drawing.Point(12, 15);
            this.labelFindID.Name = "labelFindID";
            this.labelFindID.Size = new System.Drawing.Size(141, 26);
            this.labelFindID.TabIndex = 60;
            this.labelFindID.Text = "회원 가입>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 50);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonConfirm.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.Location = new System.Drawing.Point(175, 294);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(119, 51);
            this.buttonConfirm.TabIndex = 54;
            this.buttonConfirm.Tag = "6";
            this.buttonConfirm.Text = "확인";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.UseWaitCursor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirmClicked);
            // 
            // buttonDoubleCheck
            // 
            this.buttonDoubleCheck.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonDoubleCheck.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonDoubleCheck.ForeColor = System.Drawing.Color.White;
            this.buttonDoubleCheck.Location = new System.Drawing.Point(320, 73);
            this.buttonDoubleCheck.Name = "buttonDoubleCheck";
            this.buttonDoubleCheck.Size = new System.Drawing.Size(106, 37);
            this.buttonDoubleCheck.TabIndex = 50;
            this.buttonDoubleCheck.Tag = "2";
            this.buttonDoubleCheck.Text = "중복 확인";
            this.buttonDoubleCheck.UseVisualStyleBackColor = false;
            this.buttonDoubleCheck.Click += new System.EventHandler(this.buttonDoubleCheckClicked);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxEmail.Location = new System.Drawing.Point(111, 233);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(203, 31);
            this.textBoxEmail.TabIndex = 53;
            this.textBoxEmail.Tag = "5";
            this.textBoxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEmail_KeyDown);
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            oracleParameter1.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter1.ParameterName = "id";
            oracleParameter2.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter2.ParameterName = "password";
            oracleParameter3.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter3.ParameterName = "name";
            oracleParameter4.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter4.ParameterName = "email";
            this.oracleCommand1.Parameters.Add(oracleParameter1);
            this.oracleCommand1.Parameters.Add(oracleParameter2);
            this.oracleCommand1.Parameters.Add(oracleParameter3);
            this.oracleCommand1.Parameters.Add(oracleParameter4);
            this.oracleCommand1.Transaction = null;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=ORAORA;USER ID=B5293993;PASSWORD=B5293993;";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxName.Location = new System.Drawing.Point(111, 177);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(203, 31);
            this.textBoxName.TabIndex = 52;
            this.textBoxName.Tag = "4";
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxPasswd.Location = new System.Drawing.Point(111, 126);
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.Size = new System.Drawing.Size(203, 31);
            this.textBoxPasswd.TabIndex = 51;
            this.textBoxPasswd.Tag = "3";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(16, 236);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(88, 23);
            this.labelEmail.TabIndex = 56;
            this.labelEmail.Text = "이 메 일 :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(16, 180);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 23);
            this.labelName.TabIndex = 57;
            this.labelName.Text = "이      름 :";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxID.Location = new System.Drawing.Point(111, 77);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(203, 31);
            this.textBoxID.TabIndex = 49;
            this.textBoxID.Tag = "1";
            // 
            // labelPasswd
            // 
            this.labelPasswd.AutoSize = true;
            this.labelPasswd.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPasswd.ForeColor = System.Drawing.Color.White;
            this.labelPasswd.Location = new System.Drawing.Point(15, 129);
            this.labelPasswd.Name = "labelPasswd";
            this.labelPasswd.Size = new System.Drawing.Size(97, 23);
            this.labelPasswd.TabIndex = 58;
            this.labelPasswd.Text = "비밀번호 :";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(16, 80);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(88, 23);
            this.labelID.TabIndex = 55;
            this.labelID.Text = "아 이 디 :";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // administerTableAdapter1
            // 
            this.administerTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // FormSignUpAnother
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(440, 362);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonDoubleCheck);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPasswd);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelPasswd);
            this.Controls.Add(this.labelID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSignUpAnother";
            this.Text = "EVERYTHIN\'";
            this.Load += new System.EventHandler(this.FormSignUpAnother_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonDoubleCheck;
        private System.Windows.Forms.TextBox textBoxEmail;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand1;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPasswd;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        internal System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelPasswd;
        private System.Windows.Forms.Label labelID;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.ADMINISTERTableAdapter administerTableAdapter1;
        private DataSet1TableAdapters.EMPLOYEETableAdapter employeeTableAdapter1;
    }
}