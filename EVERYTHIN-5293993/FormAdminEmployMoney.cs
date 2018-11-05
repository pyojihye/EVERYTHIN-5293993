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
    public partial class FormAdminEmployMoney : Form
    {
        FormMain mainform;
        DataTable WorkHourTable;
        string date;
        List<string> employId = new List<string>();
        List<string> workDate = new List<string>();

        public FormAdminEmployMoney(FormMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void FormAdminMoney_FormClosing(object sender, FormClosingEventArgs e)
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

        private void labelTotalSearchClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminEmploy frm = new FormAdminEmploy(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormAdminMoney_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            workhourTableAdapter1.Fill(dataSet11.WORKHOUR);
            WorkHourTable = dataSet11.Tables["WORKHOUR"];

            DataRow[] foundRows = WorkHourTable.Select();
            int Totalhour = 0;
            int hour = 0;
            int hourlywage = 0;
            int money = 0;
            employId = new List<string>();
            workDate = new List<string>();
            foreach (DataRow mydataRow in foundRows)
            {
                hour = int.Parse(mydataRow["work_time"].ToString());
                hourlywage = int.Parse(mydataRow["work_hourlywage"].ToString());
                DateTime day = Convert.ToDateTime(mydataRow["work_date"]);
                string date = day.Year + "-" + day.Month + "-" + day.Day;

                if (Convert.ToDateTime(mydataRow["work_date"].ToString()).Month == monthCalendar1.SelectionStart.Month)
                {
                    Totalhour += hour;
                    listBox1.Items.Add(mydataRow["employ_id"] + " " + date);
                    employId.Add(mydataRow["employ_id"].ToString());
                    workDate.Add(date);
                    money += hour * hourlywage;
                }
            }
            textBoxtotalMoney.Text = money.ToString();
            textBoxhourlywage.Text = "";
            textBoxMoney.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            workhourTableAdapter1.Fill(dataSet11.WORKHOUR);
            WorkHourTable = dataSet11.Tables["WORKHOUR"];
            string str = "employ_id='" + employId[listBox1.SelectedIndex] + "' AND work_date='" + workDate[listBox1.SelectedIndex] + "'";
            DataRow[] foundRows = WorkHourTable.Select(str);
            int hour = 0;
            int hourlywage = 0;
            int money = 0;
            foreach (DataRow mydataRow in foundRows)
            {
                hour = int.Parse(mydataRow["work_time"].ToString());
                hourlywage = int.Parse(mydataRow["work_hourlywage"].ToString());
                DateTime day = Convert.ToDateTime(mydataRow["work_date"]);
                date = day.Year + "-" + day.Month + "-" + day.Day;

                if (Convert.ToDateTime(mydataRow["work_date"].ToString()).Month == monthCalendar1.SelectionStart.Month)
                {
                    money = hour * hourlywage;
                }
            }
            textBoxhourlywage.Text = hourlywage.ToString();
            textBoxMoney.Text = money.ToString();
        }


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            listBox1.Items.Clear();
            workhourTableAdapter1.Fill(dataSet11.WORKHOUR);
            WorkHourTable = dataSet11.Tables["WORKHOUR"];

            DataRow[] foundRows = WorkHourTable.Select();
            int Totalhour = 0;
            int hour = 0;
            int hourlywage = 0;
            int money = 0;
            int TotalMoney = 0;
            employId = new List<string>();
            workDate = new List<string>();
            foreach (DataRow mydataRow in foundRows)
            {
                if (Convert.ToDateTime(mydataRow["work_date"].ToString()).Month == monthCalendar1.SelectionRange.Start.Month)
                {
                    
                    hour = int.Parse(mydataRow["work_time"].ToString());
                    Totalhour += hour;
                    hourlywage = int.Parse(mydataRow["work_hourlywage"].ToString());
                    DateTime day = Convert.ToDateTime(mydataRow["work_date"]);
                    string date = day.Year + "-" + day.Month + "-" + day.Day;
                    employId.Add(mydataRow["employ_id"].ToString());
                    workDate.Add(date);
                    listBox1.Items.Add(mydataRow["work_time"] + "\t" + date);
                    money = hour * hourlywage;
                    TotalMoney += hour * hourlywage;
                }
            }
            textBoxhourlywage.Text = hourlywage.ToString();
            textBoxMoney.Text = money.ToString();
            textBoxtotalMoney.Text= TotalMoney.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminEmployChart frm = new FormAdminEmployChart(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormAdminEmployMoney_MouseDown(object sender, MouseEventArgs e)
        {
            FormAdminMoney_Load(sender, e);
        }
    }
}
