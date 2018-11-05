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
    public partial class FormAdminChartCateReturn : Form
    {
        FormMain mainform;
        DataTable categoryTable;

        public FormAdminChartCateReturn(FormMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void FormAdminChartCateReturn_FormClosing(object sender, FormClosingEventArgs e)
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

        private void labelTotalSearch_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminChartRent frm = new FormAdminChartRent(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminChartReturn frm = new FormAdminChartReturn(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void labelCateSearch_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminChartRent frm = new FormAdminChartRent(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormAdminChartCateReturn_Load(object sender, EventArgs e)
        {
            List<string> cate = new List<string>();
            List<int> cateNum = new List<int>();
            List<string> data = new List<string>();

            categoryTableAdapter1.Fill(dataSet11.CATEGORY);
            categoryTable = dataSet11.Tables["category"];
            DataRow[] foundRows = categoryTable.Select();

            foreach (DataRow mydataRow in foundRows)
            {
                cate.Add(mydataRow["cate_id"].ToString());
            }

            oracleConnection1.Open();
            oracleCommand1.CommandText = "select * from return";
            OracleDataReader rdr3 = oracleCommand1.ExecuteReader();

            while (rdr3.Read())
            {
                string str = rdr3["cate_id"].ToString();
                data.Add(str);
            }
            for (int i = 0; i < cate.Count; i++)
            {
                int a = 0;
                for (int j = 0; j < data.Count; j++)
                {
                    if (cate[i].Equals(data[j]))
                    {
                        a++;
                    }
                }
                cateNum.Add(a);
            }

            chart1.Series[0].Name = "Date";

            for (int i = 0; i < cate.Count; i++)
            {
                if (cateNum[i] != 0)
                {
                    chart1.Series[0].Points.AddXY(cate[i], cateNum[i]);
                }
            }
            oracleConnection1.Close();
        }
    }
}
