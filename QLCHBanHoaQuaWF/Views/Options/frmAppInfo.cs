using QLCHWF.CustomMessageBox;

namespace QLCHWF.Views.Options
{
    public partial class frmAppInfo : Form, IAppInfo
    {
        public frmAppInfo()
        {
            InitializeComponent();
        }

        public string AppName
        {
            get { return txtAppName.Text; }
            set { txtAppName.Text = value; }
        }
        public string Phone
        {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }
        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string Address
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }
        public byte[]? PrintFormat { get; set; }
        public event EventHandler? UpdateAppInfo;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateAppInfo?.Invoke(sender, e);
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
