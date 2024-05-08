namespace QLCHWF.Views.User
{
    public partial class frmUpdatePassword : Form, IUpdatePassword
    {
        public frmUpdatePassword()
        {
            InitializeComponent();
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                MessageBox.Show(_message, "Thông báo");
            }
        }
        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetField("txt" + name);
            if (textBoxField != null && textBoxField.GetType().IsAssignableTo(typeof(UserControl)))
            {
                var textBox = (UserControl)textBoxField.GetValue(this);
                textBox.Focus();
            }
        }


        public string Email
        {
            get { return lblEmail.Text; }
            set { lblEmail.Text = value; }
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
    }
}
