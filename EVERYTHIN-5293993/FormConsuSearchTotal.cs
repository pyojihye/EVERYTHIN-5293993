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
    public partial class FormConsuSearchTotal : Form
    {
        FormMain mainform;
        string id;
        string cate;
        string item;
        DataTable categoryTable;
        //DataTable itemTable;

        public FormConsuSearchTotal(FormMain mainform, string id, string cate, string item)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.id = id;
            this.cate = cate;
            this.item = item;
        }

        public FormConsuSearchTotal(FormMain mainform, string id)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.id = id;
            item = "";
            cate = "book";
        }

        private void FormConsuTotalSearch_Load(object sender, EventArgs e)
        {
            
            // TODO: 이 코드는 데이터를 'dataSet1.ITEM' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.iTEMTableAdapter.Fill(this.dataSet1.ITEM);

            iTEMBindingSource.Filter = "item_name like '%" + item + "%' AND cate_id='" + cate + "'";
            iTEMBindingSource.Sort = "ITEM_NAME";

            categoryTableAdapter1.Fill(dataSet11.CATEGORY);
            categoryTable = dataSet11.Tables["category"];
            DataRow[] foundRows = categoryTable.Select();

            foreach (DataRow mydataRow in foundRows)
            {
                comboBoxSearch.Items.Add(mydataRow["cate_id"].ToString());
            }
            comboBoxSearch.SelectedItem = cate;
            textBoxSearch.Text = item;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuMode frm = new FormConsuMode(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormConsuTotalSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearchClick(sender, e);
            }
        }

        private void buttonSearchClick(object sender, EventArgs e)
        {
            cate = comboBoxSearch.SelectedItem.ToString();
            item = textBoxSearch.Text;
            iTEMBindingSource.Filter = "item_name like '%" + item + "%' AND cate_id='" + cate + "'";
            iTEMBindingSource.Sort = "ITEM_NAME";
        }

        private void labelCateSearchClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuSearchCate frm = new FormConsuSearchCate(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void labelBestSellerClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuSearchBestSeller frm = new FormConsuSearchBestSeller(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void labelAgeSearchClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuSearchAge frm = new FormConsuSearchAge(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void labelNewItemSearchClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuSearchNewItem frm = new FormConsuSearchNewItem(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormConsuItemInfo frm = new FormConsuItemInfo(mainform, dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormConsuSearchTotal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
