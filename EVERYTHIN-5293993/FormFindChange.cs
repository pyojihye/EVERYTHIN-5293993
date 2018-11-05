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
    public partial class FormFindChange : Form
    {
        private FormMain mainform;
        string mode;

        public FormFindChange(FormMain mainform, string mode)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.mode = mode;
        }

        //아이디 찾기를 눌렀을 때
        private void FindIDClicked(object sender, EventArgs e)
        {
            switch (mode)
            {
                case "고객":
                    FormFindIDConsumer frm = new FormFindIDConsumer(mainform);
                    frm.Owner = this;
                    frm.Show();
                    this.Visible = false;
                    break;
                case "직원":
                case "관리자":
                    FormFindIDAnother frm2 = new FormFindIDAnother(mainform, mode);
                    frm2.Owner = this;
                    frm2.Show();
                    this.Visible = false;
                    break;
            }

        }

        //비밀번호 변경을 눌렀을 때
        private void FindPasswdClicked(object sender, EventArgs e)
        {
            switch (mode)
            {
                case "고객":
                    FormChangePasswordConsumer frm = new FormChangePasswordConsumer(mainform);
                    frm.Owner = this;
                    frm.Show();
                    this.Visible = false;
                    break;
                case "직원":
                case "관리자":
                    FormChangePasswordAnother frm2 = new FormChangePasswordAnother(mainform, mode);
                    frm2.Owner = this;
                    frm2.Show();
                    this.Visible = false;
                    break;
            }
        }
    }
}
