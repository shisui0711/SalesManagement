using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBanHoaQuaWF.Views.User
{
    public partial class frmViewUser : Form,IViewUser
    {
        public frmViewUser()
        {
            InitializeComponent();
        }

        public string SearchText
        {
            get { return txtSearch.Text;}
            set { txtSearch.Text = value; }
        }
        public BindingSource UserBindingSource
        {
            get { return userBindingSource; }
        }
        public event EventHandler? SearchUser;
        public event EventHandler? LoadUser;
        public event EventHandler? LockUser;
        public event EventHandler? UnlockUser;
        public event EventHandler? ShowChangePassword;

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ShowChangePassword?.Invoke(sender,e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUser?.Invoke(sender,e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadUser?.Invoke(sender,e);
        }

        private void frmViewUser_Load(object sender, EventArgs e)
        {
            LoadUser?.Invoke(sender,e);
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            LockUser?.Invoke(sender,e);
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            UnlockUser?.Invoke(sender,e);
        }
    }
}
