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
    public partial class FormConsuSearchAge : Form
    {
        FormMain mainform;
        string id;

        public FormConsuSearchAge(FormMain mainform, string id)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.id = id;
        }

        private void labelTotalSearchClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuSearchTotal frm = new FormConsuSearchTotal(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void labelCateSearchClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuSearchCate frm = new FormConsuSearchCate(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void labelBestSellerClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuSearchBestSeller frm = new FormConsuSearchBestSeller(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void labelNewItemSearchClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuSearchNewItem frm = new FormConsuSearchNewItem(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuMode frm = new FormConsuMode(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormConsuSearchAge_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.ITEMAGERENTAL' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            //this.iTEMAGERENTALTableAdapter.Fill(this.dataSet1.ITEMAGERENTAL);
        }

        private void FormConsuSearchAge_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void labelAgeClick(object sender, EventArgs e)
        {
            Label age = (Label)sender;
            switch (age.Text)
            {
                case "10대":
                    label10.ForeColor = Color.LightPink;
                    label20.ForeColor = Color.White;
                    label30.ForeColor = Color.White;
                    label40.ForeColor = Color.White;
                    label50.ForeColor = Color.White;
                    this.itemagerentalTableAdapter1.Fill(this.dataSet1.ITEMAGERENTAL);
                    iTEMAGERENTALBindingSource.Filter = "10<=age AND age<20";
                    break;

                case "20대":
                    label10.ForeColor = Color.White;
                    label20.ForeColor = Color.LightPink;
                    label30.ForeColor = Color.White;
                    label40.ForeColor = Color.White;
                    label50.ForeColor = Color.White;
                    this.itemagerentalTableAdapter1.Fill(this.dataSet1.ITEMAGERENTAL);
                    iTEMAGERENTALBindingSource.Filter = "20<=age AND age<30";
                    break;

                case "30대":
                    label10.ForeColor = Color.White;
                    label20.ForeColor = Color.White;
                    label30.ForeColor = Color.LightPink;
                    label40.ForeColor = Color.White;
                    label50.ForeColor = Color.White;
                    this.itemagerentalTableAdapter1.Fill(this.dataSet1.ITEMAGERENTAL);
                    iTEMAGERENTALBindingSource.Filter = "30<=age AND age<40";
                    break;

                case "40대":
                    label10.ForeColor = Color.White;
                    label20.ForeColor = Color.White;
                    label30.ForeColor = Color.White;
                    label40.ForeColor = Color.LightPink;
                    label50.ForeColor = Color.White;
                    this.itemagerentalTableAdapter1.Fill(this.dataSet1.ITEMAGERENTAL);
                    iTEMAGERENTALBindingSource.Filter = "40<=age AND age<50";
                    break;

                case "50대 ~":
                    label10.ForeColor = Color.White;
                    label20.ForeColor = Color.White;
                    label30.ForeColor = Color.White;
                    label40.ForeColor = Color.White;
                    label50.ForeColor = Color.LightPink;
                    this.itemagerentalTableAdapter1.Fill(this.dataSet1.ITEMAGERENTAL);
                    iTEMAGERENTALBindingSource.Filter = "50<=age";
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormConsuItemInfo frm = new FormConsuItemInfo(mainform, dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }
    }
}
