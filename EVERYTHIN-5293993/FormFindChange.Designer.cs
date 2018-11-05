namespace EVERYTHIN_5293993
{
    partial class FormFindChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindChange));
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonChangePasswd = new System.Windows.Forms.Button();
            this.buttonFindID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFindID
            // 
            this.labelFindID.AutoSize = true;
            this.labelFindID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(134)))), ((int)(((byte)(153)))));
            this.labelFindID.Font = new System.Drawing.Font("나눔스퀘어", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFindID.ForeColor = System.Drawing.Color.White;
            this.labelFindID.Location = new System.Drawing.Point(12, 13);
            this.labelFindID.Name = "labelFindID";
            this.labelFindID.Size = new System.Drawing.Size(356, 26);
            this.labelFindID.TabIndex = 30;
            this.labelFindID.Text = "아이디 찾기 / 비밀번호 바꾸기>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 50);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // buttonChangePasswd
            // 
            this.buttonChangePasswd.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonChangePasswd.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonChangePasswd.ForeColor = System.Drawing.Color.White;
            this.buttonChangePasswd.Location = new System.Drawing.Point(233, 62);
            this.buttonChangePasswd.Name = "buttonChangePasswd";
            this.buttonChangePasswd.Size = new System.Drawing.Size(190, 185);
            this.buttonChangePasswd.TabIndex = 27;
            this.buttonChangePasswd.Tag = "2";
            this.buttonChangePasswd.Text = "비밀번호\r\n\r\n바꾸기";
            this.buttonChangePasswd.UseVisualStyleBackColor = false;
            this.buttonChangePasswd.Click += new System.EventHandler(this.FindPasswdClicked);
            // 
            // buttonFindID
            // 
            this.buttonFindID.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonFindID.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonFindID.ForeColor = System.Drawing.Color.White;
            this.buttonFindID.Location = new System.Drawing.Point(17, 62);
            this.buttonFindID.Name = "buttonFindID";
            this.buttonFindID.Size = new System.Drawing.Size(190, 185);
            this.buttonFindID.TabIndex = 28;
            this.buttonFindID.Tag = "1";
            this.buttonFindID.Text = "아이디\r\n\r\n찾기";
            this.buttonFindID.UseVisualStyleBackColor = false;
            this.buttonFindID.Click += new System.EventHandler(this.FindIDClicked);
            // 
            // FormFindChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(435, 261);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonChangePasswd);
            this.Controls.Add(this.buttonFindID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormFindChange";
            this.Text = "EVERYTHIN\'";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonChangePasswd;
        private System.Windows.Forms.Button buttonFindID;
    }
}