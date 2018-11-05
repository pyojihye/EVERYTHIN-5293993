namespace EVERYTHIN_5293993
{
    partial class FormEmployReturnMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployReturnMoney));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonMile = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxWanttMoney = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxMile = new System.Windows.Forms.TextBox();
            this.textBoxFine = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.oracleCommand1 = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBox5Ten = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5H = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5T = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5M = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFindID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataSet11 = new EVERYTHIN_5293993.DataSet1();
            this.consumerTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.CONSUMERTableAdapter();
            this.stockTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.STOCKTableAdapter();
            this.consumerrentalTableAdapter1 = new EVERYTHIN_5293993.DataSet1TableAdapters.CONSUMERRENTALTableAdapter();
            this.oracleCommand2 = new Oracle.DataAccess.Client.OracleCommand();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(62, 314);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 27);
            this.checkBox1.TabIndex = 87;
            this.checkBox1.Text = "적립금 :";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonMile
            // 
            this.buttonMile.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonMile.Enabled = false;
            this.buttonMile.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonMile.ForeColor = System.Drawing.Color.White;
            this.buttonMile.Location = new System.Drawing.Point(289, 310);
            this.buttonMile.Name = "buttonMile";
            this.buttonMile.Size = new System.Drawing.Size(81, 30);
            this.buttonMile.TabIndex = 86;
            this.buttonMile.Text = "사용";
            this.buttonMile.UseVisualStyleBackColor = false;
            this.buttonMile.Click += new System.EventHandler(this.buttonMileClick);
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonPay.Font = new System.Drawing.Font("나눔스퀘어", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonPay.ForeColor = System.Drawing.Color.White;
            this.buttonPay.Location = new System.Drawing.Point(142, 564);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(127, 49);
            this.buttonPay.TabIndex = 85;
            this.buttonPay.Text = "결  제";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPayClick);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(15, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(354, 96);
            this.listBox1.TabIndex = 84;
            // 
            // textBoxWanttMoney
            // 
            this.textBoxWanttMoney.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxWanttMoney.Location = new System.Drawing.Point(213, 512);
            this.textBoxWanttMoney.Name = "textBoxWanttMoney";
            this.textBoxWanttMoney.Size = new System.Drawing.Size(164, 31);
            this.textBoxWanttMoney.TabIndex = 73;
            this.textBoxWanttMoney.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(45, 515);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(174, 23);
            this.label19.TabIndex = 67;
            this.label19.Text = "지불 해야 할 금액 : ";
            // 
            // textBoxMile
            // 
            this.textBoxMile.Enabled = false;
            this.textBoxMile.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxMile.Location = new System.Drawing.Point(165, 310);
            this.textBoxMile.Name = "textBoxMile";
            this.textBoxMile.Size = new System.Drawing.Size(118, 31);
            this.textBoxMile.TabIndex = 74;
            this.textBoxMile.Text = "0";
            this.textBoxMile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxFine
            // 
            this.textBoxFine.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxFine.Location = new System.Drawing.Point(171, 225);
            this.textBoxFine.Name = "textBoxFine";
            this.textBoxFine.Size = new System.Drawing.Size(198, 31);
            this.textBoxFine.TabIndex = 75;
            this.textBoxFine.Text = "0";
            this.textBoxFine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(83, 228);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 23);
            this.label20.TabIndex = 69;
            this.label20.Text = "연체료 : ";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            this.oracleCommand1.Transaction = null;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=ORAORA;PERSIST SECURITY INFO=True;USER ID=B5293993;PASSWORD=B5293993;" +
    "";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxMoney.Location = new System.Drawing.Point(172, 262);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(198, 31);
            this.textBoxMoney.TabIndex = 76;
            this.textBoxMoney.Text = "0";
            this.textBoxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 70;
            this.label3.Text = "총금액 : ";
            // 
            // textBoxT
            // 
            this.textBoxT.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxT.Location = new System.Drawing.Point(288, 395);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(55, 31);
            this.textBoxT.TabIndex = 78;
            this.textBoxT.Text = "0";
            this.textBoxT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxT.Click += new System.EventHandler(this.TextBoxMoneyClick);
            this.textBoxT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMoneyKeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(209, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 68;
            this.label6.Text = "천  원 : ";
            // 
            // textBoxTen
            // 
            this.textBoxTen.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxTen.Location = new System.Drawing.Point(288, 469);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(55, 31);
            this.textBoxTen.TabIndex = 81;
            this.textBoxTen.Text = "0";
            this.textBoxTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTen.Click += new System.EventHandler(this.TextBoxMoneyClick);
            this.textBoxTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMoneyKeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(209, 472);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 23);
            this.label10.TabIndex = 66;
            this.label10.Text = "십  원 : ";
            // 
            // textBoxH
            // 
            this.textBoxH.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxH.Location = new System.Drawing.Point(288, 432);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(55, 31);
            this.textBoxH.TabIndex = 71;
            this.textBoxH.Text = "0";
            this.textBoxH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxH.Click += new System.EventHandler(this.TextBoxMoneyClick);
            this.textBoxH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMoneyKeyPress);
            // 
            // textBox5Ten
            // 
            this.textBox5Ten.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5Ten.Location = new System.Drawing.Point(104, 469);
            this.textBox5Ten.Name = "textBox5Ten";
            this.textBox5Ten.Size = new System.Drawing.Size(55, 31);
            this.textBox5Ten.TabIndex = 83;
            this.textBox5Ten.Text = "0";
            this.textBox5Ten.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox5Ten.Click += new System.EventHandler(this.TextBoxMoneyClick);
            this.textBox5Ten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMoneyKeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(208, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 64;
            this.label8.Text = "백  원 : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(24, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 23);
            this.label9.TabIndex = 65;
            this.label9.Text = "오십원 : ";
            // 
            // textBox5H
            // 
            this.textBox5H.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5H.Location = new System.Drawing.Point(104, 432);
            this.textBox5H.Name = "textBox5H";
            this.textBox5H.Size = new System.Drawing.Size(55, 31);
            this.textBox5H.TabIndex = 82;
            this.textBox5H.Text = "0";
            this.textBox5H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox5H.Click += new System.EventHandler(this.TextBoxMoneyClick);
            this.textBox5H.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMoneyKeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 51;
            this.label7.Text = "오백원 : ";
            // 
            // textBox5T
            // 
            this.textBox5T.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5T.Location = new System.Drawing.Point(104, 395);
            this.textBox5T.Name = "textBox5T";
            this.textBox5T.Size = new System.Drawing.Size(55, 31);
            this.textBox5T.TabIndex = 80;
            this.textBox5T.Text = "0";
            this.textBox5T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox5T.Click += new System.EventHandler(this.TextBoxMoneyClick);
            this.textBox5T.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMoneyKeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 52;
            this.label5.Text = "오천원 : ";
            // 
            // textBoxM
            // 
            this.textBoxM.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxM.Location = new System.Drawing.Point(288, 355);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(55, 31);
            this.textBoxM.TabIndex = 79;
            this.textBoxM.Text = "0";
            this.textBoxM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxM.Click += new System.EventHandler(this.TextBoxMoneyClick);
            this.textBoxM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMoneyKeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(209, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 53;
            this.label4.Text = "만  원 : ";
            // 
            // textBox5M
            // 
            this.textBox5M.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5M.Location = new System.Drawing.Point(104, 355);
            this.textBox5M.Name = "textBox5M";
            this.textBox5M.Size = new System.Drawing.Size(55, 31);
            this.textBox5M.TabIndex = 77;
            this.textBox5M.Text = "0";
            this.textBox5M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox5M.Click += new System.EventHandler(this.TextBoxMoneyClick);
            this.textBox5M.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMoneyKeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(349, 358);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 23);
            this.label18.TabIndex = 54;
            this.label18.Text = "개";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(348, 398);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 23);
            this.label17.TabIndex = 55;
            this.label17.Text = "개";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(348, 435);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 23);
            this.label16.TabIndex = 56;
            this.label16.Text = "개";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(348, 472);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 23);
            this.label15.TabIndex = 63;
            this.label15.Text = "개";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(165, 472);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 23);
            this.label14.TabIndex = 57;
            this.label14.Text = "개";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(165, 435);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 23);
            this.label13.TabIndex = 58;
            this.label13.Text = "개";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(165, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 23);
            this.label12.TabIndex = 59;
            this.label12.Text = "개";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(165, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 23);
            this.label11.TabIndex = 60;
            this.label11.Text = "개";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "오만원 : ";
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxName.Location = new System.Drawing.Point(15, 62);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(161, 31);
            this.textBoxName.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(182, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 23);
            this.label1.TabIndex = 62;
            this.label1.Text = "님";
            // 
            // labelFindID
            // 
            this.labelFindID.AutoSize = true;
            this.labelFindID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(134)))), ((int)(((byte)(153)))));
            this.labelFindID.Font = new System.Drawing.Font("나눔스퀘어", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFindID.ForeColor = System.Drawing.Color.White;
            this.labelFindID.Location = new System.Drawing.Point(10, 12);
            this.labelFindID.Name = "labelFindID";
            this.labelFindID.Size = new System.Drawing.Size(141, 26);
            this.labelFindID.TabIndex = 50;
            this.labelFindID.Text = "물건 반납>>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 50);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
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
            // stockTableAdapter1
            // 
            this.stockTableAdapter1.ClearBeforeFill = true;
            // 
            // consumerrentalTableAdapter1
            // 
            this.consumerrentalTableAdapter1.ClearBeforeFill = true;
            // 
            // oracleCommand2
            // 
            this.oracleCommand2.Connection = this.oracleConnection1;
            this.oracleCommand2.Transaction = null;
            // 
            // FormEmployReturnMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(387, 625);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonMile);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxWanttMoney);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxMile);
            this.Controls.Add(this.textBoxFine);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.textBox5Ten);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5H);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5T);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5M);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFindID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEmployReturnMoney";
            this.Text = "EVERYTHN\'";
            this.Load += new System.EventHandler(this.FormEmployReturnMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonMile;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxWanttMoney;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxMile;
        private System.Windows.Forms.TextBox textBoxFine;
        private System.Windows.Forms.Label label20;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand1;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBox5Ten;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5H;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5T;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5M;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFindID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.CONSUMERTableAdapter consumerTableAdapter1;
        private DataSet1TableAdapters.STOCKTableAdapter stockTableAdapter1;
        private DataSet1TableAdapters.CONSUMERRENTALTableAdapter consumerrentalTableAdapter1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand2;
    }
}