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
    public partial class FormAdminItemItem : Form
    {
        DataTable DescriptionTable;
        DataTable StockTable;
        DataTable ItemTable;
        FormMain mainform;

        public FormAdminItemItem(FormMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void FormAdminItemItem_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.ITEM' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.iTEMTableAdapter.Fill(this.dataSet1.ITEM);
            ItemTable = dataSet1.Tables["item"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormAdminItemItemInfo frm = new FormAdminItemItemInfo(this, dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormAdminItemItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonModifyClick(object sender, EventArgs e)
        {
            FormAdminItemPlus frm = new FormAdminItemPlus(this);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[0];
                
                if (checkBoxCell.Value != null)
                {
                    string itemId=dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string cateID=dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string itemName=dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string price = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    int mile = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());

                    descriptionTableAdapter1.Fill(dataSet1.DESCRIPTION);
                    DescriptionTable = dataSet1.Tables["DESCRIPTION"];

                    string str = "item_id='" + itemId + "'";
                    DataRow[] foundRows = DescriptionTable.Select(str);
                    string des = "";

                    foreach (DataRow mydataRow in foundRows)
                    {
                        des = mydataRow["des_description"].ToString();
                    }
                    descriptionTableAdapter1.Delete(itemId, cateID, des);

                    stockTableAdapter1.Fill(dataSet1.STOCK);
                    StockTable = dataSet1.Tables["STOCK"];

                    DataRow[] foundRows2 = StockTable.Select(str);
                    List<int> sto_stock = new List<int>();
                    List<DateTime> sto_buydate = new List<DateTime>();
                    List<string> sto_loc = new List<string>();
                    List<string> sto_state = new List<string>();
                    List<int> sto_num = new List<int>();

                    foreach(DataRow mydataRow2 in foundRows2)
                    {
                        sto_stock.Add(int.Parse(mydataRow2["sto_stock"].ToString()));
                        sto_buydate.Add(Convert.ToDateTime(mydataRow2["sto_buydate"].ToString()));
                        sto_loc.Add(mydataRow2["sto_loc"].ToString());
                        sto_state.Add(mydataRow2["sto_state"].ToString());
                        
                        sto_num.Add(int.Parse(mydataRow2["sto_num"].ToString()));
                    }

                    for(int f = 0; f < sto_stock.Count; f++)
                    {
                        stockTableAdapter1.Delete(itemId, cateID, sto_stock[f], sto_buydate[f], sto_loc[f], sto_state[f], sto_num[f]);
                    }
                    
                    iTEMTableAdapter.Delete(itemId, cateID, itemName, price, mile);
                    FormAdminItemItem_Load(sender, e);
                    MessageBox.Show("물건을 삭제하였습니다");
                }
                else
                {
                    count++;
                }

            }
            if (count == dataGridView1.RowCount)
            {
                MessageBox.Show("삭제하고자 하는 아이템을 클릭해주세요");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminMode frm = new FormAdminMode(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminItemFine frm = new FormAdminItemFine(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void labelTotalSearch_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminItemCate frm = new FormAdminItemCate(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        public void F5(object sender, EventArgs e)
        {
            FormAdminItemItem_Load(sender, e);
        }
    }
}
