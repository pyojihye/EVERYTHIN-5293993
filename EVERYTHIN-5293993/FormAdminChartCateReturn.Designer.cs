﻿namespace EVERYTHIN_5293993
{
    partial class FormAdminChartCateReturn
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminChartCateReturn));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelCateSearch = new System.Windows.Forms.Label();
            this.labelTotalSearch = new System.Windows.Forms.Label();
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.oracleCommand1 = new Oracle.DataAccess.Client.OracleCommand();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet11 = new EVERYTHIN_5293993.DataSet1();
            this.categoryTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.CATEGORYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(16, 85);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series7.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series7.IsValueShownAsLabel = true;
            series7.Label = "#VALX\\n#PERCENT";
            series7.Legend = "Legend1";
            series7.LegendText = "#VALX";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(583, 464);
            this.chart1.TabIndex = 121;
            this.chart1.Text = "chart1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(672, 443);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 72);
            this.pictureBox3.TabIndex = 120;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // labelCateSearch
            // 
            this.labelCateSearch.AutoSize = true;
            this.labelCateSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelCateSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCateSearch.ForeColor = System.Drawing.Color.White;
            this.labelCateSearch.Location = new System.Drawing.Point(651, 169);
            this.labelCateSearch.Name = "labelCateSearch";
            this.labelCateSearch.Size = new System.Drawing.Size(110, 23);
            this.labelCateSearch.TabIndex = 117;
            this.labelCateSearch.Text = "분야별 대여";
            this.labelCateSearch.Click += new System.EventHandler(this.labelCateSearch_Click);
            // 
            // labelTotalSearch
            // 
            this.labelTotalSearch.AutoSize = true;
            this.labelTotalSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.labelTotalSearch.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTotalSearch.ForeColor = System.Drawing.Color.White;
            this.labelTotalSearch.Location = new System.Drawing.Point(651, 102);
            this.labelTotalSearch.Name = "labelTotalSearch";
            this.labelTotalSearch.Size = new System.Drawing.Size(110, 23);
            this.labelTotalSearch.TabIndex = 116;
            this.labelTotalSearch.Text = "요일별 대여";
            this.labelTotalSearch.Click += new System.EventHandler(this.labelTotalSearch_Click);
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
            this.labelFindID.TabIndex = 118;
            this.labelFindID.Text = "통계>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 68);
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(615, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 516);
            this.pictureBox2.TabIndex = 119;
            this.pictureBox2.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.label2.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(651, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 123;
            this.label2.Text = "분야별 반납";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.label1.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(651, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 122;
            this.label1.Text = "요일별 반납";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // FormAdminChartCateReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelCateSearch);
            this.Controls.Add(this.labelTotalSearch);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormAdminChartCateReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVERYTHIN\'";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminChartCateReturn_FormClosing);
            this.Load += new System.EventHandler(this.FormAdminChartCateReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelCateSearch;
        private System.Windows.Forms.Label labelTotalSearch;
        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.CATEGORYTableAdapter categoryTableAdapter1;
    }
}