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
    public partial class FormAdminMoneyChart : Form
    {
        FormMain mainform;
        DataTable ReturnTable;

        public FormAdminMoneyChart(FormMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void labelTotalSearch_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminMoney frm = new FormAdminMoney(mainform);
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

        private void FormAdminMoneyChart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormAdminMoneyChart_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.RETURN' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.returnchartTableAdapter1.Fill(this.dataSet1.RETURNCHART);
            ReturnTable = dataSet1.Tables["RETURNCHART"];
            
            DateTime date = DateTime.Now;
            int day = 0;
            switch (date.Month)
            {
                case 2:
                    day = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    day = 30;
                    break;
                default:
                    day = 31;
                    break;
            }
            string first = date.Year + "-" + date.Month + "-" + 1;
            string now = date.Year + "-" + date.Month + "-" + day;
            string str = String.Format("to_date('" + first + "','YYYY-MM-DD') <= today_date AND today_date<=to_date('" + now + "','YYYY-MM-DD')");

            oracleConnection1.Open();
            oracleCommand1.CommandText = "select * from returnchart where " + str;

            OracleDataReader rdr = oracleCommand1.ExecuteReader();

            chart1.Series[0].Name = "date";

            while (rdr.Read())
            {
                int money=0;
                money+= 50000 * int.Parse(rdr["ret_50000"].ToString());
                money += 10000 * int.Parse(rdr["ret_10000"].ToString());
                money += 5000 * int.Parse(rdr["ret_5000"].ToString());
                money += 1000 * int.Parse(rdr["ret_1000"].ToString());
                money += 500 * int.Parse(rdr["ret_500"].ToString());
                money += 100 * int.Parse(rdr["ret_100"].ToString());
                money += 50 * int.Parse(rdr["ret_50"].ToString());
                money += 10 * int.Parse(rdr["ret_10"].ToString());
                chart1.Series[0].Points.AddXY(rdr["today_date"], money);
            }
            oracleConnection1.Close();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar1.SelectionRange.Start;
            int day = 0;
            switch (date.Month)
            {
                case 2:
                    day = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    day = 30;
                    break;
                default:
                    day = 31;
                    break;
            }
            string first = date.Year + "-" + date.Month + "-" + 1;
            string now = date.Year + "-" + date.Month + "-" + day;
            string str = String.Format("to_date('" + first + "','YYYY-MM-DD') <= today_date AND today_date<=to_date('" + now + "','YYYY-MM-DD')");

            oracleConnection1.Open();
            oracleCommand1.CommandText = "select * from returnchart where " + str;

            OracleDataReader rdr = oracleCommand1.ExecuteReader();

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            chart1.Series[0].Name = "date";

            while (rdr.Read())
            {
                int money = 0;
                money += 50000 * int.Parse(rdr["ret_50000"].ToString());
                money += 10000 * int.Parse(rdr["ret_10000"].ToString());
                money += 5000 * int.Parse(rdr["ret_5000"].ToString());
                money += 1000 * int.Parse(rdr["ret_1000"].ToString());
                money += 500 * int.Parse(rdr["ret_500"].ToString());
                money += 100 * int.Parse(rdr["ret_100"].ToString());
                money += 50 * int.Parse(rdr["ret_50"].ToString());
                money += 10 * int.Parse(rdr["ret_10"].ToString());
                chart1.Series[0].Points.AddXY(Convert.ToInt32(rdr["today_date"]), money);
            }
            oracleConnection1.Close();
        }
    }
}
