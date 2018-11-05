using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace EVERYTHIN_5293993
{
    public partial class FormAdminEmploy : Form
    {
        FormMain mainform;
        DataTable EmployTable;
        string EmployID;
        DataTable EmpTable;
        DataTable WorkHourTable;

        public FormAdminEmploy(FormMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminMode frm = new FormAdminMode(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormAdminEmploy_Load(object sender, EventArgs e)
        {
            employeeTableAdapter1.Fill(dataSet11.EMPLOYEE);
            EmpTable = dataSet11.Tables["EMPLOYEE"];

            DataRow[] foundRows = EmpTable.Select();

            foreach (DataRow mydataRow in foundRows)
            {
                listBox1.Items.Add(mydataRow["employ_name"]);
            }
        }

        private void FormAdminEmploy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonModifyClick(object sender, EventArgs e)
        {
            workhourTableAdapter1.Fill(dataSet11.WORKHOUR);
            WorkHourTable = dataSet11.Tables["workhour"];
            string str = "employ_id='" + EmployID + "'";
            DataRow[] mydatarow = WorkHourTable.Select(str);

            foreach (DataRow mydata in mydatarow)
            {
                mydata["work_hourlywage"] = textBox2.Text;
            }

            this.workhourTableAdapter1.Update(dataSet11.WORKHOUR);
            MessageBox.Show("값이 변경되었습니다.");
        }

        private void labelCateSearchClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminEmployMoney frm = new FormAdminEmployMoney(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminEmployChart frm = new FormAdminEmployChart(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeeworkhourTableAdapter1.Fill(dataSet11.EMPLOYEEWORKHOUR);
            EmployTable = dataSet11.Tables["EMPLOYEEWORKHOUR"];
            string str = "employ_name='" + listBox1.Items[listBox1.SelectedIndex] + "'";

            DataRow[] foundRows = EmployTable.Select(str);

            foreach (DataRow mydataRow in foundRows)
            {
                textBoxID.Text = mydataRow["employ_id"].ToString();
                textBoxName.Text = mydataRow["employ_name"].ToString();
                textBoxEmail.Text = mydataRow["employ_email"].ToString();
                textBox1.Text= mydataRow["totalTime"].ToString();
                textBox2.Text= mydataRow["work_hourlywage"].ToString();
                break;
            }
            EmployID = textBoxID.Text;
        }
    }
}
