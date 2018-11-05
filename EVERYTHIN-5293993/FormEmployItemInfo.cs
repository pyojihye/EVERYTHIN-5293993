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
    public partial class FormEmployItemInfo : Form
    {
        FormMain mainform;
        DataTable BookInfoTable;
        string name;

        public FormEmployItemInfo(FormMain mainform, string name)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.name = name;
        }

        private void FormEmployItemInfo_Load(object sender, EventArgs e)
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

                listBox1.Items.Add(mydataRow["sto_buydate"]);
            }
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Owner.Activate();
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
