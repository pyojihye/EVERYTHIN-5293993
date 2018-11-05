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
    public partial class FormEmploySearch : Form
    {
        FormMain mainform;
        string id;
        string item;

        public FormEmploySearch(FormMain mainform, string id)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.id = id;
        }

        private void labelConsuSearchClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEmploySearchConsu frm = new FormEmploySearchConsu(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormEmploySearch_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.ITEM' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.iTEMTableAdapter.Fill(this.dataSet1.ITEM);
            iTEMBindingSource.Sort = "ITEM_NAME";
        }

        private void FormEmploySearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEmployMode frm = new FormEmployMode(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormEmployItemInfo frm = new FormEmployItemInfo(mainform, dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }
    }
}
