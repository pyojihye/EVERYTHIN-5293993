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
    public partial class FormChangePasswordConsumer : Form
    {
        private FormMain mainform;

        public FormChangePasswordConsumer(FormMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void FormChangePasswordConsumer_Load(object sender, EventArgs e)
        {
            oracleConnection1.Open();
        }

        //확인버튼을 눌렀을 때
        private void buttonConfirmClicked(object sender, EventArgs e)
        {
            string id = textBoxPasswdID.Text;
            string name = textBoxPasswdName.Text;
            DateTime date = dateTimePickerBirth.Value.Date;
            string birth = date.Year + "-" + date.Month + "-" + date.Day;

            if (name != "")
            {
                oracleCommand1.CommandText = "select consu_password from consumer where consu_id='" + id + "' AND consu_name='" + name + "' AND consu_birth=TO_DATE('" + birth + "', 'YYYY-MM-DD')";
                OracleDataReader rdr = oracleCommand1.ExecuteReader();
                int flag = 0;
                while (rdr.Read())
                {
                    FormChangePasswordData searchFrm = new FormChangePasswordData(mainform, "고객", id, rdr[0].ToString());
                    searchFrm.Owner = this;
                    searchFrm.Show();
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
    }
}
