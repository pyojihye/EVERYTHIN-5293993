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
    public partial class FormAdminEmployChart : Form
    {
        FormMain mainform;

        public FormAdminEmployChart(FormMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void FormEmployChart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormEmployChart_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.EMPLOYCHART' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.eMPLOYCHARTTableAdapter.Fill(this.dataSet1.EMPLOYCHART);
        }

        private void labelTotalSearchClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminEmploy frm = new FormAdminEmploy(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void labelCateSearchClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminEmployMoney frm = new FormAdminEmployMoney(mainform);
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
    }
}
