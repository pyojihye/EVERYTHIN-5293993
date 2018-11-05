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
    public partial class FormEmployMode : Form
    {
        private FormMain mainform;
        private string id;
        public DateTime StartTime;
        public DateTime EndTime;
        DataTable workTimeTable;

        public FormEmployMode(FormMain mainform, string id)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.id = id;
        }

        private void FormEmployMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Owner = this;
            frm.Show();
            this.Visible = false;
            EndTime = DateTime.Now;
            TimeSpan timeCal = EndTime - StartTime;
            int timeCalHour = timeCal.Hours;
            workhourTableAdapter1.Fill(dataSet11.WORKHOUR);
            workTimeTable = dataSet11.Tables["workhour"];
            workTimeTable.DefaultView.Sort = "work_date desc";
            string str = "employ_id='" + id + "'";
            DataRow[] foundRows = workTimeTable.Select(str);
            DateTime dateTime;
            string hourlywage = "";

            foreach (DataRow mydataRow in foundRows)
            {
                dateTime = Convert.ToDateTime(mydataRow["work_date"]);
                hourlywage = mydataRow["work_hourlywage"].ToString();
            }
            if (timeCalHour > 0)
            {
                string date = StartTime.Year + "-" + StartTime.Month + "-" + StartTime.Day;
                oracleCommand1.CommandText = "insert into workhour values('" + id + "','" + timeCalHour + "','" + hourlywage + "',TO_DATE('" + date + "', 'YYYY-MM-DD')" + ")";
                oracleCommand1.ExecuteNonQuery();
            }
        }

        private void buttonRentalClick(object sender, EventArgs e)
        {
            FormEmployRental frm = new FormEmployRental(mainform, id);
            frm.Owner = this;
            frm.Show();
            this.Visible = false;
        }

        private void buttonReturnClick(object sender, EventArgs e)
        {
            FormEmployReturn frm = new FormEmployReturn(mainform, id);
            frm.Owner = this;
            frm.Show();
            this.Visible = false;
        }

        private void buttonMyPageClick(object sender, EventArgs e)
        {
            FormEmployMyPage frm = new FormEmployMyPage(mainform, id, StartTime);
            frm.Owner = this;
            frm.Show();
            this.Visible = false;
        }

        private void buttonSearchClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEmploySearch frm = new FormEmploySearch(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormEmployMode_Load(object sender, EventArgs e)
        {
            StartTime = DateTime.Now;
        }
    }
}
