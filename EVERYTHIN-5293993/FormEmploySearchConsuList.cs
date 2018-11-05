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
    public partial class FormEmploySearchConsuList : Form
    {
        FormEmployRental rentalForm;
        DataTable ConsumerTable;
        string name = "";
        Boolean check = false;

        public FormEmploySearchConsuList(FormEmployRental rentalForm)
        {
            InitializeComponent();
            this.rentalForm = rentalForm;
        }

        private void FormEmploySearchConsuList_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.CONSUMER' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.cONSUMERTableAdapter.Fill(this.dataSet1.CONSUMER);
            cONSUMERTableAdapter.Fill(dataSet1.CONSUMER);
            ConsumerTable = dataSet1.Tables["CONSUMER"];
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearchClick(sender, e);
            }
        }

        private void buttonConfirmClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells != null && name.Equals("") == false)
            {
                rentalForm.SetData(name, check);
            }
            else
            {
                MessageBox.Show("다시 회원을 선택하여 주십시오.");
            }
            this.Visible = false;
        }

        private void FormEmploySearchConsuList_FormClosing(object sender, FormClosingEventArgs e)
        {
            buttonConfirmClick(sender, e);
            this.Visible = false;
        }

        private void buttonSearchClick(object sender, EventArgs e)
        {
            name = textBoxSearch.Text;
            cONSUMERBindingSource.Filter = "consu_name like '%" + name + "%'";
            cONSUMERBindingSource.Sort = "consu_name";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            buttonConfirm.Enabled = true;
            if ((dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()).Equals("T"))
            {
                check = true;
            }
            else
            {
                check = false;
            }
        }
    }
}
