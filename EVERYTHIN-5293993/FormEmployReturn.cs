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
    public partial class FormEmployReturn : Form
    {
        FormMain mainform;
        string id;
        DataTable consumerTable;
        DataTable itemTable;
        DataTable ReturnTable;
        int mileage;

        public FormEmployReturn(FormMain mainform, string id)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.id = id;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEmployMode frm = new FormEmployMode(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormEmployReturn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormEmployReturn_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.CONSUMERRENTAL' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.cONSUMERRENTALTableAdapter.Fill(this.dataSet1.CONSUMERRENTAL);
            returnTableAdapter1.Fill(dataSet11.RETURN);
            ReturnTable = dataSet11.Tables["return"];
            F5();
        }

        public void F5()
        {
            DataRow[] foundRows = ReturnTable.Select();
            foreach (DataRow mydataRow in foundRows)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (mydataRow["consu_id"].ToString() == dataGridView1.Rows[i].Cells[9].Value.ToString() && mydataRow["item_id"].ToString() == dataGridView1.Rows[i].Cells[10].Value.ToString())
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                    }
                }
            }
        }

        public void F5(string consuId, string itemId)
        {
            DataRow[] foundRows = ReturnTable.Select();
            foreach (DataRow mydataRow in foundRows)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (consuId == dataGridView1.Rows[i].Cells[9].Value.ToString() && itemId == dataGridView1.Rows[i].Cells[10].Value.ToString())
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                        break;
                    }
                }
            }
        }

        private void buttonSearchClick(object sender, EventArgs e)
        {
            cONSUMERRENTALBindingSource.Filter = "item_name like '%" + textBoxSearch.Text + "%'";
        }

        private void buttonSearchConsuClick(object sender, EventArgs e)
        {
            cONSUMERRENTALBindingSource.Filter = "consu_name like '%" + textBoxSearch.Text + "%'";
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearchClick(sender, e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string consuName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string consuID = "";
            string itemName = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            string itemID = "";
            string cateID = "";
            string stoStock = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            string renMoney = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            consumerTableAdapter1.Fill(dataSet1.CONSUMER);
            consumerTable = dataSet1.Tables["consumer"];
            string str = "consu_name='" + consuName + "'";
            DataRow[] foundrows = consumerTable.Select(str);

            foreach (DataRow mydataRow in foundrows)
            {
                consuID = mydataRow["consu_id"].ToString();
            }

            itemTableAdapter1.Fill(dataSet1.ITEM);
            itemTable = dataSet1.Tables["item"];
            string str2 = "item_name='" + itemName + "'";
            DataRow[] foundrows2 = itemTable.Select(str2);

            foreach (DataRow mydataRow in foundrows2)
            {
                itemID = mydataRow["item_id"].ToString();
                cateID = mydataRow["cate_id"].ToString();
                mileage = int.Parse(mydataRow["item_mileage"].ToString());
            }

            FormEmployReturnMoney frm = new FormEmployReturnMoney(this, consuName, consuID, itemName, itemID, cateID, id, stoStock, renMoney, mileage);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void labelNowReturnClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEmployReturnNow frm = new FormEmployReturnNow(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }
    }
}
