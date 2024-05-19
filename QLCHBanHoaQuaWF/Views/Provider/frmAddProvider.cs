using QLCHWF.CustomMessageBox;
using System.Reflection;

namespace QLCHWF.Views.Provider
{
    public partial class frmAddProvider : Form, IAddProvider
    {
        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(x => x.Name == "txt" + name).FirstOrDefault();
            if (textBoxField != null)
            {
                var textBox = (UserControl)textBoxField.GetValue(this);
                textBox.Focus();
            }
        }
        public string ProviderName
        {
            get { return txtProviderName.Text; }
            set { txtProviderName.Text = value; }
        }

        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string Phone
        {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }
        public string Address
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }

        public void Reset()
        {
            var fieldTypes = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(f => f.Name.StartsWith("txt"));
            foreach (var fieldType in fieldTypes)
            {
                UserControl control = (UserControl)fieldType.GetValue(this);
                control.Text = String.Empty;
            }
        }

        public event EventHandler? AddProvider;
        public frmAddProvider()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProvider?.Invoke(sender, e);
        }


        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
