using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVERYTHIN_5293993
{
    public partial class FormEmployRentalConfirm : Form
    {
        FormEmployRental rentalForm;
        string consuID;
        string consuName;
        List<String> itemID;
        List<String> cateID;
        List<String> itemName;
        string id;
        List<int> TotalMoney;
        int TotalMileage;
        DataTable RentalTable;
        DataTable StockTable;
        DataTable reservateionTable;

        public FormEmployRentalConfirm(FormEmployRental rentalForm, string consuID, string consuName, List<string> itemID, List<string> cateID, string id, List<int> TotalMoney, int TotalMileage, List<string> itemName)
        {
            InitializeComponent();
            this.rentalForm = rentalForm;
            this.consuID = consuID;
            this.consuName = consuName;
            this.itemID = itemID;
            this.cateID = cateID;
            this.id = id;
            this.TotalMoney = TotalMoney;
            this.TotalMileage = TotalMileage;
            this.itemName = itemName;
        }

        private void Reservation(List<string> itemID, string consuID, List<string> cateID)
        {
            reservateionTableAdapter1.Fill(dataSet11.RESERVATEION);
            reservateionTable = dataSet11.Tables["RESERVATEION"];

            string str = "item_id='" + itemID[0] + "' AND consu_id='" + consuID + "'";
            DataRow[] foundRows = reservateionTable.Select(str);
            string reservation = "";

            foreach (DataRow mydataRow in foundRows)
            {
                reservation = mydataRow["reser_reservateion"].ToString();
            }

            oracleConnection1.Open();
            oracleCommand1.CommandText = "delete from reservateion where consu_id='" + consuID[0] + "' AND item_id='" + itemID[0] + "'";
            oracleCommand1.ExecuteNonQuery();
        }

        private void buttonPreClick(object sender, EventArgs e)
        {
            oracleConnection1.Open();

            string st = "item_id='" + itemID + "'";
            DataRow[] foundRows = RentalTable.Select(st);
            int count = 0;

            foreach (DataRow mydataRow in foundRows)
            {
                count = int.Parse(mydataRow["ren_count"].ToString());
            }

            count++;

            for (int i = 0; i < itemName.Count; i++)
            {
                string str = "item_id='" + itemID[i] + "'";
                DataRow[] foundRows2 = StockTable.Select(str);
                int num = 0;
                List<string> loc = new List<string>();

                foreach (DataRow mydataRow2 in foundRows2)
                {
                    num = int.Parse(mydataRow2["sto_NUM"].ToString());
                    loc.Add(mydataRow2["sto_loc"].ToString());
                }

                string str2 = "sto_num='" + num + "' AND sto_loc='" + loc[loc.Count - 1] + "' AND item_id='" + itemID[i] + "'";
                oracleCommand1.CommandText = "update stock set sto_NUM='" + (num - 1) + "' where " + str2;
                oracleCommand1.ExecuteNonQuery();

                DateTime now = DateTime.Now;
                string date = now.Year + "-" + now.Month + "-" + now.Day;
                oracleCommand2.CommandText = "insert into rental values('" + consuID + "','" + itemID[i] + "','" + cateID[i] + "','" + id + "','" + TotalMoney[i] + "',TO_DATE('" + date + "', 'YYYY-MM-DD'),'F','" + count + "','" + num + "')";
                oracleCommand2.ExecuteNonQuery();

            }
            MessageBox.Show("대출이 완료 되었습니다");
            oracleConnection1.Close();
            this.Visible = false;
            rentalForm.F5(sender, e);
            rentalForm.Activate();
            Reservation(itemID, consuID, cateID);
        }

        private void FormEmployRentalConfirm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBoxName.Text = consuName;
            textBoxMile.Text = TotalMileage.ToString();
            int total = 0;
            for (int i = 0; i < itemName.Count; i++)
            {
                listBox1.Items.Add(cateID[i] + "\t" + itemName[i]);
                total += TotalMoney[i];
            }

            textBoxMoney.Text = total.ToString();
            rentalTableAdapter1.Fill(dataSet11.RENTAL);
            RentalTable = dataSet11.Tables["rental"];
            stockTableAdapter1.Fill(dataSet11.STOCK);
            StockTable = dataSet11.Tables["stock"];
        }
    }
}
