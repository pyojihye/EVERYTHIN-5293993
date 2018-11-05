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
    public partial class FormAdminItemPlus : Form
    {
        FormAdminItemItem itemForm;
        DataTable categoryTable;
        DataTable StockTable;

        public FormAdminItemPlus(FormAdminItemItem itemForm)
        {
            InitializeComponent();
            this.itemForm = itemForm;
        }

        private void FormAdminItemPlus_Load(object sender, EventArgs e)
        {
            categoryTableAdapter1.Fill(dataSet11.CATEGORY);
            categoryTable = dataSet11.Tables["category"];
            DataRow[] foundRows = categoryTable.Select();

            foreach (DataRow mydataRow in foundRows)
            {
                comboBoxCate.Items.Add(mydataRow["cate_id"].ToString());
            }
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            oracleConnection1.Open();
            oracleCommand1.CommandText = "insert into item values('" + textBoxID.Text + "','" + comboBoxCate.SelectedItem + "','" + textBoxName.Text + "','" + textBoxPrice.Text + "','" + textBoxMileage.Text + "')";
            oracleCommand1.ExecuteNonQuery();

            oracleCommand2.CommandText = "insert into description values('" + textBoxID.Text + "','" + comboBoxCate.SelectedItem + "','" + textBox1.Text + "')";
            oracleCommand2.ExecuteNonQuery();

            stockTableAdapter1.Fill(dataSet11.STOCK);
            StockTable = dataSet11.Tables["STOCK"];

            string str = "item_id='" + textBoxID.Text + "'";
            DataRow[] foundRows = StockTable.Select(str);
            string stock = "1";

            foreach (DataRow mydataRow in foundRows)
            {
                stock = mydataRow["sto_stock"].ToString();
            }

            DateTime day = dateTimePicker1.Value;
            string date = day.Year + "-" + day.Month + "-" + day.Day;
            oracleCommand3.CommandText = "insert into stock values ('" + textBoxID.Text + "','" + comboBoxCate.SelectedItem + "','" + stock + "',to_date('" + date + "','YYYY-MM-DD'),'" + textBoxLoc.Text + "','" + textBoxState.Text + "','" + textBoxStock.Text + "')";
            oracleCommand3.ExecuteNonQuery();
            MessageBox.Show("물건이 추가되었습니다");
            this.Visible = false;
            itemForm.Activate();
            oracleConnection1.Close();
            itemForm.F5(sender,e);
        }
    }
}
