using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHWF.CustomMessageBox;

namespace QLCHWF.Views.User
{
    public partial class frmChangeUserRole : Form, IChangeUserRole
    {
        public frmChangeUserRole()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string Email
        {
            get { return txtEmail.Text; }
            set => txtEmail.Text = value;
        }

        public int RoleID
        {
            get { try
                {
                    return int.Parse(cboVaiTro.Tag!.ToString()!);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public BindingSource UserRoleBindingSource
        {
            get { return userRoleBindingSource;}
            set { userRoleBindingSource = value; }
        }

        public event EventHandler? ChangeUserRole;

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangeUserRole?.Invoke(sender,e);
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
