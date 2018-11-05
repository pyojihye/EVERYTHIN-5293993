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
    public partial class FormConsuSearchCate : Form
    {
        FormMain mainform;
        string id;
        DataTable categoryTable;
        DataTable descriptionTable;

        public FormConsuSearchCate(FormMain mainform, string id)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.id = id;
        }

        private void labelTotalSearchClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuSearchTotal frm = new FormConsuSearchTotal(mainform, id);
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuMode frm = new FormConsuMode(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormConsuSearchCate_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.ITEMSTOCKDESCRIPTION' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.iTEMSTOCKDESCRIPTIONTableAdapter.Fill(this.dataSet1.ITEMSTOCKDESCRIPTION);
            iTEMSTOCKDESCRIPTIONBindingSource1.Filter = "cate_id='" + comboBoxSearch.Text + "' AND des_description='" + comboBoxDescription.Text + "'";

            categoryTableAdapter1.Fill(dataSet11.CATEGORY);
            categoryTable = dataSet11.Tables["category"];
            DataRow[] foundRows = categoryTable.Select();

            foreach (DataRow mydataRow in foundRows)
            {
                comboBoxSearch.Items.Add(mydataRow["cate_id"].ToString());
            }
            comboBoxSearch.SelectedIndex = 0;

            comboBoxSelectionChangeCommitted(sender, e);
        }

        private void comboBoxSelectionChangeCommitted(object sender, EventArgs e)
        {
            int count = 0;
            comboBoxDescription.Items.Clear();
            descriptionTableAdapter1.Fill(dataSet11.DESCRIPTION);
            descriptionTable = dataSet11.Tables["DESCRIPTION"];
            DataRow[] foundRows2 = descriptionTable.Select("cate_id='" + comboBoxSearch.SelectedItem + "'");
            foreach (DataRow mydataRow in foundRows2)
            {
                if (comboBoxDescription.Items.Count == 0 || count == comboBoxDescription.Items.Count)
                {
                    comboBoxDescription.Items.Add(mydataRow["DES_DESCRIPTION"].ToString());
                }

                if (comboBoxDescription.Items.Contains(mydataRow["DES_DESCRIPTION"].ToString()))
                {

                }
                else
                {
                    comboBoxDescription.Items.Add(mydataRow["DES_DESCRIPTION"].ToString());
                }
            }
        }

        private void buttonSearchClick(object sender, EventArgs e)
        {
            iTEMSTOCKDESCRIPTIONBindingSource1.Filter = "cate_id='" + comboBoxSearch.Text + "' AND des_description='" + comboBoxDescription.Text + "'";
            iTEMSTOCKDESCRIPTIONBindingSource1.Sort = "ITEM_NAME";
        }

        private void FormConsuSearchCate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormConsuItemInfo frm = new FormConsuItemInfo(mainform, dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }
    }
}
