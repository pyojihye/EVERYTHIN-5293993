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
    public partial class FormConsuRentalReturn : Form
    {
        FormMain mainform;
        string id;
        DataTable consumerTable;
        DataTable returnTable;
        DataTable rentalTable;

        public FormConsuRentalReturn(FormMain mainform, string id)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.id = id;
        }

        private void FormConsuRentalReturn_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.RETURN' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.rETURNTableAdapter.Fill(this.dataSet1.RETURN);
            // TODO: 이 코드는 데이터를 'dataSet1.RENTAL' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.rENTALTableAdapter.Fill(this.dataSet1.RENTAL);
            

            rENTALBindingSource.Filter = "consu_id='" + id + "'";
            rETURNBindingSource.Filter = "consu_id='" + id + "'";

            consumerTableAdapter1.Fill(dataSet1.CONSUMER);
            consumerTable = dataSet1.Tables["CONSUMER"];

            rentalTable = dataSet1.Tables["RENTAL"];
            returnTable = dataSet1.Tables["RETURN"];
        }

        private void labelMyInfoClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuMyPage frm = new FormConsuMyPage(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void labelMileClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuMile frm = new FormConsuMile(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
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

        private void FormConsuRentalReturn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuMode frm = new FormConsuMode(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            FormConsuReview frm = new FormConsuReview(mainform, this, id, dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }
    }
}
