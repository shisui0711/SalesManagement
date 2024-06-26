﻿using QLCHWF.CustomMessageBox;
using System.Reflection;

namespace QLCHWF.Views.User
{
    public partial class frmUpdatePassword : Form, IUpdatePassword
    {
        public frmUpdatePassword()
        {
            InitializeComponent();
        }
        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(x => x.Name == "txt" + name).FirstOrDefault();
            if (textBoxField != null)
            {
                var textBox = (UserControl)textBoxField.GetValue(this)!;
                textBox.Focus();
            }
        }


        public string Email
        {
            get => lblEmail.Text;
            set => lblEmail.Text = value;
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public string Repassword
        {
            get { return txtRepassword.Text; }
            set { txtRepassword.Text = value; }
        }
        public event EventHandler? UpdatePassowrd;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            UpdatePassowrd?.Invoke(sender, e);
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
