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
    public partial class FormConsuReview : Form
    {
        FormMain mainform;
        string id;
        string itemName;
        DataTable itemTable;
        FormConsuRentalReturn rentalReturnForm;

        public FormConsuReview(FormMain mainform, FormConsuRentalReturn rentalReturnForm, string id, string itemName)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.id = id;
            this.itemName = itemName;
            this.rentalReturnForm = rentalReturnForm;
        }

        private void buttonClearClick(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonSubmitClick(object sender, EventArgs e)
        {
            oracleConnection1.Open();
            if (textBox1.Text == "")
            {
                MessageBox.Show("내용을 입력하여 주십시오.");
            }
            else
            {
                itemTableAdapter1.Fill(dataSet11.ITEM);
                itemTable = dataSet11.Tables["item"];
                DataRow[] foundrows = itemTable.Select("item_id='" + itemName + "'");
                foreach (DataRow mydataRow in foundrows)
                {
                    string day = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                    oracleCommand1.CommandText = "insert into review values('" + id + "','" + mydataRow["item_id"] + "','" + mydataRow["cate_id"] + "','" + textBox1.Text + "',to_date('" + day + "','YYYY-MM-DD')," + comboBox1.Text + ")";
                    int a = oracleCommand1.ExecuteNonQuery();
                    MessageBox.Show("후기가 저장되었습니다!");

                }
            }
            oracleConnection1.Close();
            this.Close();
            rentalReturnForm.Activate();
        }
    }
}
