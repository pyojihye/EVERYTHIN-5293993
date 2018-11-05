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
    public partial class FormEmployRental : Form
    {
        FormMain mainform;
        string id;
        string item;
        DataTable consumerTable;
        DataTable employItemStockTable;
        DataTable reservateionTable;

        public FormEmployRental(FormMain mainform, string id)
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

        private void FormEmployRental_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonSearchClick(object sender, EventArgs e)
        {
            item = textBoxSearch.Text;
            iTEMBindingSource.Filter = "item_name like '%" + item + "%'";
            iTEMBindingSource.Sort = "ITEM_NAME";
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearchClick(sender, e);
            }
        }

        public void F5(object sender, EventArgs e)
        {
            FormEmployRental_Load(sender, e);
        }


        private void FormEmployRental_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.ITEM' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.iTEMTableAdapter.Fill(this.dataSet1.ITEM);
            iTEMBindingSource.Sort = "ITEM_NAME";
            employitemstockTableAdapter1.Fill(dataSet1.EMPLOYITEMSTOCK);
            employItemStockTable = dataSet1.Tables["EMPLOYITEMSTOCK"];

            string str = "sto_num = 0";
            DataRow[] foundRows = employItemStockTable.Select(str);
            foreach (DataRow mydataRow in foundRows)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value.Equals(mydataRow["item_name"]))
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                    }
                }
            }
        }

        private void buttonRentalClick(object sender, EventArgs e)
        {
            if (checkBoxSearchConsu.Text.Equals("회원 검색을 해주세요"))
            {
                MessageBox.Show("회원 검색을 해주세요!");
            }
            else
            {
                int count = 0;
                string consuID = "";
                List<string> itemID = new List<string>();
                List<string> cateID = new List<string>();
                List<string> itemName = new List<string>();
                List<int> TotalMoney = new List<int>();
                int TotalMileage = 0;

                consumerTableAdapter1.Fill(dataSet1.CONSUMER);
                consumerTable = dataSet1.Tables["consumer"];

                string consuName = "consu_name='" + checkBoxSearchConsu.Text + "'";
                DataRow[] ConsuNameRow = consumerTable.Select(consuName);

                foreach (DataRow mydataRow in ConsuNameRow)
                {
                    consuID = mydataRow["consu_id"].ToString();
                }

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[0];


                    if (checkBoxCell.Value != null)
                    {
                        itemID.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        cateID.Add(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        itemName.Add(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        TotalMoney.Add(int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()));
                        TotalMileage += int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    }
                    else
                    {
                        count++;
                    }

                }
                if (count == dataGridView1.RowCount)
                {
                    MessageBox.Show("대여하고자 하는 아이템을 클릭해주세요");
                }
                else
                {
                    FormEmployRentalConfirm frm = new FormEmployRentalConfirm(this, consuID, checkBoxSearchConsu.Text, itemID, cateID, id, TotalMoney, TotalMileage, itemName);
                    frm.Owner = this;
                    frm.Show();
                    frm.Activate();
                }
            }
        }

        private void buttonSearchConsuClick(object sender, EventArgs e)
        {
            FormEmploySearchConsuList frm = new FormEmploySearchConsuList(this);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        public void SetData(string data, Boolean check)
        {
            checkBoxSearchConsu.Text = data;
            checkBoxSearchConsu.Checked = check;
        }

        private void labelNowRentalClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEmployRentalNow frm = new FormEmployRentalNow(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }
    }
}
