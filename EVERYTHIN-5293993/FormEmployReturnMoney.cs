using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace EVERYTHIN_5293993
{
    public partial class FormEmployReturnMoney : Form
    {
        FormEmployReturn returnForm;
        string consuID;
        string itemID;
        string cateID;
        string employID;
        string stoStock;
        string renMoney;
        string consuName;
        string itemName;
        DataTable consumerTable;
        DataTable stockTable;
        DataTable RentalTable;
        int mileage;
        Boolean mileTrue = false;
        int jukmileage;

        public FormEmployReturnMoney(FormEmployReturn returnForm, string consuName, string consuID, string itemName, string itemID, string cateID, string employID, string stoStock, string renMoney, int jukmileage)
        {
            InitializeComponent();
            this.returnForm = returnForm;
            this.consuName = consuName;
            this.consuID = consuID;
            this.itemName = itemName;
            this.itemID = itemID;
            this.cateID = cateID;
            this.employID = employID;
            this.stoStock = stoStock;
            this.renMoney = renMoney;
            this.jukmileage = jukmileage;
        }

        private void FormEmployReturnMoney_Load(object sender, EventArgs e)
        {
            textBoxName.Text = consuName;
            listBox1.Items.Add("분류 : " + cateID);
            listBox1.Items.Add("물건명 : " + itemName);
            DateTime ReturnDate = DateTime.Now;
            DateTime RentalDate = DateTime.Now;
            consumerrentalTableAdapter1.Fill(dataSet11.CONSUMERRENTAL);
            RentalTable = dataSet11.Tables["CONSUMERRENTAL"];

            string str = "consu_id='" + consuID + "' AND item_id='" + itemID + "'";
            DataRow[] foundRows = RentalTable.Select(str);
            foreach (DataRow mydataRow in foundRows)
            {
                RentalDate = Convert.ToDateTime(mydataRow["ren_date"]);
                TimeSpan ts = ReturnDate - RentalDate;
                int days = int.Parse(ts.Days.ToString());
                if (days > int.Parse(mydataRow["cate_date"].ToString()))
                {
                    int num = FineMoney(itemID,stoStock);
                    textBoxFine.Text = (num * days).ToString();
                }
            }
            int ori = int.Parse(renMoney.ToString());
            int fine = int.Parse(textBoxFine.Text.ToString());
            textBoxMoney.Text = (ori + fine).ToString();
            textBoxWanttMoney.Text = textBoxMoney.Text;

        }

        private int FineMoney(string itemID, string stoStock)
        {
            int num=0;
            oracleConnection1.Open();
            oracleCommand2.CommandText = "select fine_fine from stock left outer join rental on stock.ITEM_ID=rental.ITEM_ID left outer join fine on stock.sto_state=fine.sto_state where rental.item_id='"+itemID+"'";
            OracleDataReader rdr = oracleCommand2.ExecuteReader();

            while (rdr.Read())
            {
                num = int.Parse(rdr[0].ToString());
            }

            oracleConnection1.Close();
            return num;
        }

        private void buttonPayClick(object sender, EventArgs e)
        {
            if (textBoxWanttMoney.Text == "0")
            {
                oracleConnection1.Open();
                int fiveM = int.Parse(textBox5M.Text);
                int oneM = int.Parse(textBoxM.Text);
                int fiveT = int.Parse(textBox5T.Text);
                int oneT = int.Parse(textBoxT.Text);
                int fiveH = int.Parse(textBox5H.Text);
                int oneH = int.Parse(textBoxH.Text);
                int fiveTen = int.Parse(textBox5Ten.Text);
                int oneTen = int.Parse(textBoxTen.Text);
                string day = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                oracleCommand1.CommandText = "insert into return values('" + consuID + "','" + itemID + "','" + cateID + "','" + employID + "',to_date('" + day + "','YYYY-MM-DD')," + fiveM + "," + oneM + "," + fiveT + "," + oneT + "," + fiveH + "," + oneH + "," + fiveTen + "," + oneTen + "," + stoStock + ")";
                oracleCommand1.ExecuteNonQuery();

                MessageBox.Show("반납이 완료 되었습니다.");
                oracleConnection1.Close();


                stockTableAdapter1.Fill(dataSet11.STOCK);
                stockTable = dataSet11.Tables["stock"];

                string str = "sto_stock='" + stoStock + "' AND item_id='" + itemID + "'";
                DataRow[] mydataRow = stockTable.Select(str);
                foreach (DataRow mydata in mydataRow)
                {
                    mydata["sto_num"] = (int.Parse(mydata["sto_num"].ToString()) + 1).ToString();
                }
                consumerTableAdapter1.Fill(dataSet11.CONSUMER);
                consumerTable = dataSet11.Tables["consumer"];
                string str2 = "consu_id='" + consuID + "'";
                DataRow[] foundrows = consumerTable.Select(str2);

                foreach (DataRow mydataRow2 in foundrows)
                {
                    int a = int.Parse(mydataRow2["consu_mileage"].ToString());
                    int b = int.Parse(textBoxMile.Text);

                    mydataRow2["consu_mileage"] = ((a-b)+jukmileage).ToString();
                    oracleConnection1.Open();
                    oracleCommand1.CommandText = "insert into mileage values('" + consuID + "','" + jukmileage + "',to_date('" + day + "','YYYY-MM-DD'))";
                    oracleCommand1.ExecuteNonQuery();
                    oracleConnection1.Close();
                }
                consumerTableAdapter1.Update(dataSet11.CONSUMER);
                stockTableAdapter1.Update(dataSet11.STOCK);
                returnForm.F5(consuID, itemID);
                this.Visible = false;
                returnForm.Activate();
            }
            else//돈내야하는데 안냄
            {
                MessageBox.Show("돈을 지불하여 주십시오");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBoxMile.Enabled = true;
                buttonMile.Enabled = true;
                consumerTableAdapter1.Fill(dataSet11.CONSUMER);
                consumerTable = dataSet11.Tables["consumer"];
                string str = "consu_id='" + consuID + "'";
                DataRow[] foundrows = consumerTable.Select(str);

                foreach (DataRow mydataRow in foundrows)
                {
                    textBoxMile.Text = mydataRow["consu_mileage"].ToString();
                    mileage = int.Parse(textBoxMile.Text);
                }
            }
            else
            {
                if (mileTrue == true)
                {
                    textBoxWanttMoney.Text = (int.Parse(textBoxWanttMoney.Text) + int.Parse(textBoxMile.Text)).ToString();
                    mileTrue = false;
                }
                textBoxMile.Text = "0";
                textBoxMile.Enabled = false;
                buttonMile.Enabled = false;
            }
        }

        private void TextBoxMoneyKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox money = (TextBox)sender;
            int pay = 0;

            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (int)Keys.Back)
            {
                if (money.Text != "")
                {
                    switch (money.Name)
                    {
                        case "textBox5M":
                            pay = 50000 * int.Parse(money.Text);
                            break;

                        case "textBoxM":
                            pay = 10000 * int.Parse(money.Text);
                            break;

                        case "textBox5T":
                            pay = 5000 * int.Parse(money.Text);
                            break;

                        case "textBoxT":
                            pay = 1000 * int.Parse(money.Text);
                            break;

                        case "textBox5H":
                            pay = 500 * int.Parse(money.Text);
                            break;

                        case "textBoxH":
                            pay = 100 * int.Parse(money.Text);
                            break;

                        case "textBox5Ten":
                            pay = 50 * int.Parse(money.Text);
                            break;

                        case "textBoxTen":
                            pay = 10 * int.Parse(money.Text);
                            break;

                    }
                    ExtraMoneyPlus(pay);
                }
            }
            else
            {
                switch (money.Name)
                {
                    case "textBox5M":
                        pay = 50000 * int.Parse(e.KeyChar.ToString());
                        break;

                    case "textBoxM":
                        pay = 10000 * int.Parse(e.KeyChar.ToString());
                        break;

                    case "textBox5T":
                        pay = 5000 * int.Parse(e.KeyChar.ToString());
                        break;

                    case "textBoxT":
                        pay = 1000 * int.Parse(e.KeyChar.ToString());
                        break;

                    case "textBox5H":
                        pay = 500 * int.Parse(e.KeyChar.ToString());
                        break;

                    case "textBoxH":
                        pay = 100 * int.Parse(e.KeyChar.ToString());
                        break;

                    case "textBox5Ten":
                        pay = 50 * int.Parse(e.KeyChar.ToString());
                        break;

                    case "textBoxTen":
                        pay = 10 * int.Parse(e.KeyChar.ToString());
                        break;

                }
                ExtraMoneyCal(pay);
            }
        }

        private void ExtraMoneyCal(int pay)
        {
            int total = int.Parse(textBoxWanttMoney.Text);
            textBoxWanttMoney.Text = (total - pay).ToString();
        }

        private void ExtraMoneyPlus(int pay)
        {
            int total = int.Parse(textBoxWanttMoney.Text);
            textBoxWanttMoney.Text = (total + pay).ToString();
        }

        private void buttonMileClick(object sender, EventArgs e)
        {
            int pay = int.Parse(textBoxMile.Text.ToString());
            if (pay <= mileage)
            {
                if (MessageBox.Show(pay + "원의 마일리지를 사용하시겠습니까?", "마일리지 사용 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ExtraMoneyCal(pay);
                    buttonMile.Enabled = false;
                    mileTrue = true;
                }
            }
            else
            {
                MessageBox.Show("보유한 마일리지보다 더 많은 마일리지를 사용하려 하였습니다.");
            }
        }

        private void TextBoxMoneyClick(object sender, EventArgs e)
        {
            TextBox money = (TextBox)sender;
            if (money.Text == "0")
            {
                money.Text = "";
            }

        }
    }
}
