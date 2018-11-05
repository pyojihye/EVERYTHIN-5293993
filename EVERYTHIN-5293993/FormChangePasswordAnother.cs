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
    public partial class FormChangePasswordAnother : Form
    {
        FormMain mainform;
        string mode;

        public FormChangePasswordAnother(FormMain mainform, string mode)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.mode = mode;
        }

        private void textBoxPasswdName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonConfirmClick(sender, e);
            }
        }

        private void buttonConfirmClick(object sender, EventArgs e)
        {
            string id = textBoxPasswdID.Text;
            string name = textBoxPasswdName.Text;

            if (name != "")
            {
                switch (mode)
                {
                    case "직원":
                        oracleCommand1.CommandText = "select employ_password from employee where employ_id='" + id + "' AND employ_name='" + name + "'";
                        break;
                    case "관리자":
                        oracleCommand1.CommandText = "select admin_password from administer where admin_id='" + id + "' AND admin_name='" + name + "'";
                        break;
                }
                OracleDataReader rdr = oracleCommand1.ExecuteReader();
                int flag = 0;
                while (rdr.Read())
                {
                    FormChangePasswordData frm = new FormChangePasswordData(mainform, mode, id, rdr[0].ToString());
                    frm.Owner = this;
                    frm.Show();
                    this.Visible = false;
                    flag++;
                }
                oracleConnection1.Close();
                if (flag == 0)
                {
                    MessageBox.Show("해당하는 정보의 사용자가 없습니다.");
                }
            }
            else
            {
                MessageBox.Show("모든 값을 입력해 주세요");
            }
        }

        private void FormChangePasswordAnother_Load(object sender, EventArgs e)
        {
            oracleConnection1.Open();
        }
    }
}
