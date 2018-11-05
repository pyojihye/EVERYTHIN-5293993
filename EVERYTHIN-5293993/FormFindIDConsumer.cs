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
    public partial class FormFindIDConsumer : Form
    {
        private FormMain mainform;

        public FormFindIDConsumer(FormMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void FormFindIDConsumer_Load(object sender, EventArgs e)
        {
            oracleConnection1.Open();
        }

        //확인버튼을 눌렀을 때
        private void buttonConfirmClicked(object sender, EventArgs e)
        {
            string name = textBoxFindIdName.Text;
            DateTime date = dateTimePickerBirth.Value.Date;
            string birth = date.Year + "-" + date.Month + "-" + date.Day;

            if (name != "")
            {
                oracleCommand1.CommandText = "select consu_id from consumer where consu_name='" + name + "' AND consu_birth=TO_DATE('" + birth + "', 'YYYY-MM-DD')";
                OracleDataReader rdr = oracleCommand1.ExecuteReader();
                int flag = 0;
                while (rdr.Read())
                {
                    MessageBox.Show("아이디는 " + rdr["consu_id"] + "입니다");
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
                MessageBox.Show("이름을 입력해 주세요");
            }
        }
    }
}
