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
    public partial class FormAdminConsu : Form
    {
        FormMain mainform;
        DataTable ConsuTable;

        public FormAdminConsu(FormMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void FormAdminConsu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminMode frm = new FormAdminMode(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormAdminConsu_Load(object sender, EventArgs e)
        {
            consumerTableAdapter1.Fill(dataSet11.CONSUMER);
            ConsuTable = dataSet11.Tables["CONSUMER"];

            DataRow[] foundRows = ConsuTable.Select();

            foreach(DataRow mydataRow in foundRows)
            {
                listBox1.Items.Add(mydataRow["consu_id"]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            consumerTableAdapter1.Fill(dataSet11.CONSUMER);
            ConsuTable = dataSet11.Tables["CONSUMER"];
            string str = "consu_id='" + listBox1.Items[listBox1.SelectedIndex] + "'";

            DataRow[] foundRows = ConsuTable.Select(str);

            foreach (DataRow mydataRow in foundRows)
            {
                textBoxID.Text = mydataRow["consu_id"].ToString();
                textBoxName.Text = mydataRow["consu_name"].ToString();
                textBoxEmail.Text= mydataRow["consu_email"].ToString();
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
                    OracleBlob blobData = rdr.GetOracleBlob(2);
                    byte[] conten = new Byte[blobData.Length];
                    int i = blobData.Read(conten, 0, Convert.ToInt32(blobData.Length));

                    System.IO.MemoryStream memStream = new System.IO.MemoryStream(conten);

                    // blob에서 가져온 이미지를 화면에 출력 
                    pictureBox4.Image = Image.FromStream(memStream);
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }else
            {
                pictureBox4.Image = System.Drawing.Image.FromFile("C:\\boss2.png");
            }
            oracleConnection1.Close();
        }

        private void labelCateSearch_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminEmail frm = new FormAdminEmail(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }
    }
}
