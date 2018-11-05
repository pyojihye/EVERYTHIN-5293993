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
    public partial class FormAdminMode : Form
    {
        private FormMain mainform;

        public FormAdminMode(FormMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void FormAdminMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonNowClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminChartRent frm = new FormAdminChartRent(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void buttonItemClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminItemCate frm = new FormAdminItemCate(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void buttonConsuClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminConsu frm = new FormAdminConsu(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void buttonEmployClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminEmploy frm = new FormAdminEmploy(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Owner = this;
            frm.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminRentalReturn frm = new FormAdminRentalReturn(mainform);
            frm.Owner = this;
            frm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminMoney frm = new FormAdminMoney(mainform);
            frm.Owner = this;
            frm.Show();
            this.Visible = false;
        }
    }
}
