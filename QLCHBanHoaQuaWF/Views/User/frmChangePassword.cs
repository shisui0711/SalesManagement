using QLCHWF.CustomMessageBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHWF.Views.User
{
    public partial class frmChangePassword : Form,IChangePassword
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        public string Email
        {
            get { return txtEmail.Text;}
            set { txtEmail.Text = value; }
        }
        public string OldPassword
        {
            get { return txtOldPassword.Text;}
            set { txtOldPassword.Text = value; }
        }
        public string NewPassword
        {
            get { return txtNewPassword.Text;}
            set { txtNewPassword.Text = value; }
        }
        public string Repassword
        {
            get { return txtRepassword.Text;}
            set { txtRepassword.Text = value; }
        }
        public event EventHandler? ChangePassowrd;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangePassowrd?.Invoke(sender,e);
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
