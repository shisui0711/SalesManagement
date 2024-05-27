using System.ComponentModel;
using System.Reflection;
using Guna.UI2.WinForms;
using QLCHWF.CustomMessageBox;

namespace QLCHWF.Views.User
{
    public partial class frmViewUser : Form, IViewUser
    {
        public frmViewUser()
        {
            InitializeComponent();
            LoadCopy();
        }

        public string SearchText
        {
            get { return txtSearch.Text; }
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
        public event EventHandler? ShowAddUser;
        public event EventHandler? ShowChangePassword;
        public event EventHandler? ShowChangeUserRole;

        private void LoadCopy()
        {
            var properties = typeof(Models.User).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.GetCustomAttribute(typeof(DisplayNameAttribute),true) != null);
            foreach (var propertyInfo in properties)
            {
                string? propertyName = (propertyInfo.GetCustomAttribute(typeof(DisplayNameAttribute) )as DisplayNameAttribute)?.DisplayName;
                if (propertyName == null)
                {
                    continue;
                }
                btnCopy.DropDownItems.Add(new ToolStripMenuItem(propertyName));
            }
            foreach (var toolStripMenuItem in btnCopy.DropDownItems.OfType<ToolStripMenuItem>())
            {
                toolStripMenuItem.Click += delegate
                {
                    Models.User? selected = userBindingSource.Current as Models.User;
                    if (selected == null)
                    {
                        return;
                    }
                    var property = selected.GetType().GetProperties().Where(x =>
                    {
                        var displayNameAtribute = x.GetCustomAttribute(typeof(DisplayNameAttribute)) as DisplayNameAttribute;
                        return displayNameAtribute?.DisplayName == toolStripMenuItem.Text;
                    }).FirstOrDefault();
                    if (property != null )
                    {
                        Clipboard.SetText(property.GetValue(selected)!.ToString()!);
                    }
                    
                };
            }
        }

        //public void Copy()
        //{
        //    foreach (var toolStripMenuItem in btnCopy.DropDownItems.OfType<ToolStripMenuItem>())
        //    {
        //        toolStripMenuItem.Click += delegate
        //        {
        //            var selected = userBindingSource.Current as Models.User;
        //            var property = selected.GetType().GetProperties().Where(x =>
        //            {
        //                var displayNameAtribute = x.GetCustomAttribute(typeof(DisplayNameAttribute)) as DisplayNameAttribute;
        //                return displayNameAtribute?.DisplayName == toolStripMenuItem.Text;
        //            }).FirstOrDefault();
        //            Clipboard.SetText(property.GetValue(selected).ToString());
        //        };
        //    }
        //}
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ShowChangePassword?.Invoke(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUser?.Invoke(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadUser?.Invoke(sender, e);
        }

        private void frmViewUser_Load(object sender, EventArgs e)
        {
            LoadUser?.Invoke(sender, e);
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.Show("Bạn có chắc chắn muốn khóa tài khoản đã chọn", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            LockUser?.Invoke(sender, e);
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.Show("Bạn có chắc chắn muốn mở khóa tài khoản đã chọn", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            UnlockUser?.Invoke(sender, e);
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAddUser?.Invoke(sender,e);
        }
        public int CurrentPage
        {
            get
            {
                try
                {
                    return int.Parse(btnCurrentPage.Text);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set { btnCurrentPage.Text = value.ToString(); }
        }
        public event EventHandler PreviousPage = null!;
        public event EventHandler NextPage = null!;
        public void DisableNextPage()
        {
            btnNext.Enabled = false;
        }

        public void DisablePreviousPage()
        {
            btnPrevious.Enabled = false;
        }

        public void EnablePreviousPage()
        {
            btnPrevious.Enabled = true;
        }

        public void EnableNextPage()
        {
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextPage?.Invoke(sender, e);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PreviousPage?.Invoke(sender, e);
        }

        private void btnChangeUserRole_Click(object sender, EventArgs e)
        {
            ShowChangeUserRole?.Invoke(sender,e);
        }
    }
}
