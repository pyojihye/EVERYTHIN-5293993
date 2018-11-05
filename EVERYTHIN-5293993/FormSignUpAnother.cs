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
    public partial class FormSignUpAnother : Form
    {
        private FormMain mainform;
        private string mode;
        DataTable employeeTable;
        DataTable administerTable;

        public FormSignUpAnother(FormMain mainform, string mode)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.mode = mode;
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonConfirmClicked(sender, e);
            }
        }

        private void FormSignUpAnother_Load(object sender, EventArgs e)
        {
            oracleConnection1.Open();
            employeeTableAdapter1.Fill(dataSet11.EMPLOYEE);
            employeeTable = dataSet11.Tables["employee"];
            administerTableAdapter1.Fill(dataSet11.ADMINISTER);
            administerTable = dataSet11.Tables["administer"];
        }

        private void buttonDoubleCheckClicked(object sender, EventArgs e)
        {
            if (textBoxID.Text != "")
            {
                string id;
                switch (mode)
                {
                    case "직원":
                        id = "employ_id= '" + textBoxID.Text + "'";
                        SearchSignUp(employeeTable, id);
                        break;
                    case "관리자":
                        id = "admin_id= '" + textBoxID.Text + "'";
                        SearchSignUp(administerTable, id);
                        break;
                }
            }
            else
            {
                MessageBox.Show("아이디를 입력하여 주세요");
            }
        }

        private void SearchSignUp(DataTable mytable, string id)
        {
            DataRow[] foundRows = mytable.Select(id);
            int flag = 0;

            foreach (DataRow mydataRow in foundRows)
            {
                MessageBox.Show("이미 존재하는 아이디 입니다.");
                flag++;
            }
            if (flag == 0)
            {
                MessageBox.Show("사용 가능한 아이디 입니다");
                buttonDoubleCheck.Enabled = false;
            }
        }

        private void buttonConfirmClicked(object sender, EventArgs e)
        {
            if (buttonDoubleCheck.Enabled == false)
            {
                string id = textBoxID.Text;
                string password = textBoxPasswd.Text;
                string name = textBoxName.Text;
                string email = textBoxEmail.Text;
                if (id != "" && password != "" && name != "" && email != "")
                {
                    switch (mode)
                    {
                        case "직원":
                            oracleCommand1.CommandText = "insert into employee values(:id,:password,:name,:email)";
                            break;
                        case "관리자":
                            oracleCommand1.CommandText = "insert into administer values(:id,:password,:name,:email)";
                            break;
                    }
                    oracleCommand1.Parameters["id"].Value = id;
                    oracleCommand1.Parameters["password"].Value = password;
                    oracleCommand1.Parameters["name"].Value = name;
                    oracleCommand1.Parameters["email"].Value = email;
                    oracleCommand1.ExecuteNonQuery();
                    MessageBox.Show("회원가입 성공!");
                    this.Visible = false;
                    mainform.Activate();
                }
                else
                {
                    MessageBox.Show("모든 값을 제대로 넣어 주십시오");
                }
            }
            else
            {
                MessageBox.Show("중복 확인을 해주세요");
            }
        }
    }
}
