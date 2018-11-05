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
    public partial class FormConsuSearchNewItem : Form
    {
        FormMain mainform;
        string id;

        public FormConsuSearchNewItem(FormMain mainform, string id)
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

        private void labelCateSearchClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuSearchCate frm = new FormConsuSearchCate(mainform, id);
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

        private void FormConsuSearchNewItem_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.NEWITEM' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.nEWITEMTableAdapter.Fill(this.dataSet1.NEWITEM);

        }

        private void FormConsuSearchNewItem_FormClosing(object sender, FormClosingEventArgs e)
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
