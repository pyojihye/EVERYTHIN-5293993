using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Mail;

namespace EVERYTHIN_5293993
{
    public partial class FormAdminEmail : Form
    {
        FormMain mainform;
        DataTable ReturnTable;
        DataTable ConsuTable;

        public FormAdminEmail(FormMain mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void FormAdminEmail_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void labelTotalSearch_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminConsu frm = new FormAdminConsu(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormAdminMode frm = new FormAdminMode(mainform);
            frm.Owner = this;
            frm.Show();
            frm.Activate();
        }

        private void FormAdminEmail_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.CONSUMERRENTAL' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.cONSUMERRENTALTableAdapter.Fill(this.dataSet1.CONSUMERRENTAL);
            ConsuTable = dataSet1.Tables["CONSUMERRENTAL"];
            returnTableAdapter1.Fill(dataSet11.RETURN);
            ReturnTable = dataSet11.Tables["return"];
            F5();
        }

        public void F5()
        {
            DataRow[] foundRows = ReturnTable.Select();
             
            foreach (DataRow mydataRow in foundRows)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (mydataRow["consu_id"].ToString() == dataGridView1.Rows[i].Cells[9].Value.ToString() && mydataRow["item_id"].ToString() == dataGridView1.Rows[i].Cells[10].Value.ToString())
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                        break;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MailMessage sendMail = new MailMessage();
            sendMail.From = new MailAddress("admin@everythin.com");        // 보내는 사람
            sendMail.To.Add(new MailAddress(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()));       // 받는 사람
            sendMail.SubjectEncoding = System.Text.Encoding.UTF8;
            sendMail.BodyEncoding = System.Text.Encoding.UTF8;
            
            sendMail.Subject = "[공지] 물건을 반납해주세요";                   // 메일 제목
            sendMail.Body = "물건을 빠른 시일 내로 반납하여 주시기 바랍니다!!";                     // 메일 내용

            // 보내는 메일 서버(SMTP)
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com",587);      // System.net.Mail
            smtpServer.UseDefaultCredentials = false;                   // DefaultCredentials를 보낼지 여부를 제어
            smtpServer.EnableSsl = true;                               // SmtpClient에서 SSL을 사용하여 연결을 암호화할지 여부 설정
            smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;     // 보내는 전자 메일 메시지의 처리 방법 설정
            smtpServer.Credentials = new System.Net.NetworkCredential("wlgp2915@gmail.com", "julierkdwnl12");   // SSL 연결을 설정하는데 사용할 인증서 설정
            smtpServer.Send(sendMail);
            MessageBox.Show("메일을 보냈습니다");
        }
    }
}
