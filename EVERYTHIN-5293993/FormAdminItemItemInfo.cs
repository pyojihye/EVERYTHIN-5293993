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
    public partial class FormAdminItemItemInfo : Form
    {
        FormAdminItemItem itemForm;
        DataTable BookInfoTable;
        string name;
        DataTable StockTable;
        string stock;
        string id;

        public FormAdminItemItemInfo(FormAdminItemItem itemForm, string name, string id)
        {
            InitializeComponent();
            this.itemForm = itemForm;
            this.name = name;
            this.id = id;
        }

        private void FormAdminItemItemInfo_Load(object sender, EventArgs e)
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
                textBoxPrice.Text = mydataRow["item_price"].ToString();
                textBoxMileage.Text = mydataRow["item_mileage"].ToString();
                stock = mydataRow["sto_stock"].ToString();
                listBox1.Items.Add(mydataRow["sto_buydate"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            itemForm.Activate();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                stockTableAdapter1.Fill(dataSet11.STOCK);
                StockTable = dataSet11.Tables["STOCK"];

                string str = "item_id='" + id + "' AND sto_stock='" + stock + "'";
                DataRow[] foundRows = StockTable.Select(str);

                foreach (DataRow mydataRow in foundRows)
                {
                    mydataRow["sto_num"] = textBoxStock.Text;
                    mydataRow["sto_state"] = textBoxState.Text;
                    mydataRow["sto_loc"] = textBoxLoc.Text;
                }
                int a = stockTableAdapter1.Update(dataSet11.STOCK);
                if (a > 0)
                {
                    MessageBox.Show("업데이트 성공");
                    this.Visible = false;
                    itemForm.Activate();
                }
                else
                {
                    MessageBox.Show("업데이트 실패");
                }
            }else
            {
                MessageBox.Show("바꾸고자 하는 값을 클릭하세요");
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                itemstockdescriptionTableAdapter1.Fill(dataSet11.ITEMSTOCKDESCRIPTION);
                BookInfoTable = dataSet11.Tables["ITEMSTOCKDESCRIPTION"];
                string str = "item_name='" + name + "' AND sto_buydate='" + listBox1.SelectedItem + "'";

                DataRow[] foundRows = BookInfoTable.Select(str);

                foreach (DataRow mydataRow in foundRows)
                {
                    dateTimePicker1.Value = Convert.ToDateTime(mydataRow["sto_buydate"]);
                    textBoxStock.Text = mydataRow["sto_num"].ToString();
                    textBoxState.Text = mydataRow["sto_state"].ToString();
                    textBoxLoc.Text = mydataRow["sto_loc"].ToString();
                }
            }
        }
    }
}
