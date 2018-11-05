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
    public partial class FormConsuMode : Form
    {
        private FormMain mainform;
        DataTable categoryTable;
        string id;

        public FormConsuMode(FormMain mainform, string id)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.id = id;
        }

        private void FormConsuMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormConsuMode_Load(object sender, EventArgs e)
        {
            categoryTableAdapter1.Fill(dataSet11.CATEGORY);
            categoryTable = dataSet11.Tables["category"];
            DataRow[] foundRows = categoryTable.Select();

            foreach (DataRow mydataRow in foundRows)
            {
                comboBoxSearch.Items.Add(mydataRow["cate_id"].ToString());
            }
            comboBoxSearch.SelectedIndex = 0;
        }

        private void buttonSearchClick(object sender, EventArgs e)
        {
            FormConsuSearchTotal frm = new FormConsuSearchTotal(mainform, id, comboBoxSearch.SelectedItem.ToString(), textBoxSearch.Text);
            frm.Owner = this;
            frm.Show();
            this.Visible = false;
        }

        private void buttonMyPageClick(object sender, EventArgs e)
        {
            FormConsuMyPage frm = new FormConsuMyPage(mainform, id);
            frm.Owner = this;
            frm.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Owner = this;
            frm.Show();
            this.Visible = false;
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearchClick(sender, e);
            }
        }
    }
}
