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
    public partial class FormEmployConsuInfo : Form
    {
        FormEmploySearchConsu ConsuForm;
        string name;
        string id;
        DataTable ConsumerTable;
        DataTable FineTable;

        public FormEmployConsuInfo(FormEmploySearchConsu ConsuForm, string name, string id)
        {
            InitializeComponent();
            this.ConsuForm = ConsuForm;
            this.name = name;
            this.id = id;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string str = "consu_name='" + textBoxName.Text + "' AND consu_id='" + textBoxID.Text + "'";
            ChangePassword(ConsumerTable, str);
            int a = consumerTableAdapter1.Update(dataSet11.CONSUMER);
            MessageAlert(a);
            ConsuForm.F5(sender, e);
            this.Visible = false;
        }

        private void ChangePassword(DataTable mytable, string str)
        {
            DataRow[] mydataRow = mytable.Select(str);
            foreach (DataRow mydata in mydataRow)
            {
                if (mydata["consu_blackconsumer"].Equals("F"))
                {
                    mydata["consu_blackconsumer"] = "T";
                }
                else
                {
                    mydata["consu_blackconsumer"] = "F";
                }

            }
        }

        private void MessageAlert(int a)
        {
            if (a == 1)
            {
                MessageBox.Show("회원 정보를 변경하였습니다");
                ConsuForm.Activate();
            }
        }

        private void FormEmployConsuInfo_Load(object sender, EventArgs e)
        {
            consumerTableAdapter1.Fill(dataSet11.CONSUMER);
            ConsumerTable = dataSet11.Tables["consumer"];
            fineTableAdapter1.Fill(dataSet11.FINE);
            FineTable = dataSet11.Tables["fine"];

            string str = "consu_id='" + name + "'";
            DataRow[] foundRows = ConsumerTable.Select(str);
            foreach (DataRow mydataRow in foundRows)
            {
                textBoxID.Text = mydataRow["consu_id"].ToString();
                textBoxName.Text = mydataRow["consu_name"].ToString();
                textBoxEmail.Text = mydataRow["consu_email"].ToString();
                textBoxMileage.Text = mydataRow["consu_mileage"].ToString();
                if (mydataRow["consu_blackconsumer"].ToString().Equals("T"))
                {
                    checkBox1.Checked = true;
                }
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
    }
}
