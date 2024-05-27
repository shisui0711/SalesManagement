using QLCHWF.CustomMessageBox;
using System.Reflection;

namespace QLCHWF.Views.Provider
{
    public partial class frmUpdateProvider : Form, IUpdateProvider
    {
        public frmUpdateProvider()
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

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
