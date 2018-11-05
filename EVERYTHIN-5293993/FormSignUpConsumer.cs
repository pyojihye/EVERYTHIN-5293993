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
    public partial class FormSignUpConsumer : Form
    {
        private FormMain mainform;
        private string mode;
        DataTable consumerTable;

        public FormSignUpConsumer(FormMain mainform, string mode)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.mode = mode;
        }

        //회원가입 폼이 로드 되었을 때
        private void FormSignUpConsumer_Load(object sender, EventArgs e)
        {
            oracleConnection1.Open();
            consumerTableAdapter1.Fill(dataSet11.CONSUMER);
            consumerTable = dataSet11.Tables["consumer"];
        }

        //중복 체크 버튼을 눌렀을 때
        private void buttonDoubleCheckClicked(object sender, EventArgs e)
        {
            if (textBoxID.Text != "")
            {
                string id;
                switch (mode)
                {
                    case "고객":
                        id = "consu_id= '" + textBoxID.Text + "'";
                        SearchSignUp(consumerTable, id);
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

        //회원가입 완료 버튼을 눌렀을 때
        private void buttonConfirmClicked(object sender, EventArgs e)
        {
            if (buttonDoubleCheck.Enabled == false)
            {
                string id = textBoxID.Text;
                string password = textBoxPasswd.Text;
                string name = textBoxName.Text;
                string email = textBoxEmail.Text;
                DateTime birth = dateTimePickerBirth.Value.Date;
                if (id != "" && password != "" && name != "" && email != "")
                {
                    if (mode.Equals("고객"))
                    {
                        oracleCommand1.CommandText = "insert into consumer values(:id,:password,:name,:email,:birth,'F',0)";
                        oracleCommand1.Parameters["id"].Value = id;
                        oracleCommand1.Parameters["password"].Value = password;
                        oracleCommand1.Parameters["name"].Value = name;
                        oracleCommand1.Parameters["email"].Value = email;
                        oracleCommand1.Parameters["birth"].Value = birth;
                    }
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
