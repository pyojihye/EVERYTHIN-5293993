﻿namespace EVERYTHIN_5293993
{
    partial class FormEmployItemInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployItemInfo));
            this.buttonReservation = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDescription = new System.Windows.Forms.ComboBox();
            this.comboBoxCate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.textBoxLoc = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxMileage = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxItemID = new System.Windows.Forms.TextBox();
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.itemstockdescriptionTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.ITEMSTOCKDESCRIPTIONTableAdapter();
            this.dataSet11 = new EVERYTHIN_5293993.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReservation
            // 
            this.buttonReservation.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonReservation.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonReservation.ForeColor = System.Drawing.Color.White;
            this.buttonReservation.Location = new System.Drawing.Point(146, 502);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(179, 41);
            this.buttonReservation.TabIndex = 86;
            this.buttonReservation.Text = "확   인";
            this.buttonReservation.UseVisualStyleBackColor = false;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(27, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(434, 73);
            this.listBox1.TabIndex = 85;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 293);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(354, 31);
            this.dateTimePicker1.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 84;
            this.label8.Text = "구입일 :";
            // 
            // comboBoxDescription
            // 
            this.comboBoxDescription.Enabled = false;
            this.comboBoxDescription.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBoxDescription.FormattingEnabled = true;
            this.comboBoxDescription.Location = new System.Drawing.Point(330, 191);
            this.comboBoxDescription.Name = "comboBoxDescription";
            this.comboBoxDescription.Size = new System.Drawing.Size(129, 31);
            this.comboBoxDescription.TabIndex = 66;
            // 
            // comboBoxCate
            // 
            this.comboBoxCate.Enabled = false;
            this.comboBoxCate.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBoxCate.FormattingEnabled = true;
            this.comboBoxCate.Location = new System.Drawing.Point(107, 191);
            this.comboBoxCate.Name = "comboBoxCate";
            this.comboBoxCate.Size = new System.Drawing.Size(129, 31);
            this.comboBoxCate.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(245, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 82;
            this.label7.Text = "상    태 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 81;
            this.label6.Text = "위    치 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 80;
            this.label5.Text = "재    고 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(246, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 79;
            this.label4.Text = "적립금 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 78;
            this.label3.Text = "가    격 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(246, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 23);
            this.label9.TabIndex = 83;
            this.label9.Text = "설    명 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 76;
            this.label2.Text = "물건명 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 77;
            this.label1.Text = "분류명 :";
            // 
            // textBoxState
            // 
            this.textBoxState.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxState.Location = new System.Drawing.Point(330, 400);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.ReadOnly = true;
            this.textBoxState.Size = new System.Drawing.Size(129, 31);
            this.textBoxState.TabIndex = 72;
            // 
            // textBoxLoc
            // 
            this.textBoxLoc.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxLoc.Location = new System.Drawing.Point(107, 452);
            this.textBoxLoc.Name = "textBoxLoc";
            this.textBoxLoc.ReadOnly = true;
            this.textBoxLoc.Size = new System.Drawing.Size(352, 31);
            this.textBoxLoc.TabIndex = 73;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxStock.Location = new System.Drawing.Point(107, 400);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.ReadOnly = true;
            this.textBoxStock.Size = new System.Drawing.Size(129, 31);
            this.textBoxStock.TabIndex = 71;
            // 
            // textBoxMileage
            // 
            this.textBoxMileage.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxMileage.Location = new System.Drawing.Point(331, 345);
            this.textBoxMileage.Name = "textBoxMileage";
            this.textBoxMileage.ReadOnly = true;
            this.textBoxMileage.Size = new System.Drawing.Size(129, 31);
            this.textBoxMileage.TabIndex = 70;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxPrice.Location = new System.Drawing.Point(107, 342);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(129, 31);
            this.textBoxPrice.TabIndex = 69;
            // 
            // textBoxItemID
            // 
            this.textBoxItemID.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxItemID.Location = new System.Drawing.Point(107, 240);
            this.textBoxItemID.Name = "textBoxItemID";
            this.textBoxItemID.ReadOnly = true;
            this.textBoxItemID.Size = new System.Drawing.Size(354, 31);
            this.textBoxItemID.TabIndex = 67;
            // 
            // labelFindID
            // 
            this.labelFindID.AutoSize = true;
            this.labelFindID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(134)))), ((int)(((byte)(153)))));
            this.labelFindID.Font = new System.Drawing.Font("나눔스퀘어", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFindID.ForeColor = System.Drawing.Color.White;
            this.labelFindID.Location = new System.Drawing.Point(12, 11);
            this.labelFindID.Name = "labelFindID";
            this.labelFindID.Size = new System.Drawing.Size(141, 26);
            this.labelFindID.TabIndex = 75;
            this.labelFindID.Text = "상세 정보>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 50);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // itemstockdescriptionTableAdapter1
            // 
            this.itemstockdescriptionTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormEmployItemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(490, 556);
            this.Controls.Add(this.buttonReservation);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxDescription);
            this.Controls.Add(this.comboBoxCate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.textBoxLoc);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxMileage);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxItemID);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEmployItemInfo";
            this.Text = "EVERYTHIN\'";
            this.Load += new System.EventHandler(this.FormEmployItemInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxCate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.TextBox textBoxLoc;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxMileage;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxItemID;
        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DataSet1TableAdapters.ITEMSTOCKDESCRIPTIONTableAdapter itemstockdescriptionTableAdapter1;
        private DataSet1 dataSet11;
    }
}