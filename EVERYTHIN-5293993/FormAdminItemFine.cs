using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace EVERYTHIN_5293993
{
    public partial class FormAdminItemFine : Form
    {
        FormMain mainform;

        public FormAdminItemFine(FormMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void FormAdminItemFine_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void labelTotalSearch_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminItemCate frm = new FormAdminItemCate(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminItemItem frm = new FormAdminItemItem(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminMode frm = new FormAdminMode(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormAdminItemFine_Load(object sender, EventArgs e)
        {
            oracleConnection1.Open();
            oracleCommand1.CommandText = "select * from fine";

            OracleDataReader rdr = oracleCommand1.ExecuteReader();

            while (rdr.Read())
            {
                if ((rdr["Sto_State"].ToString()).Equals("A"))
                {
                    textBoxA.Text = rdr["fine_fine"].ToString();
                }else if ((rdr["Sto_State"].ToString()).Equals("B"))
                {
                    textBoxB.Text = rdr["fine_fine"].ToString();
                }else
                {
                    textBoxC.Text = rdr["fine_fine"].ToString();
                }
            }   
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            oracleCommand1.CommandText="update fine set fine_fine='"+textBoxA.Text+"' where sto_state='A'";
            oracleCommand1.ExecuteNonQuery();
            oracleCommand1.CommandText = "update fine set fine_fine='" + textBoxB.Text + "' where sto_state='B'";
            oracleCommand1.ExecuteNonQuery();
            oracleCommand1.CommandText = "update fine set fine_fine='" + textBoxC.Text + "' where sto_state='C'";
            oracleCommand1.ExecuteNonQuery();

            MessageBox.Show("벌금이 변경되었습니다!");
            oracleConnection1.Close();
        }
    }
}
