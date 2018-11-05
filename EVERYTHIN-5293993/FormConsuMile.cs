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
    public partial class FormConsuMile : Form
    {
        private FormMain mainform;
        string id;
        DataTable mileTable;

        public FormConsuMile(FormMain mainform, string id)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.id = id;
        }

        private void FormConsuMile_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.MILEAGE' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.mILEAGETableAdapter.Fill(this.dataSet1.MILEAGE);
            mileTable = dataSet1.Tables["MILEAGE"];
            mILEAGEBindingSource.Filter = "consu_id='" + id + "'";
        }

        private void labelLogoutMouseDown(object sender, MouseEventArgs e)
        {
            labelLogout.ForeColor = Color.LightCoral;
        }

        private void labelLogoutMouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("로그아웃 되었습니다");
            this.Visible = false;
            FormMain frm = new FormMain();
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void labelMyInfoClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuMyPage frm = new FormConsuMyPage(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void labelRentalReturnClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuRentalReturn frm = new FormConsuRentalReturn(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormConsuMile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuMode frm = new FormConsuMode(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }
    }
}
