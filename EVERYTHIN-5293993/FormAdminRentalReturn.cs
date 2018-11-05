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
    public partial class FormAdminRentalReturn : Form
    {
        FormMain mainform;
        DataTable RentalTable;

        public FormAdminRentalReturn(FormMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void FormAdminRentalReturn_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FormAdminRentalReturn_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.RENTAL' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.rENTALTableAdapter.Fill(this.dataSet1.RENTAL);
            RentalTable = dataSet1.Tables["rental"];
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
            string str = String.Format("'" + first + "' <= REN_DATE AND REN_DATE<='" + now + "'");

            rENTALBindingSource.Filter = str;
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
            string str = String.Format("'" + first + "' <= REN_DATE AND REN_DATE<='" + now + "'");

            rENTALBindingSource.Filter = str;
        }

        private void labelCateSearch_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminRentalReturn2 frm = new FormAdminRentalReturn2(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminRentalReturn3 frm = new FormAdminRentalReturn3(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }
    }
}
