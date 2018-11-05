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
    public partial class FormAdminMoney : Form
    {
        FormMain mainform;
        DataTable ReturnTable;

        public FormAdminMoney(FormMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void FormAdminMomey_Load(object sender, EventArgs e)
        {
            returnTableAdapter1.Fill(dataSet11.RETURN);
            ReturnTable = dataSet11.Tables["return"];

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
            string str = String.Format("'" + first + "' <= today_date AND today_date<='" + now + "'");

            DataRow[] mydataRow = ReturnTable.Select(str);

            foreach(DataRow mydata in mydataRow)
            {
                DateTime day2 = Convert.ToDateTime(mydata["today_date"]);
                string date2 = day2.Year + "-" + day2.Month + "-" + day2.Day;
                listBox1.Items.Add(date2);
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            listBox1.Items.Clear();
            returnTableAdapter1.Fill(dataSet11.RETURN);
            ReturnTable = dataSet11.Tables["return"];

            DateTime date = e.Start;
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
            string str = String.Format("'" + first + "' <= today_date AND today_date<='" + now + "'");

            DataRow[] mydataRow = ReturnTable.Select(str);

            foreach (DataRow mydata in mydataRow)
            {
                DateTime day2 = Convert.ToDateTime(mydata["today_date"]);
                string date2 = day2.Year + "-" + day2.Month + "-" + day2.Day;
                listBox1.Items.Add(date2);
            }

            DateTime Start2 = e.Start;
            monthCalendar1.SelectionStart = Start2;
            string first2 = Start2.Year + "-" + Start2.Month + "-" + Start2.Day;

            string str2 = "today_date = '" + first + "'";
            DataRow[] foundRows = ReturnTable.Select(str2);

            int money = 0;
            foreach(DataRow mydataRow2 in foundRows)
            {
                money += 50000 * int.Parse(mydataRow2["ret_50000"].ToString());
                money += 10000 * int.Parse(mydataRow2["ret_10000"].ToString());
                money += 5000 * int.Parse(mydataRow2["ret_5000"].ToString());
                money += 1000 * int.Parse(mydataRow2["ret_1000"].ToString());
                money += 500 * int.Parse(mydataRow2["ret_500"].ToString());
                money += 100 * int.Parse(mydataRow2["ret_100"].ToString());
                money += 50 * int.Parse(mydataRow2["ret_50"].ToString());
                money += 10 * int.Parse(mydataRow2["ret_10"].ToString());
            }

            textBox1.Text = money.ToString();
        }

        private void FormAdminMomey_FormClosing(object sender, FormClosingEventArgs e)
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

        private void labelCateSearch_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminMoneyChart frm = new FormAdminMoneyChart(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime Start = Convert.ToDateTime(listBox1.SelectedItem);
            monthCalendar1.SelectionStart = Start;
            string first = Start.Year + "-" + Start.Month + "-" + Start.Day;

            string str = "today_date = '" + first + "'";
            DataRow[] foundRows = ReturnTable.Select(str);

            int money = 0;
            foreach (DataRow mydataRow in foundRows)
            {
                money += 50000 * int.Parse(mydataRow["ret_50000"].ToString());
                money += 10000 * int.Parse(mydataRow["ret_10000"].ToString());
                money += 5000 * int.Parse(mydataRow["ret_5000"].ToString());
                money += 1000 * int.Parse(mydataRow["ret_1000"].ToString());
                money += 500 * int.Parse(mydataRow["ret_500"].ToString());
                money += 100 * int.Parse(mydataRow["ret_100"].ToString());
                money += 50 * int.Parse(mydataRow["ret_50"].ToString());
                money += 10 * int.Parse(mydataRow["ret_10"].ToString());
            }

            textBox1.Text = money.ToString();
        }
    }
}
