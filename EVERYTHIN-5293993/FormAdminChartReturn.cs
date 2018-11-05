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
    public partial class FormAdminChartReturn : Form
    {
        FormMain mainform;
        
        public FormAdminChartReturn(FormMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void FormAdminChartReturn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormAdminChartReturn_Load(object sender, EventArgs e)
        {
            oracleConnection1.Open();
            oracleCommand1.CommandText = "select * from return";
            OracleDataReader rdr3 = oracleCommand1.ExecuteReader();

            double mon = 0; double tue = 0; double wed = 0; double thur = 0; double fri = 0; double sat = 0; double sun = 0;
            while (rdr3.Read())
            {
                DateTime date = Convert.ToDateTime(rdr3["today_date"].ToString());
                switch (date.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        mon++;
                        break;
                    case DayOfWeek.Tuesday:
                        tue++;
                        break;
                    case DayOfWeek.Wednesday:
                        wed++;
                        break;
                    case DayOfWeek.Thursday:
                        thur++;
                        break;
                    case DayOfWeek.Friday:
                        fri++;
                        break;
                    case DayOfWeek.Saturday:
                        sat++;
                        break;
                    case DayOfWeek.Sunday:
                        sun++;
                        break;
                }
            }

            chart1.Series[0].Name = "Date";
            if (mon != 0)
            {
                chart1.Series[0].Points.AddXY("Monday", mon);
            }
            if (tue != 0)
            {

                chart1.Series[0].Points.AddXY("Tuesday", tue);
            }
            if (wed != 0)
            {
                chart1.Series[0].Points.AddXY("Wednesday", wed);
            }
            if (thur != 0)
            {
                chart1.Series[0].Points.AddXY("Thursday", thur);

            }
            if (fri != 0)
            {
                chart1.Series[0].Points.AddXY("Friday", fri);
            }
            if (sat != 0)
            {
                chart1.Series[0].Points.AddXY("Saturday", sat);
            }
            if (sun != 0)
            {

                chart1.Series[0].Points.AddXY("Sunday", sun);
            }
            oracleConnection1.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminMode frm = new FormAdminMode(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminChartCateReturn frm = new FormAdminChartCateReturn(mainform);
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

        private void labelCateSearch_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminChartCateRent frm = new FormAdminChartCateRent(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }
    }
}
