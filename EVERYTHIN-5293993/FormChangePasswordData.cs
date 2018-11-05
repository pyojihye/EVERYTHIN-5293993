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
    public partial class FormChangePasswordData : Form
    {
        FormMain mainform;
        string mode;
        DataTable consumerTable;
        DataTable employeeTable;
        DataTable administerTable;
        string id;
        string password;

        public FormChangePasswordData(FormMain mainform, string mode, string id, string password)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.mode = mode;
            this.id = id;
            this.password = password;
        }

        private void FormChangePasswordData_Load(object sender, EventArgs e)
        {
            consumerTableAdapter1.Fill(dataSet11.CONSUMER);
            consumerTable = dataSet11.Tables["consumer"];
            employeeTableAdapter1.Fill(dataSet11.EMPLOYEE);
            employeeTable = dataSet11.Tables["employee"];
            administerTableAdapter1.Fill(dataSet11.ADMINISTER);
            administerTable = dataSet11.Tables["administer"];
        }


        private void textBoxChangePasswd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonChangeClick(sender, e);
            }
        }

        private void buttonChangeClick(object sender, EventArgs e)
        {
            string str;
            int a;
            switch (mode)
            {
                case "고객":
                    str = "consu_id='" + id + "' AND consu_password='" + password + "'";
                    ChangePassword(consumerTable, str);
                    a = consumerTableAdapter1.Update(dataSet11.CONSUMER);
                    MessageAlert(a);
                    break;
                case "직원":
                    str = "employ_id='" + id + "' AND employ_password='" + password + "'";
                    ChangePassword(employeeTable, str);
                    a = employeeTableAdapter1.Update(dataSet11.EMPLOYEE);
                    MessageAlert(a);
                    break;
                case "관리자":
                    str = "admin_id='" + id + "' AND admin_password='" + password + "'";
                    ChangePassword(administerTable, str);
                    a = administerTableAdapter1.Update(dataSet11.ADMINISTER);
                    MessageAlert(a);
                    break;
            }

        }

        private void ChangePassword(DataTable mytable, string str)
        {
            DataRow[] mydataRow = mytable.Select(str);
            foreach (DataRow mydata in mydataRow)
            {
                mydata[1] = textBoxChangePasswd.Text;
            }
        }

        private void MessageAlert(int a)
        {
            if (a == 1)
            {
                MessageBox.Show("비밀번호가 변경되었습니다");
                this.Visible = false;
                mainform.Activate();
            }
            else
            {
                MessageBox.Show("비밀번호 변경이 실패되었습니다");
            }
        }
    }
}
