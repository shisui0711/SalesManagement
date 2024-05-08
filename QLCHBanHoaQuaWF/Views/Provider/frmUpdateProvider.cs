namespace QLCHWF.Views.Provider
{
    public partial class frmUpdateProvider : Form, IUpdateProvider
    {
        public frmUpdateProvider()
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
                MessageBox.Show(_message, "Thông Báo");
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

        public int ProviderID
        {
            get { return int.Parse(txtProviderID.Text); }
            set { txtProviderID.Text = value.ToString(); }
        }
        public string ProviderName
        {
            get { return txtProviderName.Text;}
            set { txtProviderName.Text = value; }
        }
        public string Email {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string Phone {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }
        public string Address {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }
        public event EventHandler? UpdateProvider;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateProvider?.Invoke(sender,e);
        }
    }
}
