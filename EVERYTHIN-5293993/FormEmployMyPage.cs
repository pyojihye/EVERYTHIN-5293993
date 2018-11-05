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
    public partial class FormEmployMyPage : Form
    {
        FormMain mainform;
        string id;
        DataTable EmployeeTable;
        DateTime StartTime;
        DataTable workTimeTable;

        public FormEmployMyPage(FormMain mainform, string id, DateTime StartTime)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.id = id;
            this.StartTime = StartTime;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEmployMode frm = new FormEmployMode(mainform, id);
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
            FormMain frm = new FormMain();
            frm.Owner = this;
            frm.Show();
            this.Visible = false;
            DateTime EndTime = DateTime.Now;
            TimeSpan timeCal = EndTime - StartTime;
            int timeCalHour = timeCal.Hours;
            workhourTableAdapter1.Fill(dataSet11.WORKHOUR);
            workTimeTable = dataSet11.Tables["workhour"];
            workTimeTable.DefaultView.Sort = "work_date desc";
            string str = "employ_id='" + id + "'";
            DataRow[] foundRows = workTimeTable.Select(str);
            DateTime dateTime;
            string hourlywage = "";

            foreach (DataRow mydataRow in foundRows)
            {
                dateTime = Convert.ToDateTime(mydataRow["work_date"]);
                hourlywage = mydataRow["work_hourlywage"].ToString();
            }
            if (int.Parse(hourlywage) > 0)
            {
                oracleCommand1.CommandText = "insert into workhour values('" + id + "','" + timeCalHour + "','" + hourlywage + "'," + StartTime + ")";
                oracleCommand1.ExecuteNonQuery();
            }
            oracleConnection1.Close();
        }

        private void FormEmployMyPage_Load(object sender, EventArgs e)
        {
            employeeTableAdapter1.Fill(dataSet11.EMPLOYEE);
            EmployeeTable = dataSet11.Tables["EMPLOYEE"];
            string str = "employ_id='" + id + "'";

            DataRow[] foundRows = EmployeeTable.Select(str);

            foreach (DataRow mydataRow in foundRows)
            {
                textBoxID.Text = mydataRow["employ_id"].ToString();
                textBoxName.Text = mydataRow["employ_name"].ToString();
            }
        }

        private void buttonModifyClick(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            string passwordConfirm = textBoxPasswordConfirm.Text;
            string email = textBoxEmail.Text;
            if (password != "" && passwordConfirm != "" && email != "")
            {
                if (password.Equals(passwordConfirm))
                {
                    string str = "employ_id='" + id + "'";
                    ChangePassword(EmployeeTable, str);
                    int a = employeeTableAdapter1.Update(dataSet11.EMPLOYEE);
                    MessageAlert(a);
                }
                else
                {
                    MessageBox.Show("비밀번호와 비밀번호 확인이 같지 않습니다.");
                }

            }
            else
            {
                MessageBox.Show("모든 값을 제대로 넣어 주십시오");
            }
        }

        private void ChangePassword(DataTable mytable, string str)
        {
            DataRow[] mydataRow = mytable.Select(str);
            foreach (DataRow mydata in mydataRow)
            {
                mydata["employ_password"] = textBoxPassword.Text;
                mydata["employ_email"] = textBoxEmail.Text;
            }
        }

        private void MessageAlert(int a)
        {
            if (a == 1)
            {
                MessageBox.Show("비밀번호가 변경되었습니다");

                mainform.Activate();
            }
            else
            {
                MessageBox.Show("비밀번호 변경이 실패되었습니다");
            }
        }

        private void labelMoneyClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEmployMoney frm = new FormEmployMoney(mainform, id, StartTime);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormEmployMyPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
