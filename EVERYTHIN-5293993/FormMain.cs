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
    public partial class FormMain : Form
    {
        DataTable consumerTable;
        DataTable employeeTable;
        DataTable administerTable;

        public FormMain()
        {
            InitializeComponent();
        }

        private void DoubleClickLogo(object sender, EventArgs e)
        {
            switch (labelMode.Text)
            {
                case "고객":
                    labelMode.Text = "직원";
                    labelMode.Visible = true;
                    break;
                case "직원":
                    labelMode.Text = "관리자";
                    break;
                case "관리자":
                    labelMode.Text = "고객";
                    labelMode.Visible = false;
                    break;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxPasswd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLoginClicked(sender, e);
            }
        }

        private void buttonLoginClicked(object sender, EventArgs e)
        {
            consumerTableAdapter1.Fill(dataSet11.CONSUMER);
            consumerTable = dataSet11.Tables["consumer"];
            employeeTableAdapter1.Fill(dataSet11.EMPLOYEE);
            employeeTable = dataSet11.Tables["employee"];
            administerTableAdapter1.Fill(dataSet11.ADMINISTER);
            administerTable = dataSet11.Tables["administer"];

            string id = textBoxID.Text;
            string password = textBoxPasswd.Text;

            if (id != "" && password != "")
            {
                string str = null;
                switch (labelMode.Text)
                {
                    case "고객":
                        str = "consu_id='" + id + "' AND consu_password='" + password + "'";
                        SignUpInfo(consumerTable, str, 0);
                        break;

                    case "직원":
                        str = "employ_id='" + id + "' AND employ_password='" + password + "'";
                        SignUpInfo(employeeTable, str, 1);
                        break;

                    case "관리자":
                        str = "admin_id='" + id + "' AND admin_password='" + password + "'";
                        SignUpInfo(administerTable, str, 2);
                        break;
                }
            }
            else
            {
                MessageBox.Show("아이디와 비밀번호를 입력하여 주세요");
            }
        }

        public void SignUpInfo(DataTable mytable, string str, int mode)
        {
            DataRow[] foundRows = mytable.Select(str);
            int count = 0;

            foreach (DataRow mydataRow in foundRows)
            {
                this.Visible = false;
                switch (mode)
                {
                    case 0:
                        FormConsuMode searchFrm = new FormConsuMode(this, textBoxID.Text);
                        searchFrm.Owner = this;
                        searchFrm.Show();
                        break;
                    case 1:
                        FormEmployMode employFrm = new FormEmployMode(this, textBoxID.Text);
                        employFrm.Owner = this;
                        employFrm.Show();
                        break;
                    case 2:
                        FormAdminMode adminFrm = new FormAdminMode(this);
                        adminFrm.Owner = this;
                        adminFrm.Show();
                        break;
                }
                count++;
            }
            if (count == 0)
            {
                MessageBox.Show("아이디 또는 비밀번호를 잘못 입력하셨습니다.\n아이디/비밀번호 찾기를 이용해보세요.");
            }
        }

        private void FindIdPasswdClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormFindChange frm = new FormFindChange(this, labelMode.Text);
            frm.Owner = this;
            frm.Show();
        }

        private void SignUpClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (labelMode.Text)
            {
                case "고객":
                    FormSignUpConsumer frm = new FormSignUpConsumer(this, labelMode.Text);
                    frm.Owner = this;
                    frm.Show();
                    break;
                case "직원":
                    FormSignUpAnother frm2 = new FormSignUpAnother(this, labelMode.Text);
                    frm2.Owner = this;
                    frm2.Show();
                    break;
                case "관리자":
                    FormSignUpAnother frm3 = new FormSignUpAnother(this, labelMode.Text);
                    frm3.Owner = this;
                    frm3.Show();
                    break;
            }
        }
    }
}
