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
    public partial class FormFindIDAnother : Form
    {
        FormMain mainform;
        string mode;

        public FormFindIDAnother(FormMain mainform, string mode)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.mode = mode;
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonConfirmClick(sender, e);
            }
        }

        private void FormFindIDAnother_Load(object sender, EventArgs e)
        {
            oracleConnection1.Open();
        }

        private void buttonConfirmClick(object sender, EventArgs e)
        {
            string name = textBoxFindIdName.Text;
            string email = textBoxEmail.Text;

            if (name != "" && email != "")
            {
                switch (mode)
                {
                    case "직원":
                        oracleCommand1.CommandText = "select employ_id from employee where employ_name='" + name + "' AND employ_email='" + email + "'";
                        break;
                    case "관리자":
                        oracleCommand1.CommandText = "select admin_id from administer where admin_name='" + name + "' AND admin_email='" + email + "'";
                        break;
                }
                OracleDataReader rdr = oracleCommand1.ExecuteReader();
                int flag = 0;
                while (rdr.Read())
                {
                    MessageBox.Show("아이디는 " + rdr[0] + "입니다");
                    flag++;
                    this.Visible = false;
                    mainform.Activate();
                }
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
    }
}
