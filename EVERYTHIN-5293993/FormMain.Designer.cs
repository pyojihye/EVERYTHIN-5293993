namespace EVERYTHIN_5293993
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkLabelIDPasswd = new System.Windows.Forms.LinkLabel();
            this.mainpasswd = new System.Windows.Forms.Label();
            this.mainID = new System.Windows.Forms.Label();
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataSet11 = new EVERYTHIN_5293993.DataSet1();
            this.consumerTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.CONSUMERTableAdapter();
            this.administerTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.ADMINISTERTableAdapter();
            this.employeeTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.EMPLOYEETableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Neou", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(233, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 76);
            this.label1.TabIndex = 10;
            this.label1.Text = "Everythin\'";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(186)))), ((int)(((byte)(99)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(103)))), ((int)(((byte)(94)))));
            this.linkLabel1.Location = new System.Drawing.Point(233, 110);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 21);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "5";
            this.linkLabel1.Text = "회원가입";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(176)))), ((int)(((byte)(133)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpClicked);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(253, 23);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 68);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Tag = "3";
            this.buttonLogin.Text = "로그인";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLoginClicked);
            // 
            // linkLabelIDPasswd
            // 
            this.linkLabelIDPasswd.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(186)))), ((int)(((byte)(99)))));
            this.linkLabelIDPasswd.AutoSize = true;
            this.linkLabelIDPasswd.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(103)))), ((int)(((byte)(94)))));
            this.linkLabelIDPasswd.Location = new System.Drawing.Point(27, 110);
            this.linkLabelIDPasswd.Name = "linkLabelIDPasswd";
            this.linkLabelIDPasswd.Size = new System.Drawing.Size(175, 21);
            this.linkLabelIDPasswd.TabIndex = 3;
            this.linkLabelIDPasswd.TabStop = true;
            this.linkLabelIDPasswd.Tag = "4";
            this.linkLabelIDPasswd.Text = "아이디/비밀번호 찾기";
            this.linkLabelIDPasswd.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(176)))), ((int)(((byte)(133)))));
            this.linkLabelIDPasswd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FindIdPasswdClicked);
            // 
            // mainpasswd
            // 
            this.mainpasswd.AutoSize = true;
            this.mainpasswd.Location = new System.Drawing.Point(14, 65);
            this.mainpasswd.Name = "mainpasswd";
            this.mainpasswd.Size = new System.Drawing.Size(89, 21);
            this.mainpasswd.TabIndex = 3;
            this.mainpasswd.Text = "비밀번호 :";
            // 
            // mainID
            // 
            this.mainID.AutoSize = true;
            this.mainID.Location = new System.Drawing.Point(14, 26);
            this.mainID.Name = "mainID";
            this.mainID.Size = new System.Drawing.Size(82, 21);
            this.mainID.TabIndex = 2;
            this.mainID.Text = "아 이 디 :";
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.Location = new System.Drawing.Point(109, 62);
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.PasswordChar = '*';
            this.textBoxPasswd.Size = new System.Drawing.Size(138, 29);
            this.textBoxPasswd.TabIndex = 1;
            this.textBoxPasswd.Tag = "2";
            this.textBoxPasswd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPasswd_KeyDown);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(109, 23);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(138, 29);
            this.textBoxID.TabIndex = 0;
            this.textBoxID.Tag = "1";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.BackColor = System.Drawing.Color.LightSlateGray;
            this.labelMode.Font = new System.Drawing.Font("나눔스퀘어", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMode.ForeColor = System.Drawing.Color.White;
            this.labelMode.Location = new System.Drawing.Point(135, 364);
            this.labelMode.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.labelMode.Name = "labelMode";
            this.labelMode.Padding = new System.Windows.Forms.Padding(20);
            this.labelMode.Size = new System.Drawing.Size(113, 75);
            this.labelMode.TabIndex = 12;
            this.labelMode.Text = "고객";
            this.labelMode.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Controls.Add(this.linkLabelIDPasswd);
            this.groupBox1.Controls.Add(this.mainpasswd);
            this.groupBox1.Controls.Add(this.mainID);
            this.groupBox1.Controls.Add(this.textBoxPasswd);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Font = new System.Drawing.Font("나눔스퀘어", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(338, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 145);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "로그인";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 126);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.DoubleClickLogo);
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
            // administerTableAdapter1
            // 
            this.administerTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVERYTHIN\'";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel linkLabelIDPasswd;
        private System.Windows.Forms.Label mainpasswd;
        private System.Windows.Forms.Label mainID;
        private System.Windows.Forms.TextBox textBoxPasswd;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.CONSUMERTableAdapter consumerTableAdapter1;
        private DataSet1TableAdapters.ADMINISTERTableAdapter administerTableAdapter1;
        private DataSet1TableAdapters.EMPLOYEETableAdapter employeeTableAdapter1;
    }
}