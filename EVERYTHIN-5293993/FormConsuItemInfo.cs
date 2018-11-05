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
    public partial class FormConsuItemInfo : Form
    {
        FormMain mainform;
        string name;
        string id;
        DataTable BookInfoTable;
        DataTable ReviewTable;
        DataTable ItemTable;
        string itemId;
        string review;
        string cateId;
        DataTable reservationTable;

        public FormConsuItemInfo(FormMain mainform, string name, string id)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.name = name;
            this.id = id;
        }

        private void FormItemInfo_Load(object sender, EventArgs e)
        {
            itemstockdescriptionTableAdapter1.Fill(dataSet11.ITEMSTOCKDESCRIPTION);
            BookInfoTable = dataSet11.Tables["ITEMSTOCKDESCRIPTION"];
            string str = "item_name='" + name + "'";

            DataRow[] foundRows = BookInfoTable.Select(str);

            foreach (DataRow mydataRow in foundRows)
            {
                comboBoxCate.Text = mydataRow["cate_id"].ToString();
                comboBoxDescription.Text = mydataRow["des_description"].ToString();
                textBoxItemID.Text = mydataRow["item_name"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(mydataRow["sto_buydate"]);
                textBoxPrice.Text = mydataRow["item_price"].ToString();
                textBoxMileage.Text = mydataRow["item_mileage"].ToString();
                textBoxStock.Text = mydataRow["sto_num"].ToString();
                textBoxState.Text = mydataRow["sto_state"].ToString();
                textBoxLoc.Text = mydataRow["sto_loc"].ToString();
            }
            if (int.Parse(textBoxStock.Text) > 0)
            {
                buttonReservation.Enabled = false;
            }

            itemTableAdapter1.Fill(dataSet11.ITEM);
            ItemTable = dataSet11.Tables["ITEM"];
            DataRow[] itemRows = ItemTable.Select(str);

            foreach (DataRow mydatarow in itemRows)
            {
                itemId = mydatarow["item_id"].ToString();
                cateId = mydatarow["cate_id"].ToString();
            }

            reviewTableAdapter1.Fill(dataSet11.REVIEW);
            ReviewTable = dataSet11.Tables["Review"];
            listBox1.Items.Clear();

            string st = "item_id='" + itemId + "'";
            DataRow[] foundRows2 = ReviewTable.Select(st);
            int count = 0;
            foreach (DataRow mydataRow in foundRows2)
            {
                string star = null;
                switch (mydataRow["REVIEW_GRADE"].ToString())
                {
                    case "0":
                        star = "";
                        break;
                    case "1":
                        star = "★";
                        break;
                    case "2":
                        star = "★★";
                        break;
                    case "3":
                        star = "★★★";
                        break;
                    case "4":
                        star = "★★★★";
                        break;
                    case "5":
                        star = "★★★★★";
                        break;
                }
                listBox1.Items.Add(star);
                review = mydataRow["REVIEW_REVIEW"].ToString();
                count++;
            }
            if (count == 0)
            {
                listBox1.Items.Add("아직 후기가 없는 물건입니다.");
            }
        }

        private void buttonReservationClick(object sender, EventArgs e)
        {
            oracleConnection1.Open();
            reservateionTableAdapter1.Fill(dataSet11.RESERVATEION);
            reservationTable = dataSet11.Tables["RESERVATEION"];
            DataRow[] foundRows = reservationTable.Select("item_id='" + itemId + "'");
            int count = 0;
            foreach (DataRow mydataRow in foundRows)
            {
                count++;
            }
            oracleCommand2.CommandText = "insert into reservateion values('" + itemId + "','" + id + "','" + cateId + "'," + count + ")";
            oracleCommand2.ExecuteNonQuery();

            MessageBox.Show((count + 1) + "번째 순서로 예약 신청이 완료되었습니다.");

            oracleConnection1.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!listBox1.SelectedItem.Equals("아직 후기가 없는 물건입니다."))
            {
                DataRow[] foundrows = ReviewTable.Select("review_review='" + review + "'");
                foreach (DataRow mydataRow in foundrows)
                {
                    textBox1.Text = mydataRow["REVIEW_REVIEW"].ToString();
                }
            }
        }
    }
}
