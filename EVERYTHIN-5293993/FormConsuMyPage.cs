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
using Oracle.DataAccess.Types;

namespace EVERYTHIN_5293993
{
    public partial class FormConsuMyPage : Form
    {
        private FormMain mainform;
        string id;
        DataTable consumerTable;

        public FormConsuMyPage(FormMain mainform, string id)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.id = id;
        }

        private void FormMyPageConsu_Load(object sender, EventArgs e)
        {
            consumerTableAdapter1.Fill(dataSet11.CONSUMER);
            consumerTable = dataSet11.Tables["consumer"];
            string str = "consu_id='" + id + "'";

            DataRow[] foundRows = consumerTable.Select(str);

            foreach (DataRow mydataRow in foundRows)
            {
                textBoxID.Text = mydataRow["consu_id"].ToString();
                textBoxName.Text = mydataRow["consu_name"].ToString();
                dateTimePickerBirth.Value = Convert.ToDateTime(mydataRow["consu_birth"]);
            }
            oracleConnection1.Open();
            oracleCommand2.Connection = oracleConnection1;
            oracleCommand2.CommandText = "SELECT * FROM ConsuPictures WHERE consu_id = '" + textBoxID.Text + "'";
            OracleDataReader rdr = oracleCommand2.ExecuteReader();

            if (rdr.HasRows) // 검색 결과가 있으면
            {
                while (rdr.Read())
                {
                    //BLOB_DEMO (blob_id, file_name, media_file)
                    OracleBlob blobData = rdr.GetOracleBlob(2); // 0, 1, 2 즉 3번째 컬럼이 blob
                    byte[] conten = new Byte[blobData.Length];
                    int i = blobData.Read(conten, 0, Convert.ToInt32(blobData.Length));

                    System.IO.MemoryStream memStream = new System.IO.MemoryStream(conten);

                    // blob에서 가져온 이미지를 화면에 출력 
                    pictureBox3.Image = Image.FromStream(memStream);
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            oracleConnection1.Close();
        }

        private void FormMyPageConsu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
                    string str = "consu_id='" + id + "'";
                    ChangePassword(consumerTable, str);
                    int a = consumerTableAdapter1.Update(dataSet11.CONSUMER);
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
                mydata["consu_password"] = textBoxPassword.Text;
                mydata["consu_email"] = textBoxEmail.Text;
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

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonModifyClick(sender, e);
            }
        }

        private void labelLogoutMouseDown(object sender, MouseEventArgs e)
        {
            labelLogout.ForeColor = Color.LightCoral;
        }

        private void labelLogoutMouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("로그아웃 되었습니다");
            this.Visible = false;
            FormMain frm = new FormMain();
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void labelRentalReuturnClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuRentalReturn frm = new FormConsuRentalReturn(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void labelMileClick(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuMile frm = new FormConsuMile(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConsuMode frm = new FormConsuMode(mainform, id);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oracleConnection1.Open();
            string fullPathName = "";
            // BLOB_DEMO (blob_id, file_name, media_file)
            OpenFileDialog open = openFileDialog1; // 도구 상자에서 추가
            open.Filter = "ImageType(jpg, bmp)|*.jpg;*.bmp";
            open.Multiselect = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                fullPathName = open.FileName;
                pictureBox3.Image = Image.FromFile(open.FileName);
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            // Save files to Oracle DB, 

            System.IO.FileStream fs =
                      new System.IO.FileStream(fullPathName,
                             System.IO.FileMode.Open, System.IO.FileAccess.Read);
            byte[] b = new byte[fs.Length - 1];
            fs.Read(b, 0, b.Length);
            fs.Close();

            oracleCommand1.Connection = oracleConnection1;
            
            oracleCommand1.CommandText = "select * from consupictures where consu_id='" + textBoxID.Text + "'";
            OracleDataReader rdr = oracleCommand1.ExecuteReader();

            if (rdr.HasRows)
            {
                oracleCommand1.CommandText = "update ConsuPictures set file_name=:fname, media_file=:img_file where consu_id='" + textBoxID.Text + "'";
                oracleCommand1.Parameters[0].Value = fullPathName;
                oracleCommand1.Parameters[1].Size = b.Length;
                oracleCommand1.Parameters[1].Value = b;
                int result = oracleCommand1.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("사진이 등록되었습니다.");
                }
                else
                {
                    MessageBox.Show("사진 등록이 실패되었습니다.");
                }
            }
            else
            {
                oracleCommand1.CommandText = "INSERT INTO ConsuPictures VALUES ('" + textBoxID.Text + "', :fname, :img_file)";

                oracleCommand1.Parameters[0].Value = fullPathName;
                oracleCommand1.Parameters[1].Size = b.Length;
                oracleCommand1.Parameters[1].Value = b;
                int result = oracleCommand1.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("사진이 등록되었습니다.");
                }
                else
                {
                    MessageBox.Show("사진 등록이 실패되었습니다.");
                }
            }
            oracleConnection1.Close();
        }
    }
}
