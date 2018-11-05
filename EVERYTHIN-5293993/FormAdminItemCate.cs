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
    public partial class FormAdminItemCate : Form
    {
        FormMain mainform;
        DataTable categoryTable;
        public FormAdminItemCate(FormMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void FormAdminItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminMode frm = new FormAdminMode(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void buttonModifyclick(object sender, EventArgs e)
        {
            oracleConnection1.Open();
            oracleCommand1.CommandText="insert into category values('"+textBox1.Text+"','"+textBox2.Text+"', '"+textBox3.Text+"')";
            oracleCommand1.ExecuteNonQuery();
            MessageBox.Show("분류가 추가되었습니다");
            oracleConnection1.Close();
            FormAdminItem_Load(sender, e);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void FormAdminItem_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            categoryTableAdapter1.Fill(dataSet11.CATEGORY);
            categoryTable = dataSet11.Tables["category"];
            DataRow[] foundRows = categoryTable.Select();

            foreach (DataRow mydataRow in foundRows)
            {
                listBox1.Items.Add(mydataRow["cate_id"].ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminItemItem frm = new FormAdminItemItem(mainform);
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
    }
}
