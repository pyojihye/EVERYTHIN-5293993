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
    public partial class FormEmployMoney : Form
    {
        FormMain mainform;
        string id;
        DataTable WorkHourTable;
        DateTime StartTime;

        public FormEmployMoney(FormMain mainform, string id, DateTime StartTime)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.id = id;
            this.StartTime = StartTime;
        }

        private void FormEmployMoney_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            workhourTableAdapter1.Fill(dataSet11.WORKHOUR);
            WorkHourTable = dataSet11.Tables["WORKHOUR"];
            string str = "employ_id='" + id + "'";

            DataRow[] foundRows = WorkHourTable.Select(str);
            int Totalhour = 0;
            int hour = 0;
            int hourlywage = 0;
            int money = 0;
            foreach (DataRow mydataRow in foundRows)
            {
                hour = int.Parse(mydataRow["work_time"].ToString());
                hourlywage = int.Parse(mydataRow["work_hourlywage"].ToString());
                DateTime day = Convert.ToDateTime(mydataRow["work_date"]);
                string date = day.Year + "-" + day.Month + "-" + day.Day;

                if (Convert.ToDateTime(mydataRow["work_date"].ToString()).Month == monthCalendar1.TodayDate.Month)
                {
                    Totalhour += hour;
                    listBox1.Items.Add(date + "\t" + mydataRow["work_time"]);
                    money += hour * hourlywage;
                }
            }
            textBoxTime.Text = Totalhour.ToString();
            textBoxhourlywage.Text = hourlywage.ToString();
            textBoxMoney.Text = money.ToString();
        }

        private void labelLogoutMouseDown(object sender, MouseEventArgs e)
        {
            labelLogout.ForeColor = Color.LightCoral;
        }

        private void labelLogoutMouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("로그아웃 되었습니다");
            FormMain frm = new FormMain();
            frm.Owner = this;
            frm.Show();
            this.Visible = false;
            DateTime EndTime = DateTime.Now;
            TimeSpan timeCal = EndTime - StartTime;
            int timeCalHour = timeCal.Hours;
            workhourTableAdapter1.Fill(dataSet11.WORKHOUR);
            WorkHourTable = dataSet11.Tables["workhour"];
            WorkHourTable.DefaultView.Sort = "work_date desc";
            string str = "employ_id='" + id + "'";
            DataRow[] foundRows = WorkHourTable.Select(str);
            DateTime dateTime;
            string hourlywage = "";

            foreach (DataRow mydataRow in foundRows)
            {
                dateTime = Convert.ToDateTime(mydataRow["work_date"]);
                hourlywage = mydataRow["work_hourlywage"].ToString();
            }
            if (int.Parse(hourlywage) > 0)
            {
                oracleCommand1.CommandText = "insert into workhour values('" + id + "','" + timeCalHour + "','" + hourlywage + "'," + StartTime + ")";
                oracleCommand1.ExecuteNonQuery();
            }
            oracleConnection1.Close();
        }

        private void labelMyInfoClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEmployMyPage frm = new FormEmployMyPage(mainform, id, StartTime);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormEmployMoney_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            listBox1.Items.Clear();
            workhourTableAdapter1.Fill(dataSet11.WORKHOUR);
            WorkHourTable = dataSet11.Tables["WORKHOUR"];
            string str = "employ_id='" + id + "'";

            DataRow[] foundRows = WorkHourTable.Select(str);
            int Totalhour = 0;
            int hour = 0;
            int hourlywage = 0;
            int money = 0;
            foreach (DataRow mydataRow in foundRows)
            {
                if (Convert.ToDateTime(mydataRow["work_date"].ToString()).Month == monthCalendar1.SelectionRange.Start.Month)
                {
                    hour = int.Parse(mydataRow["work_time"].ToString());
                    Totalhour += hour;
                    hourlywage = int.Parse(mydataRow["work_hourlywage"].ToString());
                    DateTime day = Convert.ToDateTime(mydataRow["work_date"]);
                    string date = day.Year + "-" + day.Month + "-" + day.Day;

                    listBox1.Items.Add(date + "\t" + mydataRow["work_time"]);
                    money += hour * hourlywage;
                }
            }
            textBoxTime.Text = Totalhour.ToString();
            textBoxhourlywage.Text = hourlywage.ToString();
            textBoxMoney.Text = money.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEmployMode frm = new FormEmployMode(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }
    }
}
