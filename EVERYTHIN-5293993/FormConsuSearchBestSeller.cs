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
    public partial class FormConsuSearchBestSeller : Form
    {
        FormMain mainform;
        string id;

        public FormConsuSearchBestSeller(FormMain mainform, string id)
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

        private void labelCateSearchClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuSearchCate frm = new FormConsuSearchCate(mainform, id);
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

        private void FormConsuSearchBestSeller_Load(object sender, EventArgs e)
        {
            
            this.iTEMRENTALTableAdapter.Fill(this.dataSet1.ITEMRENTAL);
            for (int i = 0; i < 98; i++)
            {
                this.dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void FormConsuSearchBestSeller_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormConsuItemInfo frm = new FormConsuItemInfo(mainform, dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }
    }
}
