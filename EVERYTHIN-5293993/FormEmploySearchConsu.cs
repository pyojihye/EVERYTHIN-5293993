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
    public partial class FormEmploySearchConsu : Form
    {
        FormMain mainform;
        string id;
        string name;

        public FormEmploySearchConsu(FormMain mainform, string id)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.id = id;
        }

        private void FormEmploySearchConsu_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.CONSUMER' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.cONSUMERTableAdapter.Fill(this.dataSet1.CONSUMER);
            cONSUMERBindingSource.Sort = "consu_name";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEmployMode frm = new FormEmployMode(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void labelItemSearchClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEmploySearch frm = new FormEmploySearch(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormEmploySearchConsu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonSearchClick(object sender, EventArgs e)
        {
            name = textBoxSearch.Text;
            cONSUMERBindingSource.Filter = "consu_name like '%" + name + "%'";
            cONSUMERBindingSource.Sort = "consu_name";
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
            FormEmployConsuInfo frm = new FormEmployConsuInfo(this, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }
        public void F5(object sender, EventArgs e)
        {
            FormEmploySearchConsu_Load(sender, e);
        }
    }
}
